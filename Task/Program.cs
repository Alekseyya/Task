using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = Int32.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            string pattern = @"\d*[^\D]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);


            Dictionary<int, int> dic1 = sum(matches, quantity);


            ArrayList list = new ArrayList();
            foreach (KeyValuePair<int, int> keyValue in dic1)
            {
                list.Add(keyValue.Key);

            }
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

        }
        static Dictionary<int, int> sum(MatchCollection matches, int quantity)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>(quantity);
            int i = 0;
            int quantity1 = quantity;
            while (quantity != 0)
            {

                string t = matches[i].ToString();
                int m = Convert.ToInt32(t);

                dic.Add(i + 1, m);

                i = m - 1;
                quantity--;
            }
            return dic;


        }
    }
}
