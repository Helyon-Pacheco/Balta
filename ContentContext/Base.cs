using System;
using Balta.NotificationContext;

namespace Balta.ContentContext{
    public class Base : Notifiable{
        public Base(){
            Id = Guid.NewGuid(); // SPOF
        }

        public Guid Id { get; set; }
    }
}