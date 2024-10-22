using Calculadora_c_.controller;
using Calculadora_c_.dto;

namespace Calculadora_c_.view
{
    public class Menu
    {
        private List<string> operacoes;

        public Menu(ControllerCalc controle)
        {
            try
            {
                OperacoesDTO OperacoesDTO = controle.GeraMenu();
                this.operacoes = OperacoesDTO.getOperacoes();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
        }

        public RequestDTO show()
        {
            this.showMenu();
            return this.captureValues();
        }

        private RequestDTO captureValues()
        {
            Console.WriteLine("Escolha sua operação:");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == this.operacoes.Count + 1) Environment.Exit(0);

            Console.WriteLine("Informe o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());

            return new RequestDTO(this.operacoes[opcao - 1], valor1, valor2);
        }

        private void showMenu()
        {
            Console.WriteLine("Escolha sua operação:");
            int index = 1;
            try
            {
                foreach (string op in this.operacoes)
                {
                    Console.WriteLine(index + " - " + op);
                    index++;
                }

                Console.WriteLine(index + " - Sair ...");
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message); 
            }
        }

        public void showResult(ResponseDTO responseDTO)
        {
            Console.WriteLine("O Resultado é: " + responseDTO.getResult());
        }
    }
}
