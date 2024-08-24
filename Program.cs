using System;
using System.Runtime.InteropServices.Marshalling;

namespace DemSoKyTuXuatHienTrongMang
{
    class Program
    {
        static void Main(string[]args)
        {
            string? kytu;
            string? name;
            char kt;
            while(true)
            {
                Console.Write("Nhap vao chuoi muon dem so ky tu: ");
                name=Console.ReadLine();
                if (name != string.Empty)
                {
                    break;
                }
                continue;
            }
            while(true)
            {
                Console.Write("Nhap vao 1 ky tu muon dem: ");
                kytu=Console.ReadLine();
                if (!string.IsNullOrEmpty(kytu) &&kytu.Length == 1)
                {
                    kt=kytu[0];
                    break;
                }
                continue;
            }
            if (name!=null)
            {
                int count= KiemTraKyTu(name, kt);            
                Console.WriteLine("Trong name co {0} ky tu {1}", count,kt);
            }
            else
            {
                Console.Write("Nhap vao chuoi co gia tri null");
            }
            
        }
        static int KiemTraKyTu(string str, char kt)
        {
            int count=0;            
            foreach (char c in str)
            {    
                //Không phân biệt chữ hoa chữ thường                          
                //if(char.ToLower(c)==char.ToLower(kt))

                //Phân biệt chữ hoa chữ thường
                if (c==kt)
                {
                    count++;
                }
            }
            return count;
        }
    }
}