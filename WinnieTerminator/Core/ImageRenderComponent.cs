using Microsoft.Xna.Framework.Graphics;
using System;

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
            throw new NotImplementedException();
        }

        public override void render(int cam_x, int cam_y)
        {
            throw new NotImplementedException();
        }

        public override void update(float delta)
        {
            throw new NotImplementedException();
        }
    }
}
