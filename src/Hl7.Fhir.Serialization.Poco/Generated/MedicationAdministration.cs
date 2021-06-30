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
  /// JSON Serialization Extensions for MedicationAdministration
  /// </summary>
  public static class MedicationAdministrationSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR MedicationAdministration into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.MedicationAdministration current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","MedicationAdministration");
      // Complex: MedicationAdministration, Export: MedicationAdministration, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("instantiates",current.InstantiatesElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("partOf", current.PartOf, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.StatusElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("statusReason", current.StatusReason, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("category", current.Category, writer, options);

      if (current.Medication != null)
      {
        switch (current.Medication)
        {
          case Hl7.Fhir.Model.CodeableConcept v_CodeableConcept:
            JsonStreamUtilities.SerializeComplexProperty("medicationCodeableConcept", v_CodeableConcept, writer, options);
            break;
          case Hl7.Fhir.Model.ResourceReference v_ResourceReference:
            JsonStreamUtilities.SerializeComplexProperty("medicationReference", v_ResourceReference, writer, options);
            break;
        }
      }
      JsonStreamUtilities.SerializeComplexProperty("subject", current.Subject, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("context", current.Context, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("supportingInformation", current.SupportingInformation, writer, options);

      if (current.Effective != null)
      {
        switch (current.Effective)
        {
          case Hl7.Fhir.Model.FhirDateTime v_FhirDateTime:
            JsonStreamUtilities.SerializePrimitiveProperty("effectiveDateTime",v_FhirDateTime,writer,options);
            break;
          case Hl7.Fhir.Model.Period v_Period:
            JsonStreamUtilities.SerializeComplexProperty("effectivePeriod", v_Period, writer, options);
            break;
        }
      }
      JsonStreamUtilities.SerializeComplexProperty("performer", current.Performer, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("reasonCode", current.ReasonCode, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("reasonReference", current.ReasonReference, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("request", current.Request, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("device", current.Device, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("note", current.Note, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("dosage", current.Dosage, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("eventHistory", current.EventHistory, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationAdministration
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.MedicationAdministration current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicationAdministration >>> MedicationAdministration.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicationAdministration: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationAdministration
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.MedicationAdministration current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "instantiates":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'instantiates' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.InstantiatesElement = new List<FhirUri>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.InstantiatesElement.Add(new FhirUri());
              reader.Skip();
            }
            else
            {
              current.InstantiatesElement.Add(new FhirUri(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'instantiates' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.InstantiatesElement.Count == 0)
          {
            current.InstantiatesElement = null;
          }
          break;

        case "_instantiates":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'instantiates' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_instantiates = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_instantiates >= current.InstantiatesElement.Count)
            {
              current.InstantiatesElement.Add(new FhirUri());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.InstantiatesElement[i_instantiates++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'instantiates' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'partOf' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.PartOf = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_PartOf = new Hl7.Fhir.Model.ResourceReference();
            v_PartOf.DeserializeJson(ref reader, options);
            current.PartOf.Add(v_PartOf);

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'partOf' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PartOf.Count == 0)
          {
            current.PartOf = null;
          }
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatusCodes>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatusCodes>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatusCodes>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.MedicationAdministration.MedicationAdministrationStatusCodes>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "statusReason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'statusReason' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.StatusReason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_StatusReason = new Hl7.Fhir.Model.CodeableConcept();
            v_StatusReason.DeserializeJson(ref reader, options);
            current.StatusReason.Add(v_StatusReason);

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'statusReason' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.StatusReason.Count == 0)
          {
            current.StatusReason = null;
          }
          break;

        case "category":
          current.Category = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Category).DeserializeJson(ref reader, options);
          break;

        case "medicationCodeableConcept":
          current.Medication = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Medication).DeserializeJson(ref reader, options);
          break;

        case "medicationReference":
          current.Medication = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Medication).DeserializeJson(ref reader, options);
          break;

        case "subject":
          current.Subject = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Subject).DeserializeJson(ref reader, options);
          break;

        case "context":
          current.Context = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Context).DeserializeJson(ref reader, options);
          break;

        case "supportingInformation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'supportingInformation' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.SupportingInformation = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_SupportingInformation = new Hl7.Fhir.Model.ResourceReference();
            v_SupportingInformation.DeserializeJson(ref reader, options);
            current.SupportingInformation.Add(v_SupportingInformation);

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'supportingInformation' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.SupportingInformation.Count == 0)
          {
            current.SupportingInformation = null;
          }
          break;

        case "effectiveDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Effective = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Effective = new FhirDateTime(reader.GetString());
          }
          break;

        case "_effectiveDateTime":
          if (current.Effective == null) { current.Effective = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Effective).DeserializeJson(ref reader, options);
          break;

        case "effectivePeriod":
          current.Effective = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Effective).DeserializeJson(ref reader, options);
          break;

        case "performer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'performer' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Performer = new List<MedicationAdministration.PerformerComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.MedicationAdministration.PerformerComponent v_Performer = new Hl7.Fhir.Model.MedicationAdministration.PerformerComponent();
            v_Performer.DeserializeJson(ref reader, options);
            current.Performer.Add(v_Performer);

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'performer' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Performer.Count == 0)
          {
            current.Performer = null;
          }
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'reasonCode' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ReasonCode = new Hl7.Fhir.Model.CodeableConcept();
            v_ReasonCode.DeserializeJson(ref reader, options);
            current.ReasonCode.Add(v_ReasonCode);

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'reasonCode' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
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
            throw new JsonException($"MedicationAdministration error reading 'reasonReference' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReasonReference = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_ReasonReference = new Hl7.Fhir.Model.ResourceReference();
            v_ReasonReference.DeserializeJson(ref reader, options);
            current.ReasonReference.Add(v_ReasonReference);

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'reasonReference' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonReference.Count == 0)
          {
            current.ReasonReference = null;
          }
          break;

        case "request":
          current.Request = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Request).DeserializeJson(ref reader, options);
          break;

        case "device":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'device' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Device = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Device = new Hl7.Fhir.Model.ResourceReference();
            v_Device.DeserializeJson(ref reader, options);
            current.Device.Add(v_Device);

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'device' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Device.Count == 0)
          {
            current.Device = null;
          }
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'note' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Annotation v_Note = new Hl7.Fhir.Model.Annotation();
            v_Note.DeserializeJson(ref reader, options);
            current.Note.Add(v_Note);

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'note' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Note.Count == 0)
          {
            current.Note = null;
          }
          break;

        case "dosage":
          current.Dosage = new Hl7.Fhir.Model.MedicationAdministration.DosageComponent();
          ((Hl7.Fhir.Model.MedicationAdministration.DosageComponent)current.Dosage).DeserializeJson(ref reader, options);
          break;

        case "eventHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicationAdministration error reading 'eventHistory' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.EventHistory = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_EventHistory = new Hl7.Fhir.Model.ResourceReference();
            v_EventHistory.DeserializeJson(ref reader, options);
            current.EventHistory.Add(v_EventHistory);

            if (!reader.Read())
            {
              throw new JsonException($"MedicationAdministration error reading 'eventHistory' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.EventHistory.Count == 0)
          {
            current.EventHistory = null;
          }
          break;

        // Complex: MedicationAdministration, Export: MedicationAdministration, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicationAdministration#Performer into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.MedicationAdministration.PerformerComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicationAdministration#Performer, Export: PerformerComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("function", current.Function, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("actor", current.Actor, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationAdministration#Performer
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.MedicationAdministration.PerformerComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicationAdministration.PerformerComponent >>> MedicationAdministration#Performer.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicationAdministration.PerformerComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationAdministration#Performer
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.MedicationAdministration.PerformerComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "function":
          current.Function = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Function).DeserializeJson(ref reader, options);
          break;

        case "actor":
          current.Actor = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Actor).DeserializeJson(ref reader, options);
          break;

        // Complex: performer, Export: PerformerComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicationAdministration#Dosage into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.MedicationAdministration.DosageComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicationAdministration#Dosage, Export: DosageComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("text",current.TextElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("site", current.Site, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("route", current.Route, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("method", current.Method, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("dose", current.Dose, writer, options);

      if (current.Rate != null)
      {
        switch (current.Rate)
        {
          case Hl7.Fhir.Model.Ratio v_Ratio:
            JsonStreamUtilities.SerializeComplexProperty("rateRatio", v_Ratio, writer, options);
            break;
          case Hl7.Fhir.Model.Quantity v_Quantity:
            JsonStreamUtilities.SerializeComplexProperty("rateQuantity", v_Quantity, writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationAdministration#Dosage
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.MedicationAdministration.DosageComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicationAdministration.DosageComponent >>> MedicationAdministration#Dosage.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicationAdministration.DosageComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicationAdministration#Dosage
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.MedicationAdministration.DosageComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "text":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TextElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.TextElement = new FhirString(reader.GetString());
          }
          break;

        case "_text":
          if (current.TextElement == null) { current.TextElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.TextElement).DeserializeJson(ref reader, options);
          break;

        case "site":
          current.Site = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Site).DeserializeJson(ref reader, options);
          break;

        case "route":
          current.Route = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Route).DeserializeJson(ref reader, options);
          break;

        case "method":
          current.Method = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Method).DeserializeJson(ref reader, options);
          break;

        case "dose":
          current.Dose = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Dose).DeserializeJson(ref reader, options);
          break;

        case "rateRatio":
          current.Rate = new Hl7.Fhir.Model.Ratio();
          ((Hl7.Fhir.Model.Ratio)current.Rate).DeserializeJson(ref reader, options);
          break;

        case "rateQuantity":
          current.Rate = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Rate).DeserializeJson(ref reader, options);
          break;

        // Complex: dosage, Export: DosageComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MedicationAdministrationJsonConverter : JsonConverter<Hl7.Fhir.Model.MedicationAdministration>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.MedicationAdministration value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.MedicationAdministration Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.MedicationAdministration();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file