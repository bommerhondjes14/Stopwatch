﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiotNet
{
    public partial class StaticChampionTest
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("version")]
        public Version Version { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, Datum> Data { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("version")]
        public Version Version { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("blurb")]
        public string Blurb { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("partype")]
        public Partype Partype { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, double> Stats { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("sprite")]
        public Sprite Sprite { get; set; }

        [JsonProperty("group")]
        public TypeEnum Group { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("w")]
        public long W { get; set; }

        [JsonProperty("h")]
        public long H { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("attack")]
        public long Attack { get; set; }

        [JsonProperty("defense")]
        public long Defense { get; set; }

        [JsonProperty("magic")]
        public long Magic { get; set; }

        [JsonProperty("difficulty")]
        public long Difficulty { get; set; }
    }

    public enum TypeEnum { Champion };

    public enum Sprite { Champion0Png, Champion1Png, Champion2Png, Champion3Png, Champion4Png };

    public enum Partype { Battlefury, BloodWell, Dragonfury, Energy, Ferocity, Gnarfury, Heat, Mp, None, Rage, Wind };

    public enum Tag { Assassin, Fighter, Mage, Marksman, Melee, Support, Tank };

    public enum Version { The6241 };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                TypeEnumConverter.Singleton,
                SpriteConverter.Singleton,
                PartypeConverter.Singleton,
                TagConverter.Singleton,
                VersionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "champion")
            {
                return TypeEnum.Champion;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.Champion)
            {
                serializer.Serialize(writer, "champion");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class SpriteConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Sprite) || t == typeof(Sprite?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "champion0.png":
                    return Sprite.Champion0Png;
                case "champion1.png":
                    return Sprite.Champion1Png;
                case "champion2.png":
                    return Sprite.Champion2Png;
                case "champion3.png":
                    return Sprite.Champion3Png;
                case "champion4.png":
                    return Sprite.Champion4Png;
            }
            throw new Exception("Cannot unmarshal type Sprite");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Sprite)untypedValue;
            switch (value)
            {
                case Sprite.Champion0Png:
                    serializer.Serialize(writer, "champion0.png");
                    return;
                case Sprite.Champion1Png:
                    serializer.Serialize(writer, "champion1.png");
                    return;
                case Sprite.Champion2Png:
                    serializer.Serialize(writer, "champion2.png");
                    return;
                case Sprite.Champion3Png:
                    serializer.Serialize(writer, "champion3.png");
                    return;
                case Sprite.Champion4Png:
                    serializer.Serialize(writer, "champion4.png");
                    return;
            }
            throw new Exception("Cannot marshal type Sprite");
        }

        public static readonly SpriteConverter Singleton = new SpriteConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (Int64.TryParse(value, out var l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class PartypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Partype) || t == typeof(Partype?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Battlefury":
                    return Partype.Battlefury;
                case "BloodWell":
                    return Partype.BloodWell;
                case "Dragonfury":
                    return Partype.Dragonfury;
                case "Energy":
                    return Partype.Energy;
                case "Ferocity":
                    return Partype.Ferocity;
                case "Gnarfury":
                    return Partype.Gnarfury;
                case "Heat":
                    return Partype.Heat;
                case "MP":
                    return Partype.Mp;
                case "None":
                    return Partype.None;
                case "Rage":
                    return Partype.Rage;
                case "Wind":
                    return Partype.Wind;
            }
            throw new Exception("Cannot unmarshal type Partype");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Partype)untypedValue;
            switch (value)
            {
                case Partype.Battlefury:
                    serializer.Serialize(writer, "Battlefury");
                    return;
                case Partype.BloodWell:
                    serializer.Serialize(writer, "BloodWell");
                    return;
                case Partype.Dragonfury:
                    serializer.Serialize(writer, "Dragonfury");
                    return;
                case Partype.Energy:
                    serializer.Serialize(writer, "Energy");
                    return;
                case Partype.Ferocity:
                    serializer.Serialize(writer, "Ferocity");
                    return;
                case Partype.Gnarfury:
                    serializer.Serialize(writer, "Gnarfury");
                    return;
                case Partype.Heat:
                    serializer.Serialize(writer, "Heat");
                    return;
                case Partype.Mp:
                    serializer.Serialize(writer, "MP");
                    return;
                case Partype.None:
                    serializer.Serialize(writer, "None");
                    return;
                case Partype.Rage:
                    serializer.Serialize(writer, "Rage");
                    return;
                case Partype.Wind:
                    serializer.Serialize(writer, "Wind");
                    return;
            }
            throw new Exception("Cannot marshal type Partype");
        }

        public static readonly PartypeConverter Singleton = new PartypeConverter();
    }

    internal class TagConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tag) || t == typeof(Tag?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Assassin":
                    return Tag.Assassin;
                case "Fighter":
                    return Tag.Fighter;
                case "Mage":
                    return Tag.Mage;
                case "Marksman":
                    return Tag.Marksman;
                case "Melee":
                    return Tag.Melee;
                case "Support":
                    return Tag.Support;
                case "Tank":
                    return Tag.Tank;
            }
            throw new Exception("Cannot unmarshal type Tag");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Tag)untypedValue;
            switch (value)
            {
                case Tag.Assassin:
                    serializer.Serialize(writer, "Assassin");
                    return;
                case Tag.Fighter:
                    serializer.Serialize(writer, "Fighter");
                    return;
                case Tag.Mage:
                    serializer.Serialize(writer, "Mage");
                    return;
                case Tag.Marksman:
                    serializer.Serialize(writer, "Marksman");
                    return;
                case Tag.Melee:
                    serializer.Serialize(writer, "Melee");
                    return;
                case Tag.Support:
                    serializer.Serialize(writer, "Support");
                    return;
                case Tag.Tank:
                    serializer.Serialize(writer, "Tank");
                    return;
            }
            throw new Exception("Cannot marshal type Tag");
        }

        public static readonly TagConverter Singleton = new TagConverter();
    }

    internal class VersionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Version) || t == typeof(Version?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "6.24.1")
            {
                return Version.The6241;
            }
            throw new Exception("Cannot unmarshal type Version");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Version)untypedValue;
            if (value == Version.The6241)
            {
                serializer.Serialize(writer, "6.24.1");
                return;
            }
            throw new Exception("Cannot marshal type Version");
        }

        public static readonly VersionConverter Singleton = new VersionConverter();
    }
}
