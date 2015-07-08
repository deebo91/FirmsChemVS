using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmsChemVS.Services
{
   public class BaseTableMassService
    {

       private static BaseTableMassService instance;
       int tablePosition = -1;
       int tableCount;
       
       public int TableCount
       {get{return tableCount;}set{tableCount = value;}}
       

       public static BaseTableMassService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaseTableMassService();
                }
                return instance;
            }
        }

       public int incrementBaseTableMassPosition()
       {
           if (tableCount == 0)
           {
               return -9;
           }
           else if (tablePosition < TableCount - 1)
           {
               tablePosition++;
           }
           else
           {
               tablePosition = 0;
           }

           return tablePosition;
       }

       public void resetBaseTablePosition()
       {
           tablePosition = -1;
       }
    }
}
