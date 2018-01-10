// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Xml;

namespace System.ServiceModel.Syndication
{
    public struct ParseDateTimeArgs
    {
        internal ParseDateTimeArgs(string dateTimeString, XmlQualifiedName elementQualifiedName)
        {
            DateTimeString = dateTimeString;
            ElementQualifiedName = elementQualifiedName;
        }

        public string DateTimeString { get; private set; }
        public XmlQualifiedName ElementQualifiedName { get; private set; }
    }
}
