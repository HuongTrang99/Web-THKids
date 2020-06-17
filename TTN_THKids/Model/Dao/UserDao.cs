using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using System.Data.SqlClient;

namespace Model.Dao
{
    public class UserDao
    {
        TTN_THKidsDbConText db = null;
        public UserDao()
        {
            db = new TTN_THKidsDbConText();
        }
        public string Insert (KhachHang entity)
        {
            db.KhachHangs.Add(entity);
            db.SaveChanges();
            return entity.MaKhachHang;
        }
        public bool Login(string TenDangNhap, string MatKhau)
        {
            var result = db.KhachHangs.Count(x => x.TenDangNhap == TenDangNhap && x.MatKhau == MatKhau);
            if (result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
