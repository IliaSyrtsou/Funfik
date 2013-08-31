using System;
using System.Collections.Generic;
using Funfik.Core.Entities;

namespace Funfik.Web.Areas.Default.Models
{
    public class UserModel
    {
        public virtual int Id { get; private set; }

        public virtual String Username { get; set; }

        public virtual ICollection<Article> Articles { get; set; }   
    }
}