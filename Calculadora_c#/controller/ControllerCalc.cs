﻿using System.Reflection;
using Calculadora_c_.dto;
using Calculadora_c_.exception;
using Calculadora_c_.model;
using Calculadora_c_.model.operation;

namespace Calculadora_c_.controller
{
    public class ControllerCalc
    {
        public ResponseDTO calc(RequestDTO requestDTO)
        {
            int result = 0;
            ICalc calc = new Calc();

            string pacoteBase = "Calculadora_c_.model.operation." + requestDTO.getOpcao();
            Console.WriteLine(pacoteBase);
            try
            {
                // Usar reflection para obter o tipo da operação
                Type classeOperacao = Type.GetType(pacoteBase);
                
                // Criar instância da operação
                IOperation operation = (IOperation)Activator.CreateInstance(classeOperacao);

                // Executar o cálculo
                result = calc.calculation(operation, requestDTO.getValor1(), requestDTO.getValor2());

                return new ResponseDTO(result);
            }
            catch (Exception e) when (e is TypeLoadException || e is TargetInvocationException ||
                                      e is MissingMethodException || e is InvalidCastException || 
                                      e is ArgumentNullException)
            {
                throw new OperacaoInvalidaException("Erro ao criar instância da operação: " + e.Message);
            }
        }

        public OperacoesDTO GeraMenu()
        {
            List<string> operacoes = new List<string>();

            string directoryPath = "../../../model/operation";

            if (Directory.Exists(directoryPath))
            {
                // Obtém a lista de arquivos no diretório
                string[] files = Directory.GetFiles(directoryPath);

                // Percorre os arquivos
                foreach (string filePath in files)
                {
                    // Usando reflection para obter o nome do arquivo
                    FileInfo fileInfo = new FileInfo(filePath);
                    MethodInfo getNameMethod = typeof(FileInfo).GetMethod("get_Name");

                    if (getNameMethod != null)
                    {
                        // Invoca o método para obter o nome do arquivo
                        string arquivo = (string)getNameMethod.Invoke(fileInfo, null);
                        string nomeArquivo = arquivo.Split(".")[0];
                        
                        if (!nomeArquivo.Equals("IOperation")){
                            operacoes.Add(nomeArquivo);
                        }
                    }
                }
                return new OperacoesDTO(operacoes);
            }
            else
            {
                Console.WriteLine("O diretório especificado não existe.");
            }
            return null;
        }
    }
}
