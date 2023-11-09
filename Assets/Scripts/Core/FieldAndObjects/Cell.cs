using UnityEngine;

namespace Core.FieldAndObjects
{
    public class Cell
    {
        public Vector2 coord;
        public Entity entity;

        public void Init(int x, int y, Entity _entity)
        {
            coord = new Vector2(x,y);
            entity = _entity;
        }
    }
}