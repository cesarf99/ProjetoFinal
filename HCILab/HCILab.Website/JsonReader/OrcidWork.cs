﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Orcid_Work;
//
//    var orcidWork = OrcidWork.FromJson(jsonString);

namespace Orcid_Work
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class OrcidWork
    {
        [JsonProperty("created-date")]
        public EdDate CreatedDate { get; set; }

        [JsonProperty("last-modified-date")]
        public EdDate LastModifiedDate { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("put-code")]
        public long PutCode { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("title")]
        public Title Title { get; set; }

        [JsonProperty("journal-title")]
        public JournalTitle JournalTitle { get; set; }

        [JsonProperty("short-description")]
        public string ShortDescription { get; set; }

        [JsonProperty("citation")]
        public Citation Citation { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("publication-date")]
        public PublicationDate PublicationDate { get; set; }

        [JsonProperty("external-ids")]
        public ExternalIds ExternalIds { get; set; }

        [JsonProperty("url")]
        public object Url { get; set; }

        [JsonProperty("contributors")]
        public Contributors Contributors { get; set; }

        [JsonProperty("language-code")]
        public object LanguageCode { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public partial class Citation
    {
        [JsonProperty("citation-type")]
        public string CitationType { get; set; }

        [JsonProperty("citation-value")]
        public string CitationValue { get; set; }
    }

    public partial class Contributors
    {
        [JsonProperty("contributor")]
        public List<object> Contributor { get; set; }
    }

    public partial class EdDate
    {
        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public partial class ExternalIds
    {
        [JsonProperty("external-id")]
        public List<ExternalId> ExternalId { get; set; }
    }

    public partial class ExternalId
    {
        [JsonProperty("external-id-type")]
        public string ExternalIdType { get; set; }

        [JsonProperty("external-id-value")]
        public string ExternalIdValue { get; set; }

        [JsonProperty("external-id-normalized")]
        public ExternalIdNormalized ExternalIdNormalized { get; set; }

        [JsonProperty("external-id-normalized-error")]
        public object ExternalIdNormalizedError { get; set; }

        [JsonProperty("external-id-url")]
        public JournalTitle ExternalIdUrl { get; set; }

        [JsonProperty("external-id-relationship")]
        public string ExternalIdRelationship { get; set; }
    }

    public partial class ExternalIdNormalized
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("transient")]
        public bool Transient { get; set; }
    }

    public partial class JournalTitle
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class PublicationDate
    {
        [JsonProperty("year")]
        public JournalTitle Year { get; set; }

        [JsonProperty("month")]
        public object Month { get; set; }

        [JsonProperty("day")]
        public object Day { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("source-orcid")]
        public SourceOrcid SourceOrcid { get; set; }

        [JsonProperty("source-client-id")]
        public object SourceClientId { get; set; }

        [JsonProperty("source-name")]
        public JournalTitle SourceName { get; set; }

        [JsonProperty("assertion-origin-orcid")]
        public object AssertionOriginOrcid { get; set; }

        [JsonProperty("assertion-origin-client-id")]
        public object AssertionOriginClientId { get; set; }

        [JsonProperty("assertion-origin-name")]
        public object AssertionOriginName { get; set; }
    }

    public partial class SourceOrcid
    {
        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }
    }

    public partial class Title
    {
        [JsonProperty("title")]
        public JournalTitle TitleTitle { get; set; }

        [JsonProperty("subtitle")]
        public object Subtitle { get; set; }

        [JsonProperty("translated-title")]
        public object TranslatedTitle { get; set; }
    }

    public partial class OrcidWork
    {
        public static OrcidWork FromJson(string json) => JsonConvert.DeserializeObject<OrcidWork>(json, Orcid_Work.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this OrcidWork self) => JsonConvert.SerializeObject(self, Orcid_Work.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
