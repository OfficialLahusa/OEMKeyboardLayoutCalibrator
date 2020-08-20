using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEMKeyboardLayoutCalibrator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;

            // This bypasses the [Ctrl]+[C] hotkey for closing the console, use [ESC] instead
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Keyboard Layout Calibrator (C) Lasse Huber-Saffer, 2020");
            Console.WriteLine("Press [ESC] to close");
            Console.Write("----------\n\n");

            do
            {
                keyInfo = Console.ReadKey();

                string modCtrl = string.Empty, modAlt = string.Empty, modShift = string.Empty, pressedKey;
                if ((keyInfo.Modifiers & ConsoleModifiers.Control)  != 0)   modCtrl     = "[CTRL] + ";
                if ((keyInfo.Modifiers & ConsoleModifiers.Alt)      != 0)   modAlt      = "[ALT] + ";
                if ((keyInfo.Modifiers & ConsoleModifiers.Shift)    != 0)   modShift    = "[SHIFT] + ";
                pressedKey = $"[{keyInfo.Key.ToString()}]";

                Console.WriteLine($"\rInput: {modCtrl}{modAlt}{modShift}{pressedKey}");
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
