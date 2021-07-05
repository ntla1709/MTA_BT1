using System;

namespace BT1_Anhntl45
{
    class Program
    {
        static void nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void xuat(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }

        static int[] CloneArray(int[] a, int[] a2, int n)
        {
           
            for (int i = 0; i < n; i++)
            {
                a2[i] = a[i];
            }
            return a2;
        }
        static int[] SumAndAverage(int[] a, int n, int x)
        {

            int[] a2 = new int[2] { 0, 0 };
            for (int i = 0; i < n; i+=x)
            {    
                    a2[0] += a[i];
                    a2[1] += 1;
            }
            return a2;
        }
        static void SapXep(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] > a[i])
                    {
                        
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
        }

        static int DemSoPhanTuLonNhat(int[] a, int n)
        {
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i]==a[0])
                {
                    x++;
                }
            }
            return x;
        }

        static int Equal5(int[] a, int n)
        {
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == 5)
                {
                    x++;
                }
            }
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bai 1 va Bai 2 ");
            Console.Write("1. Nhap so luong phan tu trong mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int[] array2 = new int[n];
            Console.WriteLine("Nhap mang: ");
            nhap(array, n);
            array2 = CloneArray(array, array2, n);
            Console.WriteLine("2. Sap xep phan tu trong mang theo thu tu giam dan: ");
            SapXep(array2, n);
            xuat(array2, n);
            Console.WriteLine("\n3.Hien thi thong tin ve mang ban dau: ");
            xuat(array, n);
            Console.WriteLine("\n4.In ra phan tu co gia tri lon nhat va nho nhat: " + array2[0] + " " + array2[n-1]);
            Console.WriteLine("5.Tinh tong va trung binh cong cac phan tu co chi so chan ");
            int[] sum = SumAndAverage(array, n, 2);
            Console.Write("Tong: " + sum[0] + ", TBC: " + sum[0]/sum[1]);
            Console.Write("\n6.Dem so luong phan tu lon nhat: "+ DemSoPhanTuLonNhat(array2,n));
            Console.Write("\n7.Tinh trung binh cong cac phan tu trong mang: ");
            int[] sum2 = SumAndAverage(array, n, 1);
            Console.Write("TBC: " + sum[0]/sum[1]);
            Console.Write("\n8.Dem so luong phan tu bang 5: " + Equal5(array, n));
            ///////////
            Console.WriteLine("\nBai 3");
            Console.Write("1. Nhap doanh so: ");
            int doanhSo = Convert.ToInt32(Console.ReadLine());
            if (doanhSo<0 || doanhSo>10) {
                Console.WriteLine("\nNhap sai ");
            }
            else if (doanhSo >=8 && doanhSo <= 10)
            {
                Console.WriteLine("Tuyet voi(5%)");
            }
            else if (doanhSo == 7)
            {
                Console.WriteLine("Rat tot(3.5%)");
            }
            else if (doanhSo == 6)
            {
                Console.WriteLine("Tot(2%)");
            }
            else if (doanhSo == 5)
            {
                Console.WriteLine("Co co gang(0.5%)");
            }
            else if (doanhSo == 4)
            {
                Console.WriteLine("Kem(-0.5%)");
            }
            else
            {
                Console.WriteLine("Rat kem(-1%)");
            }
            ////////
            Console.WriteLine("Bai 4");
            Console.Write("Nhap so phut : ");
            int soPhut = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ma khach hang\nSinh vien(0), Khac(1) : ");
            int ma = Convert.ToInt32(Console.ReadLine());
            int d40 = soPhut - 401 + 1 > 0 ? soPhut - 401 + 1 : 0;
            int d80 = soPhut - d40 - 201 + 1 > 0 ? soPhut - d40 - 201 + 1 : 0;
            int d120 = soPhut - d40 - d80;
            if (ma == 0)
            {
                d120 = d120 - 50 > 0 ? d120 - 50 : 0;
            }
            else
            {
                d120 = d120;
            }
            double tien = (d120 * 120 + d80 * 80 + d40 * 40 + 27000) * 1.1;
            Console.Write("Tien dien thoai : " + tien);
        }
    }
}
