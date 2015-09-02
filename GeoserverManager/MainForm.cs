using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;
using GeoserverManager.IoC.Container;
using GeoserverManager.UseCases.Interface.UseCases.Layers;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;
using GeoserverManager.UseCases.UseCases.Layers.Requests;

namespace GeoserverManager
{
    public partial class MainForm : Form
    {
        private readonly IGetAllLayersUseCase getAllLayersUseCase;
        private readonly IGetLayerStatusUseCase getLayerStatusUseCase;

        private delegate void SetRowColorDelegate(LayerStatus status, int pos);

        public MainForm()
        {
            InitializeComponent();

            getAllLayersUseCase = IocContainer.Resolve<IGetAllLayersUseCase>();
            getLayerStatusUseCase = IocContainer.Resolve<IGetLayerStatusUseCase>();
        }

        private void LoadGrid()
        {
            var request = new GetAllLayersRequests();
            try
            {
                getAllLayersUseCase.Execute(request, GetAllLayersHandler);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.InnerException.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAllLayersHandler(IGetAllLayersResponse obj)
        {
            var list = obj.Layers.ToList();

            LayersGrid.DataSource = list;

            CheckAllLayersState();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void bt_check_state_Click(object sender, EventArgs e)
        {
            CheckAllLayersState();
        }

        private void CheckAllLayersState()
        {
            if (LayersGrid.DataSource != null && !backgroundWorker1.IsBusy)
            {
                var list = LayersGrid.DataSource as IEnumerable<ILayerInfo>;
                progressBar1.Maximum = LayersGrid.RowCount;
                progressBar1.Visible = true;
                backgroundWorker1.RunWorkerAsync(list);
            }
            else
            {
                MessageBox.Show("Can't do that right now!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetColor(LayerStatus status, int pos)
        {
            if (LayersGrid.InvokeRequired)
            {
                SetRowColorDelegate d = SetColor;
                Invoke(d, status, pos);
            }
            else
            {
                switch (status)
                {
                    case LayerStatus.Ok:
                        LayersGrid.Rows[pos].DefaultCellStyle.BackColor = Color.Green;
                        break;

                    case LayerStatus.Error:
                        LayersGrid.Rows[pos].DefaultCellStyle.BackColor = Color.Red;
                        break;

                    case LayerStatus.Missing:
                        LayersGrid.Rows[pos].DefaultCellStyle.BackColor = Color.Orange;
                        break;

                    case LayerStatus.WithChanges:
                        LayersGrid.Rows[pos].DefaultCellStyle.BackColor = Color.CadetBlue;
                        break;

                    default:
                        LayersGrid.Rows[pos].DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                }


            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var list = e.Argument as List<ILayerInfo>;

            for(int i = 0; i < list.Count; i++) {

                var i1 = i;
                getLayerStatusUseCase.Execute(new GetLayerStatusRequest() {Layer = list[i]},
                     response => ResponseBoundary(response,i1, ref list));

                backgroundWorker1.ReportProgress(i+1);
          
            }

        }

        private void ResponseBoundary(IGetLayerStatusResponse getLayerStatusResponse,int pos,ref List<ILayerInfo> list )
        {
            list[pos].ChangeLayerStatus(getLayerStatusResponse.Status);
            SetColor(getLayerStatusResponse.Status, pos);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}