using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorAppExcel.Utils
{
    public class ExcelDataService
    {
        public IList<ExcelData> GetExcelDatas(int count)
        {
            return Enumerable.Range(0, count).Select(index => new ExcelData
            {
                Id = index,
                Name = $"Name-{index}",
                Date = DateTimeOffset.Now
            })
            .ToList();
        }
    }
}
