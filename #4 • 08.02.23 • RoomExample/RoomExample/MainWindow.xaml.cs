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
using RoomLibrary;

namespace RoomExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room1 = new Room();
        Room room2 = new Room();
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открытие первой комнаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpen1_Click(object sender, RoutedEventArgs e)
        {
            // Разрешить открыть вторую комнату
            ButtonOpen2.IsEnabled = true;

            // Инициализация полей класса и генерация числа человек
            room1.RoomLenght = rnd.Next(2, 11);
            room1.RoomWidth = rnd.Next(2, 11);
            int numP = rnd.Next(1, 9);

            // Вывод сгенерированных данных в метки
            LabelLenght1.Content = room1.RoomLenght;
            LabelWidth1.Content = room1.RoomWidth;
            LabelNumPerson1.Content = numP;

            // Вычисление периметра, площади, метража и вывод в метки
            LabelPerimeter1.Content = room1.RoomPerimeter();
            LabelArea1.Content = room1.RoomArea();
            LabelPersonArea1.Content = Math.Round(room1.PersonArea(numP), 3);
        }

        /// <summary>
        /// Открытие второй комнаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpen2_Click(object sender, RoutedEventArgs e)
        {
            int numP;

            // Ввод данныз и инициализация полей класса
            try
            {
                room2.RoomLenght = Convert.ToDouble(TBLenght2.Text);
                room2.RoomWidth = Convert.ToDouble(TBWidth2.Text);
                numP = Convert.ToInt32(TBNumPerson2.Text);
            }
            catch (FormatException)
            {
                LabelPerimeter2.Content = "";
                LabelArea2.Content = "";
                LabelPersonArea2.Content = "";
                LabelAllArea.Content = "";

                TBLenght2.BorderBrush = Brushes.Red;
                TBWidth2.BorderBrush = Brushes.Red;
                TBNumPerson2.BorderBrush = Brushes.Red;

                ButtonAll.IsEnabled = false;

                return;
            }

            TBLenght2.BorderBrush = Brushes.Transparent;
            TBWidth2.BorderBrush = Brushes.Transparent;
            TBNumPerson2.BorderBrush = Brushes.Transparent;

            // Вычисление периметра, площади, метража и вывод в метки
            LabelPerimeter2.Content = room2.RoomPerimeter();
            LabelArea2.Content = room2.RoomArea();
            LabelPersonArea2.Content = Math.Round(room2.PersonArea(numP), 3);

            // Разрешить суммировать площади комнат
            ButtonAll.IsEnabled = true;
        }

        /// <summary>
        /// Подсчет суммарной площади комнат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAll_Click(object sender, RoutedEventArgs e)
        {
            LabelAllArea.Content = room1.RoomArea() + room2.RoomArea();
        }

        /// <summary>
        /// Завершение работы приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
