using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorAppExcel.Utils
{
    public static class FileUtil
    {
        public static async Task SaveAs(this IJSRuntime js, string fileName, byte[] data)
        {
            await js.InvokeVoidAsync("saveAsFile", fileName, Convert.ToBase64String(data));
        }
    }
}
