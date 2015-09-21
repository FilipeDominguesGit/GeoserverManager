using System;
using System.Linq;
using System.Windows.Forms;

namespace GeoserverManager
{
    public partial class GeoserverManagerForm : Form
    {
        private LayersForm layersForm;
        private SettingsForm settingsForm;

        public GeoserverManagerForm()
        {
            InitializeComponent();
        }

        private void importLayersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            layersForm=OpenOrFocusWindow<LayersForm>(layersForm);
           
        }

        private T OpenOrFocusWindow<T>( Form form) where T : Form
        {
            if (Application.OpenForms.Cast<Form>().Any(x => x.GetType() == typeof(T)))
            {
                form.Focus();
                return (T) form;
            }


            if (form != null && !form.IsDisposed) return null;

            form = (T)Activator.CreateInstance(typeof(T));
            form.MdiParent = this;
            form.StartPosition=FormStartPosition.CenterScreen;
            form.Show();
            return (T) form;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm = OpenOrFocusWindow<SettingsForm>(settingsForm);
        }
    }
}