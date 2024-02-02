using System;
using System.IO;
using System.Xml.Xsl;
using System.Diagnostics;

const string rootFolder = @"C:\Users\Nick\Google Drive\GAS\Financial\2023-2024\Invoices";
const string no = "523";
const string outputFile = $"{no}.html";

var xslt = new XslCompiledTransform();
xslt.Load( Path.Combine(rootFolder, "InvoiceMonthlyBootstrap.xslt"));
xslt.Transform(Path.Combine(rootFolder, $"{no}.xml"), outputFile);

var url = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outputFile);

Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });


