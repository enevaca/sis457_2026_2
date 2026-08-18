using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsola
{
    internal abstract class FiguraGeometrica
    {
        public abstract decimal area();
        public abstract decimal perimetro();
    }

    internal class Cuadrado : FiguraGeometrica
    {
        private readonly decimal lado;
        public Cuadrado(decimal lado) { this.lado = lado; }

        public override decimal area()
        {
            return lado * lado;
        }

        public override decimal perimetro() => lado * 4;
    }

    internal class Rectangulo : FiguraGeometrica
    {
        private readonly decimal base_;
        private readonly decimal altura;

        public Rectangulo(decimal base_, decimal altura)
        {
            this.base_ = base_;
            this.altura = altura;
        }

        public override decimal area() => base_ * altura;

        public override decimal perimetro() => 2 * (base_ + altura);
    }
}
