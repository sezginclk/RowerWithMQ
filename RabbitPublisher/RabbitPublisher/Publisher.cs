using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitPublisher
{
    public class Publisher
    {


        private readonly RabbitMQService _rabbitMQService;

        public Publisher(string queueName, string message)
        {

            _rabbitMQService = new RabbitMQService();


            using (var connection = _rabbitMQService.GetRabbitMQConnection())
            {
                using (var chanel = connection.CreateModel())
                {

                    chanel.QueueDeclare(queueName, false, false, false, null);
                    chanel.BasicPublish("", queueName, null, Encoding.UTF8.GetBytes(message));

                    
                }



            }
        }


    }
}
