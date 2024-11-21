using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace MergeSort
{
    public partial class MergeSorting : Form
    {

        public MergeSorting()
        {
            InitializeComponent();
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            int[] arr = { 100, 99, 150, 199, 20, 89, 1, 4, 3 };

            MergeSort(arr, 0, arr.Length - 1);

            string sortedArray = string.Join(", ", arr); //รวมตัวเลขใน array เป็นข้อความเดียว
            textBox1.Text = sortedArray;
        }
        private void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;//การหาค่ากลาง
                MergeSort(arr, left, mid);// จัดเรียงส่วนซ้าย
                MergeSort(arr, mid + 1, right);// จัดเรียงส่วนขวา
                Merge(arr, left, mid, right);//รวม2ส่วนที่เรียง
            }
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;// ขนาดของอาร์เรย์ย่อยด้านซ้าย
            int n2 = right - mid;// ขนาดของอาร์เรย์ย่อยด้านขวา
            int[] leftArray = new int[n1];//สร้างอาร์เรย์ย่อยสำหรับเก็บข้อมูลชั่วคราว
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];// คัดลอกจากตำแหน่ง left ถึง mid
            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[mid + 1 + j];//คัดลอกจากตำแหน่ง mid + 1 ถึง right


            int iIndex = 0, jIndex = 0, kIndex = left;//เปรียบเทียบรวมข้อมูลจากอาร์เรย์ย่อยกลับเข้ามาใน arr
            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                    arr[kIndex++] = leftArray[iIndex++];
                else
                    arr[kIndex++] = rightArray[jIndex++];
            }
            while (iIndex < n1)//ถ้ามีค่าที่เหลือใน ซ้าย (leftArray): เก็บลงใน arr
                arr[kIndex++] = leftArray[iIndex++];
            while (jIndex < n2)//ถ้ามีค่าที่เหลือใน ขวา (rightArray): เก็บลงใน arr
                arr[kIndex++] = rightArray[jIndex++];
        }
    }
}
