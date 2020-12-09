using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using Amazon.S3.Model;

namespace Jashan_ImageRec_Lambda
{
    [DynamoDBTable("Lab4")]
    class ImageMetadata
    {
        [DynamoDBHashKey]
        public string ImageKey { get; set; }

        [DynamoDBProperty("Tags")]
        public List<Tag> TagsList { get; set; }
    }
}
