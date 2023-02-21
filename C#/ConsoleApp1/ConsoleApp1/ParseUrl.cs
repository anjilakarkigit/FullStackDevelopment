using System;
namespace ConsoleApp1
{
	public class ParseUrl
	{
		public void Parse()
		{
            string url = "https://www.apple.com/iphone";

            // Split the URL into protocol, server, and resource
            string[] urlParts = url.Split(new char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);

            // Extract the parts
            string protocol = urlParts.Length >= 2 ? urlParts[0] : "";
            string server = urlParts.Length >= 1 ? urlParts[1] : "";
            string resource = urlParts.Length >= 3 ? url.Substring(url.IndexOf(server) + server.Length + 1) : "";

            // Output the parts to the console
            Console.WriteLine("Protocol: {0}", protocol);
            Console.WriteLine("Server: {0}", server);
            Console.WriteLine("Resource: {0}", resource);
        }

	}
}

