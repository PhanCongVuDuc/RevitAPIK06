using System;

namespace BetaDragon
{
    // Tạo một class có tên là PTBH, khai báo các property là A, B, C và khai báo 1 method có tên là NghiemPTBH
    class PTBH
    {
        // ctril + k + d format code
        internal double A { get; }

        internal double B { get; }

        internal double C { get; }

        public PTBH(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        //Method NghiemPTBH tính toán và trả về một giá trị có kiểu là string thông báo các nghiệm của phương trình bậc 2
        public string NghiemPTBH()
        {
            //Ly thuyet:
            //Ax2 + Bx + C =0
            // Δ = B2-4AC
            // Δ > 0: phương trình tồn tại 2 nghiệm: x1 = (-b+ sqrt(Δ )/2a ; x2 = -b- sqrt(Δ )/2a
            //  Δ = 0, phương trình có nghiệm kép x = -b / 2a
            // Δ < 0, phương trình đã cho vô nghiệm.'

            //Code tính toán: 

            double alpha;
            double x1;
            double x2;
            //Math.Pow(B,2) thay thế b*b
            //alpha = Math.Pow(B,2) - 4 * A * C;
            //if (alpha > 0)
            //{
            //    x1 = (-B + Math.Sqrt(alpha) / (2 * A));
            //    x2 = (-B - Math.Sqrt(alpha) / (2 * A));

            //    return string.Concat("\nVì Δ > 0 nên phương trình tồn tại 2 nghiệm: ", "\nX1= ", x1, "\nX2= ", x2);
            //}
            //else if (alpha < 0)
            //{
            //    x1 = x2 = -B / (2 * A);
            //    return string.Concat("\nVì Δ < 0 nên Phương trình có nghiệm kép x = ", x1);
            //}
            //else
            //{
            //    return "\nVì Δ = 0 nên phương trình đã cho vô nghiệm";
            //}

            double a = A;

            // Sửa 
            alpha = Math.Pow(B, 2) - 4 * a * C;
            if (alpha > 0)
            {
                x1 = (-B + Math.Sqrt(alpha) / (2 * a));
                x2 = (-B - Math.Sqrt(alpha) / (2 * a));

                return string.Concat("\nVì Δ > 0 nên phương trình tồn tại 2 nghiệm: ", "\nX1= ", x1, "\nX2= ", x2);
            }
            else if (alpha < 0)
            {
                return "\nVì Δ = 0 nên phương trình đã cho vô nghiệm";

            }
            else
            {
                x1 = x2 = -B / (2 * a);
                return string.Concat("\nVì Δ < 0 nên Phương trình có nghiệm kép x = ", x1);
            }
        }

    }
}
