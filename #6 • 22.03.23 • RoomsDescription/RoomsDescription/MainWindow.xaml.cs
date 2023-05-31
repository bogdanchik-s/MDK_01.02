using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace RoomsDescription
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Room> lstRooms = new List<Room>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            Room room = new Room();

            try
            {
                room.RoomLenght = Convert.ToDouble(TBLenghtR.Text);
                room.RoomWidth = Convert.ToDouble(TBWidthR.Text);
            }
            catch (FormatException)
            {
                TBLenghtR.BorderBrush = Brushes.Red;
                TBWidthR.BorderBrush = Brushes.Red;

                return;
            }

            TBLenghtR.BorderBrush = Brushes.Transparent;
            TBWidthR.BorderBrush = Brushes.Transparent;

            lstRooms.Add(room);
        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            LivingRoom livingRoom = new LivingRoom();

            try
            {
                livingRoom.RoomLenght = Convert.ToDouble(TBLenghtL.Text);
                livingRoom.RoomWidth = Convert.ToDouble(TBWidthL.Text);
                livingRoom.NumWin = Convert.ToInt32(TBNumW.Text);
            }
            catch (FormatException)
            {
                TBLenghtL.BorderBrush = Brushes.Red;
                TBWidthL.BorderBrush = Brushes.Red;
                TBNumW.BorderBrush = Brushes.Red;

                return;
            }

            TBLenghtL.BorderBrush = Brushes.Transparent;
            TBWidthL.BorderBrush = Brushes.Transparent;
            TBNumW.BorderBrush = Brushes.Transparent;

            lstRooms.Add(livingRoom);
        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            Office office = new Office();

            try
            {
                office.RoomLenght = Convert.ToDouble(TBLenghtO.Text);
                office.RoomWidth = Convert.ToDouble(TBWidthO.Text);
                office.NumSockets = Convert.ToInt32(TBNumS.Text);
            }
            catch (FormatException)
            {
                TBLenghtO.BorderBrush = Brushes.Red;
                TBWidthO.BorderBrush = Brushes.Red;
                TBNumS.BorderBrush = Brushes.Red;

                return;
            }

            TBLenghtO.BorderBrush = Brushes.Transparent;
            TBWidthO.BorderBrush = Brushes.Transparent;
            TBNumS.BorderBrush = Brushes.Transparent;

            lstRooms.Add(office);
        }

        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";

            foreach (Room r in lstRooms)
                ListRooms.Content += r.Info() + '\n';
        }

        private void TextBoxes_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.BorderBrush != Brushes.Transparent)
                textBox.BorderBrush = Brushes.Transparent;
        }
    }
}
