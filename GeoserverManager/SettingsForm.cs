using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeoserverManager.DAL.UI.Repositories.ConfigData;
using GeoserverManager.IoC.Container;

namespace GeoserverManager
{
    public partial class SettingsForm : Form
    {
        private readonly IConfigurationDataGateway configurationDataGateway;


        public SettingsForm()
        {
            InitializeComponent();

            configurationDataGateway = IocContainer.Resolve<IConfigurationDataGateway>();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettingsTextBoxs();
        }

        private void LoadSettingsTextBoxs()
        {
            textBox1.Text = configurationDataGateway.GeoServerUri;
            textBox2.Text = configurationDataGateway.GeoServerUser;
            textBox3.Text = configurationDataGateway.GeoServerPassword;
        }

        private void bt_default_Click(object sender, EventArgs e)
        {
            textBox1.Text = "http://localhost:8080/geoserver/rest";
            textBox2.Text = "admin";
            textBox3.Text = "geoserver";
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)
                && !string.IsNullOrWhiteSpace(textBox2.Text)
                && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                configurationDataGateway.GeoServerUri = textBox1.Text;
                configurationDataGateway.GeoServerUser = textBox2.Text;
                configurationDataGateway.GeoServerPassword = textBox3.Text;


                

                this.Dispose();

            }
            else
            {
                MessageBox.Show("No empty values allowed.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }

           
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
