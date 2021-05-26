
namespace Laboratory
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chemistryPage = new System.Windows.Forms.TabPage();
            this.numofmemLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmtmemGridview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cytologyPage = new System.Windows.Forms.TabPage();
            this.numofmemLabel1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ctlmemGridview = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hematologyPage = new System.Windows.Forms.TabPage();
            this.numofmemLabel2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.hmtmemGridview = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.microbiologyPage = new System.Windows.Forms.TabPage();
            this.numofmemLabel3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.mcbmemGridview = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.chemistryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmtmemGridview)).BeginInit();
            this.cytologyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlmemGridview)).BeginInit();
            this.hematologyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hmtmemGridview)).BeginInit();
            this.microbiologyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcbmemGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.chemistryPage);
            this.tabControl1.Controls.Add(this.cytologyPage);
            this.tabControl1.Controls.Add(this.hematologyPage);
            this.tabControl1.Controls.Add(this.microbiologyPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 755);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // chemistryPage
            // 
            this.chemistryPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chemistryPage.Controls.Add(this.numofmemLabel);
            this.chemistryPage.Controls.Add(this.label8);
            this.chemistryPage.Controls.Add(this.cmtmemGridview);
            this.chemistryPage.Controls.Add(this.label2);
            this.chemistryPage.Controls.Add(this.label12);
            this.chemistryPage.Controls.Add(this.panel1);
            this.chemistryPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chemistryPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chemistryPage.Location = new System.Drawing.Point(4, 34);
            this.chemistryPage.Margin = new System.Windows.Forms.Padding(2);
            this.chemistryPage.Name = "chemistryPage";
            this.chemistryPage.Padding = new System.Windows.Forms.Padding(2);
            this.chemistryPage.Size = new System.Drawing.Size(1174, 717);
            this.chemistryPage.TabIndex = 0;
            this.chemistryPage.Text = "Chemistry";
            this.chemistryPage.UseVisualStyleBackColor = true;
            // 
            // numofmemLabel
            // 
            this.numofmemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numofmemLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numofmemLabel.Location = new System.Drawing.Point(215, 462);
            this.numofmemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numofmemLabel.Name = "numofmemLabel";
            this.numofmemLabel.Size = new System.Drawing.Size(84, 22);
            this.numofmemLabel.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(126, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Members:";
            // 
            // cmtmemGridview
            // 
            this.cmtmemGridview.AllowUserToAddRows = false;
            this.cmtmemGridview.AllowUserToDeleteRows = false;
            this.cmtmemGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmtmemGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cmtmemGridview.BackgroundColor = System.Drawing.Color.White;
            this.cmtmemGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cmtmemGridview.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmtmemGridview.Location = new System.Drawing.Point(126, 508);
            this.cmtmemGridview.Margin = new System.Windows.Forms.Padding(2);
            this.cmtmemGridview.Name = "cmtmemGridview";
            this.cmtmemGridview.ReadOnly = true;
            this.cmtmemGridview.RowHeadersWidth = 62;
            this.cmtmemGridview.RowTemplate.Height = 33;
            this.cmtmemGridview.Size = new System.Drawing.Size(926, 186);
            this.cmtmemGridview.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(126, 416);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:             CMT123\r\nLearder:    Sarah Lam\r\n";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(126, 240);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(926, 163);
            this.label12.TabIndex = 2;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 206);
            this.panel1.TabIndex = 0;
            // 
            // cytologyPage
            // 
            this.cytologyPage.Controls.Add(this.numofmemLabel1);
            this.cytologyPage.Controls.Add(this.label10);
            this.cytologyPage.Controls.Add(this.ctlmemGridview);
            this.cytologyPage.Controls.Add(this.label3);
            this.cytologyPage.Controls.Add(this.label1);
            this.cytologyPage.Controls.Add(this.panel2);
            this.cytologyPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cytologyPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cytologyPage.Location = new System.Drawing.Point(4, 34);
            this.cytologyPage.Margin = new System.Windows.Forms.Padding(2);
            this.cytologyPage.Name = "cytologyPage";
            this.cytologyPage.Padding = new System.Windows.Forms.Padding(2);
            this.cytologyPage.Size = new System.Drawing.Size(1174, 717);
            this.cytologyPage.TabIndex = 1;
            this.cytologyPage.Text = "Cytology";
            this.cytologyPage.UseVisualStyleBackColor = true;
            // 
            // numofmemLabel1
            // 
            this.numofmemLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numofmemLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numofmemLabel1.Location = new System.Drawing.Point(209, 507);
            this.numofmemLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numofmemLabel1.Name = "numofmemLabel1";
            this.numofmemLabel1.Size = new System.Drawing.Size(84, 22);
            this.numofmemLabel1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(126, 507);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Members:";
            // 
            // ctlmemGridview
            // 
            this.ctlmemGridview.AllowUserToAddRows = false;
            this.ctlmemGridview.AllowUserToDeleteRows = false;
            this.ctlmemGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlmemGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctlmemGridview.BackgroundColor = System.Drawing.Color.White;
            this.ctlmemGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlmemGridview.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctlmemGridview.Location = new System.Drawing.Point(126, 552);
            this.ctlmemGridview.Margin = new System.Windows.Forms.Padding(2);
            this.ctlmemGridview.Name = "ctlmemGridview";
            this.ctlmemGridview.ReadOnly = true;
            this.ctlmemGridview.RowHeadersWidth = 62;
            this.ctlmemGridview.RowTemplate.Height = 33;
            this.ctlmemGridview.Size = new System.Drawing.Size(926, 142);
            this.ctlmemGridview.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(126, 461);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:             CTL789\r\nLearder:    Linda Smith\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(126, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(926, 209);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 206);
            this.panel2.TabIndex = 1;
            // 
            // hematologyPage
            // 
            this.hematologyPage.Controls.Add(this.numofmemLabel2);
            this.hematologyPage.Controls.Add(this.label13);
            this.hematologyPage.Controls.Add(this.hmtmemGridview);
            this.hematologyPage.Controls.Add(this.label5);
            this.hematologyPage.Controls.Add(this.label4);
            this.hematologyPage.Controls.Add(this.panel3);
            this.hematologyPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hematologyPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hematologyPage.Location = new System.Drawing.Point(4, 34);
            this.hematologyPage.Margin = new System.Windows.Forms.Padding(2);
            this.hematologyPage.Name = "hematologyPage";
            this.hematologyPage.Size = new System.Drawing.Size(1174, 717);
            this.hematologyPage.TabIndex = 2;
            this.hematologyPage.Text = "Hematology";
            this.hematologyPage.UseVisualStyleBackColor = true;
            // 
            // numofmemLabel2
            // 
            this.numofmemLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numofmemLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numofmemLabel2.Location = new System.Drawing.Point(209, 506);
            this.numofmemLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numofmemLabel2.Name = "numofmemLabel2";
            this.numofmemLabel2.Size = new System.Drawing.Size(84, 22);
            this.numofmemLabel2.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(126, 506);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 23);
            this.label13.TabIndex = 7;
            this.label13.Text = "Members:";
            // 
            // hmtmemGridview
            // 
            this.hmtmemGridview.AllowUserToAddRows = false;
            this.hmtmemGridview.AllowUserToDeleteRows = false;
            this.hmtmemGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hmtmemGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hmtmemGridview.BackgroundColor = System.Drawing.Color.White;
            this.hmtmemGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hmtmemGridview.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.hmtmemGridview.Location = new System.Drawing.Point(126, 558);
            this.hmtmemGridview.Margin = new System.Windows.Forms.Padding(2);
            this.hmtmemGridview.Name = "hmtmemGridview";
            this.hmtmemGridview.ReadOnly = true;
            this.hmtmemGridview.RowHeadersWidth = 62;
            this.hmtmemGridview.RowTemplate.Height = 33;
            this.hmtmemGridview.Size = new System.Drawing.Size(926, 136);
            this.hmtmemGridview.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(126, 460);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 46);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID:             HMT567\r\nLearder:    Huỳnh Quang Duy\r\n";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(126, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(926, 206);
            this.label4.TabIndex = 4;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1174, 206);
            this.panel3.TabIndex = 1;
            // 
            // microbiologyPage
            // 
            this.microbiologyPage.Controls.Add(this.numofmemLabel3);
            this.microbiologyPage.Controls.Add(this.label15);
            this.microbiologyPage.Controls.Add(this.mcbmemGridview);
            this.microbiologyPage.Controls.Add(this.label7);
            this.microbiologyPage.Controls.Add(this.label6);
            this.microbiologyPage.Controls.Add(this.panel4);
            this.microbiologyPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.microbiologyPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.microbiologyPage.Location = new System.Drawing.Point(4, 34);
            this.microbiologyPage.Margin = new System.Windows.Forms.Padding(2);
            this.microbiologyPage.Name = "microbiologyPage";
            this.microbiologyPage.Size = new System.Drawing.Size(1174, 717);
            this.microbiologyPage.TabIndex = 3;
            this.microbiologyPage.Text = "Microbiology";
            this.microbiologyPage.UseVisualStyleBackColor = true;
            // 
            // numofmemLabel3
            // 
            this.numofmemLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numofmemLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numofmemLabel3.Location = new System.Drawing.Point(209, 553);
            this.numofmemLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numofmemLabel3.Name = "numofmemLabel3";
            this.numofmemLabel3.Size = new System.Drawing.Size(84, 22);
            this.numofmemLabel3.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(126, 553);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 23);
            this.label15.TabIndex = 8;
            this.label15.Text = "Members:";
            // 
            // mcbmemGridview
            // 
            this.mcbmemGridview.AllowUserToAddRows = false;
            this.mcbmemGridview.AllowUserToDeleteRows = false;
            this.mcbmemGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mcbmemGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mcbmemGridview.BackgroundColor = System.Drawing.Color.White;
            this.mcbmemGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mcbmemGridview.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.mcbmemGridview.Location = new System.Drawing.Point(126, 596);
            this.mcbmemGridview.Margin = new System.Windows.Forms.Padding(2);
            this.mcbmemGridview.Name = "mcbmemGridview";
            this.mcbmemGridview.ReadOnly = true;
            this.mcbmemGridview.RowHeadersWidth = 62;
            this.mcbmemGridview.RowTemplate.Height = 33;
            this.mcbmemGridview.Size = new System.Drawing.Size(926, 98);
            this.mcbmemGridview.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(126, 506);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID:             MCB345\r\nLearder:    Tôn Trí Thiện \r\n";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(126, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(926, 258);
            this.label6.TabIndex = 5;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1174, 206);
            this.panel4.TabIndex = 1;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 755);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scientific Department";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.chemistryPage.ResumeLayout(false);
            this.chemistryPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmtmemGridview)).EndInit();
            this.cytologyPage.ResumeLayout(false);
            this.cytologyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlmemGridview)).EndInit();
            this.hematologyPage.ResumeLayout(false);
            this.hematologyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hmtmemGridview)).EndInit();
            this.microbiologyPage.ResumeLayout(false);
            this.microbiologyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mcbmemGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage chemistryPage;
        private System.Windows.Forms.TabPage cytologyPage;
        private System.Windows.Forms.TabPage hematologyPage;
        private System.Windows.Forms.TabPage microbiologyPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView cmtmemGridview;
        private System.Windows.Forms.DataGridView ctlmemGridview;
        private System.Windows.Forms.DataGridView hmtmemGridview;
        private System.Windows.Forms.DataGridView mcbmemGridview;
        private System.Windows.Forms.Label numofmemLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label numofmemLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label numofmemLabel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label numofmemLabel3;
        private System.Windows.Forms.Label label15;
    }
}