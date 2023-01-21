using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class StaffDAO
    {
        private static StaffDAO instance = null;
        private static readonly object instanceLock = new object();

        private StaffDAO() { }

        public static StaffDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }

        public StaffAccount LoginByStaffAccount(String email, String password)
        {
            StaffAccount staff = null;
            try
            {
                var context = new CarRentalSystemDBContext();
                staff = context.StaffAccounts.SingleOrDefault(c => c.Email == email && c.Password == password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staff;
        }

        public IEnumerable<StaffAccount> GetStaffList()
        {
            IEnumerable<StaffAccount> staffList = null;
            try
            {
                var context = new CarRentalSystemDBContext();
                staffList = context.StaffAccounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staffList;
        }

        public StaffAccount GetStaffById(String staffID)
        {
            StaffAccount staff = null;
            try
            {
                var context = new CarRentalSystemDBContext();
                staff = context.StaffAccounts.SingleOrDefault(c => c.StaffId == staffID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staff;
        }

        public void Add(StaffAccount staff)
        {
            try
            {
                var context = new CarRentalSystemDBContext();
                context.StaffAccounts.Add(staff);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public void Update(StaffAccount staff)
        {
            try
            {
                StaffAccount _staff = GetStaffById(staff.StaffId);
                if (_staff != null)
                {
                    var context = new CarRentalSystemDBContext();
                    context.StaffAccounts.Update(staff);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Staff does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void Delete(StaffAccount staff)
        {
            try
            {
                StaffAccount _staff = GetStaffById(staff.StaffId);
                if (_staff != null)
                {
                    var context = new CarRentalSystemDBContext();
                    context.StaffAccounts.Remove(staff);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Staff does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
