using FluentNHibernate.Mapping;
using SOP_API.DBClasses.Models;

namespace SOP_API.DBClasses.ClassMaps
{
    public class FileNoteClassMap: ClassMap<FileNote>
    {
        public FileNoteClassMap()
        {
            Id(x => x.ID);
            Map(x => x.Name);
            Map(x => x.Description);
            HasOne(x => x.LabTest);
            Table("FileNote");
        }
    }
}
