using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityPractice.Models
{
	public class Message
	{
		public virtual int Id { get; set; }
		public virtual string Body { get; set; }
	}
}