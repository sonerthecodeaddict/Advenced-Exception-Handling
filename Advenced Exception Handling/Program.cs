using Advenced_Exception_Handling;
using System;
using System.Threading.Tasks;


namespace Exception_Handling
{
    class Program
    {
        public static void Main(string[] args)
        {

            HandleException(() =>
            {
                Find();
            });

        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }

            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Bazı yaygın exceptionlar
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }


        public static void Find()
        {
            List<string> nameList = new List<string>() { "ahmet", "mehmet", "ayşe", "fatma" };

            if (!nameList.Contains("mohammad"))
            {
                throw new RecordNotFoundException(message: "kayıt yok");// özel hata mesajı
            }

            else
            {
                Console.WriteLine("mohammad kaydı mevcut.");
            }
        }
    }
}
