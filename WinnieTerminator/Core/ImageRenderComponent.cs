using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WinnieTerminator.Core
{

    class ImageRenderComponent : RenderComponent
    {
        Texture2D image;

        public ImageRenderComponent(string id, GameObject owner, ref Texture2D image) : base(id, owner)
        {
            this.image = image;
        }
        public override void render()
        {
            
        }

        public override void render(SpriteBatch sb)
        {
            sb.Draw(image, owner.Position, Color.White);
        }

        public override void render(SpriteBatch sb, float cam_x, float cam_y)
        {
            sb.Draw(image, new Vector2(owner.Position.X - cam_x, owner.Position.Y - cam_y), Color.White);
        }

        public override void update(GameTime gameTime)
        {
            
        }
    }
}
