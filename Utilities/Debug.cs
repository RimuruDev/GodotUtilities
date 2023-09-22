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
    public static void Log(params object[] parameters) => GD.Print(parameters);
    public static void LogWarning(string message) => GD.PushWarning(message);
    public static void LogError(string message) => GD.PushError(message);
}