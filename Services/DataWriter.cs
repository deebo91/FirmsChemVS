﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmsChemVS.Repositories;

namespace FirmsChemVS.Services
{
    class DataWriter
    {
        FirmsChemDBEntities database;
        private string[] Elements;

        public DataWriter()
        {
            Elements = new string[] {"C","H","N","O","F","Cl","Br","I","S","P","Si" };
            database = new FirmsChemDBEntities();
        }

        public string[] elements
        {
            get { return Elements; }
        }

         

        public void saveCompoundToDatabase()
        {

        }
    }
}
