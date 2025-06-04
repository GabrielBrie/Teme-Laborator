using CalculatorClientWinForms;
using System.Windows.Forms;

public class SplashWrapper : ApplicationContext
{
    public SplashWrapper()
    {
        var splash = new SplashForm();
        splash.Show();
        splash.FormClosed += (s, e) =>
        {
            var main = new Form1();
            main.Show();
            main.FormClosed += (s2, e2) => ExitThread();
        };
    }
}
