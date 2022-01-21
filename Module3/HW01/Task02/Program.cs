using System;

namespace Task02
{
    delegate double DelegateConvertTemperature(double a);
    class TemperatureConventerImp
    {
        public double Celcium2Faringate(double a)
        {
            return ((double)5 / 9) * (a - 32);
        }
        public double Faringate2Celcium (double a)
        {
            return ((double)9 / 5) * a + 32;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            DelegateConvertTemperature del1 = new DelegateConvertTemperature((new TemperatureConventerImp()).Celcium2Faringate);
            DelegateConvertTemperature del2 = new DelegateConvertTemperature((new TemperatureConventerImp()).Faringate2Celcium);
            del1 += (new TemperatureConventerImp()).Faringate2Celcium;
            Console.WriteLine(del1(7));
        }
    }
}
