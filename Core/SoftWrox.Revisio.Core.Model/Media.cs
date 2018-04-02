using System;
using SoftWrox.Core.Model;

namespace SoftWrox.Revisio.Core.Model
{
    public class Media : IModel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int FamilyId { get; set; }
        public int CustodianId { get; set; }
        public string Description { get; set; }
    }
}