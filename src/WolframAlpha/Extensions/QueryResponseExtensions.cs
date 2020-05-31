﻿using System.Linq;
using Genbox.WolframAlpha.Objects;

namespace Genbox.WolframAlpha.Extensions
{
    public static class QueryResponseExtensions
    {
        /// <summary>Gets the primary pod</summary>
        public static Pod GetPrimaryPod(this QueryResponse response)
        {
            if (response.Pods.HasElements())
                return response.Pods.FirstOrDefault(pod => pod.IsPrimary);

            return null;
        }
    }
}