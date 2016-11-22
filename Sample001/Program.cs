using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample001
{
    public class IntNum
    {
        delegate int calc01(int x);
        delegate int calc02(int x, int y);

        private int myFunc(int x, int y)
        {
            return x * y;
        }

        public int Multiple(int x)
        {
            calc01 exp01 = xx => x * x;
            calc02 exp02 = (yy, zz) => ((zz + 10) * (yy - x));

            int num = myFunc(exp01(x), exp02(30, 50));

            return num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IntNum test = new IntNum();

            Func<int, int> hoge = test.Multiple;

            var num = hoge(3);
            MessageBox.Show(num.ToString());
            num = hoge(9);
            MessageBox.Show(num.ToString());
        }
    }
}
