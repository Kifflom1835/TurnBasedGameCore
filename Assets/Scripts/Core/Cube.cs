using System;
using System.Collections.Generic;

namespace Core
{
    public class Cube
    {
        private CubeLevel levelIndex;
        private CubeLevel minLevelIndex = CubeLevel.D4;
        private CubeLevel maxLevelIndex = CubeLevel.D20;

        public CubeLevel LevelIndex
        {
            get => levelIndex;
            set
            {
                CubeLevel cl;
                if (value <= minLevelIndex)
                {
                    cl = minLevelIndex;
                }
                else
                {
                    cl = value;
                }

                if (value >= maxLevelIndex)
                {
                    cl = maxLevelIndex;
                }
                else
                {
                    cl = value;
                }
                levelIndex = cl;
            }
        }

        private List<int> values = new List<int>(){0,4,6,8,10,12,20,100};
        private bool isExplosive = true;

        public int Calculate()
        {
            if (levelIndex == CubeLevel.D0)
            {
                return 0;
            }
            
            int valueFromIndex = GetValueFromIndex((int) levelIndex);
            int value = UnityEngine.Random.Range(1, valueFromIndex);

            if (value == 1)//CritFale
            {
                //TODO:Add Succes effect
                return value;
            }
            
            if (value == valueFromIndex && isExplosive)//CritSucces
            {
                value += Explose((int)levelIndex);
            }
            
            return 0;
        }

        int Explose(int currentIndex)
        {
            int newIndex = currentIndex + 1;

            if (newIndex > (int) CubeLevel.D100)
            {
                return 0;
            }
            
            int valueFromIndex = GetValueFromIndex(newIndex);
            int value = UnityEngine.Random.Range(1, valueFromIndex);

            if (value == valueFromIndex && newIndex <= (int) CubeLevel.D100)
            {
               value += Explose(newIndex);
            }

            return value;

        }
        

        int GetValueFromIndex(int index)
        {
            if (index <= values.Count-1)
            {
                return values[index];
            }
            else
            {
                return values[values.Count - 1];
            }
        }
    }

    public enum CubeLevel
    {
        D0,
        D4,
        D6,
        D8,
        D10,
        D12,
        D20,
        D100
        
    }
}