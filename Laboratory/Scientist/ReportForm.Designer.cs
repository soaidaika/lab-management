
namespace Laboratory
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reportGridview = new System.Windows.Forms.DataGridView();
            this.showreportRTextbox = new System.Windows.Forms.RichTextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1035, 1);
            this.label2.TabIndex = 52;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(386, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 37);
            this.label3.TabIndex = 53;
            this.label3.Text = "Experiment reports";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportGridview
            // 
            this.reportGridview.AllowUserToAddRows = false;
            this.reportGridview.AllowUserToDeleteRows = false;
            this.reportGridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportGridview.BackgroundColor = System.Drawing.Color.White;
            this.reportGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridview.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportGridview.Location = new System.Drawing.Point(8, 56);
            this.reportGridview.Margin = new System.Windows.Forms.Padding(2);
            this.reportGridview.Name = "reportGridview";
            this.reportGridview.ReadOnly = true;
            this.reportGridview.RowHeadersWidth = 62;
            this.reportGridview.RowTemplate.Height = 33;
            this.reportGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportGridview.Size = new System.Drawing.Size(280, 503);
            this.reportGridview.TabIndex = 54;
            this.reportGridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportGridview_CellDoubleClick);
            // 
            // showreportRTextbox
            // 
            this.showreportRTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showreportRTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showreportRTextbox.Location = new System.Drawing.Point(293, 56);
            this.showreportRTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.showreportRTextbox.Name = "showreportRTextbox";
            this.showreportRTextbox.Size = new System.Drawing.Size(735, 467);
            this.showreportRTextbox.TabIndex = 55;
            this.showreportRTextbox.Text = "";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uploadBtn.AutoSize = true;
            this.uploadBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.uploadBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.uploadBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uploadBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uploadBtn.Location = new System.Drawing.Point(293, 530);
            this.uploadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(105, 29);
            this.uploadBtn.TabIndex = 56;
            this.uploadBtn.Text = "Upload file";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeBtn.AutoSize = true;
            this.removeBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.removeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeBtn.Location = new System.Drawing.Point(413, 530);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(105, 29);
            this.removeBtn.TabIndex = 57;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1035, 566);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.showreportRTextbox);
            this.Controls.Add(this.reportGridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView reportGridview;
        private System.Windows.Forms.RichTextBox showreportRTextbox;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Button removeBtn;
    }
}