using Hl7.Fhir.Model;
using System;
using System.Text.Json;
using System.Xml;

namespace Hl7.Fhir.Serialization;

public interface IFhirStreamingSerializationEngine : IFhirSerializationEngine
{
    /// <summary>
    /// Deserializes a resource from a JSON reader
    /// </summary>
    /// <param name="reader">The JSON reader</param>
    /// <returns>The parsed resource</returns>
    public Resource DeserializeFromJson(Utf8JsonReader reader);

    public Base DeserializeObjectFromJson(Type targetType, Utf8JsonReader reader);
    
    /// <summary>
    /// Deserializes a resource from an XML reader
    /// </summary>
    /// <param name="reader">The XML reader</param>
    /// <returns>The parsed resource</returns>
    public Resource DeserializeFromXml(XmlReader reader);

    public Base DeserializeElementFromXml(XmlReader reader);
}