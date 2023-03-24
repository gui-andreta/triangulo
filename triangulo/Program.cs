using ClasseTriangulo;

internal class Program {
    private static void Main(string[] args) {
        /* Crie uma abstração triangulo
         * emparelhe suas propriedades para
         que só possam ser lidas e não ateradas
        
         crie um metodo que retorne
        a area do triangulo
        
         dica -> um triangulo não existe sem os 3 lados.
        
         Preencha os lados do contrutor.*/

        double[] lado = new double[3];

        for(int i = 0; i < 3; i++) {
            Console.WriteLine("Digite um lado do triangulo");
            lado[i] = double.Parse(Console.ReadLine());

            if (lado[i] == 0) {
                i = 1 - 1;
                Console.WriteLine("Numero invalido, digite novamente: ");
                lado[i] = double.Parse(Console.ReadLine());
            }
        }

        Triangulo tri = new Triangulo(lado[0], lado[1], lado[2]);
        double area = tri.AreaT();

        Console.WriteLine("Os lados do Triangulo são: " + tri);
        Console.WriteLine("\nA area do seu triangulo é: " + area);

    }
}