using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ASP.NET_CompanyEmployees_SQL_Server_EF_6.xx.Models
{
    [Table("Department")]
    public partial class Department : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}