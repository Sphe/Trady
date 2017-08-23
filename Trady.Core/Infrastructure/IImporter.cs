﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Trady.Core.Period;

namespace Trady.Core
{
    public interface IImporter
    {
        // startTime & endTime should be inclusive
        Task<IEnumerable<Candle>> ImportAsync(string symbol, DateTime? startTime = null, DateTime? endTime = null, PeriodOption period = PeriodOption.Daily, CancellationToken token = default(CancellationToken));
    }
}