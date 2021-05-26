
namespace Laboratory
{
    partial class AddProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProjectForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exptdescriptTextbox = new System.Windows.Forms.RichTextBox();
            this.expidTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.participantGridview = new System.Windows.Forms.DataGridView();
            this.sctnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sctposColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantCombobox = new System.Windows.Forms.ComboBox();
            this.leaderCheckbox = new System.Windows.Forms.CheckBox();
            this.addmemBtn = new System.Windows.Forms.Button();
            this.aprtCombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.addaprtBtn = new System.Windows.Forms.Button();
            this.startTimepicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.endTimepicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.takenaprtGridview = new System.Windows.Forms.DataGridView();
            this.takenaprtnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takenquantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.participantGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenaprtGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 1);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(394, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 54);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add project";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exptdescriptTextbox
            // 
            this.exptdescriptTextbox.Location = new System.Drawing.Point(197, 148);
            this.exptdescriptTextbox.Name = "exptdescriptTextbox";
            this.exptdescriptTextbox.Size = new System.Drawing.Size(350, 144);
            this.exptdescriptTextbox.TabIndex = 125;
            this.exptdescriptTextbox.Text = "";
            // 
            // expidTextbox
            // 
            this.expidTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expidTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expidTextbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.expidTextbox.Location = new System.Drawing.Point(197, 98);
            this.expidTextbox.Name = "expidTextbox";
            this.expidTextbox.Size = new System.Drawing.Size(350, 31);
            this.expidTextbox.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 28);
            this.label5.TabIndex = 122;
            this.label5.Text = "Scientist:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 121;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 28);
            this.label3.TabIndex = 120;
            this.label3.Text = "ID:";
            // 
            // participantGridview
            // 
            this.participantGridview.AllowUserToAddRows = false;
            this.participantGridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.participantGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.participantGridview.BackgroundColor = System.Drawing.Color.White;
            this.participantGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sctnameColumn,
            this.sctposColumn});
            this.participantGridview.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.participantGridview.Location = new System.Drawing.Point(584, 132);
            this.participantGridview.Name = "participantGridview";
            this.participantGridview.RowHeadersWidth = 62;
            this.participantGridview.RowTemplate.Height = 33;
            this.participantGridview.Size = new System.Drawing.Size(355, 227);
            this.participantGridview.TabIndex = 126;
            // 
            // sctnameColumn
            // 
            this.sctnameColumn.HeaderText = "Name";
            this.sctnameColumn.MinimumWidth = 8;
            this.sctnameColumn.Name = "sctnameColumn";
            // 
            // sctposColumn
            // 
            this.sctposColumn.HeaderText = "Position";
            this.sctposColumn.MinimumWidth = 8;
            this.sctposColumn.Name = "sctposColumn";
            // 
            // participantCombobox
            // 
            this.participantCombobox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.participantCombobox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.participantCombobox.FormattingEnabled = true;
            this.participantCombobox.Items.AddRange(new object[] {
            "Chemist",
            "Case Navigator",
            "Greenhouse Technician",
            "Lab Assistant",
            "Lab Inspector",
            "Laboratory Manager",
            "Lab Scientist",
            "Lab Technician",
            "Process Operator",
            "Research Assistant",
            "Research Engineer",
            "Security"});
            this.participantCombobox.Location = new System.Drawing.Point(197, 312);
            this.participantCombobox.Name = "participantCombobox";
            this.participantCombobox.Size = new System.Drawing.Size(350, 33);
            this.participantCombobox.TabIndex = 127;
            // 
            // leaderCheckbox
            // 
            this.leaderCheckbox.AutoSize = true;
            this.leaderCheckbox.Location = new System.Drawing.Point(197, 362);
            this.leaderCheckbox.Name = "leaderCheckbox";
            this.leaderCheckbox.Size = new System.Drawing.Size(90, 29);
            this.leaderCheckbox.TabIndex = 128;
            this.leaderCheckbox.Text = "Leader";
            this.leaderCheckbox.UseVisualStyleBackColor = true;
            // 
            // addmemBtn
            // 
            this.addmemBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addmemBtn.AutoSize = true;
            this.addmemBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.addmemBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addmemBtn.FlatAppearance.BorderSize = 0;
            this.addmemBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.addmemBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addmemBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addmemBtn.Location = new System.Drawing.Point(397, 357);
            this.addmemBtn.Name = "addmemBtn";
            this.addmemBtn.Size = new System.Drawing.Size(150, 40);
            this.addmemBtn.TabIndex = 129;
            this.addmemBtn.Text = "Add";
            this.addmemBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addmemBtn.UseVisualStyleBackColor = false;
            // 
            // aprtCombobox
            // 
            this.aprtCombobox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aprtCombobox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.aprtCombobox.FormattingEnabled = true;
            this.aprtCombobox.Items.AddRange(new object[] {
            "Chemist",
            "Case Navigator",
            "Greenhouse Technician",
            "Lab Assistant",
            "Lab Inspector",
            "Laboratory Manager",
            "Lab Scientist",
            "Lab Technician",
            "Process Operator",
            "Research Assistant",
            "Research Engineer",
            "Security"});
            this.aprtCombobox.Location = new System.Drawing.Point(197, 412);
            this.aprtCombobox.Name = "aprtCombobox";
            this.aprtCombobox.Size = new System.Drawing.Size(350, 33);
            this.aprtCombobox.TabIndex = 130;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(43, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 28);
            this.label6.TabIndex = 131;
            this.label6.Text = "Apparatus:";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityTextbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.quantityTextbox.Location = new System.Drawing.Point(197, 462);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.PlaceholderText = "Quantity...";
            this.quantityTextbox.Size = new System.Drawing.Size(126, 31);
            this.quantityTextbox.TabIndex = 132;
            // 
            // addaprtBtn
            // 
            this.addaprtBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addaprtBtn.AutoSize = true;
            this.addaprtBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.addaprtBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addaprtBtn.FlatAppearance.BorderSize = 0;
            this.addaprtBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.addaprtBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addaprtBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addaprtBtn.Location = new System.Drawing.Point(394, 457);
            this.addaprtBtn.Name = "addaprtBtn";
            this.addaprtBtn.Size = new System.Drawing.Size(150, 40);
            this.addaprtBtn.TabIndex = 133;
            this.addaprtBtn.Text = "Add";
            this.addaprtBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addaprtBtn.UseVisualStyleBackColor = false;
            // 
            // startTimepicker
            // 
            this.startTimepicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.startTimepicker.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.startTimepicker.Location = new System.Drawing.Point(197, 512);
            this.startTimepicker.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.startTimepicker.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.startTimepicker.Name = "startTimepicker";
            this.startTimepicker.Size = new System.Drawing.Size(350, 31);
            this.startTimepicker.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(43, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 28);
            this.label7.TabIndex = 135;
            this.label7.Text = "Start date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(43, 563);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 137;
            this.label8.Text = "End date:";
            // 
            // endTimepicker
            // 
            this.endTimepicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.endTimepicker.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.endTimepicker.Location = new System.Drawing.Point(197, 562);
            this.endTimepicker.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.endTimepicker.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.endTimepicker.Name = "endTimepicker";
            this.endTimepicker.Size = new System.Drawing.Size(350, 31);
            this.endTimepicker.TabIndex = 136;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(584, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 28);
            this.label9.TabIndex = 138;
            this.label9.Text = "Participants:";
            // 
            // takenaprtGridview
            // 
            this.takenaprtGridview.AllowUserToAddRows = false;
            this.takenaprtGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.takenaprtGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.takenaprtGridview.BackgroundColor = System.Drawing.Color.White;
            this.takenaprtGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenaprtGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takenaprtnameColumn,
            this.takenquantityColumn});
            this.takenaprtGridview.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.takenaprtGridview.Location = new System.Drawing.Point(584, 393);
            this.takenaprtGridview.Name = "takenaprtGridview";
            this.takenaprtGridview.RowHeadersWidth = 62;
            this.takenaprtGridview.RowTemplate.Height = 33;
            this.takenaprtGridview.Size = new System.Drawing.Size(355, 200);
            this.takenaprtGridview.TabIndex = 139;
            // 
            // takenaprtnameColumn
            // 
            this.takenaprtnameColumn.HeaderText = "Name";
            this.takenaprtnameColumn.MinimumWidth = 8;
            this.takenaprtnameColumn.Name = "takenaprtnameColumn";
            // 
            // takenquantityColumn
            // 
            this.takenquantityColumn.HeaderText = "Quantity";
            this.takenquantityColumn.MinimumWidth = 8;
            this.takenquantityColumn.Name = "takenquantityColumn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(584, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 28);
            this.label10.TabIndex = 140;
            this.label10.Text = "Taken apparatuses:";
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
            this.cancelBtn.Location = new System.Drawing.Point(519, 612);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelBtn.Size = new System.Drawing.Size(150, 40);
            this.cancelBtn.TabIndex = 142;
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
            this.addBtn.Location = new System.Drawing.Point(348, 612);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(150, 40);
            this.addBtn.TabIndex = 141;
            this.addBtn.Text = "Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.takenaprtGridview);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.endTimepicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startTimepicker);
            this.Controls.Add(this.addaprtBtn);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aprtCombobox);
            this.Controls.Add(this.addmemBtn);
            this.Controls.Add(this.leaderCheckbox);
            this.Controls.Add(this.participantCombobox);
            this.Controls.Add(this.participantGridview);
            this.Controls.Add(this.exptdescriptTextbox);
            this.Controls.Add(this.expidTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add project";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddProjectForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddProjectForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddProjectForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddProjectForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.participantGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenaprtGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox exptdescriptTextbox;
        private System.Windows.Forms.TextBox expidTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView participantGridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn sctnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sctposColumn;
        private System.Windows.Forms.ComboBox participantCombobox;
        private System.Windows.Forms.CheckBox leaderCheckbox;
        private System.Windows.Forms.Button addmemBtn;
        private System.Windows.Forms.ComboBox aprtCombobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Button addaprtBtn;
        private System.Windows.Forms.DateTimePicker startTimepicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker endTimepicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView takenaprtGridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenaprtnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takenquantityColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
    }
}