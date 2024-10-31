using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DL2
{
    public partial class Matrix : Form
    {
        public Matrix()
        {
            InitializeComponent();
            int[,] A = { {3,6,1,2},
                         {1,5,6,7},
                         {9,2,4,1}
                        };
            //Console.WriteLine(A[0, 0]);
            //Console.WriteLine(A[0, 1]);

            for (int i = 0; i < 3; i++)
            { // วนรอบแถว
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(A[i, j] + "\t"); // แสดงค่าที่ตำแหน่ง (i, j)
                }
                Console.WriteLine(); // ข้ามไปยังบรรทัดถัดไปหลังจากแสดงแต่ละแถว
            }
        }
    }
}
