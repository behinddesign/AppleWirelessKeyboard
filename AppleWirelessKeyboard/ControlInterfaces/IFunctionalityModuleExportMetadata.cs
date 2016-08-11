﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleWirelessKeyboard.Keyboard
{
    public interface IFunctionalityModuleExportMetadata
    {
        string Name { get; }
        [DefaultValue("")]
        string Category { get; }
    }
}
