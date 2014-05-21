using System;
using System.Collections.Generic;
using System.Drawing;

namespace SpriteSheeter.Algorithms
{
    // http://wiki.unity3d.com/index.php?title=MaxRectsBinPack
    // http://clb.demon.fi/files/RectangleBinPack.pdf [pg 18]

    public abstract class BaseAlgorithm<TEnum> where TEnum : struct, IConvertible, IComparable, IFormattable
    {
        public int MaxWidth { get; set; }
        public int MaxHeight { get; set; }
        public bool AllowRotation { get; set; }

        private TEnum _Heuristic;
        public TEnum Heuristic
        {
            get { return _Heuristic; }
            set
            {
                if (!typeof(TEnum).IsEnum)
                {
                    throw new ArgumentException("TEnum must be an enumerated type");
                }
                _Heuristic = value;
            }
        }

        public List<Rectangle> usedRects = new List<Rectangle>();
        public List<Rectangle> freeRects = new List<Rectangle>();

        public abstract void Init(int maxWidth, int maxHeight, bool allowRotation = true);
    }
}
