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
        
        /// <summary>
        /// Gets the owner node, then searches for the specified Node and returns it.
        /// </summary>
        /// <example>
        /// <code>
        ///Hierarchy on scene -> Game -> WorldLayer/Timer
        ///public sealed class FindHeroIcon : Node2D
        ///{
        ///    private const string TimerPath = "WorldLayer/Timer";
        ///    private Timer timer;
        /// 
        ///    public override void _Ready()
        ///    {
        ///        timer = this.GetNodeChildByOwner Timer>(TimerPath);
        ///    }
        ///}
        /// </code>
        /// </example>
        public static TNode GetNodeChildByOwner<TNode>(this Node node, string pathToNode) where TNode : Node
        {
            if (node == null)
                throw new NullReferenceException("The node to which the action is attached is null.");

            if (string.IsNullOrWhiteSpace(pathToNode))
                throw new ArgumentException(nameof(pathToNode));

            var owner = node.GetOwner<Node>();

            if (owner == null)
                throw new NullReferenceException("Owner not found!");

            var targetNode = owner.GetNode<TNode>(pathToNode);

            if (targetNode == null)
                throw new NullReferenceException($"Node by path {pathToNode} not found!");

            return targetNode;
        }

        /// <summary>
        /// Gets the owner node, then searches for the specified Node2d and returns it.
        /// </summary>
        /// <example>
        /// <code>
        ///Hierarchy on scene -> Game -> WorldLayer/Sprite
        ///public sealed class FindHeroIcon : Node2D
        ///{
        ///    private const string HeroIconPath = "WorldLayer/Sprite";
        ///    private Sprite heroSprite;
        ///
        ///    public override void _Ready()
        ///    {
        ///        heroSprite = this.GetNodeChildByOwner2D Sprite>(HeroIconPath);
        ///    }
        ///}
        /// </code>
        /// </example>
        public static TNode2d GetNodeChildByOwner2D<TNode2d>(this Node2D node, string pathToNode) where TNode2d : Node2D
        {
            if (node == null)
                throw new NullReferenceException("The node to which the action is attached is null.");

            if (string.IsNullOrWhiteSpace(pathToNode))
                throw new ArgumentException(nameof(pathToNode));

            var owner = node.GetOwner<Node>();

            if (owner == null)
                throw new NullReferenceException("Owner not found!");

            var targetNode = owner.GetNode<TNode2d>(pathToNode);

            if (targetNode == null)
                throw new NullReferenceException($"Node by path {pathToNode} not found!");

            return targetNode;
        }
    }
}