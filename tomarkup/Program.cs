using System;
using System.IO;
using Markdig;
using static System.Console;

if (!(args.Length >= 1
    && File.Exists(args[0])
    && Path.GetExtension(args[0]).ToLowerInvariant() is ".md"))
{
    WriteLine("A valid inputfile must be provided.");
    return;
}

string markup = Markdown.ToHtml(File.ReadAllText(args[0]));

if (args.Length is 2 && Directory.Exists(Path.GetDirectoryName(args[1])))
{
    File.WriteAllText(args[1], markup);
}
else
{
    WriteLine(markup);
}
