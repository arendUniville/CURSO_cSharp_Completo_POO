﻿using System.Globalization;

namespace adicionaRemoveProdutos
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {

            return Preco * Quantidade;

        }

        public void AdicionarProdutos(int quantidade)
        {

            Quantidade += quantidade;

        }


        public override string ToString()
        {

            return Nome 
                   + ", $" 
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade
                   + " unidades, Total: $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
