using QuestPdfDemo;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

QuestPDF.Settings.License = LicenseType.Community;

var filePath = "invoice.pdf";
var model = InvoiceDocumentDataSource.GetInvoiceDetails();
var document = new InvoiceDocument(model);
document.GeneratePdf(filePath);
