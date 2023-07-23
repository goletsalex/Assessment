using System;

namespace UndoAssessment.Models
{
    public class User: IModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
    }
}
