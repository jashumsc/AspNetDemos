using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace MyAspDemos.xUnitTestProject
{
    public partial class BooksApiTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public BooksApiTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

    }
}