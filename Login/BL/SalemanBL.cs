using System;
using Persistence;
using DAL;

namespace BL
{
    public class SalemanBL
    {
        private SalemanDAL dal = new SalemanDAL();
        public int Login(Saleman saleman)
        {
            return dal.Login(saleman);
        }
    }
}
