namespace GeoserverManager
{
    partial class LayersForm
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
            this.LayersGrid = new System.Windows.Forms.DataGridView();
            this.bt_check_state = new System.Windows.Forms.Button();
            this.CheckStateBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pb_load_layers = new System.Windows.Forms.ToolStripProgressBar();
            this.tssl_loading_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.bt_upload_missing = new System.Windows.Forms.Button();
            this.UploadLayerToGeoserverBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.LayersGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayersGrid
            // 
            this.LayersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LayersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LayersGrid.Location = new System.Drawing.Point(12, 48);
            this.LayersGrid.Name = "LayersGrid";
            this.LayersGrid.Size = new System.Drawing.Size(642, 300);
            this.LayersGrid.TabIndex = 0;
            // 
            // bt_check_state
            // 
            this.bt_check_state.Location = new System.Drawing.Point(12, 19);
            this.bt_check_state.Name = "bt_check_state";
            this.bt_check_state.Size = new System.Drawing.Size(75, 23);
            this.bt_check_state.TabIndex = 1;
            this.bt_check_state.Text = "Check State";
            this.bt_check_state.UseVisualStyleBackColor = true;
            this.bt_check_state.Click += new System.EventHandler(this.bt_check_state_Click);
            // 
            // CheckStateBackgroundWorker
            // 
            this.CheckStateBackgroundWorker.WorkerReportsProgress = true;
            this.CheckStateBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CheckStateBackgroundWorker_DoWork);
            this.CheckStateBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.CheckStateBackgroundWorker_ProgressChanged);
            this.CheckStateBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CheckStateBackgroundWorker_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pb_load_layers,
            this.tssl_loading_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 369);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(666, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pb_load_layers
            // 
            this.pb_load_layers.Name = "pb_load_layers";
            this.pb_load_layers.Size = new System.Drawing.Size(100, 16);
            // 
            // tssl_loading_label
            // 
            this.tssl_loading_label.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tssl_loading_label.Name = "tssl_loading_label";
            this.tssl_loading_label.Size = new System.Drawing.Size(4, 17);
            // 
            // bt_upload_missing
            // 
            this.bt_upload_missing.Location = new System.Drawing.Point(93, 19);
            this.bt_upload_missing.Name = "bt_upload_missing";
            this.bt_upload_missing.Size = new System.Drawing.Size(87, 23);
            this.bt_upload_missing.TabIndex = 4;
            this.bt_upload_missing.Text = "Upload missing";
            this.bt_upload_missing.UseVisualStyleBackColor = true;
            this.bt_upload_missing.Click += new System.EventHandler(this.bt_upload_missing_Click);
            // 
            // UploadLayerToGeoserverBackgroundWorker
            // 
            this.UploadLayerToGeoserverBackgroundWorker.WorkerReportsProgress = true;
            this.UploadLayerToGeoserverBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UploadLayerToGeoserverBackgroundWorker_DoWork);
            this.UploadLayerToGeoserverBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.UploadLayerToGeoserverBackgroundWorker_ProgressChanged);
            this.UploadLayerToGeoserverBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.UploadLayerToGeoserverBackgroundWorker_RunWorkerCompleted);
            // 
            // LayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 391);
            this.Controls.Add(this.bt_upload_missing);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_check_state);
            this.Controls.Add(this.LayersGrid);
            this.Name = "LayersForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LayersForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LayersGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LayersGrid;
        private System.Windows.Forms.Button bt_check_state;
        private System.ComponentModel.BackgroundWorker CheckStateBackgroundWorker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pb_load_layers;
        private System.Windows.Forms.ToolStripStatusLabel tssl_loading_label;
        private System.Windows.Forms.Button bt_upload_missing;
        private System.ComponentModel.BackgroundWorker UploadLayerToGeoserverBackgroundWorker;
    }
}