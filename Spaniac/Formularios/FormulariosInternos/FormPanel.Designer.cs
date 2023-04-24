namespace Spaniac.Formularios.FormulariosInternos
{
    partial class FormPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbInicio = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.GraficaCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraficaStockProd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraficaEntrSal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaStockProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaEntrSal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(54, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 5);
            this.panel1.TabIndex = 2;
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Reem Kufi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbInicio.Location = new System.Drawing.Point(34, 23);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(708, 116);
            this.lbInicio.TabIndex = 3;
            this.lbInicio.Text = "PANEL DE CONTROL";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Reem Kufi", 18F, System.Drawing.FontStyle.Bold);
            this.lbHora.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbHora.Location = new System.Drawing.Point(1345, 54);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(91, 44);
            this.lbHora.TabIndex = 4;
            this.lbHora.Text = "HORA";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Reem Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbFecha.Location = new System.Drawing.Point(1217, 92);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(98, 27);
            this.lbFecha.TabIndex = 5;
            this.lbFecha.Text = "DÍA ACTUAL";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // GraficaCategorias
            // 
            chartArea1.Name = "ChartArea1";
            this.GraficaCategorias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficaCategorias.Legends.Add(legend1);
            this.GraficaCategorias.Location = new System.Drawing.Point(54, 182);
            this.GraficaCategorias.Name = "GraficaCategorias";
            this.GraficaCategorias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraficaCategorias.Series.Add(series1);
            this.GraficaCategorias.Size = new System.Drawing.Size(688, 300);
            this.GraficaCategorias.TabIndex = 6;
            this.GraficaCategorias.Text = "chart1";
            // 
            // GraficaStockProd
            // 
            chartArea2.Name = "ChartArea1";
            this.GraficaStockProd.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraficaStockProd.Legends.Add(legend2);
            this.GraficaStockProd.Location = new System.Drawing.Point(748, 182);
            this.GraficaStockProd.Name = "GraficaStockProd";
            this.GraficaStockProd.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Reem Kufi", 8F);
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.GraficaStockProd.Series.Add(series2);
            this.GraficaStockProd.Size = new System.Drawing.Size(692, 300);
            this.GraficaStockProd.TabIndex = 7;
            this.GraficaStockProd.Text = "chart1";
            // 
            // GraficaEntrSal
            // 
            chartArea3.Name = "ChartArea1";
            this.GraficaEntrSal.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.GraficaEntrSal.Legends.Add(legend3);
            this.GraficaEntrSal.Location = new System.Drawing.Point(54, 515);
            this.GraficaEntrSal.Name = "GraficaEntrSal";
            this.GraficaEntrSal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = new System.Drawing.Font("Reem Kufi", 8F);
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.GraficaEntrSal.Series.Add(series3);
            this.GraficaEntrSal.Size = new System.Drawing.Size(1386, 315);
            this.GraficaEntrSal.TabIndex = 8;
            this.GraficaEntrSal.Text = "chart1";
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1505, 862);
            this.Controls.Add(this.GraficaEntrSal);
            this.Controls.Add(this.GraficaStockProd);
            this.Controls.Add(this.GraficaCategorias);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPanel";
            this.Text = "FormPanel";
            ((System.ComponentModel.ISupportInitialize)(this.GraficaCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaStockProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaEntrSal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaCategorias;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaStockProd;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaEntrSal;
    }
}