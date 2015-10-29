﻿using Microsoft.Xna.Framework;

namespace WinnieTerminator.Core
{
    class RectColliderComponent : ColliderComponent
    {

        private Rectangle rect;

        public RectColliderComponent(string id, GameObject owner, Rectangle rect) : base(id, owner)
        {
            this.rect = rect;
        }

        public override bool IsActiveCollider
        {
            get { return isActiveCollider; }
            set { isActiveCollider = value; }
        }

        public override bool IsCollideWith(Point point)
        {
            return false;
        }

        public override bool IsCollideWith(Rectangle rect)
        {
            return false;
        }
    }
}
