using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Escriba el tamaño de espacio en la memoria");
                    byte numEspacios = byte.Parse(Console.ReadLine());
                    byte[] array = new byte[numEspacios];
                    Console.WriteLine("Escriba la cantidad de memoria");
                    for (int i = 0; i < numEspacios; i++)
                    {
                        array[i] = byte.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Escriba el byte que desea buscar");
                    byte x = byte.Parse(Console.ReadLine());
                    BitArray bits = new BitArray(array);
                    linearSearch(x, array, bits);
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("El tamaño del byte solo puede ser hasta 255\n");

                }
            }
        }

        static byte linearSearch(byte x, byte[] array,BitArray bits)
        {
            int contador = 0;
            foreach (bool bit in bits)
            {
                contador++;
                if (contador == 8)
                {
                    Console.WriteLine("\n");
                    contador = 0;
                }
                else
                {
                    Console.Write(Convert.ToByte(bit));
                }
            }
            for (byte i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    Console.WriteLine("El byte {0} se encuentra en la posicion: {1}",x , i);
                    return i;
                }
            }
            
            Console.WriteLine("El byte no se encuentra");
            return 0;
        }
    }
}
