﻿using System;
using Newtonsoft.Json;

namespace WebHookster
{
    /// <summary>
    /// Represents a video inside an embed.
    /// </summary>
    public sealed class EmbedVideo
    {
        /// <summary>
        /// Gets the source url of the video.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; internal set; }

        /// <summary>
        /// Gets the height of the video.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int Height { get; internal set; }

        /// <summary>
        /// Gets the width of the video.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int Width { get; internal set; }

        internal EmbedVideo() { }
    }
}