﻿using System;
using System.Collections.Generic;
using DomainLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceLayer.Repository;

namespace TestLayer
{
    [TestClass]
    public class UserTest
    {
        UserRepository _user=new UserRepository();

        [TestMethod]
        public async void AddItem()
        {
            var find=await _user.Add(new User()
            {
                Name="tohid",
                Password="tohid0123",
                Username="tohid"
            });
            Assert.IsFalse(find);
        }

        [TestMethod]
        public void GetItem()
        {

        }

        [TestMethod]
        public void UpdateItem()
        {

        }

        [TestMethod]
        public void DeleteItem()
        {

        }
    }
}
