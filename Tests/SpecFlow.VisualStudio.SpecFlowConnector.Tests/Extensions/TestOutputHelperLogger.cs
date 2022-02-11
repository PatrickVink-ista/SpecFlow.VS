﻿using SpecFlowConnector.Tests;

namespace SpecFlow.VisualStudio.SpecFlowConnector.Tests.Extensions;

public class TestOutputHelperLogger : StringWriterLogger
{
    private readonly TestOutputHelperStringWriter _textWriter;

    public TestOutputHelperLogger(ITestOutputHelper testOutputHelper)
    {
        _textWriter = new TestOutputHelperStringWriter(testOutputHelper);
    }

    protected override StringWriter GetTextWriter(LogLevel level) => _textWriter;
}
