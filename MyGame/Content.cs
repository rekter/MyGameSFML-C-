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

        public static Texture texTile0; // GROUND
        public static Texture texTile1; // GRASS

        public static void Load()
        {
            texTile0 = new Texture(CONTENT_DIR + "Textures\\Tiles_0.png");
            texTile1 = new Texture(CONTENT_DIR + "Textures\\Tiles_1.png");
        }
    }
}
