namespace mv {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.pnlConsoleBorder = new System.Windows.Forms.Panel();
            this.pnlConsolePadding = new System.Windows.Forms.Panel();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblConsole = new System.Windows.Forms.Label();
            this.pnlLinesVisible = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSourceVisible = new System.Windows.Forms.CheckBox();
            this.lblLinesVisible = new System.Windows.Forms.Label();
            this.cbSplineVisible = new System.Windows.Forms.CheckBox();
            this.nudSegmentation = new System.Windows.Forms.NumericUpDown();
            this.lblSegmentation = new System.Windows.Forms.Label();
            this.pnlPointsCount = new System.Windows.Forms.Panel();
            this.btnApplyPountsCount = new System.Windows.Forms.Button();
            this.nudPointsCount = new System.Windows.Forms.NumericUpDown();
            this.lblPointsCount = new System.Windows.Forms.Label();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pbView = new System.Windows.Forms.PictureBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.tblPoints = new System.Windows.Forms.DataGridView();
            this.btnRandom = new System.Windows.Forms.Button();
            this.pnlSide.SuspendLayout();
            this.pnlConsoleBorder.SuspendLayout();
            this.pnlConsolePadding.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlLinesVisible.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegmentation)).BeginInit();
            this.pnlPointsCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointsCount)).BeginInit();
            this.pnlAbout.SuspendLayout();
            this.pnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Controls.Add(this.pnlConsoleBorder);
            this.pnlSide.Controls.Add(this.pnlSettings);
            this.pnlSide.Controls.Add(this.pnlAbout);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSide.Size = new System.Drawing.Size(198, 451);
            this.pnlSide.TabIndex = 2;
            // 
            // pnlConsoleBorder
            // 
            this.pnlConsoleBorder.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlConsoleBorder.Controls.Add(this.pnlConsolePadding);
            this.pnlConsoleBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsoleBorder.Location = new System.Drawing.Point(8, 198);
            this.pnlConsoleBorder.Name = "pnlConsoleBorder";
            this.pnlConsoleBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlConsoleBorder.Size = new System.Drawing.Size(182, 175);
            this.pnlConsoleBorder.TabIndex = 4;
            // 
            // pnlConsolePadding
            // 
            this.pnlConsolePadding.BackColor = System.Drawing.Color.White;
            this.pnlConsolePadding.Controls.Add(this.rtbConsole);
            this.pnlConsolePadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsolePadding.Location = new System.Drawing.Point(1, 1);
            this.pnlConsolePadding.Name = "pnlConsolePadding";
            this.pnlConsolePadding.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.pnlConsolePadding.Size = new System.Drawing.Size(180, 173);
            this.pnlConsolePadding.TabIndex = 3;
            // 
            // rtbConsole
            // 
            this.rtbConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConsole.Location = new System.Drawing.Point(5, 5);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbConsole.Size = new System.Drawing.Size(175, 163);
            this.rtbConsole.TabIndex = 2;
            this.rtbConsole.Text = "";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.lblConsole);
            this.pnlSettings.Controls.Add(this.pnlLinesVisible);
            this.pnlSettings.Controls.Add(this.nudSegmentation);
            this.pnlSettings.Controls.Add(this.lblSegmentation);
            this.pnlSettings.Controls.Add(this.pnlPointsCount);
            this.pnlSettings.Controls.Add(this.lblPointsCount);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(8, 8);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(182, 190);
            this.pnlSettings.TabIndex = 8;
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConsole.Location = new System.Drawing.Point(0, 174);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(50, 13);
            this.lblConsole.TabIndex = 11;
            this.lblConsole.Text = "Консоль";
            // 
            // pnlLinesVisible
            // 
            this.pnlLinesVisible.Controls.Add(this.panel1);
            this.pnlLinesVisible.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLinesVisible.Location = new System.Drawing.Point(0, 76);
            this.pnlLinesVisible.Name = "pnlLinesVisible";
            this.pnlLinesVisible.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.pnlLinesVisible.Size = new System.Drawing.Size(182, 98);
            this.pnlLinesVisible.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(182, 61);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbSourceVisible);
            this.panel2.Controls.Add(this.lblLinesVisible);
            this.panel2.Controls.Add(this.cbSplineVisible);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel2.Size = new System.Drawing.Size(180, 59);
            this.panel2.TabIndex = 3;
            // 
            // cbSourceVisible
            // 
            this.cbSourceVisible.AutoSize = true;
            this.cbSourceVisible.Checked = true;
            this.cbSourceVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSourceVisible.Location = new System.Drawing.Point(8, 21);
            this.cbSourceVisible.Name = "cbSourceVisible";
            this.cbSourceVisible.Size = new System.Drawing.Size(114, 17);
            this.cbSourceVisible.TabIndex = 14;
            this.cbSourceVisible.Text = "Исходная кривая";
            this.cbSourceVisible.UseVisualStyleBackColor = true;
            this.cbSourceVisible.CheckedChanged += new System.EventHandler(this.cbVisible_CheckedChanged);
            // 
            // lblLinesVisible
            // 
            this.lblLinesVisible.AutoSize = true;
            this.lblLinesVisible.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLinesVisible.Location = new System.Drawing.Point(5, 5);
            this.lblLinesVisible.Name = "lblLinesVisible";
            this.lblLinesVisible.Size = new System.Drawing.Size(69, 13);
            this.lblLinesVisible.TabIndex = 16;
            this.lblLinesVisible.Text = "Отображать";
            // 
            // cbSplineVisible
            // 
            this.cbSplineVisible.AutoSize = true;
            this.cbSplineVisible.Checked = true;
            this.cbSplineVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSplineVisible.Location = new System.Drawing.Point(8, 37);
            this.cbSplineVisible.Name = "cbSplineVisible";
            this.cbSplineVisible.Size = new System.Drawing.Size(168, 17);
            this.cbSplineVisible.TabIndex = 15;
            this.cbSplineVisible.Text = "Интерполированная кривая";
            this.cbSplineVisible.UseVisualStyleBackColor = true;
            this.cbSplineVisible.CheckedChanged += new System.EventHandler(this.cbVisible_CheckedChanged);
            // 
            // nudSegmentation
            // 
            this.nudSegmentation.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudSegmentation.Location = new System.Drawing.Point(0, 56);
            this.nudSegmentation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSegmentation.Name = "nudSegmentation";
            this.nudSegmentation.Size = new System.Drawing.Size(182, 20);
            this.nudSegmentation.TabIndex = 2;
            this.nudSegmentation.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSegmentation.ValueChanged += new System.EventHandler(this.nudSegmentation_ValueChanged);
            // 
            // lblSegmentation
            // 
            this.lblSegmentation.AutoSize = true;
            this.lblSegmentation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSegmentation.Location = new System.Drawing.Point(0, 37);
            this.lblSegmentation.Name = "lblSegmentation";
            this.lblSegmentation.Padding = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.lblSegmentation.Size = new System.Drawing.Size(74, 19);
            this.lblSegmentation.TabIndex = 8;
            this.lblSegmentation.Text = "Сегментация";
            // 
            // pnlPointsCount
            // 
            this.pnlPointsCount.Controls.Add(this.btnApplyPountsCount);
            this.pnlPointsCount.Controls.Add(this.nudPointsCount);
            this.pnlPointsCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPointsCount.Location = new System.Drawing.Point(0, 15);
            this.pnlPointsCount.Name = "pnlPointsCount";
            this.pnlPointsCount.Size = new System.Drawing.Size(182, 22);
            this.pnlPointsCount.TabIndex = 13;
            // 
            // btnApplyPountsCount
            // 
            this.btnApplyPountsCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnApplyPountsCount.Enabled = false;
            this.btnApplyPountsCount.Image = global::mv.Properties.Resources.apply;
            this.btnApplyPountsCount.Location = new System.Drawing.Point(137, 0);
            this.btnApplyPountsCount.Name = "btnApplyPountsCount";
            this.btnApplyPountsCount.Size = new System.Drawing.Size(45, 22);
            this.btnApplyPountsCount.TabIndex = 2;
            this.btnApplyPountsCount.UseVisualStyleBackColor = true;
            this.btnApplyPountsCount.Click += new System.EventHandler(this.btnApplyPountsCount_Click);
            // 
            // nudPointsCount
            // 
            this.nudPointsCount.Location = new System.Drawing.Point(1, 1);
            this.nudPointsCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPointsCount.Name = "nudPointsCount";
            this.nudPointsCount.Size = new System.Drawing.Size(130, 20);
            this.nudPointsCount.TabIndex = 6;
            this.nudPointsCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPointsCount.ValueChanged += new System.EventHandler(this.nudPointsCount_ValueChanged);
            // 
            // lblPointsCount
            // 
            this.lblPointsCount.AutoSize = true;
            this.lblPointsCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPointsCount.Location = new System.Drawing.Point(0, 0);
            this.lblPointsCount.Name = "lblPointsCount";
            this.lblPointsCount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblPointsCount.Size = new System.Drawing.Size(97, 15);
            this.lblPointsCount.TabIndex = 7;
            this.lblPointsCount.Text = "Количество точек";
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.label1);
            this.pnlAbout.Controls.Add(this.lblAuthor);
            this.pnlAbout.Controls.Add(this.lblAbout);
            this.pnlAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAbout.Location = new System.Drawing.Point(8, 373);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(182, 70);
            this.pnlAbout.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кубическая сплайн интерполяция";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAuthor.Location = new System.Drawing.Point(3, 56);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(121, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Егоров Евгений © 2016";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAbout.Location = new System.Drawing.Point(1, 23);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(160, 13);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "КР \"Методы вычислений\"";
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlView.Controls.Add(this.pbView);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(198, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Padding = new System.Windows.Forms.Padding(10);
            this.pnlView.Size = new System.Drawing.Size(556, 374);
            this.pnlView.TabIndex = 3;
            // 
            // pbView
            // 
            this.pbView.BackColor = System.Drawing.Color.White;
            this.pbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbView.Location = new System.Drawing.Point(10, 10);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(536, 354);
            this.pbView.TabIndex = 0;
            this.pbView.TabStop = false;
            this.pbView.Paint += new System.Windows.Forms.PaintEventHandler(this.pbView_Paint);
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.LightGray;
            this.pnlData.Controls.Add(this.tblPoints);
            this.pnlData.Controls.Add(this.btnRandom);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlData.Location = new System.Drawing.Point(198, 374);
            this.pnlData.Name = "pnlData";
            this.pnlData.Padding = new System.Windows.Forms.Padding(10);
            this.pnlData.Size = new System.Drawing.Size(556, 77);
            this.pnlData.TabIndex = 1;
            // 
            // tblPoints
            // 
            this.tblPoints.AllowUserToAddRows = false;
            this.tblPoints.AllowUserToDeleteRows = false;
            this.tblPoints.AllowUserToResizeColumns = false;
            this.tblPoints.AllowUserToResizeRows = false;
            this.tblPoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPoints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPoints.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPoints.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPoints.Location = new System.Drawing.Point(10, 10);
            this.tblPoints.MultiSelect = false;
            this.tblPoints.Name = "tblPoints";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPoints.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblPoints.RowHeadersVisible = false;
            this.tblPoints.RowTemplate.Height = 28;
            this.tblPoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblPoints.Size = new System.Drawing.Size(479, 57);
            this.tblPoints.TabIndex = 7;
            this.tblPoints.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPoints_CellEndEdit);
            this.tblPoints.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tblPoints_EditingControlShowing);
            this.tblPoints.SelectionChanged += new System.EventHandler(this.tblPoints_SelectionChanged);
            // 
            // btnRandom
            // 
            this.btnRandom.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRandom.Image = global::mv.Properties.Resources.dice;
            this.btnRandom.Location = new System.Drawing.Point(489, 10);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(57, 57);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 451);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlSide);
            this.Name = "MainForm";
            this.Text = "Курсовая работа. Егоров Евгений";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlSide.ResumeLayout(false);
            this.pnlConsoleBorder.ResumeLayout(false);
            this.pnlConsolePadding.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlLinesVisible.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegmentation)).EndInit();
            this.pnlPointsCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPointsCount)).EndInit();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.pnlView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbView;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.NumericUpDown nudSegmentation;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlConsoleBorder;
        private System.Windows.Forms.Panel pnlConsolePadding;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblSegmentation;
        private System.Windows.Forms.Label lblPointsCount;
        private System.Windows.Forms.NumericUpDown nudPointsCount;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.Button btnApplyPountsCount;
        protected System.Windows.Forms.DataGridView tblPoints;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Panel pnlPointsCount;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLinesVisible;
        private System.Windows.Forms.CheckBox cbSourceVisible;
        private System.Windows.Forms.Label lblLinesVisible;
        private System.Windows.Forms.CheckBox cbSplineVisible;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

