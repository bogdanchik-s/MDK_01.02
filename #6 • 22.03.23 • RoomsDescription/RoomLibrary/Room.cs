using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLenght;  // Длина помещения
        double roomWidth;   // Ширина помещения

        public double RoomLenght
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }

        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }

        /// <summary>
        /// Метод вычисляет периметр помещения
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLenght + roomWidth);
        }

        /// <summary>
        /// Метод вычисляет площадь помещения
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double RoomArea()
        {
            return roomLenght * roomWidth;
        }

        /// <summary>
        /// Метод вычисляет число квадратных метров на одного человека
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns>Возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }

        /// <summary>
        /// Метод формирует информацию о помещении
        /// </summary>
        /// <returns>Возвращает строку с информацией</returns>
        public virtual string Info()
        {
            return "Помещение площадью " + RoomArea() + "кв. м.";
        }
    }

    /// <summary>
    /// Класс "Жилая комната"
    /// </summary>
    public class LivingRoom : Room
    {
        int numWin;     // Число окон

        public int NumWin
        {
            get { return numWin; }
            set { numWin = value; }
        }

        /// <summary>
        /// Метод формирует информацию о жилой комнате
        /// </summary>
        /// <returns>Возвращает строку с информацией</returns>
        public override string Info()
        {
            return "Жилая комната площадью " + RoomArea() + "кв. м., с " + numWin + " окнами";
        }
    }

    /// <summary>
    /// Класс "Офис"
    /// </summary>
    public class Office : Room
    {
        int numSockets;     // Число розеток

        public int NumSockets
        {
            get { return numSockets; }
            set { numSockets = value; }
        }

        /// <summary>
        /// Метод вычисляет максимально возможное число рабочих мест
        /// </summary>
        /// <returns>Возвращает число рабочих мест</returns>
        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, num);
        }

        /// <summary>
        /// Метод формирует информацию об офисе
        /// </summary>
        /// <returns>Возвращает строку с информацией</returns>
        public override string Info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест";
        }
    }
}
