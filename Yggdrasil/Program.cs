﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yggdrasil
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>/ol,
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Manage());
        }
    }
}
