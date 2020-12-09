using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jashan_ImageRec_Lambda
{
    interface ITableDataService
    {
        Task Store<T>(T item) where T : new();       
    }
}
