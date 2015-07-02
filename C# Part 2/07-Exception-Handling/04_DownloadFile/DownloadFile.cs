namespace _04_DownloadFile
{
    using System;
    using System.Net;
    using System.Text;

    class DownloadFile
    {
        /*	Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
        	Find in Google how to download files in C#.
        	Be sure to catch all exceptions and to free any used resources in the finally block.*/

        static void Main()
        {
            string fileName = "news-img01.png";
            string fileUrl = @"http://telerikacademy.com/Content/Images/" + fileName;
            StringBuilder result = new StringBuilder();
            
            try 
	        {
                WebClient webClient = new WebClient();

                webClient.DownloadFile(fileUrl, fileName);
                result.AppendLine("Download completed!");
	        }
            catch (ArgumentNullException)
	        {
                result.AppendLine("The address parameter is null.");
	        }
            catch (WebException)
            {
                result.AppendLine(@"The URI formed by combining BaseAddress and address is invalid.
Filename is null or Empty.
The file does not exist.
An error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                result.AppendLine("The method has been called simultaneously on multiple threads.");
            }
            finally
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
