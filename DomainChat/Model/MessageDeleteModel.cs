﻿using DomainChat.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainChat.Model
{
    public class MessageDeleteModel
    {
        public string DeleteType { get; set; }
        public Message Message { get; set; }
        public string DeletedUserId { get; set; }
    }
}
