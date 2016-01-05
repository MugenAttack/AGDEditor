namespace AGDEditor
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbLevels = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToNext = new System.Windows.Forms.TextBox();
            this.txtRequired = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAttributes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UpperD = new System.Windows.Forms.NumericUpDown();
            this.LowerD = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.chtLevel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdBtnNext = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpperD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtLevel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Levels";
            // 
            // cbLevels
            // 
            this.cbLevels.FormattingEnabled = true;
            this.cbLevels.Location = new System.Drawing.Point(12, 60);
            this.cbLevels.Name = "cbLevels";
            this.cbLevels.Size = new System.Drawing.Size(65, 21);
            this.cbLevels.TabIndex = 1;
            this.cbLevels.SelectedIndexChanged += new System.EventHandler(this.cbLevels_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Experience Needed for Next Level";
            // 
            // txtToNext
            // 
            this.txtToNext.Location = new System.Drawing.Point(12, 116);
            this.txtToNext.Name = "txtToNext";
            this.txtToNext.Size = new System.Drawing.Size(170, 20);
            this.txtToNext.TabIndex = 4;
            this.txtToNext.TextChanged += new System.EventHandler(this.txtToNext_TextChanged);
            // 
            // txtRequired
            // 
            this.txtRequired.Location = new System.Drawing.Point(12, 158);
            this.txtRequired.Name = "txtRequired";
            this.txtRequired.Size = new System.Drawing.Size(170, 20);
            this.txtRequired.TabIndex = 6;
            this.txtRequired.TextChanged += new System.EventHandler(this.txtRequired_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Experience Required for this Level";
            // 
            // txtAttributes
            // 
            this.txtAttributes.Location = new System.Drawing.Point(12, 197);
            this.txtAttributes.Name = "txtAttributes";
            this.txtAttributes.Size = new System.Drawing.Size(169, 20);
            this.txtAttributes.TabIndex = 8;
            this.txtAttributes.TextChanged += new System.EventHandler(this.txtAttributes_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Attribute Points Gained";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UpperD);
            this.groupBox1.Controls.Add(this.LowerD);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(200, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 194);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leveling Adjuster";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(9, 106);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Set All to 0";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(9, 78);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "Cube All";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Square All ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Minus(-) All by X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Plus(+) All by X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Divide(/) All by X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Multiply(*) All by X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "X:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(108, 138);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(80, 20);
            this.txtX.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Range To Apply to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "To";
            // 
            // UpperD
            // 
            this.UpperD.Location = new System.Drawing.Point(194, 168);
            this.UpperD.Name = "UpperD";
            this.UpperD.Size = new System.Drawing.Size(56, 20);
            this.UpperD.TabIndex = 2;
            // 
            // LowerD
            // 
            this.LowerD.Location = new System.Drawing.Point(108, 168);
            this.LowerD.Name = "LowerD";
            this.LowerD.Size = new System.Drawing.Size(56, 20);
            this.LowerD.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set All to Level #";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chtLevel
            // 
            chartArea2.CursorX.Interval = 5D;
            chartArea2.Name = "ChartArea1";
            this.chtLevel.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtLevel.Legends.Add(legend2);
            this.chtLevel.Location = new System.Drawing.Point(12, 286);
            this.chtLevel.Name = "chtLevel";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.MarkerStep = 2;
            series2.Name = "Levels";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chtLevel.Series.Add(series2);
            this.chtLevel.Size = new System.Drawing.Size(444, 222);
            this.chtLevel.TabIndex = 10;
            this.chtLevel.Text = "chart1";
            this.chtLevel.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.rdBtnNext);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 44);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apply Leveling Adjuster to";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(220, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(187, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Experience Required for this Level";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdBtnNext
            // 
            this.rdBtnNext.AutoSize = true;
            this.rdBtnNext.Location = new System.Drawing.Point(6, 19);
            this.rdBtnNext.Name = "rdBtnNext";
            this.rdBtnNext.Size = new System.Drawing.Size(188, 17);
            this.rdBtnNext.TabIndex = 0;
            this.rdBtnNext.TabStop = true;
            this.rdBtnNext.Text = "Experience Needed for Next Level";
            this.rdBtnNext.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AGDEditor.Properties.Resources._033380;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chtLevel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAttributes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRequired);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLevels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AGD Editor (Leveling Editor) 1.0.0 by MugenAttack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpperD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtLevel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLevels;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToNext;
        private System.Windows.Forms.TextBox txtRequired;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAttributes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown UpperD;
        private System.Windows.Forms.NumericUpDown LowerD;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdBtnNext;
        private System.Windows.Forms.TextBox txtX;
    }
}

