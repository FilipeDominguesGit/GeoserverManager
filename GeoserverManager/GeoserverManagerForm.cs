﻿using System;
using System.Linq;
using System.Windows.Forms;
using GeoserverManager.DAL.UI.Repositories.ConfigData;
using GeoserverManager.IoC.Container;
using GeoserverManager.UseCases.Interface.UseCases.Server;
using GeoserverManager.UseCases.Interface.UseCases.Server.Response;
using GeoserverManager.UseCases.UseCases.Server.Request;

namespace GeoserverManager
{
    public partial class GeoserverManagerForm : Form
    {
        private LayersForm layersForm;
        private SettingsForm settingsForm;

        private IConfigurationDataGateway configurationDataGateway;

        private IGetServerStatusUseCase getServerStatusUseCase;

        public GeoserverManagerForm()
        {
            InitializeComponent();

           

            configurationDataGateway = IocContainer.Resolve<IConfigurationDataGateway>();
            getServerStatusUseCase = IocContainer.Resolve<IGetServerStatusUseCase>();
            GetServerData();
        }

        private void GetServerData()
        {
            tssl_server_name.Text = string.Format("Server: {0}", configurationDataGateway.GeoServerUri);
            GetServerStatus();
            
        }

        private void GetServerStatus()
        {
            getServerStatusUseCase.Execute(new GetServerStatusRequest(), GetServerStatusHandler);
        }

        private void GetServerStatusHandler(IGetServerStatusResponse getServerStatusResponse)
        {
            tssl_server_status.Text = getServerStatusResponse.IsOnline ? "Status: Online" : "Status: Offline";
        }

        private void importLayersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            layersForm=OpenOrFocusWindow<LayersForm>(layersForm);
            layersForm?.Show();
        }

        private T OpenOrFocusWindow<T>( Form form) where T : Form
        {
            if (Application.OpenForms.Cast<Form>().Any(x => x.GetType() == typeof(T)))
            {
                form.Focus();
                return null;
            }


            if (form != null && !form.IsDisposed) return null;

            form = (T)Activator.CreateInstance(typeof(T));
            form.MdiParent = this;
            form.StartPosition=FormStartPosition.CenterScreen;
            return (T) form;
        }

        

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            settingsForm = new SettingsForm();

            var result=settingsForm?.ShowDialog();

            if (result == DialogResult.OK)
            {
                configurationDataGateway = IocContainer.Resolve<IConfigurationDataGateway>();
                getServerStatusUseCase = IocContainer.Resolve<IGetServerStatusUseCase>();
                GetServerData();
            }
        }
    }
}