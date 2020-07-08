using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoMusicSplitter
{
	public class VMSConfigReader
	{
		private Dictionary<string, string> vmsExtensions = new Dictionary<string, string>();
		public string Extension
		{
			get
			{
				string extension = string.Empty;
				int index = 0;
				foreach (var kpl in vmsExtensions)
				{
					extension += kpl.Value;
					if (index != vmsExtensions.Count - 1)
					{
						extension += ";";
					}
					index++;
				}
				return extension;
			}
		}


		public VMSConfigReader()
		{
			vmsExtensions = new Dictionary<string, string>();
		}

		public void Read(string configFile)
		{
			using (StreamReader reader = new StreamReader(configFile))
			{
				while (reader.Peek() > -1)
				{
					string line = reader.ReadLine();
					string[] tokens = line.Trim().Split('=');
					if (!vmsExtensions.ContainsKey(tokens[0]))
					{
						vmsExtensions.Add(tokens[0], tokens[1]);
					}
				}
			}
		}
	}
}
