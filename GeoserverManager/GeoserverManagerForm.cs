using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoserverManager
{
    public partial class GeoserverManagerForm : Form
    {
        private LayersForm layersForm;

        public GeoserverManagerForm()
        {
            InitializeComponent();
        }

        private void importLayersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.Cast<Form>().Any(form => form.GetType() == typeof(LayersForm)))
            {
                layersForm.Focus();
                return;
            }

            if (layersForm==null|| layersForm.IsDisposed )
                layersForm = new LayersForm { MdiParent = this };
            layersForm.Show();

        }
    }
}
