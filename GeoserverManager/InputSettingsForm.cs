using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeoserverManager.DAL.UI.Repositories.ConfigData;
using GeoserverManager.IoC.Container;
using GeoserverManager.UseCases.Interface.UseCases.FeatureTypes;
using GeoserverManager.UseCases.UseCases.FeatureTypes.Requests;

namespace GeoserverManager
{
    public partial class InputSettingsForm : Form
    {
        private readonly IConfigurationDataGateway configurationDataGateway;
        private readonly IGetAllFeatureTypesInfosUseCase getAllLayersUseCase;

        public InputSettingsForm()
        {
            InitializeComponent();

            configurationDataGateway = IocContainer.Resolve<IConfigurationDataGateway>();
            getAllLayersUseCase = IocContainer.Resolve<IGetAllFeatureTypesInfosUseCase>();
        }

        private void bt_file_picker_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
             

            }
        }

        private void InputSettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettingsTextBoxs();
        }

        private void LoadSettingsTextBoxs()
        {
            textBox1.Text = configurationDataGateway.LocalLayersConnectionString;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))
            {
                configurationDataGateway.LocalLayersConnectionString = textBox1.Text;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Path not valid.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
