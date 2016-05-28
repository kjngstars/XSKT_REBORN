using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DoiTacObject
    {
        public string MaDoiTac { get; set; }
        public string TenDoiTac { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public int Rate { get; set; }
        
        public string GetDateTime()
        {
            return NgayTiepNhan.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
