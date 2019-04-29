using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    enum TileType
    {
        NONE,           // Пусто
        GROUND,         // Почва
        GRASS           // Трава
    }

    class Tile : Transformable, Drawable
    {
        // Размер тайла по ширине и высоте
        public const int TILE_SIZE = 16;

        TileType type = TileType.GROUND;
        RectangleShape rectShape;

        public Tile(TileType type)
        {
            this.type = type;

            rectShape = new RectangleShape(new Vector2f(TILE_SIZE, TILE_SIZE));
            
            switch (type)
            {
                case TileType.GROUND:
                    rectShape.Texture = Content.texTile0;   // Почва
                    break;
                case TileType.GRASS:
                    rectShape.Texture = Content.texTile1;   // Трава
                    break;
            }
            rectShape.TextureRect = new IntRect(0, 0, TILE_SIZE, TILE_SIZE);
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;

            target.Draw(rectShape, states);
        }
    }
}
