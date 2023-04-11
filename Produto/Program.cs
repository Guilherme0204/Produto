using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conuole.WriteLine("Informe o produto ");
            string produto = Console.ReadLine();
            Console.WriteLine($"Informe o valor do {produto}" );
            double valProduto = Convert.ToDouble(Console.ReadLine());
            if (valProduto < 20)
            {
                double lucro = valProduto * 145 / 100;
              //lucro = valProduto + lucro;
                Console.WriteLine(lucro);
            } else
            {
                double lucro = valProduto * 0.30;
                lucro = valProduto + lucro;
                Console.WriteLine(lucro);
            }
            Console.ReadKey();
        }
    }
}
