using System;
using System.Web.Services;

namespace CalculatorWS
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class CalculatorService : WebService
    {
        [WebMethod]
        public double Adunare(double a, double b) => a + b;

        [WebMethod]
        public double Scadere(double a, double b) => a - b;

        [WebMethod]
        public double Inmultire(double a, double b) => a * b;

        [WebMethod]
        public double Impartire(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Nu se poate împărți la zero.");
            return a / b;
        }

        [WebMethod]
        public double Radical(double a)
        {
            if (a < 0)
                throw new ArgumentException("Nu se poate extrage radical dintr-un număr negativ.");
            return Math.Sqrt(a);
        }

        [WebMethod]
        public double RidicareLaPutere(double a, double b) => Math.Pow(a, b);
    }
}
