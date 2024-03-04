using System.IO;
using System.Xml.Xsl;
using System.Diagnostics;

const string rootFolder = @"G:\My Drive\GAS\Financial\2023-2024\Invoices";
const string no = "524";
var outputFile = Path.Combine(rootFolder, $"{no}.html");

var xslt = new XslCompiledTransform();

xslt.Load(Path.Combine(rootFolder, "InvoiceMonthlyBootstrap.xslt"));
xslt.Transform(Path.Combine(rootFolder, $"{no}.xml"), outputFile);

Process.Start(
    new ProcessStartInfo(
        @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
        $"\"{outputFile}\""
    )
);