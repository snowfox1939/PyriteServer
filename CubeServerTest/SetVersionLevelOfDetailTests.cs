﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeServerTest
{
    using CubeServer.Model;
    using Microsoft.Xna.Framework;

    [TestClass]
    public class SetVersionLevelOfDetailTests
    {
        [TestMethod]
        public void WorldToCubeTransform()
        {
            BoundingBox worldBounds = new BoundingBox(new Vector3(-10, -10, -10), new Vector3(10, 10, 10));
            SetVersionLevelOfDetail detail = new SetVersionLevelOfDetail();
            detail.WorldBounds = worldBounds;
            detail.SetSize = new Vector3(4,4,4);

            var result = detail.ToCubeCoordinates(new Vector3(-5, 5, 0));
            Assert.AreEqual(1,result.X);
            Assert.AreEqual(3, result.Y);
            Assert.AreEqual(2, result.Z);
        }

        [TestMethod]
        public void CubeToWorldTransform()
        {
            BoundingBox worldBounds = new BoundingBox(new Vector3(-10, -10, -10), new Vector3(10, 10, 10));
            SetVersionLevelOfDetail detail = new SetVersionLevelOfDetail();
            detail.WorldBounds = worldBounds;
            detail.SetSize = new Vector3(4, 4, 4);

            var result = detail.ToWorldCoordinates(new Vector3(1, 3, 2));
            Assert.AreEqual(-5, result.X);
            Assert.AreEqual(5, result.Y);
            Assert.AreEqual(0, result.Z);
        }
    }
}
