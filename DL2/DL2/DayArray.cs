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
    public partial class DayArray : Form
    {
        public DayArray()
        {
            InitializeComponent();

        }

        private void Number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //เก็บชื่อวันเป็น Array
                    string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                    //แสดงชื่อวันที่ใน TextBox DayName ตามที่ผู้ใช้ป้อนใน TextBox Number โดย: แปลงค่าใน Number เป็น intลดค่า 1 เพื่อให้ตรงกับดัชนีในอาเรย์เข้าถึงชื่อวันในอาเรย์ day ตามดัชนีที่คำนวณได้นำชื่อวันที่นั้นไปแสดงใน TextBox DayName
                    DayName.Text = day[int.Parse(Number.Text) - 1];
                }
                catch
                {
                    // จัดการข้อผิดพลาดหากป้อนค่าที่ไม่ถูกต้อง (เช่น ไม่ใช่ตัวเลข หรือเกินช่วง 1-7)
                    DayName.Text = "กรุณาป้อนเลขระหว่าง 1 ถึง 7";
                }
            }
        }
        //private void Number_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {              
        //            //เก็บชื่อวันเป็น Array
        //            string[] nameList = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        //            int index = int.Parse(day.Text);
        //        try
        //        {
        //          DayName.Text = day[int.Parse(Number.Text) - 1];
        //        } catch (Exception ex)
        //        {
        //            DayName.Text = "กรุณาป้อนเลขระหว่าง 1 ถึง 7";
        //        }

        //    }
        //}
    }
}
