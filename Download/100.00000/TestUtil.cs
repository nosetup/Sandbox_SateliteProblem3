﻿using System;
using System.Diagnostics;
public static class TestUtil
{
    public const string BOLD = "\u001b[1m";
    public const string GRAY = "\u001b[38;5;248m";
    public const string CYAN = "\u001b[36m";
    public const string RED = "\u001b[31m";
    public const string GREEN = "\u001b[32m";
    public const string YELLOW = "\u001b[33m";
    public const string RESET = "\u001b[0m";

    public static void Check(bool condition, string message)
    {
        if (!condition)
        {
            Fail(message);
        }
        else
        {
           // Console.WriteLine($"SUCCESS: {message}"); // Success will have no messages.
        }
    }

    public static void Fail(string message)
    {
        Console.WriteLine($"FAIL: {message}");
        // Environment.Exit(1); // no need to exit.
    }
}
