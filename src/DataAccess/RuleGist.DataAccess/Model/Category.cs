using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RuleGist.DataAccess.Model
{
	public class Category : Entity
	{
		[Key]
		public int CategoryId { get; set; }
		[MaxLength(64)]
		public string CategoryName { get; set; }
	}
}
