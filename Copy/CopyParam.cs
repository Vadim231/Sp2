﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sp1
{
    public class CopyParam
    {
        public string srcFileName, destFileName;
        public Form1 frm;
        public bool IsStop;
        public ManualResetEvent evnPause;
        public CopyParam()
        {
            IsStop = false;
            evnPause = new ManualResetEvent(true);
        }
    }
}
