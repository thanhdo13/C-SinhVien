using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastOne.Properties
{
    public class SinhVien

    {
        [Key]
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public SEX GioiTinh { get; set; }
        public ChuyenNganh chuyennganh { get; set; }
        public float cn1 { get; set; }
        public float cn2 { get; set; }
        public static List<SinhVien> getSinhVienListFromDB()
        {
            return new AppContent().sinhVienDbset.OrderBy(e => e.MaSinhVien).ToList();
        }
        public static void Remove(SinhVien sv)
        {
            var db = new AppContent();
            var objSV = db.sinhVienDbset.Where(e => e.MaSinhVien == sv.MaSinhVien).FirstOrDefault();
            if (objSV != null)
            {
                db.sinhVienDbset.Remove(objSV);

            }
            db.SaveChanges();
        }
        public static void Add(SinhVien sv)
        {
            var db = new AppContent(); db.sinhVienDbset.Add(sv);
            db.SaveChanges();
        }
        public static void Edit(SinhVien sv)
        {
            var db = new AppContent();
            var objSV = db.sinhVienDbset.Where(e => e.MaSinhVien == sv.MaSinhVien).FirstOrDefault();
            if (objSV != null)
            {
                objSV.NgaySinh = sv.NgaySinh;
                objSV.HoTen = sv.HoTen;
                objSV.GioiTinh = sv.GioiTinh;
                objSV.chuyennganh = sv.chuyennganh;
                objSV.cn1 = sv.cn1;
                objSV.cn2 = sv.cn2;

            }
            db.SaveChanges();
        }
    }
    
    public enum SEX
    {
         Male, Other
    }
    public enum ChuyenNganh
    {
        Van , VatLy , CNTT
    }
}
