using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.IoC.Container;
using GeoserverManager.UseCases.Interface.UseCases.Layers;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;
using GeoserverManager.UseCases.UseCases.Layers.Requests;

namespace GeoserverManager
{
    public partial class MainForm : Form
    {
        private readonly IGetAllLayersUseCase getAllLayersUseCase;
        // private IGetAllLayersResponse Layers;

        public MainForm()
        {
            InitializeComponent();

            getAllLayersUseCase = IocContainer.Resolve<IGetAllLayersUseCase>();
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
                MessageBox.Show(e.Message+Environment.NewLine+e.InnerException.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAllLayersHandler(IGetAllLayersResponse obj)
        {
            var list = obj.Layers.ToList();

            LayersGrid.DataSource = list;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void bt_check_state_Click(object sender, EventArgs e)
        {
            //var list =(LayersGrid.DataSource as List<ILayerInfo>);

            //foreach (var layerInfo in list)
            //{
            //    Debug.Write(layerInfo.Name);
            //}

            progressBar1.Visible = true;
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                // Report progress to 'UI' thread
                backgroundWorker1.ReportProgress(i);
                // Simulate long task
                System.Threading.Thread.Sleep(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

            progressBar1.Value = e.ProgressPercentage;
            
        }
    }
}