using System.ComponentModel.DataAnnotations;

namespace JAM_mkII.Models.DomainModels
{
    public class Store
    {
        [Key] public int StoreId { get; set; }

        public string StoreName { get; set; }
        public int ManagerId { get; set; }
        public int StaffReq { get; set; }
    }
}