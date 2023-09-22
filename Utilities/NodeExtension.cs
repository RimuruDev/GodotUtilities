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
using System;

namespace RimuruDev.GodotUtilities
{
    public static class NodeExtension
    {
        /// <summary>
        /// Finding a node, and safely retrieving the script from it.
        /// </summary>
        /// <example>
        /// <code>
        ///public override void _Ready()
        ///{
        ///    if (this.TryGetNode("TestComponent", out TestComponent testComponent))
        ///        testComponent.DoSomething();
        ///    else
        ///        Debug.Log("Unable to get TestComponent node");
        ///
        ///    if (this.TryGetNode("PlayerBody", out PlayerBodyNode playerBody))
        ///        playerBody.PrintPlayerName();
        ///    else
        ///        Debug.Log("Unable to get Player node");
        ///}
        /// </code>
        /// </example>
        public static bool TryGetNode<TComponent>(this Node thisNode, string nodeName, out TComponent node) where TComponent : class
        {
            if (thisNode == null)
                throw new NullReferenceException("The node to which the action is attached is null.");

            if (string.IsNullOrWhiteSpace(nodeName))
                throw new ArgumentException(nameof(nodeName));

            node = null;

            var currentNode = thisNode.GetNode(nodeName);

            if (!(currentNode is TComponent component))
                return false;

            node = component;
            return true;
        }
    }
}