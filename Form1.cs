using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predator_prey_model_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double step = 1; //шаг
            int population = 50; //популяции
            int predator = 100; //хищники
            int prey = 500; //жертвы

            if (txtBoxStep.Text != String.Empty)
                step = Convert.ToDouble(txtBoxStep.Text);

            if (txtBoxPopulation.Text != String.Empty)
                population = Convert.ToInt32(txtBoxPopulation.Text);

            if (txtBoxPredator.Text != String.Empty)
                predator = Convert.ToInt32(txtBoxPredator.Text);

            if (txtBoxPrey.Text != String.Empty)
                prey = Convert.ToInt32(txtBoxPrey.Text);

            try
            {
                double[,] arrayForChart = HandlerClass.ArrayVP(prey, predator, population, step);

                chart.Series[0].Points.Clear();
                chart.Series[1].Points.Clear();
                chartDynamic.Series[0].Points.Clear();

                chart.Series[0].Points.AddXY(0, prey);
                chart.Series[1].Points.AddXY(0, predator);
                chartDynamic.Series[0].Points.AddXY(prey, predator);

                chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartDynamic.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                for (int i = 1; i < population - 1; i++)
                {
                    chart.Series[0].Points.AddXY(i, arrayForChart[0, i]);
                    chart.Series[1].Points.AddXY(i, arrayForChart[1, i]);
                    chartDynamic.Series[0].Points.AddXY(arrayForChart[0, i], arrayForChart[1, i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtBoxPredator_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void txtBoxPrey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void txtBoxPopulation_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void txtBoxStep_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
    }
}
