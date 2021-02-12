using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Brotherhood.API.Helpers
{
    public class FileUploadAzure : IFileUpload
    {
        private readonly string db;

        public FileUploadAzure(IConfiguration configuration)
        {
            db = configuration.GetConnectionString("Azure-Brotherhood_Storage");
        }
        public async Task DeleteFile(string Folder, string FileUrl)
        {
            var account = CloudStorageAccount.Parse(db);
            var Client = account.CreateCloudBlobClient();
            var folder = Client.GetContainerReference(Folder);

            var blobName = Path.GetFileName(FileUrl);
            var blob = folder.GetBlockBlobReference(blobName);
            await blob.DeleteIfExistsAsync();
        }

        public async Task<string> EditFile(byte[] content, string extention, string Folder, string ActFileUrl)
        {
            if (!string.IsNullOrEmpty(ActFileUrl))
            {
                await DeleteFile(ActFileUrl, Folder);
            }

            return await SaveFile(content, extention, Folder);
        }

        public async Task<string> SaveFile(byte[] content, string extention, string Folder)
        {
            var account = CloudStorageAccount.Parse(db);
            var Client = account.CreateCloudBlobClient();
            var folder = Client.GetContainerReference(Folder);
            await folder.CreateIfNotExistsAsync();
            await folder.SetPermissionsAsync(new BlobContainerPermissions 
            { 
                PublicAccess = BlobContainerPublicAccessType.Blob
            });

            var FileName = $"{Guid.NewGuid()}.{extention}";
            var blob = folder.GetBlockBlobReference(FileName);
            await blob.UploadFromByteArrayAsync(content, 0, content.Length);
            blob.Properties.ContentType = "image/jpg";
            await blob.SetPropertiesAsync();
            return blob.Uri.ToString();
        }
    }
}
