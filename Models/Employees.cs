using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ASP.NET_CompanyEmployees_SQL_Server_EF_6.xx.Models
{
    [Table("Employee")]
    public partial class Employee : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Age { get; set; }

        public float? Salary { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department
        { get => m_Department; set { m_Department = value; OnPropertyChanged(); } }
        private Department m_Department;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}