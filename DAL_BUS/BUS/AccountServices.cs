using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public  class AccountServices
    {
        AppDbContext _context;
        public AccountServices()
        {
            _context = new AppDbContext();
        }

        public string Login(string username, string password) 
        {
                var account =_context.Accounts.FirstOrDefault(p=>p.UserName == username && p.Password == password);
            if (account == null) { return ""; }
            else //có tìm thấy
            {
                return account.Role + ":" + account.UserName;
            }

         }

        //Create
        public string CreateAccount(string username, string passwword, int role)
        {
            Account account = new Account()
            {
                Role = role,
                UserName = username,
                Password = passwword
            };
            try
            {
                _context.Accounts.Add(account);
                _context.SaveChanges();
                return "Tạo thành công";
            }
            catch (Exception e)
            {

                return "Tạo thất bại" + e.Message;
            }
        }
        
        //Lấy tất cả các account
        public List<Account> GetAccounts()
        {
            return _context.Accounts.ToList();
        }

        //Khóa tài khoản
        public string LockAccount(string username)
        {
            var account = _context.Accounts.Find(username);
            if (account.Role == 1) { return "Không thể khóa tài khoản Admin "; }
            else if (account.Role == 0) { return "Tài khoản đã bị khóa, không thể khóa thêm"; }
            account.Role = 0; //0 là khóa, 1 admin, 2 nhanvien
            try
            {
                _context.Accounts.Update(account);
                _context.SaveChanges();
                return "Khóa thành công";
            }
            catch (Exception e)
            {

                return "Khóa thất bại" + e.Message;
            }

        }


        //Mở khóa tài khoản
        public string UnLockAccount(string username)
        {
            var account = _context.Accounts.Find(username);
            if (account.Role != 0) { return "Không thể mở khóa cho tài khoản không bị khóa"; }
            account.Role = 2;
            try
            {
                _context.Accounts.Update(account);
                _context.SaveChanges();
                return "Mở khóa thành công";
            }
            catch (Exception e)
            {

                return "Khóa thất bại" + e.Message;
            }

        }

        //Update
        public string UpdateAccount(string username, string passwword, int status)
        {
            var account = _context.Accounts.Find(username);
            if (account == null)
            {
                return "Không tìm thấy tài khoản cần sửa";
            }
            else
            {
                account.Role = status;
                account.Password = passwword; //ko sửa username vì nó là khóa chính
                _context.Accounts.Update(account);
                _context.SaveChanges();
                return "Sửa thành công";

            }
        }
    }
}
