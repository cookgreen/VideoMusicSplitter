namespace VideoMusicSplitter
{
    public class VideoSplitterInfo
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Name { get; set; }
		public string Text
        {
			get
			{
                return string.Format("{0}-{1} {2}", StartTime, EndTime, Name);
			}
        }
	}
}
