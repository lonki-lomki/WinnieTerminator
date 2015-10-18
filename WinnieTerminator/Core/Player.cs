﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WinnieTerminator.Core
{
    /// <summary>
    /// Класс, описывающий главного героя
    /// </summary>
    class Player : GameObject
    {
        private Texture2D picture;

        public Player() : base()
        {
            //LoadContent();
            position = new Vector2(100f, 100f);
        }

        /// <summary>
        /// Загрузка спрайтов игрока и звуков
        /// </summary>
        public void LoadContent()
        {
            picture = GameData.Instance.content.Load<Texture2D>("Images/winnie");
            ImageRenderComponent irc = new ImageRenderComponent("player", this, ref picture);
            addComponent(irc);

            KeyboardInputComponent kic = new KeyboardInputComponent("KeyboardInputComponent", this);
            addComponent(kic);
        }
    }
}
