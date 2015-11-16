using System.Windows.Forms;

namespace GeoserverManager
{
    partial class GeoserverManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoserverManagerForm));
            this.ss_main_form = new System.Windows.Forms.StatusStrip();
            this.tssl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_server_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geoServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importLayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssl_server_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_main_form.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss_main_form
            // 
            this.ss_main_form.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_server_status,
            this.tssl_status,
            this.tssl_server_name});
            this.ss_main_form.Location = new System.Drawing.Point(0, 316);
            this.ss_main_form.Name = "ss_main_form";
            this.ss_main_form.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ss_main_form.Size = new System.Drawing.Size(703, 24);
            this.ss_main_form.SizingGrip = false;
            this.ss_main_form.TabIndex = 1;
            this.ss_main_form.Text = "statusStrip1";
            // 
            // tssl_status
            // 
            this.tssl_status.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tssl_status.Name = "tssl_status";
            this.tssl_status.Size = new System.Drawing.Size(46, 19);
            this.tssl_status.Text = ":Status";
            // 
            // tssl_server_name
            // 
            this.tssl_server_name.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tssl_server_name.Name = "tssl_server_name";
            this.tssl_server_name.Size = new System.Drawing.Size(97, 19);
            this.tssl_server_name.Text = "Server: localhost";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.geoServerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.inputSettingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.settingsToolStripMenuItem.Text = "Connection Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // inputSettingsToolStripMenuItem
            // 
            this.inputSettingsToolStripMenuItem.Name = "inputSettingsToolStripMenuItem";
            this.inputSettingsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.inputSettingsToolStripMenuItem.Text = "Input Settings...";
            this.inputSettingsToolStripMenuItem.Click += new System.EventHandler(this.inputSettingsToolStripMenuItem_Click);
            // 
            // geoServerToolStripMenuItem
            // 
            this.geoServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layersToolStripMenuItem});
            this.geoServerToolStripMenuItem.Name = "geoServerToolStripMenuItem";
            this.geoServerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.geoServerToolStripMenuItem.Text = "GeoServer";
            // 
            // layersToolStripMenuItem
            // 
            this.layersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importLayersToolStripMenuItem});
            this.layersToolStripMenuItem.Name = "layersToolStripMenuItem";
            this.layersToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.layersToolStripMenuItem.Text = "Layer";
            // 
            // importLayersToolStripMenuItem
            // 
            this.importLayersToolStripMenuItem.Name = "importLayersToolStripMenuItem";
            this.importLayersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importLayersToolStripMenuItem.Text = "Import layers...";
            this.importLayersToolStripMenuItem.Click += new System.EventHandler(this.importLayersToolStripMenuItem_Click);
            // 
            // tssl_server_status
            // 
            this.tssl_server_status.Name = "tssl_server_status";
            this.tssl_server_status.Size = new System.Drawing.Size(58, 19);
            this.tssl_server_status.Text = "Unknown";
            // 
            // GeoserverManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 340);
            this.Controls.Add(this.ss_main_form);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeoserverManagerForm";
            this.Text = "Geoserver Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ss_main_form.ResumeLayout(false);
            this.ss_main_form.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss_main_form;
        private System.Windows.Forms.ToolStripStatusLabel tssl_status;
        private System.Windows.Forms.ToolStripStatusLabel tssl_server_name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geoServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importLayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem inputSettingsToolStripMenuItem;
        private ToolStripStatusLabel tssl_server_status;
    }
}