using Calculadora_c_.controller;
using Calculadora_c_.dto;
using Calculadora_c_.view;

namespace Calculadora_c_.application
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

