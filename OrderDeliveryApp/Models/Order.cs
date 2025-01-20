using System.ComponentModel.DataAnnotations;

namespace OrderDeliveryApp.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Город отправителя")]
        [Required(ErrorMessage = "Поле 'Город отправителя' обязательно для заполнения.")]
        public string SenderCity { get; set; }

        [Display(Name = "Адрес отправителя")]
        [Required(ErrorMessage = "Поле 'Адрес отправителя' обязательно для заполнения.")]
        public string SenderAddress { get; set; }

        [Display(Name = "Город получателя")]
        [Required(ErrorMessage = "Поле 'Город получателя' обязательно для заполнения.")]
        public string ReceiverCity { get; set; }

        [Display(Name = "Адрес получателя")]
        [Required(ErrorMessage = "Поле 'Адрес получателя' обязательно для заполнения.")]
        public string ReceiverAddress { get; set; }

        [Display(Name = "Вес груза (кг). Пример: 1,3")]
        [Required(ErrorMessage = "Поле 'Вес груза' обязательно для заполнения.")]
        public double Weight { get; set; }

        [Display(Name = "Дата забора")]
        [Required(ErrorMessage = "Поле 'Дата забора' обязательно для заполнения.")]
        public DateTime PickupDate { get; set; }
    }
}