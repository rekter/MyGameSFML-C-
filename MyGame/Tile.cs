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
        NONE,
        GROUND
    }

    class Tile : Transformable, Drawable
    {
        public const int TILE_SIZE = 16;

        TileType type = TileType.NONE;
        RectangleShape rectShape;

        public Tile()
        {
            rectShape = new RectangleShape(new Vector2f(TILE_SIZE, TILE_SIZE));
            
            switch ()
            {
                case TileType.GROUND:
                    rectShape.Texture = Content.texTile0;
                    rectShape.TextureRect = new IntRect();
                    break;
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;
        }
    }
}
