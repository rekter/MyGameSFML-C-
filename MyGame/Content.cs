using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Content
    {
        public const string CONTENT_DIR = "..\\Content\\";

        public static Texture texTile0;

        public static void Load()
        {
            texTile0 = new Texture(CONTENT_DIR + "Textures\\Tiles_0.png");
        }
    }
}
