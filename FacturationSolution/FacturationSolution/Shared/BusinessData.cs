﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using FacturationSolution.Pages;
using Microsoft.AspNetCore.Components.Forms;

namespace FacturationSolution.Shared
{
    public class BusinessData : IBusinessData
    {
        public IEnumerable<FactureClient> Factures { get; }
        public BusinessData()
        {
            Factures = new FactureClient[]
            {
                new FactureClient("EDF", new DateTime(2020, 05, 19), new DateTime(2020, 06, 25), 20, 600, 900),
                new FactureClient("TF1", new DateTime(2019, 03, 14), new DateTime(2020, 07, 29), 40, 800, 1000),
                new FactureClient("SOGETI", new DateTime(2018, 05, 14), new DateTime(2021, 05, 21), 60, 900, 1200)
            };
            
        }
    }

}