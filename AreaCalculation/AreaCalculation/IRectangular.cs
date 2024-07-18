using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public interface IRectangular
    {
        /// <summary>
        /// Проверяет, что фигура (например, треугольник/трапеция) является прямоугольной
        /// </summary>
        /// <returns><c>true</c>, если фигура прямоугольная, в противном случае - <c>false</c></returns>
        bool IsRectangular();
    }
}
