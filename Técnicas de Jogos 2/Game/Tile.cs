using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer2D
{
    //criacao dos blocos e atribuição das suas caracteristicas
    enum TileCollision
    {
        //bloco transparente
        Passable = 0,

        //bloco solido
        Impassable = 1,

        //bloco que da para passar em alguns dos seus lados
        Platform = 2,
    }

    //guarda o tamanho e as caracteristicas de cada bloco
    struct Tile
    {
        public Texture2D Texture;
        public TileCollision Collision;

        public const int Width = 40;
        public const int Height = 32;

        public static readonly Vector2 Size = new Vector2(Width, Height);

        //constroi os blocos no mapa
        public Tile(Texture2D texture, TileCollision collision)
        {
            Texture = texture;
            Collision = collision;
        }
    }
}