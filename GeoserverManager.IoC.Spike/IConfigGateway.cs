﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.IoC.Spike
{
    public interface IConfigGateway
    {
        string LocalLayersConnectionString { get; set; }
    }
}
