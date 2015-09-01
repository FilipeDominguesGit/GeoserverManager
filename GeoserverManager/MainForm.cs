using System;
using System.Linq;
using System.Windows.Forms;
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

        private void LayersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}