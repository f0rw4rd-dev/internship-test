using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    // Интерфейс написан для требования "Легкость добавления других фигур"
    // Прямоугольными могут быть не только треугольники, но и трапеции, и ряд пространственных фигур
    public interface IRectangular
    {
        bool IsRectangular();
    }
}
