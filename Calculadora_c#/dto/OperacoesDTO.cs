﻿namespace listaOperacoes
{
    public class OperacoesDTO
    {
        private List<string> operacoes;

        public OperacoesDTO(List<string> operacoes)
        {
            this.operacoes = operacoes;
        }

        public List<string> getOperacoes()
        {
            return operacoes;
        }
    }
}