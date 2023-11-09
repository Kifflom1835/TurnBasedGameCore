using System.Collections.Generic;
using UnityEngine;

namespace Core.FieldAndObjects
{
    public class Field
    {
        public List<Cell> cells = new List<Cell>();
        
        private int[,] matrix = new int[10,10];

        public void Init(/*FieldData*/)
        {
            
        }

        public Cell GetCell(int x, int y)
        {
            return cells.Find(c => (c.coord == new Vector2(x, y)));
        }
    }
}