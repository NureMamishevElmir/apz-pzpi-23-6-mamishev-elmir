using Amazon.S3;
using Amazon.S3.Transfer;
 
var client = new AmazonS3Client();
var utility = new TransferUtility(client);
  
await utility.UploadAsync(
    "local_file.txt",
    "my-bucket",
    "remote_file.txt"
);

var http = new HttpClient();
http.DefaultRequestHeaders
.Add("Authorization", "Bearer " + token);
  
var response = await http.PostAsync(
    "https://api.example.com/process",
    new StringContent("{\"data\":\"value\"}")
);
