using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RabbitConsumer
{
    public class Consumer
    {
        private readonly RabbitMQService _rabbitMQService;
        public string _queue { get; set; }


        public Consumer(string queueName)
        {
            _rabbitMQService = new RabbitMQService();

            using (IConnection connection = new ConnectionFactory().CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {



                    channel.QueueDeclare(queueName, false, false, false, null);
                    var consumer = new EventingBasicConsumer(channel);
                    BasicGetResult result = channel.BasicGet(queueName, true);
                    if (result != null)
                    {
                        string data =
                        Encoding.UTF8.GetString(result.Body);
                        _queue = data;
                    }

                }
            }
        }
    }
}
