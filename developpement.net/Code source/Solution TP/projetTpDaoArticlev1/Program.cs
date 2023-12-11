using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSelectByReference();
            //TestInsert();
            //TestUpdate();
            //TestDelete();
            //selectByPrixMinMax();
            //SelectByMarqueLike();
            SelectByPrixBetween();
        }
        static void SelectByPrixBetween()
        {
            Console.WriteLine(DaoArticle.SelectByPrixBetween(2, 11));
        }
        static void SelectByMarqueLike()
        {
            Console.WriteLine(DaoArticle.SelectByMarqueLike("s"));
        }
        static void selectByPrixMinMax()
        {
            Console.WriteLine(DaoArticle.selectByPrixMinMax(150, 699));
        }
        static void TestDelete()
        {

            new DaoArticle().Delete(10);

        }
        static void TestUpdate()
        {

            DaoArticle dao = new DaoArticle();
            // Personne p = new Personne(10, "orange", 800);
            Article a = new Article(10, "ORANGE", 1000);
            dao.Update(a);

        }
        static void TestInsert()
        {

            DaoArticle dao = new DaoArticle();
            Article a = new Article(10, "orange", 800);
            dao.Insert(a);




        }
        static void TestSelectByReference()
        {
            int reference = 10;
            DaoArticle dao = new DaoArticle();
            Article a = dao.SelectByReference(reference);
            if (a != null)
                Console.WriteLine(a.Reference + "\t" + a.Marque + "\t"+ a.Prix);
            else
                Console.WriteLine("article  " + reference + "  introuvable");


        }
        static void TestSelectAll1()
        {
            DaoArticle dao = new DaoArticle();
            List<Article> liste = dao.SelectAll1();
            foreach (Article a in liste)
                Console.WriteLine(a.Reference + "\t" + a.Marque + "\t" + a.Prix);

        }
    }
}
