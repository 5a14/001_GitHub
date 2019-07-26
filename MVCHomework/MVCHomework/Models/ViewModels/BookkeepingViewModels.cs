using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHomework.Models.ViewModels
{
    public enum categoryType
    {
        [Description("支出")]
        支出,
        [Description("收入")]
        收入
    }

    public class BookkeepingViewModels
    {
        [Display(Name = "類別")]
        public categoryType category { get; set; }//列舉categoryType型態，取代顯示文字

        [Display(Name = "金額")]
        [DisplayFormat(DataFormatString = "{0:N0}")]//格式化金額
        public int money { get; set; }

        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]//格式化日期
        public DateTime date { get; set; }

        [StringLength(100)]
        public string description { get; set; }
    }
}