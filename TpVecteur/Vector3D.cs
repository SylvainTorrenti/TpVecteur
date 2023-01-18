using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpVecteur
{
    internal class Vector3D : Vector2D
    {
        #region Attribute
        private int _rating;
        #endregion
        #region Get & Set Rating
        public int Rating { get => _rating; set => _rating = value; }
        #endregion
        #region Constructor
        public Vector3D()
        {
            NbVector += 1;
        }
        public Vector3D(int abscissa, int ordered, int rating) : base(abscissa, ordered)
        {
            Rating = rating;
            NbVector += 1;
        }
        public Vector3D(Vector3D vector3D)
        {
            Abscissa = vector3D.Abscissa;
            Ordered = vector3D.Ordered;
            Rating = vector3D.Rating;
            NbVector += 1;
        }
        #endregion
        #region Method
        public string ToString()
        {
            return $"X = {Abscissa}  Y = {Ordered}  Z={Rating}";
        }
        public double Norme()
        {
            return Math.Sqrt(Math.Pow(0 - Abscissa, 2) + Math.Pow(0 - Ordered, 2) + Math.Pow(0 - Rating, 2));
        }
        public bool Equals2D(Vector3D vector3D1, Vector3D vector3D2)
        {
            if ((vector3D1.Abscissa == vector3D2.Abscissa) && (vector3D1.Ordered == vector3D2.Ordered))
            {
                Console.WriteLine("Les deux vecteur sont identique");
                return true;
            }
            else
            {
                Console.WriteLine("Les deux vecteur ne sont pas identiques");
                return false;
            }
        } 
        #endregion
    }
}
