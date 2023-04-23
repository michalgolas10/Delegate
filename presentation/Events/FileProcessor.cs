namespace Events;

public class FileProcessor
{
    //public delegate void MyCustomEvent(object sender, EventArgs args);

    public event EventHandler FileProcessedSuccessfully;
    public event EventHandler FileProcessingError;

    public void ProcessFile(string fileContent)
    {
        try
        {
            if (fileContent.Length > 6)
            {
                throw new Exception("File too big");
            }

            FileProcessedSuccessfully?.Invoke(this, EventArgs.Empty);            
        }
        catch
        {
            // error
            FileProcessingError.Invoke(this, EventArgs.Empty);
        }
    }
}
