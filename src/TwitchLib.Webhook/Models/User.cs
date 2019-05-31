using System;
using Newtonsoft.Json;

namespace TwitchLib.Webhook.Models
{
	public class User
	{
		[JsonProperty("data")]
		public UserData[] Data { get; set; }
	}
}
