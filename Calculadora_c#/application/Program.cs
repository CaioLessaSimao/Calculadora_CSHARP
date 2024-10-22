using controller;
using Response;
using Resquest;
using display;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            string workingDirectory = Environment.CurrentDirectory;
            Console.WriteLine("Diretório de trabalho: " + workingDirectory);


            ControllerCalc controllerCalc = new ControllerCalc();
            Menu menu = new Menu(controllerCalc);
            RequestDTO requestDTO = menu.show();
            ResponseDTO responseDTO = controllerCalc.calc(requestDTO);
            menu.showResult(responseDTO);
        }
    }
}

