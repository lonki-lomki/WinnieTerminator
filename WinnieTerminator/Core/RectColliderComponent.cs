using Microsoft.Xna.Framework;

namespace WinnieTerminator.Core
{
    /// <summary>
    /// Контроль коллизий объекта, представленного прямоугольной областью
    /// </summary>
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
            if ((point.X >= rect.X && point.X <= (rect.X+rect.Width)) && (point.Y >= rect.Y && point.Y <= (rect.Y + rect.Height)))
            {
                return true;
            }
            return false;
        }

        public override bool IsCollideWith(Rectangle rect)
        {
            return this.rect.Intersects(rect);
        }
    }
}
