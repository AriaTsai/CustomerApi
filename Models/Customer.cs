//建立一個資料模型 UserModel，這個資料模型會被轉成資料表，把屬性 Id 設定成 Primary Key 且自動遞增：
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerApi.Models
{
  public class Customer
  {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string gender { get; set; }
    public string number { get; set; }

    [Newtonsoft.Json.JsonConverter(typeof(LongDateTimeConvert))]
    public DateTime birth_date { get; set; }
  }

}