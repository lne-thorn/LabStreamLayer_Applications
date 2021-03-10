using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSL;


namespace EmpaticaE4_Recorder
{
	public class LSLStreamingIBI : LSLStreamer
	{
		/// <summary>
		/// Lab Streaming Layer Variables Following
		/// </summary>
		private const string guid = "2C711D79-4064-46B7-87DC-2F27F07E0E8A"; // Unique Process ID -- Pre-Generated

		private const string lslStreamName = "Empatica Streamer (IBI)";
		private const string lslStreamType = "IBI-Signals";
		private const double sampling_rate = 0.0; // Default Value
		
		private const int lslChannelCount = 1; // Number of Channels to Stream by Default

		private const liblsl.channel_format_t lslChannelFormat = liblsl.channel_format_t.cf_double64; // Stream Variable Format

		// The Constructor Immediately creates a new link between LSL and the application
		public LSLStreamingIBI(string PlayerID) : base(lslStreamName + "-" + PlayerID, lslStreamType, lslChannelCount, sampling_rate, lslChannelFormat, guid + "-" + PlayerID)
		{
			
		}
	}
}
