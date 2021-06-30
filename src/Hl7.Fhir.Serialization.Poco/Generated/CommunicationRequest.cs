// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Serialization.Poco
{
  /// <summary>
  /// JSON Serialization Extensions for CommunicationRequest
  /// </summary>
  public static class CommunicationRequestSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR CommunicationRequest into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.CommunicationRequest current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","CommunicationRequest");
      // Complex: CommunicationRequest, Export: CommunicationRequest, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("basedOn", current.BasedOn, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("replaces", current.Replaces, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("groupIdentifier", current.GroupIdentifier, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.StatusElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("statusReason", current.StatusReason, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("category", current.Category, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("priority",current.PriorityElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("doNotPerform",current.DoNotPerformElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("medium", current.Medium, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("subject", current.Subject, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("about", current.About, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("encounter", current.Encounter, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("payload", current.Payload, writer, options);

      if (current.Occurrence != null)
      {
        switch (current.Occurrence)
        {
          case Hl7.Fhir.Model.FhirDateTime v_FhirDateTime:
            JsonStreamUtilities.SerializePrimitiveProperty("occurrenceDateTime",v_FhirDateTime,writer,options);
            break;
          case Hl7.Fhir.Model.Period v_Period:
            JsonStreamUtilities.SerializeComplexProperty("occurrencePeriod", v_Period, writer, options);
            break;
        }
      }
      JsonStreamUtilities.SerializePrimitiveProperty("authoredOn",current.AuthoredOnElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("requester", current.Requester, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("recipient", current.Recipient, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("sender", current.Sender, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("reasonCode", current.ReasonCode, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("reasonReference", current.ReasonReference, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("note", current.Note, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CommunicationRequest
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.CommunicationRequest current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"CommunicationRequest >>> CommunicationRequest.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"CommunicationRequest: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CommunicationRequest
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.CommunicationRequest current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'basedOn' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.BasedOn = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_BasedOn = new Hl7.Fhir.Model.ResourceReference();
            v_BasedOn.DeserializeJson(ref reader, options);
            current.BasedOn.Add(v_BasedOn);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'basedOn' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.BasedOn.Count == 0)
          {
            current.BasedOn = null;
          }
          break;

        case "replaces":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'replaces' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Replaces = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Replaces = new Hl7.Fhir.Model.ResourceReference();
            v_Replaces.DeserializeJson(ref reader, options);
            current.Replaces.Add(v_Replaces);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'replaces' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Replaces.Count == 0)
          {
            current.Replaces = null;
          }
          break;

        case "groupIdentifier":
          current.GroupIdentifier = new Hl7.Fhir.Model.Identifier();
          ((Hl7.Fhir.Model.Identifier)current.GroupIdentifier).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.RequestStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.RequestStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.RequestStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.RequestStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "statusReason":
          current.StatusReason = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.StatusReason).DeserializeJson(ref reader, options);
          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'category' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Category = new Hl7.Fhir.Model.CodeableConcept();
            v_Category.DeserializeJson(ref reader, options);
            current.Category.Add(v_Category);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'category' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Category.Count == 0)
          {
            current.Category = null;
          }
          break;

        case "priority":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PriorityElement = new Code<Hl7.Fhir.Model.RequestPriority>();
            reader.Skip();
          }
          else
          {
            current.PriorityElement = new Code<Hl7.Fhir.Model.RequestPriority>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.RequestPriority>(reader.GetString()));
          }
          break;

        case "_priority":
          if (current.PriorityElement == null) { current.PriorityElement = new Code<Hl7.Fhir.Model.RequestPriority>(); }
          ((Hl7.Fhir.Model.Element)current.PriorityElement).DeserializeJson(ref reader, options);
          break;

        case "doNotPerform":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DoNotPerformElement = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.DoNotPerformElement = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_doNotPerform":
          if (current.DoNotPerformElement == null) { current.DoNotPerformElement = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.DoNotPerformElement).DeserializeJson(ref reader, options);
          break;

        case "medium":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'medium' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Medium = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Medium = new Hl7.Fhir.Model.CodeableConcept();
            v_Medium.DeserializeJson(ref reader, options);
            current.Medium.Add(v_Medium);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'medium' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Medium.Count == 0)
          {
            current.Medium = null;
          }
          break;

        case "subject":
          current.Subject = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Subject).DeserializeJson(ref reader, options);
          break;

        case "about":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'about' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.About = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_About = new Hl7.Fhir.Model.ResourceReference();
            v_About.DeserializeJson(ref reader, options);
            current.About.Add(v_About);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'about' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.About.Count == 0)
          {
            current.About = null;
          }
          break;

        case "encounter":
          current.Encounter = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Encounter).DeserializeJson(ref reader, options);
          break;

        case "payload":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'payload' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Payload = new List<CommunicationRequest.PayloadComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CommunicationRequest.PayloadComponent v_Payload = new Hl7.Fhir.Model.CommunicationRequest.PayloadComponent();
            v_Payload.DeserializeJson(ref reader, options);
            current.Payload.Add(v_Payload);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'payload' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Payload.Count == 0)
          {
            current.Payload = null;
          }
          break;

        case "occurrenceDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Occurrence = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Occurrence = new FhirDateTime(reader.GetString());
          }
          break;

        case "_occurrenceDateTime":
          if (current.Occurrence == null) { current.Occurrence = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Occurrence).DeserializeJson(ref reader, options);
          break;

        case "occurrencePeriod":
          current.Occurrence = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Occurrence).DeserializeJson(ref reader, options);
          break;

        case "authoredOn":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AuthoredOnElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.AuthoredOnElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_authoredOn":
          if (current.AuthoredOnElement == null) { current.AuthoredOnElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.AuthoredOnElement).DeserializeJson(ref reader, options);
          break;

        case "requester":
          current.Requester = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Requester).DeserializeJson(ref reader, options);
          break;

        case "recipient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'recipient' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Recipient = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Recipient = new Hl7.Fhir.Model.ResourceReference();
            v_Recipient.DeserializeJson(ref reader, options);
            current.Recipient.Add(v_Recipient);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'recipient' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Recipient.Count == 0)
          {
            current.Recipient = null;
          }
          break;

        case "sender":
          current.Sender = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Sender).DeserializeJson(ref reader, options);
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'reasonCode' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ReasonCode = new Hl7.Fhir.Model.CodeableConcept();
            v_ReasonCode.DeserializeJson(ref reader, options);
            current.ReasonCode.Add(v_ReasonCode);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'reasonCode' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonCode.Count == 0)
          {
            current.ReasonCode = null;
          }
          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'reasonReference' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReasonReference = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_ReasonReference = new Hl7.Fhir.Model.ResourceReference();
            v_ReasonReference.DeserializeJson(ref reader, options);
            current.ReasonReference.Add(v_ReasonReference);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'reasonReference' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonReference.Count == 0)
          {
            current.ReasonReference = null;
          }
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CommunicationRequest error reading 'note' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Annotation v_Note = new Hl7.Fhir.Model.Annotation();
            v_Note.DeserializeJson(ref reader, options);
            current.Note.Add(v_Note);

            if (!reader.Read())
            {
              throw new JsonException($"CommunicationRequest error reading 'note' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Note.Count == 0)
          {
            current.Note = null;
          }
          break;

        // Complex: CommunicationRequest, Export: CommunicationRequest, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR CommunicationRequest#Payload into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.CommunicationRequest.PayloadComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: CommunicationRequest#Payload, Export: PayloadComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Content != null)
      {
        switch (current.Content)
        {
          case Hl7.Fhir.Model.FhirString v_FhirString:
            JsonStreamUtilities.SerializePrimitiveProperty("contentString",v_FhirString,writer,options);
            break;
          case Hl7.Fhir.Model.Attachment v_Attachment:
            JsonStreamUtilities.SerializeComplexProperty("contentAttachment", v_Attachment, writer, options);
            break;
          case Hl7.Fhir.Model.ResourceReference v_ResourceReference:
            JsonStreamUtilities.SerializeComplexProperty("contentReference", v_ResourceReference, writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CommunicationRequest#Payload
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.CommunicationRequest.PayloadComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"CommunicationRequest.PayloadComponent >>> CommunicationRequest#Payload.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"CommunicationRequest.PayloadComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CommunicationRequest#Payload
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.CommunicationRequest.PayloadComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "contentString":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Content = new FhirString();
            reader.Skip();
          }
          else
          {
            current.Content = new FhirString(reader.GetString());
          }
          break;

        case "_contentString":
          if (current.Content == null) { current.Content = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.Content).DeserializeJson(ref reader, options);
          break;

        case "contentAttachment":
          current.Content = new Hl7.Fhir.Model.Attachment();
          ((Hl7.Fhir.Model.Attachment)current.Content).DeserializeJson(ref reader, options);
          break;

        case "contentReference":
          current.Content = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Content).DeserializeJson(ref reader, options);
          break;

        // Complex: payload, Export: PayloadComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class CommunicationRequestJsonConverter : JsonConverter<Hl7.Fhir.Model.CommunicationRequest>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.CommunicationRequest value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.CommunicationRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.CommunicationRequest();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file