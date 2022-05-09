using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintPdf.Models
{
    public class FormOvertimeRequestModel
    {
        public string form_id { get; set; }
        public string employee_name { get; set; }
        public string job_id { get; set; }
        public string location { get; set; }
        public string site_name { get; set; }
        public bool withdrawal { get; set; }
        public DateTime normal_start_date { get; set; }
        public DateTime normal_stop_date { get; set; }
        public TimeSpan normal_start_time { get; set; }
        public TimeSpan normal_stop_time { get; set; }
        public DateTime offday_start_date { get; set; }
        public DateTime offday_stop_date { get; set; }
        public TimeSpan offday_start_time { get; set; }
        public TimeSpan offday_stop_time { get; set; }
        public string objective { get; set; }
    }
}
