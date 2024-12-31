using Azure.Storage.Blobs;
using EGreetings.Models;
using Microsoft.Extensions.Options;

namespace EGreetings.Services
{
    public class BlobStorageService
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string _containerName;

        public BlobStorageService(BlobServiceClient blobServiceClient, IOptions<AzureBlobStorageSettings> azureSettings)
        {
            _blobServiceClient = blobServiceClient;
            _containerName = azureSettings.Value.ContainerName;
        }

        public async Task<string> UploadFileAsync(string filePath, Stream fileStream)
        {
            // Get the container client
            var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);

            // Create container if it doesn't exist
            await containerClient.CreateIfNotExistsAsync();

            // Get the blob client
            var blobClient = containerClient.GetBlobClient(filePath);  // filePath is the name of the file you're uploading

            // Upload the file stream
            await blobClient.UploadAsync(fileStream, overwrite: true);  // overwrite = true to replace if file exists

            // Return the URI of the uploaded file
            return blobClient.Uri.AbsoluteUri;
        }
    }
}
