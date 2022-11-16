namespace KTSD.Core.Models
{
    public class ContactInfo: BaseEntity
    {
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string FacebookLink { get; set; }
        public string LinkedinLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string TiktokLink { get; set; }
    }
}