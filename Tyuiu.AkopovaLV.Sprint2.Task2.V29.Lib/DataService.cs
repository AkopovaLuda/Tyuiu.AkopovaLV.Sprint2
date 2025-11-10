using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AkopovaLV.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((x < 3) & (6 > y) & (y > 3)) || ((2 < x) & (x < 6) & (2 < y) & (y < 8)) || ((5 < x) & (x < 9) & (4 < y) & (y < 8)) || ((8 < x) & (x < 13) & (2 < y) & (y < 8)) || ((12 < x) & (x < 14) & (5 < y) & (y < 9)) || ((9 < x) & (x < 13) & (7 < y) & (y < 12)) || ((9 < x) & (x < 11) & (11 < y) & (y < 13)) || ((5 < x) & (x < 7) & (7 < y) & (y < 12)) || ((2 < x) & (x < 6) & (10 < y) & (y < 12)) || ((3 < x) & (x < 6) & (11 < y) & (y < 13)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
