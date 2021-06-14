
namespace Laboratory
{
    partial class AddApparatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddApparatusForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aprtnameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.aprtdescriptTextbox = new System.Windows.Forms.RichTextBox();
            this.aprtpicBox = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.addaprtpicBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aprtpicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 1);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(221, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Add apparatus";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aprtnameTextbox
            // 
            this.aprtnameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aprtnameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aprtnameTextbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.aprtnameTextbox.Location = new System.Drawing.Point(138, 59);
            this.aprtnameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.aprtnameTextbox.Name = "aprtnameTextbox";
            this.aprtnameTextbox.Size = new System.Drawing.Size(246, 23);
            this.aprtnameTextbox.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 115;
            this.label5.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 114;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 113;
            this.label3.Text = "Name:";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityTextbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.quantityTextbox.Location = new System.Drawing.Point(138, 187);
            this.quantityTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(246, 23);
            this.quantityTextbox.TabIndex = 118;
            // 
            // aprtdescriptTextbox
            // 
            this.aprtdescriptTextbox.Location = new System.Drawing.Point(138, 89);
            this.aprtdescriptTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.aprtdescriptTextbox.Name = "aprtdescriptTextbox";
            this.aprtdescriptTextbox.Size = new System.Drawing.Size(246, 88);
            this.aprtdescriptTextbox.TabIndex = 119;
            this.aprtdescriptTextbox.Text = "";
            // 
            // aprtpicBox
            // 
            this.aprtpicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aprtpicBox.Location = new System.Drawing.Point(387, 59);
            this.aprtpicBox.Margin = new System.Windows.Forms.Padding(2);
            this.aprtpicBox.Name = "aprtpicBox";
            this.aprtpicBox.Size = new System.Drawing.Size(208, 118);
            this.aprtpicBox.TabIndex = 120;
            this.aprtpicBox.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelBtn.Location = new System.Drawing.Point(328, 218);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelBtn.Size = new System.Drawing.Size(105, 29);
            this.cancelBtn.TabIndex = 123;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.AutoSize = true;
            this.addBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addBtn.Location = new System.Drawing.Point(208, 218);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(105, 29);
            this.addBtn.TabIndex = 122;
            this.addBtn.Text = "Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addaprtpicBtn
            // 
            this.addaprtpicBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addaprtpicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addaprtpicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addaprtpicBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addaprtpicBtn.FlatAppearance.BorderSize = 0;
            this.addaprtpicBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addaprtpicBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addaprtpicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addaprtpicBtn.Image = ((System.Drawing.Image)(resources.GetObject("addaprtpicBtn.Image")));
            this.addaprtpicBtn.Location = new System.Drawing.Point(562, 149);
            this.addaprtpicBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addaprtpicBtn.Name = "addaprtpicBtn";
            this.addaprtpicBtn.Size = new System.Drawing.Size(30, 24);
            this.addaprtpicBtn.TabIndex = 124;
            this.addaprtpicBtn.TabStop = false;
            this.addaprtpicBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addaprtpicBtn.UseVisualStyleBackColor = false;
            this.addaprtpicBtn.Click += new System.EventHandler(this.addaprtpicBtn_Click);
            // 
            // AddApparatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 270);
            this.Controls.Add(this.addaprtpicBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.aprtpicBox);
            this.Controls.Add(this.aprtdescriptTextbox);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.aprtnameTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddApparatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add apparatus";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddApparatusForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddApparatusForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddApparatusForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddApparatusForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.aprtpicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aprtnameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.RichTextBox aprtdescriptTextbox;
        private System.Windows.Forms.PictureBox aprtpicBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button addaprtpicBtn;
    }
}