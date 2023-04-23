namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileProcessor = new FileProcessor();

            fileProcessor.FileProcessedSuccessfully += OnFileProcessedSuccessfully;
            fileProcessor.FileProcessingError += OnFileProcessingError;

            Console.WriteLine();
            fileProcessor.ProcessFile("abcdef");
            fileProcessor.ProcessFile("123");
            fileProcessor.ProcessFile("mwoahue");
        }

        static void OnFileProcessedSuccessfully(object sender, EventArgs e)
        {
            Console.WriteLine("File processed successfully!");
        }

        static void OnFileProcessingError(object sender, EventArgs myFailedEventArgs)
        {
            Console.WriteLine($"File processing error.");
        }
    }
}