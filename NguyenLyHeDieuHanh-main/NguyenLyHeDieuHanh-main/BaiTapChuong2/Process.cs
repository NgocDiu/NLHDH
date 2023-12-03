using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapChuong2
{
    public class Process
    {
        // Thuộc tính ID
        public string ID { get; set; }

        // Thuộc tính TS (Thời điểm bắt đầu tiến trình)
        public double TA { get; set; }

        // Thuộc tính TCPU (Thời gian sử dụng CPU)
        public double TCPU { get; set; }

        // Thuộc tính THT (Thời gian lưu lại hệ thống)
        public double TS { get; set; }

        // Thuộc tính TW (Time Waited)
        public double TW { get; set; }

        // Constructor để khởi tạo các thuộc tính
        public Process()
        {
            ID = "";
            TA = 0.0;
            TCPU = 0.0;
            TS = 0.0;
            TW = 0.0;
        }

        public Process(string _id, double _ta, double _tcpu)
        {
            ID = _id;
            TA = _ta;
            TCPU = _tcpu;
        }

        

    }
}
