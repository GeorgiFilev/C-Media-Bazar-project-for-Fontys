using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepotAppMediaBazaar
{
    class ReshelfRequest
    {
        SQLConnReshelfRequest connRequests = new SQLConnReshelfRequest();
        public string[] GetStockReshelfRequests()
        {
            string[] requests = connRequests.GetStockReshelfRequestFromDB();
            return requests;
        }
        public void StockReshelf(string id)
        {
            connRequests.StockReshelfInDB(id);
        }
    }
}
