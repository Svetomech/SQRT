using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SQRT
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new frmMain());
    }

    public static int calcSqrt(int x)
    {
      //string study = String.Empty;

      string[] delimArr = fitDelim(x);

      int up = int.Parse(delimArr[0]);
      int res = findNearestSqrt(up);
      int down = res*res;

      //study = String.Concat("up: " + up, " res: " + res, " down: " + down, "\n");

      for (int i = 1; i < delimArr.Length; ++i)
      {
        up = int.Parse(String.Concat(up - down, delimArr[i]));
        int res_next = findLastNum(2 * res, up);
        down = int.Parse(String.Concat(2 * res, res_next)) * res_next;

        //study = String.Concat(study, "up: " + up, " res: " + res_next, " down: " + down, "\n");

        res = int.Parse(String.Concat(res, res_next));
      }

      //MessageBox.Show(study);

      return res;
    }


    // TODO: Recursive
    private static string[] fitDelim(int x)
    {
      var delims = new List<string>();

      for (int k = 0; x > 0; ++k)
      {
        delims.Add(String.Concat(x / 10 % 10, x % 10));
        x /= 100;
      }

      delims.Reverse();

      return delims.ToArray();
    }

    // TODO: Recursive
    private static int findNearestSqrt(int x)
    {
      int n;

      for (n = 1; n*n <= x; ++n) ;

      return n - 1;
    }

    // TODO: Recursive
    private static int findLastNum(int x, int bound)
    {
      int n;

      for (n = 1; int.Parse(String.Concat(x, n)) * n <= bound; ++n) ;

      return n - 1;
    }
  }
}
