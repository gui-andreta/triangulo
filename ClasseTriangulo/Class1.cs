namespace ClasseTriangulo {
    public class Triangulo {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangulo(double a, double b, double c) { 
            A = a;
            B = b;
            C = c;
        }

        public double AreaT() {
            double area = (B * A) / 2;

            return area;
        }

        public override string ToString() {
            return "\nLado A: " + A + "\nLado B: " + B + "\nLado C: " + C;
        }
    }
}