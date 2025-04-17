// SOLID: O: Open-Close Principle
using System.Data;

public class FileExport
{
    public void ExportToCSV (string filepath, DataTable data )
    {
        // Code To Export Data To CSV File.
    }
}


// The Code Above Doesn Not Obey SOLID/OCP.
//What If There Was A Json Export Needed As Well?
// The Corrected Format:

public abstract class FileExporter
{
    public abstract void Export(string filepath, DataTable data);
}
public class CsvFileExporter : FileExporter
{
    public override void Export(string filepath, DataTable data)
    {
        // Code Logic To Export File To CSV File.
    }
}
public class ExcelFileExporter : FileExporter
{
    public override void Export(string filepath, DataTable data)
    {
        // Code Logic To Export File To Excel File.
    }
}
public class JsonFileExporter : FileExporter
{
    public override void Export(string filepath, DataTable data)
    {
        // Code Logic To Export File To JSON File.
    }
}