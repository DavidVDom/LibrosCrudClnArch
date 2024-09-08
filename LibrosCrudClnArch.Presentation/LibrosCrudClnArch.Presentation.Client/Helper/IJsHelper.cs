﻿using Microsoft.JSInterop;

namespace LibrosCrudClnArch.Presentation.Client.Helper
{
    // debería ser una interfaz pero para el ejemplo lo dejamos así
    public static class IJsHelper
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static async ValueTask ToastrError(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
    }
}