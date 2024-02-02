using System.IO;
using System.Xml.Xsl;

const string rootFolder = @"C:\Users\Nick\Google Drive\GAS\Financial\2023-2024\Invoices";
const string no = "523";

var xslt = new XslCompiledTransform();
xslt.Load( Path.Combine(rootFolder, "InvoiceMonthlyBootstrap.xslt"));
xslt.Transform(Path.Combine(rootFolder, $"{no}.xml"), Path.Combine(rootFolder, $"{no}.html"));