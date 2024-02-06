using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurspr5sem
{
	public class MenuElem
	{
		public int item_id;
		public string item_name;
		public int item_count;
		public MenuElem(int item_id, string item_name, int item_count) 
		{
			this.item_id = item_id;
			this.item_name = item_name;
			this.item_count = item_count;
		}
	}
}
