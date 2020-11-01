using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorMovies.Client.Helpers
{
    public static class IJSRuntimeExtensionsMethods
    {

        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask ConsoleMessage(this IJSRuntime js, string consoleMessage)
        {
            await js.InvokeVoidAsync("console.log", consoleMessage);
        }
        public static async ValueTask CustomFunction(this IJSRuntime js, string customMessage)
        {
            await js.InvokeVoidAsync("MyFunction", customMessage);
        }
    }
}
