using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Platformer2D
{
    //funcao responsavel pela criacao das gemas
    class Gem
    {
        private Texture2D texture;
        private Vector2 origin;
        private SoundEffect collectedSound;

        public readonly int PointValue = 50;
        public bool IsPowerUp { get; private set; }
        public readonly Color Color;

        private Vector2 basePosition;
        

        public Level Level
        {
            get { return level; }
        }
        Level level;

        //deteta a posicao das gemas no mapa
        public Vector2 Position
        {
            get
            {
                return basePosition;
            }
        }

        //cria uma area de colisao para as gemas
        public Circle BoundingCircle
        {
            get
            {
                return new Circle(Position, Tile.Width / 3.0f);
            }
        }

        //coloca as gemas no mapa
        public Gem(Level level, Vector2 position, bool isPowerUp)
        {
            this.level = level;
            this.basePosition = position;
            IsPowerUp = isPowerUp;
            if (IsPowerUp)
            {
                PointValue = 100;
                Color = Color.Red;
            }
            else
            {
                PointValue = 50;
                Color = Color.Yellow;
            }
            LoadContent();
        }

        //carrega a textura das gemas e o seu som
        public void LoadContent()
        {
            texture = Level.Content.Load<Texture2D>("Sprites/Gem");
            origin = new Vector2(texture.Width / 2.0f, texture.Height / 2.0f);
            collectedSound = Level.Content.Load<SoundEffect>("Sounds/GemCollected");
        }

        

        /// deteta se a gema foi apanhada e se esta era uma gema normal ou um power up
        public void OnCollected(Player collectedBy)
        {
            collectedSound.Play();
            if (IsPowerUp)
                collectedBy.PowerUp();
        }

        ///desenha as gemas com a sua respetiva cor
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Position, null, Color, 0.0f, origin, 1.0f, SpriteEffects.None, 0.0f);
        }
    }
}