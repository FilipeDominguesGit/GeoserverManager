using System;
using System.Windows.Forms;
using GeoserverManager.IoC.Container;
using GeoserverManager.UseCases.Base.Interface.ResponseBoundary;
using GeoserverManager.UseCases.Interface.UseCases.Layers;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var request = new GetAllLayersRequests();
            getAllLayersUseCase.Execute(request, GetAllLayersHandler);
        }

        private void GetAllLayersHandler(IUseCaseResponse obj)
        {
        }
    }
}