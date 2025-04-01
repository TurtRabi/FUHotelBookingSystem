﻿using System;
using System.Collections.Generic;

namespace PRN222.Assignment.FUHotelBookingSystem.Repository.Model;

public partial class Message
{
    public int Id { get; set; }

    public int SenderId { get; set; }

    public int ReceiverId { get; set; }

    public string Message1 { get; set; } = null!;

    public DateTime? SentAt { get; set; }

    public virtual User Receiver { get; set; } = null!;

    public virtual User Sender { get; set; } = null!;
}
