using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Biblio bib = new Biblio();
            var line = Console.ReadLine().Split(' ');
            List<Biblio> bib = new List<Biblio>();
            int quantity = int.Parse(line[0]);
            bool bo = false;
            for (int c = 1; c < quantity; c++)
            {
                //Console.ReadLine();
                var linet = Console.ReadLine().Split(' ');
                if (linet[0] == "+")
                {
                    bo = true;
                }
                else
                {
                    bo = false;
                }
                bib.Add(new Biblio { bools = bo, time = Convert.ToInt32(linet[1]), name = linet[2] });
            }
            int i = 0;
            foreach (Biblio bi in bib)
            {
                if (bi.name == bib.ElementAt(i).ToString())
                {
                    if (bi.bools == true)
                    {
                        int timet = bi.time;
                    }
                    else
                    {
                        int timef = bi.time;
                    }

                    i++;
                }
            }
            int y =


             Console.ReadKey();

        }

    }
    class Biblio
    {
        public bool bools { get; set; }
        public int time { get; set; }
        public string name { get; set; }
    }
}
}
