﻿namespace counterProgram
{
    partial class mainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button = new System.Windows.Forms.Button();
            this.currentCount = new System.Windows.Forms.TextBox();
            this.displayAverage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button.Location = new System.Drawing.Point(268, 64);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(177, 72);
            this.button.TabIndex = 0;
            this.button.Text = "Add Edit";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // currentCount
            // 
            this.currentCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentCount.Location = new System.Drawing.Point(306, 197);
            this.currentCount.Name = "currentCount";
            this.currentCount.ReadOnly = true;
            this.currentCount.Size = new System.Drawing.Size(100, 20);
            this.currentCount.TabIndex = 1;
            this.currentCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayAverage
            // 
            this.displayAverage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.displayAverage.Location = new System.Drawing.Point(306, 289);
            this.displayAverage.Name = "displayAverage";
            this.displayAverage.ReadOnly = true;
            this.displayAverage.Size = new System.Drawing.Size(100, 20);
            this.displayAverage.TabIndex = 2;
            this.displayAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Count";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 397);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Edits";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(688, 163);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // graphColor
            // 
            this.graphColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.graphColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphColor.FormattingEnabled = true;
            this.graphColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Orange"});
            this.graphColor.Location = new System.Drawing.Point(577, 287);
            this.graphColor.Name = "graphColor";
            this.graphColor.Size = new System.Drawing.Size(121, 21);
            this.graphColor.TabIndex = 6;
            this.graphColor.SelectedIndexChanged += new System.EventHandler(this.graphColor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Graph Color";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.graphColor);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayAverage);
            this.Controls.Add(this.currentCount);
            this.Controls.Add(this.button);
            this.MinimumSize = new System.Drawing.Size(728, 611);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Average Edits";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox currentCount;
        private System.Windows.Forms.TextBox displayAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox graphColor;
        private System.Windows.Forms.Label label3;
    }
}

