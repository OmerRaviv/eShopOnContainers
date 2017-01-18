﻿namespace Microsoft.eShopOnContainers.Services.Ordering.Api.Application.Commands
{
    using System;
    using MediatR;
    using Domain;
    using System.Collections;
    using System.Collections.Generic;

    //(CDLTLL) TO DO: This is wrong, we must NOT use a child-entity class within a Command class!!
    //Need to create a different DTO class, like OrderLineDTO or similar...
    using Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.OrderAggregate;

    public class NewOrderCommand
        :IAsyncRequest<bool>
    {
        //(CDLTLL) TO DO: This is wrong, we must NOT use a child-entity class within a Command class!!
        //Need to create a different DTO class, like OrderLineDTO or similar...
        private readonly List<OrderItem> _orderItems;
        public string City { get; set; }

        public string Street { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public string CardNumber { get; set; }

        public string CardHolderName { get; set; }

        public DateTime CardExpiration { get; set; }

        public string CardSecurityNumber { get; set; }

        public int CardTypeId { get; set; }

        public string Buyer { get; set; }

        public IEnumerable<OrderItem> OrderItems => _orderItems;

        public void AddOrderItem(OrderItem item)
        {
            _orderItems.Add(item);
        }

        public NewOrderCommand()
        {
            _orderItems = new List<OrderItem>();
        }
    }
}