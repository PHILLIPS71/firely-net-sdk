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
  /// JSON Serialization Extensions for SubstanceAmount
  /// </summary>
  public static class SubstanceAmountSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR SubstanceAmount into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.SubstanceAmount current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: SubstanceAmount, Export: SubstanceAmount, Base: BackboneElement (BackboneType)
      ((Hl7.Fhir.Model.BackboneType)current).SerializeJson(writer, options, false);

      if (current.Amount != null)
      {
        switch (current.Amount)
        {
          case Hl7.Fhir.Model.Quantity v_Quantity:
            writer.WritePropertyName("amountQuantity");
            v_Quantity.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.Range v_Range:
            writer.WritePropertyName("amountRange");
            v_Range.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.FhirString v_FhirString:
            JsonStreamUtilities.SerializePrimitiveProperty("amountString",v_FhirString,writer,options);
            break;
        }
      }
      JsonStreamUtilities.SerializeComplexProperty("amountType", current.AmountType, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("amountText",current.AmountTextElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("referenceRange", current.ReferenceRange, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceAmount
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.SubstanceAmount current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"SubstanceAmount >>> SubstanceAmount.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"SubstanceAmount: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceAmount
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.SubstanceAmount current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "amountQuantity":
          current.Amount = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Amount).DeserializeJson(ref reader, options);
          break;

        case "amountRange":
          current.Amount = new Hl7.Fhir.Model.Range();
          ((Hl7.Fhir.Model.Range)current.Amount).DeserializeJson(ref reader, options);
          break;

        case "amountString":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Amount = new FhirString();
            reader.Skip();
          }
          else
          {
            current.Amount = new FhirString(reader.GetString());
          }
          break;

        case "_amountString":
          if (current.Amount == null) { current.Amount = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.Amount).DeserializeJson(ref reader, options);
          break;

        case "amountType":
          current.AmountType = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.AmountType).DeserializeJson(ref reader, options);
          break;

        case "amountText":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AmountTextElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.AmountTextElement = new FhirString(reader.GetString());
          }
          break;

        case "_amountText":
          if (current.AmountTextElement == null) { current.AmountTextElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.AmountTextElement).DeserializeJson(ref reader, options);
          break;

        case "referenceRange":
          current.ReferenceRange = new Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent();
          ((Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent)current.ReferenceRange).DeserializeJson(ref reader, options);
          break;

        // Complex: SubstanceAmount, Export: SubstanceAmount, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneType)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstanceAmount#ReferenceRange into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstanceAmount#ReferenceRange, Export: ReferenceRangeComponent, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("lowLimit", current.LowLimit, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("highLimit", current.HighLimit, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceAmount#ReferenceRange
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"SubstanceAmount.ReferenceRangeComponent >>> SubstanceAmount#ReferenceRange.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"SubstanceAmount.ReferenceRangeComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceAmount#ReferenceRange
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.SubstanceAmount.ReferenceRangeComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "lowLimit":
          current.LowLimit = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.LowLimit).DeserializeJson(ref reader, options);
          break;

        case "highLimit":
          current.HighLimit = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.HighLimit).DeserializeJson(ref reader, options);
          break;

        // Complex: referenceRange, Export: ReferenceRangeComponent, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SubstanceAmountJsonConverter : JsonConverter<Hl7.Fhir.Model.SubstanceAmount>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.SubstanceAmount value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.SubstanceAmount Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.SubstanceAmount();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file