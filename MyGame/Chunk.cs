using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Chunk : Transformable, Drawable
    {
        public const int CHUNK_SIZE = 25;

        Tile[][] tiles;

        public Chunk()
        {
            tiles = new Tile[CHUNK_SIZE][];

            for (int i = 0, i < CHUNK_SIZE, i++)
                tiles[i] = new Tile[CHUNK_SIZE];

        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform; 

            // Рисуем тайлы 
            for (int x = 0; x < CHUNK_SIZE; x++)
            {
                for (int y = 0; y < CHUNK_SIZE; y++)
                {
                    target.Draw(tiles[x][y], states);
                }
            }
        }
    }
}
