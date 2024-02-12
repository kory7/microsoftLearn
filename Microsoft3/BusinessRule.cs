using System;
namespace Microsoft3
{
	public class BusinessRule
	{
		public string Permission { get; set; }
		public int Level { get; set; }

		public void PermissionMessage()
		{
			if(this.Permission.Contains("Admin"))
			{
				if (this.Level > 55)
				{
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }

            }else if (this.Permission.Contains("Manager"))
			{
				if(this.Level >= 20)
				{
					Console.WriteLine("Contact an Admin for access.");
				}
				else
				{
					Console.WriteLine("You do not have sufficient privileges.");
				}
			}
			else
			{
				Console.WriteLine("You do not have sufficient privileges.");
			}
		}
	}

}

