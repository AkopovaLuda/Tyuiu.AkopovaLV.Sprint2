using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AkopovaLV.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (d < c);
            res[1] = (a > b) & (d < c);
            res[2] = (c > a) || (d < b);
            res[3] = (d > a) && (b < c);
            res[4] = !(res[1]);
            res[5] = (a > b) ^ (d < c);
            return res;


        }
    }
}
