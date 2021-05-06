using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PS3.Models
{
    public class FizzBuzz
    {

        [Key]
        public int ID { get; set; }
        [Display(Name = "Liczba od 1 do 1000")]
        [Range(1, 1000, ErrorMessage = "Podaj liczbe z zakresu 1 - 1000.")]
        [Required(ErrorMessage = "Podaj liczbe")]
        public int? Number { get; set; }
        [MaxLength(6)]
        [Column(TypeName = "varchar(6)")]
        public string Result { get; set; }

        public DateTime DateTime { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string UserName {get;set;} 
        public void FizzBuzzing(string userName) 
        {
            string result = "";
            if (Number % 3 == 0)
                result += "Fizz";

            if (Number % 5 == 0)
                result += "Buzz";

            Result = result == string.Empty ? Number.ToString() : result;
            DateTime = DateTime.Now;
            UserName = userName;
        }


    }
}
