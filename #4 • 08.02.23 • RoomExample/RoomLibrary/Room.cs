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
    }
}
