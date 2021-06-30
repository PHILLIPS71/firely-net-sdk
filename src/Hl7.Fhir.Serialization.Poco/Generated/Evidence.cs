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
  /// JSON Serialization Extensions for Evidence
  /// </summary>
  public static class EvidenceSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR Evidence into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Evidence current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Evidence");
      // Complex: Evidence, Export: Evidence, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("url",current.UrlElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("version",current.VersionElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("name",current.NameElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("title",current.TitleElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("shortTitle",current.ShortTitleElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("subtitle",current.SubtitleElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.StatusElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("date",current.DateElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("publisher",current.PublisherElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("contact", current.Contact, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("description",current.Description,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("note", current.Note, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("useContext", current.UseContext, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("jurisdiction", current.Jurisdiction, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("copyright",current.Copyright,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("approvalDate",current.ApprovalDateElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("lastReviewDate",current.LastReviewDateElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("effectivePeriod", current.EffectivePeriod, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("topic", current.Topic, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("author", current.Author, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("editor", current.Editor, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("reviewer", current.Reviewer, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("endorser", current.Endorser, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("relatedArtifact", current.RelatedArtifact, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("exposureBackground", current.ExposureBackground, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("exposureVariant", current.ExposureVariant, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("outcome", current.Outcome, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Evidence
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Evidence current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Evidence >>> Evidence.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Evidence: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Evidence
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Evidence current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "url":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.UrlElement = new FhirUri();
            reader.Skip();
          }
          else
          {
            current.UrlElement = new FhirUri(reader.GetString());
          }
          break;

        case "_url":
          if (current.UrlElement == null) { current.UrlElement = new FhirUri(); }
          ((Hl7.Fhir.Model.Element)current.UrlElement).DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "version":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.VersionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.VersionElement = new FhirString(reader.GetString());
          }
          break;

        case "_version":
          if (current.VersionElement == null) { current.VersionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.VersionElement).DeserializeJson(ref reader, options);
          break;

        case "name":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.NameElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.NameElement = new FhirString(reader.GetString());
          }
          break;

        case "_name":
          if (current.NameElement == null) { current.NameElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.NameElement).DeserializeJson(ref reader, options);
          break;

        case "title":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TitleElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.TitleElement = new FhirString(reader.GetString());
          }
          break;

        case "_title":
          if (current.TitleElement == null) { current.TitleElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.TitleElement).DeserializeJson(ref reader, options);
          break;

        case "shortTitle":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ShortTitleElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.ShortTitleElement = new FhirString(reader.GetString());
          }
          break;

        case "_shortTitle":
          if (current.ShortTitleElement == null) { current.ShortTitleElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.ShortTitleElement).DeserializeJson(ref reader, options);
          break;

        case "subtitle":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SubtitleElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.SubtitleElement = new FhirString(reader.GetString());
          }
          break;

        case "_subtitle":
          if (current.SubtitleElement == null) { current.SubtitleElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.SubtitleElement).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.PublicationStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "date":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DateElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.DateElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_date":
          if (current.DateElement == null) { current.DateElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.DateElement).DeserializeJson(ref reader, options);
          break;

        case "publisher":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PublisherElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.PublisherElement = new FhirString(reader.GetString());
          }
          break;

        case "_publisher":
          if (current.PublisherElement == null) { current.PublisherElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.PublisherElement).DeserializeJson(ref reader, options);
          break;

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'contact' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Contact = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactDetail v_Contact = new Hl7.Fhir.Model.ContactDetail();
            v_Contact.DeserializeJson(ref reader, options);
            current.Contact.Add(v_Contact);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'contact' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Contact.Count == 0)
          {
            current.Contact = null;
          }
          break;

        case "description":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Description = new Markdown();
            reader.Skip();
          }
          else
          {
            current.Description = new Markdown(reader.GetString());
          }
          break;

        case "_description":
          if (current.Description == null) { current.Description = new Markdown(); }
          ((Hl7.Fhir.Model.Element)current.Description).DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'note' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Annotation v_Note = new Hl7.Fhir.Model.Annotation();
            v_Note.DeserializeJson(ref reader, options);
            current.Note.Add(v_Note);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'note' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Note.Count == 0)
          {
            current.Note = null;
          }
          break;

        case "useContext":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'useContext' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.UseContext = new List<UsageContext>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.UsageContext v_UseContext = new Hl7.Fhir.Model.UsageContext();
            v_UseContext.DeserializeJson(ref reader, options);
            current.UseContext.Add(v_UseContext);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'useContext' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.UseContext.Count == 0)
          {
            current.UseContext = null;
          }
          break;

        case "jurisdiction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'jurisdiction' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Jurisdiction = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
            v_Jurisdiction.DeserializeJson(ref reader, options);
            current.Jurisdiction.Add(v_Jurisdiction);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'jurisdiction' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Jurisdiction.Count == 0)
          {
            current.Jurisdiction = null;
          }
          break;

        case "copyright":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Copyright = new Markdown();
            reader.Skip();
          }
          else
          {
            current.Copyright = new Markdown(reader.GetString());
          }
          break;

        case "_copyright":
          if (current.Copyright == null) { current.Copyright = new Markdown(); }
          ((Hl7.Fhir.Model.Element)current.Copyright).DeserializeJson(ref reader, options);
          break;

        case "approvalDate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ApprovalDateElement = new Date();
            reader.Skip();
          }
          else
          {
            current.ApprovalDateElement = new Date(reader.GetString());
          }
          break;

        case "_approvalDate":
          if (current.ApprovalDateElement == null) { current.ApprovalDateElement = new Date(); }
          ((Hl7.Fhir.Model.Element)current.ApprovalDateElement).DeserializeJson(ref reader, options);
          break;

        case "lastReviewDate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.LastReviewDateElement = new Date();
            reader.Skip();
          }
          else
          {
            current.LastReviewDateElement = new Date(reader.GetString());
          }
          break;

        case "_lastReviewDate":
          if (current.LastReviewDateElement == null) { current.LastReviewDateElement = new Date(); }
          ((Hl7.Fhir.Model.Element)current.LastReviewDateElement).DeserializeJson(ref reader, options);
          break;

        case "effectivePeriod":
          current.EffectivePeriod = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.EffectivePeriod).DeserializeJson(ref reader, options);
          break;

        case "topic":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'topic' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Topic = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Topic = new Hl7.Fhir.Model.CodeableConcept();
            v_Topic.DeserializeJson(ref reader, options);
            current.Topic.Add(v_Topic);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'topic' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Topic.Count == 0)
          {
            current.Topic = null;
          }
          break;

        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'author' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Author = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactDetail v_Author = new Hl7.Fhir.Model.ContactDetail();
            v_Author.DeserializeJson(ref reader, options);
            current.Author.Add(v_Author);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'author' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Author.Count == 0)
          {
            current.Author = null;
          }
          break;

        case "editor":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'editor' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Editor = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactDetail v_Editor = new Hl7.Fhir.Model.ContactDetail();
            v_Editor.DeserializeJson(ref reader, options);
            current.Editor.Add(v_Editor);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'editor' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Editor.Count == 0)
          {
            current.Editor = null;
          }
          break;

        case "reviewer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'reviewer' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Reviewer = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactDetail v_Reviewer = new Hl7.Fhir.Model.ContactDetail();
            v_Reviewer.DeserializeJson(ref reader, options);
            current.Reviewer.Add(v_Reviewer);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'reviewer' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Reviewer.Count == 0)
          {
            current.Reviewer = null;
          }
          break;

        case "endorser":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'endorser' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Endorser = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactDetail v_Endorser = new Hl7.Fhir.Model.ContactDetail();
            v_Endorser.DeserializeJson(ref reader, options);
            current.Endorser.Add(v_Endorser);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'endorser' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Endorser.Count == 0)
          {
            current.Endorser = null;
          }
          break;

        case "relatedArtifact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'relatedArtifact' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.RelatedArtifact = new List<RelatedArtifact>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.RelatedArtifact v_RelatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
            v_RelatedArtifact.DeserializeJson(ref reader, options);
            current.RelatedArtifact.Add(v_RelatedArtifact);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'relatedArtifact' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.RelatedArtifact.Count == 0)
          {
            current.RelatedArtifact = null;
          }
          break;

        case "exposureBackground":
          current.ExposureBackground = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.ExposureBackground).DeserializeJson(ref reader, options);
          break;

        case "exposureVariant":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'exposureVariant' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ExposureVariant = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_ExposureVariant = new Hl7.Fhir.Model.ResourceReference();
            v_ExposureVariant.DeserializeJson(ref reader, options);
            current.ExposureVariant.Add(v_ExposureVariant);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'exposureVariant' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ExposureVariant.Count == 0)
          {
            current.ExposureVariant = null;
          }
          break;

        case "outcome":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Evidence error reading 'outcome' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Outcome = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Outcome = new Hl7.Fhir.Model.ResourceReference();
            v_Outcome.DeserializeJson(ref reader, options);
            current.Outcome.Add(v_Outcome);

            if (!reader.Read())
            {
              throw new JsonException($"Evidence error reading 'outcome' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Outcome.Count == 0)
          {
            current.Outcome = null;
          }
          break;

        // Complex: Evidence, Export: Evidence, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class EvidenceJsonConverter : JsonConverter<Hl7.Fhir.Model.Evidence>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.Evidence value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.Evidence Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.Evidence();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file