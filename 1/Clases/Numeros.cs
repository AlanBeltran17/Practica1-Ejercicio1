using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Clases
{
    class Numeros
    {
        public int numero { get; set; }
        
        public void PedirNumero()
        {
            bool esNum = false;
            while (!esNum)
            {
                Console.Write("Ïngrese un numero ENTERO:  ");
                string num = Console.ReadLine();
                try
                {
                    numero = int.Parse(num);
                    esNum = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("NO ES UN NUMERO ENTERO");
                }
            }
        }

        public void ConvertirALiteral()
        {

            if (numero > 999999999 || numero < 0)
            {
                Console.WriteLine("Este programa SOLO ACEPTA numeros en un rango de ");
                Console.WriteLine("         ( 0 <= N <= 999999999 )");
            }
            else {
                int[] numerales = new int[9];   /// [0] = unidad, [1] = decena, [2] = centena, etc.

                //while para guardar cada digito en el vector de numerales
                int i = 0;
                while (numero > 0)
                {
                    numerales[i] = numero % 10;
                    numero /= 10;
                    i++;
                }
                Literales(numerales);
            }
        }

        public void Literales(int [] numerales)
        {
            Console.Write("El numero en LITERAL es:  ");
            //literales para CENTENA de MILLON
            switch (numerales[8])
            {
                case 1: Console.Write(numerales[7]==0 && numerales[6]==0 ?"cien millones ":"ciento "); break;
                case 2: Console.Write(numerales[7] == 0 && numerales[6] == 0 ? "doscientos millones ":"doscientos "); break;
                case 3: Console.Write(numerales[7] == 0 && numerales[6] == 0 ? "trescientos millones " : "trescientos "); break;
                case 4: Console.Write(numerales[7] == 0 && numerales[6] == 0 ? "cuatrocientos millones " : "cuatrocientos "); break;
                case 5: Console.Write(numerales[7] == 0 && numerales[6] == 0 ? "quinientos millones " : "quinientoscientos "); break;
                case 6: Console.Write(numerales[7] == 0 && numerales[6] == 0 ? "seiscientos millones " : "seiscientos "); break;
                case 7: Console.Write(numerales[7] == 0 && numerales[6] == 0 ? "setecientos millones " : "setecientos "); break;
                case 8: Console.Write(numerales[7] == 0 && numerales[6] == 0 ? "ochocientos millones " : "ochocientos "); break;
                case 9: Console.Write(numerales[7] == 0 && numerales[6] == 0 ? "novecientos millones " : "novecientos "); break;
            }

            //literales para DECENA de MILLON
            switch (numerales[7])
            {
                case 1: Console.Write(numerales[6]==0?"diez millones " : numerales[6]>5?"dieci":"");
                    switch (numerales[6])
                    {
                        case 1: Console.Write("once millones "); break;
                        case 2: Console.Write("donce millones "); break;
                        case 3: Console.Write("trece millones "); break;
                        case 4: Console.Write("catorce millones "); break;
                        case 5: Console.Write("quince millones "); break;
                    }
                    break;
                case 2: Console.Write(numerales[6] == 0 ? "veinte millones " : "veinti"); break;
                case 3: Console.Write(numerales[6] == 0 ? "treinta millones ." : "treinta y "); break;
                case 4: Console.Write(numerales[6] == 0 ? "cuarenta millones " : "cuarenta y "); break;
                case 5: Console.Write(numerales[6] == 0 ? "cincuenta millones " : "cincuenta y "); break;
                case 6: Console.Write(numerales[6] == 0 ? "sesenta millones " : "sesenta y "); break;
                case 7: Console.Write(numerales[6] == 0 ? "setenta millones " : "stenta y "); break;
                case 8: Console.Write(numerales[6] == 0 ? "ochenta millones " : "ochenta y "); break;
                case 9: Console.Write(numerales[6] == 0 ? "noventa millones " : "noventa y "); break;
            }

            //literales para UNIDAD de MILLON
            switch (numerales[6])
            {
                case 1: if (numerales[5] == 0 && numerales[4] == 0 &&
                            numerales[3] == 0 && numerales[2] == 0 &&
                            numerales[1] == 0 && numerales[0] == 0)
                        Console.Write("Un millon.");
                    else Console.Write("un millones ");
                        break;
                case 2: Console.Write(numerales[7] == 1 ? "" : "dos millones "); break;
                case 3: Console.Write(numerales[7] == 1 ? "" : "tres millones "); break;
                case 4: Console.Write(numerales[7] == 1 ? "" : "cuatro millones "); break;
                case 5: Console.Write(numerales[7] == 1 ? "" : "cinco millones "); break;
                case 6: Console.Write("seis millones "); break;
                case 7: Console.Write("siete millones "); break;
                case 8: Console.Write("ocho millones "); break;
                case 9: Console.Write("nueve millones "); break;
            }

            //literales para CENTENA de MILLAR
            switch (numerales[5])
            {
                case 1: Console.Write(numerales[4] == 0 && numerales[3] == 0 ? "cien mil " : "ciento "); break;
                case 2: Console.Write(numerales[4] == 0 && numerales[3] == 0 ? "doscientos mil " : "doscientos "); break;
                case 3: Console.Write(numerales[4] == 0 && numerales[3] == 0 ? "trescientos mil " : "trescientos "); break;
                case 4: Console.Write(numerales[4] == 0 && numerales[3] == 0 ? "cuatrocientos mil " : "cuatrocientos "); break;
                case 5: Console.Write(numerales[4] == 0 && numerales[3] == 0 ? "quinientos mil " : "quinientos "); break;
                case 6: Console.Write(numerales[4] == 0 && numerales[3] == 0 ? "seiscientos mil " : "seiscientos "); break;
                case 7: Console.Write(numerales[4] == 0 && numerales[3] == 0 ? "setecientos mil " : "setecientos "); break;
                case 8: Console.Write(numerales[4] == 0 && numerales[3] == 0 ? "ochocientos mil " : "ochocientos "); break;
                case 9: Console.Write(numerales[4] == 0 && numerales[3] == 0 ? "novecientos mil " : "novecientos "); break;
            }

            //literales para DECENA de MILLAR
            switch (numerales[4])
            {
                case 1:
                    Console.Write(numerales[3] == 0 ? "diez mil " : numerales[3] > 5 ? "dieci" : "");
                    switch (numerales[3])
                    {
                        case 1: Console.Write("once mil "); break;
                        case 2: Console.Write("donce mil "); break;
                        case 3: Console.Write("trece mil "); break;
                        case 4: Console.Write("catorce mil "); break;
                        case 5: Console.Write("quince mil "); break;
                    }
                    break;
                case 2: Console.Write(numerales[3] == 0 ? "veinte mil " : "veinti"); break;
                case 3: Console.Write(numerales[3] == 0 ? "treinta mil ." : "treinta y "); break;
                case 4: Console.Write(numerales[3] == 0 ? "cuarenta mil " : "cuarenta y "); break;
                case 5: Console.Write(numerales[3] == 0 ? "cincuenta mil " : "cincuenta y "); break;
                case 6: Console.Write(numerales[3] == 0 ? "sesenta mil " : "sesenta y "); break;
                case 7: Console.Write(numerales[3] == 0 ? "setenta mil " : "stenta y "); break;
                case 8: Console.Write(numerales[3] == 0 ? "ochenta mil " : "ochenta y "); break;
                case 9: Console.Write(numerales[3] == 0 ? "noventa mil " : "noventa y "); break;
            }

            //literales para UNIDAD de MILLAR
            switch (numerales[3])
            {
                case 1:
                    if (numerales[2] == 0 && numerales[1] == 0 && numerales[0] == 0)
                        Console.Write("Mil.");
                    else Console.Write(numerales[4] == 1 ? "" : "mil ");
                    break;
                case 2: Console.Write(numerales[4] == 1 ? "" : "dos mil "); break;
                case 3: Console.Write(numerales[4] == 1 ? "" : "tres mil "); break;
                case 4: Console.Write(numerales[4] == 1 ? "" : "cuatro mil "); break;
                case 5: Console.Write(numerales[4] == 1 ? "" : "cinco mil "); break;
                case 6: Console.Write("seis mil "); break;
                case 7: Console.Write("siete mil "); break;
                case 8: Console.Write("ocho mil "); break;
                case 9: Console.Write("nueve mil "); break;
            }

            //literales para CENTENAS
            switch (numerales[2])
            {
                case 1: Console.Write(numerales[1] == 0 && numerales[0] == 0 ? "Cien." : "ciento "); break;
                case 2: Console.Write("doscientos "); break;
                case 3: Console.Write("trescientos "); break;
                case 4: Console.Write("cuatrocientos "); break;
                case 5: Console.Write("quinientos "); break;
                case 6: Console.Write("seiscientos "); break;
                case 7: Console.Write("setecientos "); break;
                case 8: Console.Write("ochocientos "); break;
                case 9: Console.Write("novecienttos "); break;
            }

            //literales para DECENAS
            switch (numerales[1])
            {
                case 1:
                    Console.Write(numerales[0] == 0 ? "Diez." : numerales[0] > 5 ? "dieci" : "");
                    switch (numerales[0])
                    {
                        case 1: Console.Write("once."); break;
                        case 2: Console.Write("doce."); break;
                        case 3: Console.Write("trece."); break;
                        case 4: Console.Write("catorce."); break;
                        case 5: Console.Write("quince."); break;
                    }
                    break;
                case 2: Console.Write("veinti"); break;
                case 3: Console.Write("treinta y "); break;
                case 4: Console.Write("cuarenta y "); break;
                case 5: Console.Write("cincuenta y "); break;
                case 6: Console.Write("sesenta y "); break;
                case 7: Console.Write("setenta y "); break;
                case 8: Console.Write("ochenta y "); break;
                case 9: Console.Write("noventa y "); break;
            }

            //literales para UNIDADES
            switch (numerales[0]) 
            {
                case 0:
                    if (numerales[1] == 0 && numerales[2] == 0 &&
                        numerales[3] == 0 && numerales[4] == 0 &&
                        numerales[5] == 0 && numerales[6] == 0 &&
                        numerales[7] == 0 && numerales[8] == 0)
                        Console.Write("Cero.");
                    else switch (numerales[1])
                        {
                            case 2: Console.Write("Veinte."); break;
                            case 3: Console.Write("Treinta."); break;
                            case 4: Console.Write("Cuarenta."); break;
                            case 5: Console.Write("Cincuenta."); break;
                            case 6: Console.Write("Sesenta."); break;
                            case 7: Console.Write("Setenta."); break;
                            case 8: Console.Write("Ochenta."); break;
                            case 9: Console.Write("Noventa."); break;
                        }
                    break;
                case 1: Console.Write(numerales[1] == 1 ? "" :"uno."); break;
                case 2: Console.Write(numerales[1] == 1 ? "" : "dos."); break;
                case 3: Console.Write(numerales[1] == 1 ? "" : "tres."); break;
                case 4: Console.Write(numerales[1] == 1 ? "" : "cuatro."); break;
                case 5: Console.Write(numerales[1] == 1 ? "" : "cinco."); break;
                case 6: Console.Write("seis."); break;
                case 7: Console.Write("siete."); break;
                case 8: Console.Write("ocho."); break;
                case 9: Console.Write("nueve."); break;
            }

        }

    }
}
