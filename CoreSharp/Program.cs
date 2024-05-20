using System;
using System.Runtime.ConstrainedExecution;

namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ConsoleReadline
            //decimal resultTotal = 0;

            //while (true)
            //{
            //    Console.WriteLine("=============================================================================================");
            //    Console.WriteLine("=============================================================================================");
            //    int price;
            //    string category;
            //    string brandName;
            //    string operatorName;
            //    int size;
            //    string color;


            //    #region Operator name validation

            //    while (true)
            //    {
            //        Console.Write("Operator's name : ");
            //        operatorName = Console.ReadLine();

            //        if (operatorName.Length >= 3 && operatorName.Length <= 15)
            //            break;
            //        else
            //            Console.WriteLine("Ad duzgun daxil edilmeyib");
            //    }

            //    #endregion

            //    #region Size validation

            //    while (true)
            //    {
            //        Console.Write("Size : ");
            //        size = int.Parse(Console.ReadLine());

            //        if (size >= 30 && size <= 50)
            //            break;
            //        else
            //            Console.WriteLine("Size duzgun daxil edilmeyib");
            //    }

            //    #endregion

            //    #region Color validation

            //    while (true)
            //    {
            //        Console.Write("Color : ");
            //        color = Console.ReadLine();

            //        if (color == "Red" || color == "Black" || color == "Blue")
            //            break;
            //        else
            //            Console.WriteLine("Color duzgun daxil edilmeyib");
            //    }

            //    #endregion

            //    while (true)
            //    {
            //        Console.Write("Brand's name : ");
            //        brandName = Console.ReadLine();

            //        if (brandName == "Nike" || brandName == "Zara")
            //            break;
            //        else
            //            Console.WriteLine("Brand name duzgun daxil edilmeyib");
            //    }

            //    while (true)
            //    {
            //        Console.Write("Category's name : ");
            //        category = Console.ReadLine();

            //        if (category == "Sport" || category == "Classic")
            //            break;
            //        else
            //            Console.WriteLine("Category name duzgun daxil edilmeyib");
            //    }

            //    Console.WriteLine("Hansi qiymet araliginda Ayyagabi isdiyirsiz?");
            //    Console.Write("Price : ");
            //    price = int.Parse(Console.ReadLine());

            //    if ( price <= 200)
            //    {
            //        Console.WriteLine("Ayyagabini Aliram");
            //    }
            //    else if(price>=200)
            //    {
            //        Console.WriteLine("Ayyagabini Almiram");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Isdemedim");
            //    }

            //    Console.Write("Count : ");
            //    int count = int.Parse(Console.ReadLine());

            //    decimal individualTotal = count * price;
            //    resultTotal += individualTotal;

            //    Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {individualTotal}");
            //    Console.WriteLine("=============================================================================================");
            //    Console.WriteLine("=============================================================================================");

            //    Console.WriteLine("Yeni ayaqqabi əlavə olunsunmu? (Yes, No) (Y, N) ");
            //    string loopTerminationResult = Console.ReadLine();

            //    if (loopTerminationResult == "No" || loopTerminationResult == "N")
            //    {
            //        break; // Döngüyü sonlandır
            //    }
            //}

            //Console.WriteLine("Result Total : " + resultTotal);
            #endregion



            #region Array
            //decimal resultTotal = 0;

            //int numberOfShoes = 2;

            ////database
            //string[] operatorNames = new string[numberOfShoes];
            //int[] sizes = new int[numberOfShoes];
            //string[] colors = new string[numberOfShoes];
            //string[] brandNames = new string[numberOfShoes];
            //string[] categories = new string[numberOfShoes];
            //decimal[] prices = new decimal[numberOfShoes];
            //int[] counts = new int[numberOfShoes];


            //int idx = 0;

            //while (idx < numberOfShoes)
            //{
            //    Console.WriteLine("=============================================================================================");
            //    Console.WriteLine("=============================================================================================");
            //    string operatorName;
            //    int size;
            //    string color;

            //    #region Operator name validaiton

            //    while (true)
            //    {
            //        Console.Write("Operator's name : ");
            //        operatorName = Console.ReadLine();

            //        if (operatorName.Length >= 3 && operatorName.Length <= 15)
            //        {
            //            operatorNames[idx] = operatorName;
            //            break;
            //        }
            //        else
            //            Console.WriteLine("Size dugun daxil edilmeyib");
            //    }

            //    #endregion

            //    #region Size validation

            //    while (true)
            //    {
            //        Console.Write("Size : ");
            //        size = int.Parse(Console.ReadLine());

            //        if (size >= 30 && size <= 50)
            //        {
            //            sizes[idx] = size;
            //            break;
            //        }
            //        else
            //            Console.WriteLine("Size dugun daxil edilmeyib");
            //    }

            //    #endregion

            //    #region Color validation

            //    while (true)
            //    {
            //        Console.Write("Color : ");
            //        color = Console.ReadLine();

            //        if (color == "Red" || color == "Black" || color == "Blue")
            //        {
            //            colors[idx] = color;
            //            break;
            //        }
            //        else
            //            Console.WriteLine("Color dugun daxil edilmeyib");
            //    }

            //    #endregion

            //    Console.Write("Brand name : ");
            //    string brandName = Console.ReadLine();
            //    brandNames[idx] = brandName;

            //    Console.Write("Category : ");
            //    string category = Console.ReadLine(); //Short cut to replace all : Ctrl + RR
            //    categories[idx] = category;

            //    Console.Write("Price : ");
            //    decimal price = decimal.Parse(Console.ReadLine()); //Short cut to replace all : Ctrl + RR
            //    prices[idx] = price;

            //    Console.Write("Count : ");
            //    int count = int.Parse(Console.ReadLine()); //Short cut to replace all : Ctrl + RR
            //    counts[idx] = count;

            //    decimal individualTotal = count * price;
            //    resultTotal += individualTotal;

            //    Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {individualTotal}");
            //    Console.WriteLine("=============================================================================================");
            //    Console.WriteLine("=============================================================================================");

            //    Console.WriteLine("Yeni ayaqqabi elave olunsumu? (Yes, No) (Y, N) ");
            //    string loopTerminationResult = Console.ReadLine();

            //    if (loopTerminationResult == "No" || loopTerminationResult == "N")
            //    {
            //        //break based loop control
            //        break;
            //    }

            //    idx++;
            //}


            //Console.WriteLine("Result Total : " + resultTotal);

            #endregion

            #region HomeTask

            //int sum = 0;
            //int[] arr = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine("Array daxilindeki elementlerin cemi: " + sum);

            //Console.WriteLine("<><><><>===============<><><><>");

            //int[] arr2 = { 1, 2, 3, 4, 5 };
            //for (int i = arr2.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            //Console.WriteLine("<><><><>===============<><><><>");

            //int[] arr3 = { 1, 2, 3, 4, 5 };
            //int sum3 = 0;
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    if (arr3[i] % 2 == 0)
            //    {
            //        sum3 += arr3[i];
            //    }

            //}
            //Console.WriteLine("Array daxilinde cut ededlerin cemi:" + sum3);

            //Console.WriteLine("<><><><>===============<><><><>");

            //int[] arr4 = { 1, 2, 3, 4, 5, 6, 7 };
            //int sum4 = 0;
            //for (int i = 0; i < arr4.Length; i++)
            //{
            //    if (arr4[i] % 2 == 1)
            //    {
            //        sum4 += arr4[i];
            //    }
            //}
            //Console.WriteLine("Array daxilinde tek ededlerin cemi:" + sum4);


            //Console.WriteLine("<><><><>===============<><><><>");

            //int[] arr5 = { 5, 7, 9, 10, 12, 20 };
            //int sum5 = 0;
            //for (int i = 0; i < arr5.Length; i++)
            //{
            //    if (arr5[i] % 5 == 0)
            //    {
            //        sum5 += arr5[i];
            //    }
            //}
            //Console.WriteLine("Array daxilinde 5e bolunen ededlerin cemi:" + sum5);

            //Console.WriteLine("<><><><>===============<><><><>");

            //int[] arr6 = { 1, 2, 3, 4, 5, 6, 7 };
            //int max = arr6[0];
            //for (int i = 1; i < arr6.Length; i++)
            //{
            //    if (arr6[i] > max)
            //    {
            //        max = arr6[i];
            //    }
            //}
            //Console.WriteLine("Array Max: " + max);



            //int[] arr7 = { 1, 2, 3, 4, 5, 6, 7 };
            //int min = arr7[0];
            //for (int i = 1; i < arr7.Length; i++)
            //{
            //    if (arr7[i] < min)
            //    {
            //        min = arr7[i];
            //    }
            //}
            //Console.WriteLine("Array Min: " + min);

            //Console.WriteLine("<><><><>===============<><><><>");

            //int[] arr8 = { 1, 2, 3, 4, 5, 6, 7 };
            //int max2 = arr8.Max();
            //Console.WriteLine("Max:" + max2);
            //int min2 = arr8.Min();
            //Console.WriteLine("Min:" + min2);

            //Console.WriteLine("<><><><>===============<><><><>");


            //int[] arr9 = { 1, 2, 3, 4, 5, 6, 7 };
            //int sum6 = 0;
            //for (int i = 0; i < arr9.Length; i++)
            //{
            //    sum6 += arr9[i];
            //}
            //Console.WriteLine("Arrayin average i :" + sum6/arr9.Length);

            //Console.WriteLine("<><><><>===============<><><><>");

            //int[] array1 = { 1, 2, 3, 4, 5 };
            //int[] array2 = { 4, 5, 6, 7, 8 };




            #endregion



            #region TaskUSD und AZN 
            string[] valute = { "USD", "AZN", };
            double[] convert = { 1.70, 0.59};

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(new string('-', 40));
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Valyuta Secin: (USD, AZN)?");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(new string('-', 40));
                Console.ResetColor();
                string inputValuta = Console.ReadLine().ToUpper();
                int index = 0;
                bool found = false;

                while (index < valute.Length)
                {
                    if (inputValuta == valute[index])
                    {
                        found = true;
                        break;
                    }
                    index++;
                }

                if (!found)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bele Valyuta yoxdu yeniden cehd edin.");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(new string('-', 40));
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Hansı emeliyyatı etmek isteyirsiniz?");
                        Console.WriteLine($" 1) 1 {valute[index]} = {convert[index]} AZN ");
                        Console.WriteLine($" 2) 1 AZN = {1 / convert[index]:0.####} {valute[index]} ");
                        Console.WriteLine("Seçiminizi daxil edin (1, 2 veya 'exit' yazın):");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(new string('-', 40));
                        Console.ResetColor();
                        string choose = Console.ReadLine();

                        if (choose == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"Ne qeder {valute[index]} mebleğini daxil etmek isteyirsiniz?");
                            Console.ResetColor();
                            if (double.TryParse(Console.ReadLine(), out double price))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Valyuta emeliyyati edilmiş mebleğ: {price * convert[index]:0.##} Dollar");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Yanlış mebleğ daxil edilib. Yeniden cehd edin.");
                                Console.ResetColor();
                            }
                        }
                        else if (choose == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Mebleği daxil edin:");
                            Console.ResetColor();
                            if (double.TryParse(Console.ReadLine(), out double price))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Konvertasiya edilmiş mebleğ: {price / convert[index]:0.####} {valute[index]}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Yanlış mebleğ daxil edilib. Yeniden cehd edin.");
                                Console.ResetColor();
                            }
                        }
                        else if (choose.ToLower() == "exit")
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Yeniden cehd edin.");
                            Console.ResetColor();
                        }
                    }
                }
            }

            #endregion
        }
    }
}
