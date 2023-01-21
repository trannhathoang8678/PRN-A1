using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class StaffRepository : IRepository<StaffAccount>
    {
        public IEnumerable<StaffAccount> GetAll()
        {
            return StaffDAO.Instance.GetStaffList();
        }

        public StaffAccount GetById(string id)
        {
            return StaffDAO.Instance.GetStaffById(id);
        }
        public void Add(StaffAccount t)
        {
             StaffDAO.Instance.Add(t);
        }

        public void Delete(StaffAccount t)
        {
            return StaffDAO.Instance.Delete(t);
        }


        public void Update(StaffAccount t)
        {
            throw new NotImplementedException();
        }
    }
}
