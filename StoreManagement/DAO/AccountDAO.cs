using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StoreManagement.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value; 
        }
        public AccountDAO() { }

        public bool Login(string username, string password)
        {
            string querry = "USP_Login @username , @password";
           
            DataTable dt = DataProvider.Instance.ExecuteQuerry(querry, new object[] {username, password });

            return dt.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            Account account = null;
            string querry = "Select * from Account Where UserName = N'" + userName+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuerry(querry);
            foreach(DataRow row in dt.Rows)
            {
                account = new Account(row);
                return account;
            }
            return null;
        }
        public List<Account> GetAllAccount()
        {
            List<Account> list = new List<Account>();
            string querry = "Select * from Account";
            DataTable dt = DataProvider.Instance.ExecuteQuerry(querry);
            foreach (DataRow row in dt.Rows)
            {
                Account account = new Account(row);
                list.Add(account);
            }
            return list;
        }
		public List<Account> GetAccountByKeyword(string keyword)
		{
			List<Account> list = new List<Account>();
			string querry = "Select * from Account WHERE UserName Like '%"+ keyword + "%' OR DisplayName Like '%"+ keyword + "%' ";
			DataTable dt = DataProvider.Instance.ExecuteQuerry(querry);
			foreach (DataRow row in dt.Rows)
			{
				Account account = new Account(row);
				list.Add(account);
			}
			return list;
		}
		public bool UpdateAccountInfor(string userName, string displayName, string password, string newPassword) 
        {
            int res = DataProvider.Instance.ExecuteNonQuerry("USP_UpdateAccount @username , @displayname , @password , @newPassword", new object[] {userName, displayName, password, newPassword});
            return res > 0;
        }
		public bool UpdateAccount(string userName, string displayName, int type)
		{
			int res = DataProvider.Instance.ExecuteNonQuerry(string.Format("UPDATE Account SET DisplayName = N'{1}', Type = {2} WHERE UserName = N'{0}'", userName, displayName, type));
			return res > 0;
		}
		public bool InsertAccount(string userName, string displayName, int type)
        {
            string querry = string.Format("INSERT INTO Account (UserName, DisplayName, Password,Type) VALUES ('{0}', N'{1}', '1', {2})", userName, displayName, type);
            int res = DataProvider.Instance.ExecuteNonQuerry(querry);
            return res > 0;
        }
        public bool ResetPassword(string userName)
        {
			int res = DataProvider.Instance.ExecuteNonQuerry("UPDATE Account SET Password = 1 WHERE UserName = '"+userName+"'");
			return res > 0;
		}
        public bool DeleteAccount(string userName)
        {
            int res = 0;
            List<HoaDon> list = new List<HoaDon>();
            list = HoaDonDAO.Instance.GetHoaDonByIDNguoiTao(userName);
            foreach( HoaDon hoaDon in list )
            {
                if (!HoaDonDAO.Instance.UpdateNguoiTaoNullByIDHoaDon(hoaDon.Id))
                {
                    MessageBox.Show("Lỗi khi cập nhật người tạo null trên các hóa đơn!");
                    return false;
                }
            }
            List<PhieuNhap> listPN = new List<PhieuNhap>();
            listPN = PhieuNhapDAO.Instance.GetPhieuNhapByIDNguoiTao(userName);
            foreach(PhieuNhap phieuNhap in listPN)
            {
                if (!PhieuNhapDAO.Instance.UpdateNguoiTaoNullByIDPhieuNhap(phieuNhap.Id))
                {
                    MessageBox.Show("Lỗi khi cập nhật người tạo null trên các phiếu nhập!");
                    return false;
                }
            }
            string querry = "DELETE Account Where UserName = '" + userName + "'";
            res = DataProvider.Instance.ExecuteNonQuerry(querry);
            return res > 0;
        }
    }
}
