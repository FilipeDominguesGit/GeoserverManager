namespace GeoserverManager
{
    partial class MainForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.LayersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LayersGrid
            // 
            this.LayersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LayersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LayersGrid.Location = new System.Drawing.Point(12, 48);
            this.LayersGrid.Name = "LayersGrid";
            this.LayersGrid.Size = new System.Drawing.Size(642, 302);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 356);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(642, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 391);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bt_check_state);
            this.Controls.Add(this.LayersGrid);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LayersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LayersGrid;
        private System.Windows.Forms.Button bt_check_state;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}