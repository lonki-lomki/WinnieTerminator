using Microsoft.Xna.Framework;

namespace WinnieTerminator.Core
{
    /// <summary>
    /// Класс, реализующий компонент, отвечающий за контроль коллизий
    /// </summary>
    public abstract class ColliderComponent : Component
    {
        /// <summary>
        /// Активный или пассивный коллайдер
        /// (пассивный коллайдер сам не проверяет факт коллизии. Например, ландшафт, 
        /// он сам не перемещается и его коллизии проверять не надо. Игровые же объекты - активные.)
        /// </summary>
        protected bool isActiveCollider = false;


        public ColliderComponent(string id, GameObject owner) : base(id, owner)
        {

        }

        public override void update(GameTime gameTime)
        {

        }

        public abstract bool IsActiveCollider
        {
            //get { return isActiveCollider; }
            //set { isActiveCollider = value; }
            get;
            set;
        }

    }
}
