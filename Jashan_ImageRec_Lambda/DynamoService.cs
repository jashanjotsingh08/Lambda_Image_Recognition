using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;

namespace Jashan_ImageRec_Lambda
{
    public class DynamoService : ITableDataService
    {
        public readonly DynamoDBContext DbContext;
        private readonly AmazonDynamoDBClient client;
        private readonly BasicAWSCredentials credentials;

        public DynamoService()
        {

            credentials = new BasicAWSCredentials("AKIAZRP7NAAVXIVECSX4", "SdfBccnRhVvstVe2NaR/Y3L2jCbIwrv19d/Gw3JV");
            client = new AmazonDynamoDBClient(credentials, RegionEndpoint.USEast2);
            //SingleTableBatchWrite(DbContext);

            DbContext = new DynamoDBContext(client, new DynamoDBContextConfig
            {
                //Setting the Consistent property to true ensures that you'll always get the latest 
                ConsistentRead = true,
                SkipVersionCheck = true
            });
        }


        public async Task Store<T>(T item) where T : new()
        {
            await DbContext.SaveAsync(item);
        }

      
    }
}
