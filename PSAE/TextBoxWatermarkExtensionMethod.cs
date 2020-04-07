using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PASaveEditor {
    // Setting the cue/watermark for TextBoxes unfortunately involves P/Invoking WinAPI
    internal static class TextBoxWatermarkExtensionMethod {
        // Sets the textual cue, or tip, that is displayed by the edit control to prompt the user for information.
        const uint EM_SETCUEBANNER = 0x1501;


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam,
                                         [MarshalAs(UnmanagedType.LPWStr)] string lParam);


        public static void SetWatermark(this TextBox textBox, string watermarkText) {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }
    }
}
