namespace Predator_prey_model_WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPredator = new System.Windows.Forms.TextBox();
            this.txtBoxPrey = new System.Windows.Forms.TextBox();
            this.txtBoxPopulation = new System.Windows.Forms.TextBox();
            this.txtBoxStep = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartDynamic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDynamic)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(6, 6);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Size = new System.Drawing.Size(1022, 534);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Хищники: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Жертвы: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Популяции: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Шаг: ";
            // 
            // txtBoxPredator
            // 
            this.txtBoxPredator.Location = new System.Drawing.Point(134, 22);
            this.txtBoxPredator.Name = "txtBoxPredator";
            this.txtBoxPredator.Size = new System.Drawing.Size(199, 22);
            this.txtBoxPredator.TabIndex = 5;
            this.txtBoxPredator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPredator_KeyPress);
            // 
            // txtBoxPrey
            // 
            this.txtBoxPrey.Location = new System.Drawing.Point(134, 63);
            this.txtBoxPrey.Name = "txtBoxPrey";
            this.txtBoxPrey.Size = new System.Drawing.Size(199, 22);
            this.txtBoxPrey.TabIndex = 6;
            this.txtBoxPrey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPrey_KeyPress);
            // 
            // txtBoxPopulation
            // 
            this.txtBoxPopulation.Location = new System.Drawing.Point(464, 17);
            this.txtBoxPopulation.Name = "txtBoxPopulation";
            this.txtBoxPopulation.Size = new System.Drawing.Size(199, 22);
            this.txtBoxPopulation.TabIndex = 7;
            this.txtBoxPopulation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPopulation_KeyPress);
            // 
            // txtBoxStep
            // 
            this.txtBoxStep.Location = new System.Drawing.Point(464, 63);
            this.txtBoxStep.Name = "txtBoxStep";
            this.txtBoxStep.Size = new System.Drawing.Size(199, 22);
            this.txtBoxStep.TabIndex = 8;
            this.txtBoxStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStep_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(134, 105);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(199, 32);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Построить график";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 159);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 575);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "График";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartDynamic);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График изменения динамики";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartDynamic
            // 
            this.chartDynamic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartDynamic.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDynamic.Legends.Add(legend4);
            this.chartDynamic.Location = new System.Drawing.Point(6, 6);
            this.chartDynamic.Name = "chartDynamic";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartDynamic.Series.Add(series6);
            this.chartDynamic.Size = new System.Drawing.Size(1022, 537);
            this.chartDynamic.TabIndex = 0;
            this.chartDynamic.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 746);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBoxStep);
            this.Controls.Add(this.txtBoxPopulation);
            this.Controls.Add(this.txtBoxPrey);
            this.Controls.Add(this.txtBoxPredator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Хищник-жертва";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDynamic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPredator;
        private System.Windows.Forms.TextBox txtBoxPrey;
        private System.Windows.Forms.TextBox txtBoxPopulation;
        private System.Windows.Forms.TextBox txtBoxStep;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDynamic;
    }
}

