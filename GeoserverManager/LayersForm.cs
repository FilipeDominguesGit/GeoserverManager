﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class LayersForm : Form
    {
        #region Use Cases

        private readonly IGetAllLayersUseCase getAllLayersUseCase;
        private readonly IGetLayerStatusUseCase getLayerStatusUseCase;
        private readonly IUploadLayerToGeoserverUseCase uploadLayerToGeoserverUseCase;

        #endregion

        #region Delegates

        private delegate void SetRowColorDelegate(LayerStatus status, int pos);

        private delegate void SetLoadingToolStripStatusLabelTextDelegate(string text);

        private delegate void SetCurrentGridRowSelectionDelegate(int pos);

        #endregion

        public LayersForm()
        {
            InitializeComponent();

            getAllLayersUseCase = IocContainer.Resolve<IGetAllLayersUseCase>();
            getLayerStatusUseCase = IocContainer.Resolve<IGetLayerStatusUseCase>();
            uploadLayerToGeoserverUseCase = IocContainer.Resolve<IUploadLayerToGeoserverUseCase>();
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
                MessageBox.Show(e.Message + Environment.NewLine + e.InnerException.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetLoadingToolStripStatusLabelText("!No layers found");
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
            if (LayersGrid.DataSource != null && !CheckStateBackgroundWorker.IsBusy)
            {
                var list = LayersGrid.DataSource as IEnumerable<ILayerInfo>;
                bt_check_state.Enabled = false;
                bt_upload_missing.Enabled = false;
                pb_load_layers.Visible = true;
                CheckStateBackgroundWorker.RunWorkerAsync(list);
            }
            else
            {
                MessageBox.Show("Can't do that right now!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetLoadingToolStripStatusLabelText(string text)
        {
            if (statusStrip1.InvokeRequired)
            {
                SetLoadingToolStripStatusLabelTextDelegate d = SetLoadingToolStripStatusLabelText;
                Invoke(d, text);
            }
            else
            {
                tssl_loading_label.Text = text;
            }
        }

        private void SetRowColorByStatus(LayerStatus status, int pos)
        {
            if (LayersGrid.InvokeRequired)
            {
                SetRowColorDelegate d = SetRowColorByStatus;
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

                    case LayerStatus.ConnectionError:
                        LayersGrid.Rows[pos].DefaultCellStyle.BackColor = Color.CadetBlue;
                        break;

                    default:
                        LayersGrid.Rows[pos].DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                }
            }
        }

        private void SetCurrentGridRowSelection(int pos)
        {
            if (LayersGrid.InvokeRequired)
            {
                SetCurrentGridRowSelectionDelegate d = SetCurrentGridRowSelection;
                Invoke(d, pos);
            }
            else
            {
                LayersGrid.Rows[pos].Selected = true;
                LayersGrid.CurrentCell = LayersGrid[0, pos];
            }
        }

        private void CheckStateBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var list = e.Argument as List<ILayerInfo>;
            SetLoadingToolStripStatusLabelText("...Loading");

            for (var i = 0; i < list.Count; i++)
            {
                var i1 = i;
                try
                {
                    SetCurrentGridRowSelection(i1);

                    getLayerStatusUseCase.Execute(new GetLayerStatusRequest {Layer = list[i]},
                        response => GetLayerStatusHandler(response, i1, list));
                    CheckStateBackgroundWorker.ReportProgress(((i + 1)*100)/list.Count);
                }
                catch (Exception exception)
                {
                    if (!IsDisposed)
                    {
                        MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void GetLayerStatusHandler(IGetLayerStatusResponse getLayerStatusResponse, int pos, List<ILayerInfo> list)
        {
            list[pos].ChangeLayerStatus(getLayerStatusResponse.Status);
            SetRowColorByStatus(getLayerStatusResponse.Status, pos);
        }

        private void CheckStateBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_load_layers.Value = e.ProgressPercentage;

            SetLoadingToolStripStatusLabelText(e.ProgressPercentage + "%");
        }

        private void CheckStateBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) return;
            MessageBox.Show("Local layers up to date.", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            SetLoadingToolStripStatusLabelText("Ok");

            bt_check_state.Enabled = true;
            bt_upload_missing.Enabled = true;
        }

        private void LayersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pb_load_layers.Dispose();
            CheckStateBackgroundWorker.Dispose();
            Dispose();
            
        }

        private void bt_upload_missing_Click(object sender, EventArgs e)
        {
            if (LayersGrid.DataSource != null && !UploadLayerToGeoserverBackgroundWorker.IsBusy)
            {
                var list = LayersGrid.DataSource as IEnumerable<ILayerInfo>;
                bt_check_state.Enabled = false;
                bt_upload_missing.Enabled = false;
                pb_load_layers.Visible = true;
                UploadLayerToGeoserverBackgroundWorker.RunWorkerAsync(list);
            }
            else
            {
                MessageBox.Show("Can't do that right now!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void ResponseBoundary(IUploadLayerToGeoserverResponse uploadLayerToGeoserverResponse, int pos, List<ILayerInfo> list)
        {
            
        }

        private void UploadLayerToGeoserverBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var list = e.Argument as List<ILayerInfo>;
            SetLoadingToolStripStatusLabelText("...Uploading");

            for (var i = 0; i < list.Count; i++)
            {
                var i1 = i;
                try
                {
                    SetCurrentGridRowSelection(i1);

                    if (list[i].LayerStatus == LayerStatus.Missing)
                    {
                        uploadLayerToGeoserverUseCase.Execute(new UploadLayerToGeoserverRequest(list[i]),
                            response => ResponseBoundary(response, i1, list));

                    }

                    UploadLayerToGeoserverBackgroundWorker.ReportProgress(((i + 1) * 100) / list.Count);
                }
                catch (Exception exception)
                {
                    if (!IsDisposed)
                    {
                        MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    e.Cancel = true;
                    return;
                }
            }

        }

        private void UploadLayerToGeoserverBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_load_layers.Value = e.ProgressPercentage;

            SetLoadingToolStripStatusLabelText(e.ProgressPercentage + "%");
        }

        private void UploadLayerToGeoserverBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) return;
            MessageBox.Show("Missing layers uploaded.", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            SetLoadingToolStripStatusLabelText("Ok");

            bt_check_state.Enabled = true;
            bt_upload_missing.Enabled = true;
            
        }
    }
}