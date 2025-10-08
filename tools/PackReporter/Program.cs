using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Linq;
using System.Text;

class Program
{
    static int Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.Error.WriteLine("Usage: PackReporter <nupkg-path> <report-path>");
            return 2;
        }

        var nupkg = args[0];
        var report = args[1];

        if (!File.Exists(nupkg))
        {
            Console.Error.WriteLine($"nupkg not found: {nupkg}");
            return 3;
        }

        try
        {
            using var z = ZipFile.OpenRead(nupkg);
            var nuspecEntry = z.Entries.FirstOrDefault(e => e.FullName.EndsWith(".nuspec", StringComparison.OrdinalIgnoreCase));
            var sb = new StringBuilder();

            sb.AppendLine($"Detailed package report for: {Path.GetFileName(nupkg)}");
            sb.AppendLine($"Generated: {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC");
            sb.AppendLine();

            if (nuspecEntry != null)
            {
                using var ns = nuspecEntry.Open();
                var doc = XDocument.Load(ns);
                var metadata = doc.Root?.Element(XName.Get("metadata"));
                if (metadata != null)
                {
                    string Get(string name) => metadata.Element(XName.Get(name))?.Value?.Trim() ?? string.Empty;

                    sb.AppendLine("Metadata:");
                    sb.AppendLine($"- id: {Get("id")}");
                    sb.AppendLine($"- version: {Get("version")}");
                    sb.AppendLine($"- description: {Get("description")}");
                    sb.AppendLine($"- authors: {Get("authors")}");
                    sb.AppendLine($"- owners: {Get("owners")}");
                    sb.AppendLine($"- license: {Get("license")}");
                    sb.AppendLine($"- projectUrl: {Get("projectUrl")}");
                    sb.AppendLine($"- repository: {Get("repository")}");
                    sb.AppendLine();
                }
            }

            sb.AppendLine("Contents:");
            foreach (var e in z.Entries.OrderBy(x => x.FullName))
            {
                sb.AppendLine("- " + e.FullName);
            }

            Directory.CreateDirectory(Path.GetDirectoryName(report)!);
            File.WriteAllText(report, sb.ToString(), Encoding.UTF8);

            Console.WriteLine("PackReporter: wrote report to " + report);
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
            return 1;
        }
    }
}
