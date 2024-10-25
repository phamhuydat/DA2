using Data.Entities.Base;

namespace Data.Entities
{
    public class GroupDetails : AppEntityBase
    {
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public bool Display { get; set; }

        //fk
        public Group Group { get; set; }
        public Users User { get; set; }
    }
}