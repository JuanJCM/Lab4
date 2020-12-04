using System;
using System.Collections.Generic;
using System.Text;
using Lab.Core.Interfaces;
using Lab.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Lab4.Infrastructure.Serializers
{
    public class JsonFileGameSerializer : IMovementSerializer
    {
        public Movimiento SerializeMovement(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException();
            }

            return JsonConvert.DeserializeObject<Movimiento>(data);
        }
    }
}