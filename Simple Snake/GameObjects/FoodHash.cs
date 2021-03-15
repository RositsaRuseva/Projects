using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class FoodHash : Food
    {
        private const char Symbol = '#';
        private const int Points = 3;
        public FoodHash(Wall wall)
            : base(wall, Symbol, Points)
        {
        }
    }
}
