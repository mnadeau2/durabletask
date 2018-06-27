//  ----------------------------------------------------------------------------------
//  Copyright Microsoft Corporation
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  ----------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;

namespace DurableTask.ServiceBus
{
    internal class NamespaceManager
    {
        internal static NamespaceManager CreateFromConnectionString(string connectionString)
        {
            throw new NotImplementedException();
        }

        internal QueueDescription GetQueue(string entityName)
        {
            throw new NotImplementedException();
        }

        internal Task<QueueDescription[]> GetQueuesAsync(string v)
        {
            throw new NotImplementedException();
        }

        internal Task CreateQueueAsync(QueueDescription description)
        {
            throw new NotImplementedException();
        }

        internal Task DeleteQueueAsync(string path)
        {
            throw new NotImplementedException();
        }

        internal static long GetQueueCountAsync(string entityName)
        {
            throw new NotImplementedException();
        }
    }
}