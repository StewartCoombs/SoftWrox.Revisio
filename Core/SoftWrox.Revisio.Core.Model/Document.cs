using System;
using SoftWrox.Core.Model;

namespace SoftWrox.Revisio.Core.Model
{
    public class Document : IModel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int FamilyId { get; set; }
        public int MediaId { get; set; }
    }
}
