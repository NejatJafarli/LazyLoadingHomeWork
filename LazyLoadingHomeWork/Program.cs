using LazyLoadingHomeWork.Context;
using LazyLoadingHomeWork.Models;
using System;
using System.Linq;

namespace LazyLoadingHomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var temp = new MyDbContext())
            {
                var temp2=temp.Categories.FirstOrDefault();

                foreach (var item in temp2.Products.ToList())
                    Console.WriteLine(item.Name);
                //burda eager loading olsaydi biz categories icerisindeki Productlara cata bilmezdik
                //ama burda lazy loading dir deye biz productlara cata bilerik
            }
        }
    }
}
