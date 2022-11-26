﻿namespace Pkup.Console.Report
{
    public interface IReportService
    {
        void Report(
            string[] repositoriesSources,
            string authorName,
            DateTimeOffset? fromDate,
            DateTimeOffset? toDate,
            string projectName,
            string templatePath,
            string reportPath,
            Dictionary<string, string> tokens);
    }
}