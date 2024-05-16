namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultTotal = 0;

            while (true)
            {
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");
                int price;
                string category;
                string brandName;
                string operatorName;
                int size;
                string color;


                #region Operator name validation

                while (true)
                {
                    Console.Write("Operator's name : ");
                    operatorName = Console.ReadLine();

                    if (operatorName.Length >= 3 && operatorName.Length <= 15)
                        break;
                    else
                        Console.WriteLine("Ad duzgun daxil edilmeyib");
                }

                #endregion

                #region Size validation

                while (true)
                {
                    Console.Write("Size : ");
                    size = int.Parse(Console.ReadLine());

                    if (size >= 30 && size <= 50)
                        break;
                    else
                        Console.WriteLine("Size duzgun daxil edilmeyib");
                }

                #endregion

                #region Color validation

                while (true)
                {
                    Console.Write("Color : ");
                    color = Console.ReadLine();

                    if (color == "Red" || color == "Black" || color == "Blue")
                        break;
                    else
                        Console.WriteLine("Color duzgun daxil edilmeyib");
                }

                #endregion

                while (true)
                {
                    Console.Write("Brand's name : ");
                    brandName = Console.ReadLine();

                    if (brandName == "Nike" || brandName == "Zara")
                        break;
                    else
                        Console.WriteLine("Brand name duzgun daxil edilmeyib");
                }

                while (true)
                {
                    Console.Write("Category's name : ");
                    category = Console.ReadLine();

                    if (category == "Sport" || category == "Classic")
                        break;
                    else
                        Console.WriteLine("Category name duzgun daxil edilmeyib");
                }

                Console.WriteLine("Hansi qiymet araliginda Ayyagabi isdiyirsiz?");
                Console.Write("Price : ");
                price = int.Parse(Console.ReadLine());

                if ( price <= 200)
                {
                    Console.WriteLine("Ayyagabini Aliram");
                }
                else if(price>=200)
                {
                    Console.WriteLine("Ayyagabini Almiram");
                    break;
                }
                else
                {
                    Console.WriteLine("Isdemedim");
                }

                Console.Write("Count : ");
                int count = int.Parse(Console.ReadLine());

                decimal individualTotal = count * price;
                resultTotal += individualTotal;

                Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {individualTotal}");
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");

                Console.WriteLine("Yeni ayaqqabi əlavə olunsunmu? (Yes, No) (Y, N) ");
                string loopTerminationResult = Console.ReadLine();

                if (loopTerminationResult == "No" || loopTerminationResult == "N")
                {
                    break; // Döngüyü sonlandır
                }
            }

            Console.WriteLine("Result Total : " + resultTotal);
        }
    }
}
