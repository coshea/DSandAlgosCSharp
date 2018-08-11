using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewCakeProblems.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeUnitTests.Design
{
    [TestClass()]
    public class LRUCacheTests
    {
        [TestMethod()]
        public void LRUCacheTest_ExampleProblem1()
        {
            LRUCache cache = new LRUCache(2 /* capacity */ );

            cache.Put(1, 1);
            cache.Put(2, 2);
            Assert.AreEqual(1, cache.Get(1));
            cache.Put(3, 3);    // evicts key 2
            Assert.AreEqual(-1, cache.Get(2));       // returns -1 (not found)
            cache.Put(4, 4);    // evicts key 1
            Assert.AreEqual(-1, cache.Get(1));       // returns -1 (not found)
            Assert.AreEqual(3, cache.Get(3));       // returns 3
            Assert.AreEqual(4, cache.Get(4));       // returns 4
        }

        [TestMethod()]
        public void LRUCacheTest_ExampleProblem2()
        {
            //["LRUCache","put", "get", "put", "get", "get"]
            //[[1],        [2,1], [2], [3,2],  [2],    [3]]
            //[null,       null,   1,   null, -1,      2]

            LRUCache cache = new LRUCache(1 /* capacity */ );

            cache.Put(2, 1);
            Assert.AreEqual(1, cache.Get(2));
            cache.Put(3, 2);    // evicts key 2
            Assert.AreEqual(-1, cache.Get(2));       // returns -1 (not found)
            Assert.AreEqual(2, cache.Get(3));       // returns 2
        }

        [TestMethod()]
        public void LRUCacheTest_ExampleProblem3()
        {
            //["LRUCache","put","put","get","put","get","get"]
            //[[2],[2,1],[1,1],[2],[4,1],[1],[2]]

            LRUCache cache = new LRUCache(2 /* capacity */ );

            cache.Put(2, 1);
            cache.Put(1, 1);
            Assert.AreEqual(1, cache.Get(2));

            cache.Put(4, 1);
            Assert.AreEqual(-1, cache.Get(1));
            Assert.AreEqual(1, cache.Get(2));


        }


        [TestMethod()]
        public void LRUCacheTest_ExampleProblem4()
        {
            //["LRUCache","put","put","put","put","get","get","get","get","put","get","get","get","get","get"]
            //[[3],[1,1],[2,2],[3,3],[4,4],[4], [3],[2],[1], [5,5],[1],[2],[3],[4],[5]]

            LRUCache cache = new LRUCache(3 /* capacity */ );

            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(3, 3);
            cache.Put(4, 4);
            Assert.AreEqual(4, cache.Get(4));
            Assert.AreEqual(3, cache.Get(3));
            Assert.AreEqual(2, cache.Get(2));
            Assert.AreEqual(-1, cache.Get(1));
            cache.Put(5, 5);
            Assert.AreEqual(-1, cache.Get(1));
            Assert.AreEqual(2, cache.Get(2));
            Assert.AreEqual(3, cache.Get(3));
            Assert.AreEqual(-1, cache.Get(4));
            Assert.AreEqual(5, cache.Get(5));

        }




        [TestMethod()]
        public void LRUCacheBuiltInTest_ExampleProblem1()
        {
            LRUCacheBuiltIn cache = new LRUCacheBuiltIn(2 /* capacity */ );

            cache.Put(1, 1);
            cache.Put(2, 2);
            Assert.AreEqual(1, cache.Get(1));
            cache.Put(3, 3);    // evicts key 2
            Assert.AreEqual(-1, cache.Get(2));       // returns -1 (not found)
            cache.Put(4, 4);    // evicts key 1
            Assert.AreEqual(-1, cache.Get(1));       // returns -1 (not found)
            Assert.AreEqual(3, cache.Get(3));       // returns 3
            Assert.AreEqual(4, cache.Get(4));       // returns 4
        }

        [TestMethod()]
        public void LRUCacheBuiltInTest_ExampleProblem2()
        {
            //["LRUCache","put", "get", "put", "get", "get"]
            //[[1],        [2,1], [2], [3,2],  [2],    [3]]
            //[null,       null,   1,   null, -1,      2]

            LRUCacheBuiltIn cache = new LRUCacheBuiltIn(1 /* capacity */ );

            cache.Put(2, 1);
            Assert.AreEqual(1, cache.Get(2));
            cache.Put(3, 2);    // evicts key 2
            Assert.AreEqual(-1, cache.Get(2));       // returns -1 (not found)
            Assert.AreEqual(2, cache.Get(3));       // returns 2
        }

        [TestMethod()]
        public void LRUCacheBuiltInTest_ExampleProblem3()
        {
            //["LRUCache","put","put","get","put","get","get"]
            //[[2],[2,1],[1,1],[2],[4,1],[1],[2]]

            LRUCacheBuiltIn cache = new LRUCacheBuiltIn(2 /* capacity */ );

            cache.Put(2, 1);
            cache.Put(1, 1);
            Assert.AreEqual(1, cache.Get(2));

            cache.Put(4, 1);
            Assert.AreEqual(-1, cache.Get(1));
            Assert.AreEqual(1, cache.Get(2));


        }


        [TestMethod()]
        public void LRUCacheBuiltInTest_ExampleProblem4()
        {
            //["LRUCache","put","put","put","put","get","get","get","get","put","get","get","get","get","get"]
            //[[3],[1,1],[2,2],[3,3],[4,4],[4], [3],[2],[1], [5,5],[1],[2],[3],[4],[5]]

            LRUCacheBuiltIn cache = new LRUCacheBuiltIn(3 /* capacity */ );

            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(3, 3);
            cache.Put(4, 4);
            Assert.AreEqual(4, cache.Get(4));
            Assert.AreEqual(3, cache.Get(3));
            Assert.AreEqual(2, cache.Get(2));
            Assert.AreEqual(-1, cache.Get(1));
            cache.Put(5, 5);
            Assert.AreEqual(-1, cache.Get(1));
            Assert.AreEqual(2, cache.Get(2));
            Assert.AreEqual(3, cache.Get(3));
            Assert.AreEqual(-1, cache.Get(4));
            Assert.AreEqual(5, cache.Get(5));

        }

    }
}