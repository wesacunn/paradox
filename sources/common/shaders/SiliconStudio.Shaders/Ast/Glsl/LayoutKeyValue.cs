// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
namespace SiliconStudio.Shaders.Ast.Glsl
{
    /// <summary>
    /// LayoutKey value node.
    /// </summary>
    public class LayoutKeyValue : Node
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutKeyValue"/> class.
        /// </summary>
        public LayoutKeyValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutKeyValue"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public LayoutKeyValue(Identifier name)
        {
            Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutKeyValue"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public LayoutKeyValue(Identifier name, LiteralExpression value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutKeyValue"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public LayoutKeyValue(Identifier name, object value)
        {
            Name = name;
            Value = new LiteralExpression(value);
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public Identifier Name { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public LiteralExpression Value { get; set; }

        /// <inheritdoc/>
        public override System.Collections.Generic.IEnumerable<Node> Childrens()
        {
            ChildrenList.Clear();
            ChildrenList.Add(Name);
            ChildrenList.Add(Value);
            return ChildrenList;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format("{0}{1}", Name, Value == null ? string.Empty : "=" + Value);
        }
    }
}