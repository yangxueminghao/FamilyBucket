﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bucket.Event.KafkaClient.Model
{

    public class StudentMessage
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
