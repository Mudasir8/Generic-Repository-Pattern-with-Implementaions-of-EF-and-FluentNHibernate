using Models;
using FluentNHibernate.Mapping;



namespace DAL.NH.Mappings
{
    public class StudentMapping : ClassMap<Student>
    {
        public StudentMapping()
        {
            Table("Students");
            Id(x => x.ID);

            Map(x => x.FirstName);
            Map(x => x.LastName);
        }
    }
}
