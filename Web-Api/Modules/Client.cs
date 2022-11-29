namespace Web_Api.Modules
{
    public class Client
    {
        /// <summary>
        /// id клиента
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// id кошелька клиента
        /// </summary>
        public int idWallet { get; set; }

        /// <summary>
        /// id архива клиента с историей транзакций
        /// </summary>
        public int idArchive { get; set; } 
    }
}
