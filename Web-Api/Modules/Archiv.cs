namespace Web_Api.Modules
{
    public class Archiv
    {
        /// <summary>
        /// id архива клиента
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// id клиента сделавшего транзакцию
        /// </summary>
        public int idClientOut { get; set; }

        /// <summary>
        /// id клиента получившего транзакцию 
        /// </summary>
        public int idClientIn { get; set; }

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
