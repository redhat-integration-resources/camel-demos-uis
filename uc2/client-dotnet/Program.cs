/**
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements. See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using Amqp;
//using Amqp.Framing;
//using Amqp.Types;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string url     = "amqp://guest%40cluster1-router-mesh:UosUjVnv@cluster1-router-mesh.poc-uc2.svc:5672";
            string url     = "amqp://cluster1-router-mesh.demo-amq.svc:5672";
            
            //string address = "orders";
            string address = "fulfillment.dotnet";
            Connection.DisableServerCertValidation = true;

            Connection connection = new Connection(new Address(url));
            Session session = new Session(connection);
            SenderLink sender = new SenderLink(session, "test-sender", address);

            int i = 0;

            while(true)
            {
                Message message1 = new Message("{\"status\":\"completed\", \"system_id\":\"backend1\", \"identifier\":\""+i+"\"}");
                        
                sender.Send(message1);
                Console.WriteLine("Message "+(i++)+" sent into queue "+address);
                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}
