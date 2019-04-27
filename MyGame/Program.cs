using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Program
    {

        static RenderWindow win;
        static void Main(string[] args)
        {
            win = new RenderWindow(new SFML.Window.VideoMode(800, 600), "Моя игра!");
            win.SetVerticalSyncEnabled(true);

            win.Closed += Win_Closed;

            // Загрузка контента 
            Content.Load();

            while (win.IsOpen)
            {
                win.DispatchEvents();

                win.Clear(Color.Black);

                // Рисуем здесь!

                win.Display();
            }
        }
        private static void Win_Closed(object sender, EventArgs e)
        {
            win.Close();
        }
    }
}
