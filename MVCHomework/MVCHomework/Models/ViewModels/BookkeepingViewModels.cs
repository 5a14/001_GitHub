using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHomework.Models.ViewModels
{
    public class BookkeepingViewModels
    {
        [Display(Name = "類別")]
        public string category { get; set; }

        [Display(Name = "金額")]
        [DisplayFormat(DataFormatString = "{0:N0}")]//格式化金額
        public int money { get; set; }

        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]//格式化日期
        public DateTime date { get; set; }

        public string description { get; set; }
    }
}