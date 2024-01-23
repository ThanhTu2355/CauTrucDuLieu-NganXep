using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganXep
{
    internal class Stack
    {
        //khai bao thanh phan du lieu
        private int[] data;
        private int top;
        //dinh nghia cac phuong thuc khoi tao
        public Stack()
        {
            data = new int[100];
            top = -1;
        }
        public Stack(int sophantu)
        {
            data = new int[sophantu];
            top = -1;
        }
        //phuong thuc kiem tra rong
        public bool KiemTraRong()
        {
            bool kq = false;
            if(top == -1)
                kq = true;
            return kq;
        }
        //phuong thuc kiem tra day
        public bool KiemTraDay()
        {
            bool kq = false;
            if(top == data.Length-1)
                kq = true;
            return kq;
        }
        //them phan tu vao ngan xep
        public void Them(int n)
        {
            if(KiemTraDay())
            {
                Console.WriteLine(" Stack da day. Khong the them ");
            }else
            {
                data[++top] = n;
            }
        }
        public int LayPhanTu()
        {
            int kq = 0;
            if(KiemTraRong())
            {
                Console.WriteLine("Stack rong. Khong the lay phan tu ");
            }else
            {
                kq = data[top--];
            }
            return kq;
        }
    }
}
