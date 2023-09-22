// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub Organizations: https://github.com/Rimuru-Dev
//
// **************************************************************** //

using Godot;

public static class Debug
{
    /// <summary>
    /// Wrapper over GD.Print(params object[] parameters);
    /// </summary>
    /// <example>
    /// <code>
    /// var a = new int[] { 1, 2, 3 };
    /// Debug.Log("a", "b", a); // Prints ab[1, 2, 3]
    /// </code>
    /// </example>
    /// <param name="parameters">Arguments that will be printed.</param>
    public static void Log(params object[] parameters) => GD.Print(parameters);
    /// <summary>
    /// Wrapper over GD.PushWarning(string message);
    /// </summary>
    /// <example>
    /// Debug.LogWarning("test warning"); // Prints "test warning" to debugger and terminal as warning call
    /// </example>
    /// <param name="message">Warning message.</param>
    public static void LogWarning(string message) => GD.PushWarning(message);
    /// <summary>
    /// Wrapper over GD.PushError(string message);
    /// </summary>
    /// <example>
    /// <code>
    /// Debug.LogError("test error"); // Prints "test error" to debugger and terminal as error call
    /// </code>
    /// </example>
    /// <param name="message">Error message.</param>
    public static void LogError(string message) => GD.PushError(message);
}