using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorApp.Services
{
    public interface ICalendarHolidays
    {
        /// <Summary>
        /// 获得 假日键值
        /// </Summary>
        bool IsHoliday(DateTime dt);
    }
}
