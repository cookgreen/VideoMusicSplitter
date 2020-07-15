using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoMusicSplitter.Common
{
	public class SplitInfoTextCollection
	{
		private string videoTotalTime;
		private List<SplitInfoText> splitInfoTexts;
		public SplitInfoTextCollection(string videoTotalTime)
		{
			this.videoTotalTime = videoTotalTime;
			splitInfoTexts = new List<SplitInfoText>();
		}

		public void Append(SplitInfoText splitInfoText)
		{
			splitInfoTexts.Add(splitInfoText);
		}

		public List<VideoSplitterInfo> ToSIF()
		{
			List<VideoSplitterInfo> splitterInfos = new List<VideoSplitterInfo>();

			for (int i = 0; i < splitInfoTexts.Count; i++)
			{
				VideoSplitterInfo vsi = new VideoSplitterInfo();
				vsi.StartTime = splitInfoTexts[i].StartTime;
				if (i != splitInfoTexts.Count - 1)
				{
					vsi.EndTime = splitInfoTexts[i + 1].StartTime;
				}
				else
				{
					vsi.EndTime = videoTotalTime;
				}
				vsi.Name = splitInfoTexts[i].Name;
			}

			return splitterInfos;
		}
	}
}
