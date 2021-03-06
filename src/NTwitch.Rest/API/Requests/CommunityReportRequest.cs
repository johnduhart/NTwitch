﻿namespace NTwitch.Rest
{
    internal class CommunityReportRequest : RestRequest
    {
        public CommunityReportRequest(string token, string id, ulong channelId) 
            : base("GET", $"communities/{id}/report_channel", token)
        {
            Parameters.Add("channel_id", channelId);
        }
    }
}
