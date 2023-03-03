// Bucla foreach 

// Sintaxa:

//foreach (tip_de_date variabila    in    colectie )
//{
//    instructiune;
//}




//int[] numere = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//string[] nume = { " John ", " Alice ", " Wiliam " };

//foreach(int i in numere )
//{
//    Console.WriteLine(i);
//}

//foreach (string persoana in nume)
//{
//    Console.WriteLine(persoana);
//}

//Console.Read();


using System;

namespace laborator3
{


    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorIntregi = new int[100]; // instatiaza mai precis avem liber de 100 de elemente 


            int counter = 0; // stocam elementul pe care il dorim sa l avem in vector 


            int number = int.Parse(Console.ReadLine());  // numere introduse in vector 


            while ((number = int.Parse(Console.ReadLine())) > 0) // am tastat un numar ce respecta conditia si intra in bucla
            {


                vectorIntregi[counter] = number;             // vectorul intregi va lua valoarea counterului  

                counter++; // incrementam cu o pozitie 



            }

            for (int i = 0; i < counter; i++)
            {



                Console.WriteLine(vectorIntregi[i]);




            }

           
        }


    }


}






























