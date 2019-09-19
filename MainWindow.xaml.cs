using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        void Uravnenie_reshenie(double constanta1, double constanta2, double constanta3)
        {
            double diskriminant = 0;
            double x1 = 0;
            double x2 = 0;

            diskriminant = constanta2 * constanta2 - 4 * constanta1 * constanta3; 
            if (diskriminant < 0)
            {
                textBox.Text = "Решений нету, дискриминант меньше 0";
            }
            else if (diskriminant == 0)
            {
                x1 = (-constanta2) / (2 * constanta1);
                textBox.Text = "Один корень т.к. дискриминант = 0. 0\n х1 =" + x1;
            }
            else
            {
                x1 = (-constanta2 + Math.Sqrt(diskriminant)) / 2 * constanta1;
                x2 = (-constanta2 - Math.Sqrt(diskriminant)) / 2 * constanta1;
                textBox.Text = "У данного дискриминанта два корня. 0\n х1=" + x1 + "0\n х2=" + x2;
            }
        }
        bool Text_boxISEmpty()
        {
            return (textBox_Constant1.Text != "" && textBox_Constant2.Text != "");
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Обработчик нажатия на кнопку
        {
            if (Text_boxISEmpty())
            {
                try
                {
                    Uravnenie_reshenie(Convert.ToDouble(textBox_Constant1.Text), Convert.ToDouble(textBox_Constant2.Text), Convert.ToDouble(textBox_Constant3.Text));
                }
                catch
                {
                    MessageBox.Show("Некоректный ввод.");
                }
            }
            else
                MessageBox.Show("Не все поля заполнены.");
        }

    }
}
