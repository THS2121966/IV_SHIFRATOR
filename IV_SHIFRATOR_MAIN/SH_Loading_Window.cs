﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IV_SHIFRATOR_MAIN
{
    public partial class SH_Loading_Window : Form
    {
        public static SH_Loading_Window sh_loading_core;

        public static SH_Loading_Window SH_RELEASE_CORE()
        {
            sh_loading_core = new SH_Loading_Window();
            return sh_loading_core;
        }

        public SH_Loading_Window()
        {
            InitializeComponent();
        }
    }
}
