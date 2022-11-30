namespace Web_Api.Modules
{
    public class Archiv
    {
        /// <summary>
        /// id архива клиента
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Ls клиента сделавшего транзакцию
        /// </summary>
        public string LsClientOut { get; set; }

        /// <summary>
        /// Ls клиента получившего транзакцию 
        /// </summary>
        public string LsClientIn { get; set; }

        /// <summary>
        /// тип валюты
        /// </summary>
        public string TypeCurrency { get; set; }

        /// <summary>
        /// тип транзакции
        /// </summary>
        public string TypeTransfer { get; set; }

        /// <summary>
        /// дата и время транзакции
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}
