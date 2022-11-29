namespace Web_Api.Modules
{
    public class Wallet
    {
        /// <summary>
        /// id кошелек клиента
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// колличество BitCoin
        /// </summary>
        public decimal BTC { get; set; }

        /// <summary>
        /// колличество Ether
        /// </summary>
        public decimal ETH { get; set; }

        /// <summary>
        /// колличество DogeCoin
        /// </summary>
        public decimal DOGE { get; set; }
    }
}
