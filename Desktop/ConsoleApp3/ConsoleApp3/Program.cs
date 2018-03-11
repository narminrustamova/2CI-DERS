using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {


            // array 1ci uslub 

            //string[] adlar = new string[] { "elnur", "atilla", "nicat" };
            //int[] yaslar = new int[] { 26, 15, 29 };
            //bool[] medenistatus = new bool[] { true, false, true};
            //Console.WriteLine(adlar.Length);
            //for (int i=0; i<adlar.Length; i++)
            //{
            //    Console.WriteLine(adlar[i] + "-" + yaslar[i] + "-" + medenistatus[i]);
            //}


            //array 2ci usul
            //string[] ages = new string[5];
            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine(i +"-innci adamin adini daxil edin");
            //    ages[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine(ages[i]);
            //}



            //list  remove
            //    List<string> list = new List<string>() { "Aslan", "mehemmed", "sakit", "sekine", "nermin", "turkan", "nigar" };
            //    void goster()
            //    {


            //        for (int i = 0; i < list.Count; i++)
            //        {
            //            Console.WriteLine((i + 1) + "-" + list[i]);
            //        }
            //        sil();
            //    }

            //    void sil()
            //    {
            //        Console.Write("silmek istediyiniz  elementi yazin?");
            //        var index = Convert.ToInt32(Console.ReadLine());
            //        list.Remove(list[index - 1]);
            //        goster();
            //    }

            //    goster();







            ////list  deyistir
            //    List<string> list = new List<string>() { "Aslan", "mehemmed", "sakit", "sekine", "nermin", "turkan", "nigar" };
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine((i + 1) + "-" + list[i]);
            //}
            //     Console.Write("deyisdirmek istediyin adi yaz ");
            //    var index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yeni deyer ne olsun qadam");
            //    var yenideyer = Console.ReadLine();
            //    list[index] = yenideyer;


            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine((i + 1) + "-" + list[i]);
            //}








            // Programin teyinati veya tesviri
            List<string> db = new List<string>();


            // Istifadeci ekrani
            void Instructions()
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1.Melumat elave et");
                Console.WriteLine("2.Melumatlari goster");
                Console.WriteLine("3.Melumatlari yenile");
                Console.WriteLine("4.Melumati sil");
                Console.WriteLine("-----------------------------------");
                Console.Write("Icra etmek istediyiniz emrin nomresini daxil edin:");
                var emrNomresi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------");


                switch (emrNomresi)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        Read();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Delete();
                        break;
                    default:
                        Console.WriteLine("Daxil etdiyiniz emr movcud deyil, sizi ana ekrana yonlendirirem");
                        Instructions();
                        break;

                }

            }


            // Melumat elave etme prosesi

            void Create()
            {
                Console.Write("Elave etmek istediyiniz melumati daxil edin:");
                var createdData = Console.ReadLine();
                db.Add(createdData);
                Instructions();
            }

            // Melumat oxuma prosesi

            void Read()
            {
                var count = 0;
                foreach (var element in db)
                {
                    count++;
                    Console.WriteLine(count + "-" + element);

                }
                Instructions();
            }

            // Melumat yenileme prosesi

            void Update()
            {
                Console.Write("Yenilemek istediyiniz melumatin sira nomresini daxil edin: ");
                var selectedDataRow = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yeni deyeri daxil edin: ");
                var updatedData = Console.ReadLine();
                db[selectedDataRow - 1] = updatedData;
                Instructions();
            }

            // Melumat silme prosesi

            void Delete()
            {
                Console.Write("Silmek istediyiniz melumatin sira nomresini daxil edin: ");
                var selectedDataRow = Convert.ToInt32(Console.ReadLine());
                db.Remove(db[selectedDataRow - 1]);
                Instructions();
            }

            Instructions();



        }

    }
}
