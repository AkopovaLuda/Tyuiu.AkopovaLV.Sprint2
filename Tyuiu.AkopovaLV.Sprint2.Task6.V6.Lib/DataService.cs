using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AkopovaLV.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res1 = "";
            string res2 = "";
            string result = "";

            switch (value1)
            {
                case 1: res1 += "пик"; break;
                case 2: res1 += "треф"; break;
                case 3: res1 += "бубен"; break;
                case 4: res1 += "червей"; break;

            }
            
            switch (value2)
            {
                case 6: res2 = "шестерка" ; break;
                case 11: res2 = "валет"; break;
                case 12: res2 = "дама"; break;
                case 13: res2 = "король " ; break;
                case 14: res2 = "туз" ; break;
                case 7: res2 = "семерка " ; break;
                case 8: res2 = "восьмерка " ; break;
                case 9: res2 = "девятка"  ; break;
                case 10: res2 = "десятка" ; break;
            }

            return result = $"{res2} {res1}";
        }
    }
}
