using System;
using System.Collections.Generic;
using System.Text;

namespace MagicBus.Common.Models
{
    public class BaseModel 
    {
        private string _id;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public DateTime CreatedAt
        {
            get => _createdAt;
            set => _createdAt = value;
        }

        public DateTime UpdatedAt
        {
            get => _updatedAt;
            set => _updatedAt = value;
        }
    }
}
