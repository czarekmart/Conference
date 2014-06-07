using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conference.Models
{
	public class ConferenceContextInitializer : DropCreateDatabaseAlways<ConferenceContext>
	{
		protected override void Seed(ConferenceContext context)
		{
			context.Sessions.Add(
				new Session() { Title = "I Want Curry",
								Abstract = "The life of curry lover",
								Speaker = context.Speakers.Add(
									new Speaker() { Name = "Cezar Mart",
													EmailAddress = "czarekmart@gmail.com" })
				});
			context.SaveChanges();
		}
	}
}