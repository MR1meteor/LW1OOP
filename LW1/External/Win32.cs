using System.Runtime.InteropServices;

namespace LW1.External;

public class Win32
{
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr MessageBox(int hWnd, String text, String caption, uint type);
}