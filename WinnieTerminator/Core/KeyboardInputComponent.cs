
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace WinnieTerminator.Core
{
    class KeyboardInputComponent : Component
    {
        public KeyboardInputComponent(string id, GameObject owner) : base(id, owner)
        {

        }

        public override void update(GameTime gameTime)
        {
            if (GameData.Instance.keyboardState.IsKeyDown(Keys.Left))
            {
                owner.Position = new Vector2(owner.Position.X - 1, owner.Position.Y);
            }
            if (GameData.Instance.keyboardState.IsKeyDown(Keys.Right))
            {
                owner.Position = new Vector2(owner.Position.X + 1, owner.Position.Y);
            }
        }
    }
}
