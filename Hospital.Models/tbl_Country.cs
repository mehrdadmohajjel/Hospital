using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    //public class tbl_Country
    //{
    //    [Key]public long Id { get; set; }
    //    public string Title { get; set; }
    //    public string Code { get; set; }
    //    public ICollection<tbl_States> States { get; set; }

    //}
    public  class tbl_Country
    {
        public tbl_Country()
        {
            this.tbl_States = new HashSet<tbl_States>();
        }

        [Key] public long Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }

        public virtual ICollection<tbl_States> tbl_States { get; set; }
    }

}
