using Exercicio_MetodosAbstratos.Entities.Enums;

namespace Exercicio_MetodosAbstratos.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
