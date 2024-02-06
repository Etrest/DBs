using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurspr5sem
{
	public class UserInfo
	{
		internal string nick;
		internal int acc_level;
		internal int adm_status;

		public UserInfo(string nick, int acc_level, int adm_status)
		{
			this.nick = nick;
			this.acc_level = acc_level;
			this.adm_status = adm_status;
			
		}	
	}
}
