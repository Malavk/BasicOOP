using System;

namespace BasicOOP_DZ_5
{
    public class RationalNumbers
    {
        public int numerator;
        public int denumirator;

        public double Drobi
        {
            get { return numerator / denumirator; }
        }
        public RationalNumbers(int n, int d)
        {
            numerator = n;
            denumirator = d;
        }
        //Перегружаем оператор ==
        public static bool operator ==(RationalNumbers nm1, RationalNumbers nm2)
        {
            if ((nm1.numerator == nm2.numerator) && (nm1.denumirator == nm2.denumirator))
                return true;
            return false;
        }
        //Перегружаем оператор !=
        public static bool operator !=(RationalNumbers nm1, RationalNumbers nm2)
        {
            if ((nm1.numerator != nm2.numerator) && (nm1.denumirator != nm2.denumirator))
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }
        //Перегружаем оператор +
        public static RationalNumbers operator +(RationalNumbers nm1, RationalNumbers nm2)
        {
            return new RationalNumbers(nm1.numerator + nm2.numerator, nm1.denumirator + nm2.denumirator);
        }
        //Перегружаем оператор -
        public static RationalNumbers operator -(RationalNumbers nm1, RationalNumbers nm2)
        {
            return new RationalNumbers(nm1.numerator - nm2.numerator, nm1.denumirator - nm2.denumirator);
        }
        //Перегружаем оператор *
        public static RationalNumbers operator *(RationalNumbers nm1, RationalNumbers nm2)
        {
            return new RationalNumbers(nm1.numerator * nm2.numerator, nm1.denumirator * nm2.denumirator);
        }
        //Перегружаем оператор /
        public static RationalNumbers operator /(RationalNumbers nm1, RationalNumbers nm2)
        {
            return new RationalNumbers(nm1.numerator / nm2.numerator, nm1.denumirator / nm2.denumirator);
        }
        //Перегружаем оператор %
        public static RationalNumbers operator %(RationalNumbers nm1, RationalNumbers nm2)
        {
            return new RationalNumbers(nm1.numerator % nm2.numerator, nm1.denumirator % nm2.denumirator);
        }
        //Перегружаем унарный оператор ++ 
        public static RationalNumbers operator ++(RationalNumbers nm1)
        {
            return new RationalNumbers(nm1.numerator +=1, nm1.denumirator += 1);
        }
        //Перегружаем унарный оператор --
        public static RationalNumbers operator --(RationalNumbers nm1)
        {
            return new RationalNumbers(nm1.numerator -= 1, nm1.denumirator -= 1);
        }
        //Перегружаем унарный оператор >
        public static bool operator >(RationalNumbers nm1, RationalNumbers nm2)
        {
            return (nm1.Drobi > nm2.Drobi);
        }
        //Перегружаем унарный оператор <
        public static bool operator <(RationalNumbers nm1, RationalNumbers nm2)
        {
            return (nm1.Drobi < nm2.Drobi);
        }
        //Перегружаем унарный оператор >=
        public static bool operator >=(RationalNumbers nm1, RationalNumbers nm2)
        {
            return (nm1.Drobi >= nm2.Drobi);
        }
        //Перегружаем унарный оператор <=
        public static bool operator <=(RationalNumbers nm1, RationalNumbers nm2)
        {
            return (nm1.Drobi <= nm2.Drobi);
        }
        //Вывод дроби
        public override string ToString()
        {
            return String.Format($"{numerator} / {denumirator}");
        }
        //Оператор преобразования
        public static implicit operator double(RationalNumbers v)
        {
            return v.Drobi;
        }
    }
}
