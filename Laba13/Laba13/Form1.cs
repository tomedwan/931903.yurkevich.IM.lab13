using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int N, n; double el, a, M, D;

        int[] stat; int[] line;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double[] freq;
        Random r = new Random();
        

        private void button1_Click(object sender, EventArgs e)
        {
            N = int.Parse((string)cb1.SelectedItem);
            el = (double)lambda.Value;
            int m; double S;

            n = (int)(1+3.322 * Math.Log(N));
            stat = new int[N]; for (int i = 0; i < n; i++) stat[i] = 0;
            line = new int[N]; freq = new double[n];

            for (int i=0; i<N; i++)
            {
                m =-1; S = 0;
                do
                {
                    ++m;
                    S += Math.Log(r.Next());
                } while (S >= -el);
                line[i] = m;
            }

            M = el;
            D = el;
         
            tbM.Text = M.ToString("F3");
            tbD.Text = D.ToString("F3");
          
           for(int i =0; i<N; i++)
           {
                stat[line[i]]++;
           }
        
          double chi = 14.067;
           double X = 0;

            if (X < chi) tbChi.Text = "True";
            else tbChi.Text = "False";

            for (int i = 0; i < n; i++) freq[i] = (double)stat[i] / (double)N;
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < n; i++) chart1.Series[0].Points.AddXY(i + 1, freq[i]);
        }
        

        void sort(int first, int last)
        {
            double p = line[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (line[i] < p && i <= last) ++i;
                while (line[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = line[i];
                    line[i] = line[j];
                    line[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) sort(first, j);
            if (i < last) sort(i, last);
        }

    }
    
}
