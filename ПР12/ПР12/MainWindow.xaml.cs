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
using System.Windows.Threading;

namespace ПР12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }
        const double PI = 3.14;

        private void Task1CountButton(object sender, RoutedEventArgs e)
        {

            int.TryParse(firstSideBox.Text, out int valueR1);
            int.TryParse(secondSideBox.Text, out int valueR2);
            if (valueR1 > valueR2)
            {
                ploshadBox1.Text = Convert.ToString((valueR1 * valueR1) * PI);
                ploshadBox2.Text = Convert.ToString((valueR2 * valueR2) * PI);
                ploshadBox3.Text = Convert.ToString(((valueR1 * valueR1) * PI) - ((valueR2 * valueR2) * PI));
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Task2CountButton(object sender, RoutedEventArgs e)
        {
            int.TryParse(inputNumber.Text, out int year);
            int result = 0;
            if (year % 100 > 0)
            {
                result++;
                result += year / 100 % 100;
                centuriesBox.Text = Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm:ss");
            date.Text = d.ToString("dd.MM.yyyy");
        }
        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы Ржевский Александр ИСП-34. Реализовать расчет задачи: Задание №1 Даны два круга с общим центром и радиусами R1 и R2(R1 > R2). Найти площадиэтих кругов S1 и S2, а также площадь S3 кольца, внешний радиус которого равен R1, внутренний радиус равен R2: S1 = PI * (R1)2, S2 = PI * (R2)2, S3 = S1 – S2. Вкачестве значения PI использовать 3.14. Задание №2: Дан номер некоторого года (целое положительное число). Определить соответствующий ему номер столетия, учитывая, что, к примеру, началом 20 столетия был 1901 год", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

