using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpVecteur
{
    internal class Vector2D
    {
        #region Attribute
        private static int _nbVector = 0;
        private int _abscissa;
        private int _ordered;
        #endregion
        #region Get & Set NbVector
        public static int NbVector { get => _nbVector; set => _nbVector = value; }
        #endregion
        #region Get & Set Abscissa
        public int Abscissa { get => _abscissa; set => _abscissa = value; }
        #endregion
        #region Ordered
        public int Ordered { get => _ordered; set => _ordered = value; }
        #endregion
        #region Constructor
        public Vector2D()
        {
            NbVector += 1;
        }
        public Vector2D(int abscissa, int ordered)
        {
            Abscissa = abscissa;
            Ordered = ordered;
            NbVector += 1;
        }
        public Vector2D(Vector2D vector2D)
        {
            Abscissa = vector2D._abscissa;
            Ordered = vector2D._ordered;
            NbVector += 1;
        }
        #endregion
        #region Method
        public string ToString()
        {
            return $"X = {Abscissa}  Y = {Ordered}";
        }
        public double Norme()
        {
            return Math.Sqrt(Math.Pow(0 - Abscissa, 2) + Math.Pow(0 - Ordered, 2));
        }
        public bool Equals2D(Vector2D vector2D1, Vector2D vector2D2)
        {
            if ((vector2D1.Abscissa == vector2D2.Abscissa) && (vector2D1.Ordered == vector2D2.Ordered))
            {
                Console.WriteLine("Les deux vecteur sont identique");
                return true;
            }
            else
            {
                Console.WriteLine("Les deux vecteur ne sont pas identique");
                return false;
            }
        }
        #endregion
    }
}
