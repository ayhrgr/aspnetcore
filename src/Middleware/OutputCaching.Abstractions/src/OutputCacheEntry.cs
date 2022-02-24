// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.OutputCaching;

public class OutputCacheEntry
{
    public DateTimeOffset Created { get; set; }

    public int StatusCode { get; set; }

    public IHeaderDictionary Headers { get; set; } = default!;

    public CachedResponseBody Body { get; set; } = default!;
    public string[] Tags { get; set; }
}
