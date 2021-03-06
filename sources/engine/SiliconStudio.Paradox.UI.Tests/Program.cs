﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Paradox.UI.Tests.Events;
using SiliconStudio.Paradox.UI.Tests.Layering;

namespace SiliconStudio.Paradox.UI.Tests
{
    public class Program
    {
        public static void Main()
        {
            var uiElementTest = new UIElementLayeringTests();
            uiElementTest.TestAll();

            var panelTest = new PanelTests();
            panelTest.TestAll();

            var controlTest = new ControlTests();
            controlTest.TestAll();

            var stackPanelTest = new StackPanelTests();
            stackPanelTest.TestAll();

            var canvasTest = new CanvasTests();
            canvasTest.TestAll();

            var contentControlTest = new ContentControlTest();
            contentControlTest.TestAll();

            var eventManagerTest = new EventManagerTests();
            eventManagerTest.TestAll();

            var routedEventArgTest = new RoutedEventArgsTest();
            routedEventArgTest.TestAll();

            var uiElementEventTest = new UIElementEventTests();
            uiElementEventTest.TestAll();

            var gridTest = new GridTests();
            gridTest.TestAll();
        }
    }
}
