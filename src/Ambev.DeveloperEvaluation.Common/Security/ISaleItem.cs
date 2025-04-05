namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Interface que define as propriedades públicas do item de venda (SaleItem).
    /// Representa a associação entre um produto e uma venda, com quantidade e valor.
    /// </summary>
    public interface ISaleItem
    {
        /// <summary>
        /// Identificador único do item de venda.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Identificador da venda associada.
        /// </summary>
        string SaleId { get; }

        /// <summary>
        /// Identificador do produto vendido.
        /// </summary>
        string ProductId { get; }

        /// <summary>
        /// Quantidade do produto vendido.
        /// </summary>
        int Quantity { get; }

        /// <summary>
        /// Preço unitário do produto no momento da venda.
        /// </summary>
        decimal UnitPrice { get; }

        /// <summary>
        /// Desconto aplicado (em porcentagem).
        /// Pode ser 0, 10 ou 20.
        /// </summary>
        decimal Discount { get; }

        /// <summary>
        /// Valor total do item (considerando quantidade e desconto).
        /// </summary>
        decimal Total { get; }

        /// <summary>
        /// Indica se o item foi cancelado.
        /// </summary>
        bool IsCancelled { get; }
    }
}
