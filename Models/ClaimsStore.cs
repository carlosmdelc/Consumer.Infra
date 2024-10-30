using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Infra.Models
{
	public static class ClaimsStore
	{
		public static List<Claim> Claims =
		[
			new Claim("Create", "Create"),
			new Claim("Edit", "Edit"),
			new Claim("Delete", "Delete")
		];
	}
}
