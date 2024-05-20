using System;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer2D
{
    //funcao responsavel por criar as animaçoes
    class Animation
    {
        ///deteta os frames na imagem de forma horizontal
        public Texture2D Texture
        {
            get { return texture; }
        }
        Texture2D texture;

        //duraçao da animacao
        public float FrameTime
        {
            get { return frameTime; }
        }
        float frameTime;

        //caso a animaçao acabe esta repete se
        public bool IsLooping
        {
            get { return isLooping; }
        }
        bool isLooping;

        //deteta o numero de frames para cada animaçao
        public int FrameCount
        {
            get { return Texture.Width / FrameHeight; }
        }

        //deteta a largura de cada frame
        public int FrameWidth
        {
            get { return Texture.Height; }
        }

        //deteta a altura de cada frame
        public int FrameHeight
        {
            get { return Texture.Height; }
        }

        //constroi a animação
        public Animation(Texture2D texture, float frameTime, bool isLooping)
        {
            this.texture = texture;
            this.frameTime = frameTime;
            this.isLooping = isLooping;
        }
    }
}