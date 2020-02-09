namespace hohsys.API.dtos
{
    public class UserForDetailsDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Profession { get; set; }
        public string FullName { get { return $"{Name} {Lastname}"; } }
        public string ProfilePicture { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}