
namespace Laboratory
{
    partial class ApparatusForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApparatusForm));
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.apparatusGridview = new System.Windows.Forms.DataGridView();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.apparatuspicBox = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.apparatusnameLabel = new System.Windows.Forms.Label();
            this.apparatusidLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.apparatusdescriptTextbox = new System.Windows.Forms.RichTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apparatusQuantity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apparatusGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apparatuspicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Location = new System.Drawing.Point(0, 33);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(1034, 1);
            this.label36.TabIndex = 50;
            this.label36.Text = "label36";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label38.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label38.Location = new System.Drawing.Point(354, 8);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(353, 37);
            this.label38.TabIndex = 51;
            this.label38.Text = "Apparatuses in laboratory";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apparatusGridview
            // 
            this.apparatusGridview.AllowUserToAddRows = false;
            this.apparatusGridview.AllowUserToDeleteRows = false;
            this.apparatusGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apparatusGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.apparatusGridview.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.apparatusGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.apparatusGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.apparatusGridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.apparatusGridview.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.apparatusGridview.Location = new System.Drawing.Point(9, 77);
            this.apparatusGridview.Margin = new System.Windows.Forms.Padding(2);
            this.apparatusGridview.Name = "apparatusGridview";
            this.apparatusGridview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.apparatusGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.apparatusGridview.RowHeadersWidth = 62;
            this.apparatusGridview.RowTemplate.Height = 33;
            this.apparatusGridview.Size = new System.Drawing.Size(314, 482);
            this.apparatusGridview.TabIndex = 52;
            this.apparatusGridview.Click += new System.EventHandler(this.apparatusGridview_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextbox.ForeColor = System.Drawing.Color.Black;
            this.searchTextbox.Location = new System.Drawing.Point(703, 52);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.PlaceholderText = "Search for apparatus...";
            this.searchTextbox.Size = new System.Drawing.Size(323, 25);
            this.searchTextbox.TabIndex = 79;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // apparatuspicBox
            // 
            this.apparatuspicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.apparatuspicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.apparatuspicBox.Location = new System.Drawing.Point(703, 135);
            this.apparatuspicBox.Margin = new System.Windows.Forms.Padding(2);
            this.apparatuspicBox.Name = "apparatuspicBox";
            this.apparatuspicBox.Size = new System.Drawing.Size(320, 396);
            this.apparatuspicBox.TabIndex = 104;
            this.apparatuspicBox.TabStop = false;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(444, 135);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(245, 1);
            this.label15.TabIndex = 97;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(444, 105);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 1);
            this.label14.TabIndex = 96;
            this.label14.Text = "label14";
            // 
            // apparatusnameLabel
            // 
            this.apparatusnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.apparatusnameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.apparatusnameLabel.Location = new System.Drawing.Point(444, 117);
            this.apparatusnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apparatusnameLabel.Name = "apparatusnameLabel";
            this.apparatusnameLabel.Size = new System.Drawing.Size(245, 18);
            this.apparatusnameLabel.TabIndex = 89;
            // 
            // apparatusidLabel
            // 
            this.apparatusidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.apparatusidLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.apparatusidLabel.Location = new System.Drawing.Point(444, 87);
            this.apparatusidLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apparatusidLabel.Name = "apparatusidLabel";
            this.apparatusidLabel.Size = new System.Drawing.Size(245, 18);
            this.apparatusidLabel.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(335, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 81;
            this.label3.Text = "Full name:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(335, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 19);
            this.label10.TabIndex = 80;
            this.label10.Text = "ID:";
            // 
            // apparatusdescriptTextbox
            // 
            this.apparatusdescriptTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.apparatusdescriptTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.apparatusdescriptTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apparatusdescriptTextbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.apparatusdescriptTextbox.Location = new System.Drawing.Point(444, 182);
            this.apparatusdescriptTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.apparatusdescriptTextbox.Name = "apparatusdescriptTextbox";
            this.apparatusdescriptTextbox.Size = new System.Drawing.Size(245, 344);
            this.apparatusdescriptTextbox.TabIndex = 106;
            this.apparatusdescriptTextbox.Text = "";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label50.Location = new System.Drawing.Point(335, 180);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(89, 19);
            this.label50.TabIndex = 105;
            this.label50.Text = "Description:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(444, 528);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 1);
            this.label1.TabIndex = 108;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(703, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 109;
            this.label2.Text = "Image:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(444, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 1);
            this.label4.TabIndex = 112;
            this.label4.Text = "label4";
            // 
            // apparatusQuantity
            // 
            this.apparatusQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.apparatusQuantity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.apparatusQuantity.Location = new System.Drawing.Point(444, 146);
            this.apparatusQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apparatusQuantity.Name = "apparatusQuantity";
            this.apparatusQuantity.Size = new System.Drawing.Size(245, 18);
            this.apparatusQuantity.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(335, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 110;
            this.label6.Text = "Quantity:";
            // 
            // ApparatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apparatusQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apparatusdescriptTextbox);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.apparatuspicBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.apparatusnameLabel);
            this.Controls.Add(this.apparatusidLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.apparatusGridview);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label36);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ApparatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apparatuses";
            this.Load += new System.EventHandler(this.ApparatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apparatusGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apparatuspicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DataGridView apparatusGridview;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.PictureBox apparatuspicBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label apparatusnameLabel;
        private System.Windows.Forms.Label apparatusidLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox apparatusdescriptTextbox;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label apparatusQuantity;
        private System.Windows.Forms.Label label6;
    }
}