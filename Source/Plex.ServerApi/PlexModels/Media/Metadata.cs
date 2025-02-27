namespace Plex.ServerApi.PlexModels.Media
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Metadata
    {
        [JsonPropertyName("ratingKey")]
        public string RatingKey { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("studio")]
        public string Studio { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("subtype")]
        public string SubType { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("titleSort")]
        public string TitleSort { get; set; }

        // TV Shows Only
        [JsonPropertyName("parentGuid")]
        public string ParentGuid { get; set; }

        [JsonPropertyName("parentRatingKey")]
        public string ParentRatingKey { get; set; }

        [JsonPropertyName("parentIndex")]
        public int ParentIndex { get; set; }

        [JsonPropertyName("userRating")]
        public double UserRating { get; set; }

        [JsonPropertyName("parentThumb")]
        public string ParentThumb { get; set; }

        [JsonPropertyName("parentTitle")]
        public string ParentTitle { get; set; }

        [JsonPropertyName("grandparentArt")]
        public string GrandparentArt { get; set; }

        [JsonPropertyName("grandparentGuid")]
        public string GrandparentGuid { get; set; }

        [JsonPropertyName("grandparentKey")]
        public string GrandparentKey { get; set; }

        [JsonPropertyName("grandparentRatingKey")]
        public string GrandparentRatingKey { get; set; }

        [JsonPropertyName("grandparentThumb")]
        public string GrandparentThumb { get; set; }

        [JsonPropertyName("grandparentTitle")]
        public string GrandparentTitle { get; set; }


        [JsonPropertyName("librarySectionTitle")]
        public string LibrarySectionTitle { get; set; }

        [JsonPropertyName("librarySectionID")]
        public int LibrarySectionId { get; set; }

        [JsonPropertyName("librarySectionKey")]
        public string LibrarySectionKey { get; set; }

        [JsonPropertyName("contentRating")]
        public string ContentRating { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        [JsonPropertyName("audienceRating")]
        public double AudienceRating { get; set; }

        [JsonPropertyName("leafCount")]
        public int LeafCount { get; set; }

        [JsonPropertyName("childCount")]
        public int ChildCount { get; set; }

        [JsonPropertyName("viewCount")]
        public int ViewCount { get; set; }

        [JsonPropertyName("viewedLeafCount")]
        public int ViewedLeafCount { get; set; }

        [JsonPropertyName("lastViewedAt")]
        public long LastViewedAt { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("tagline")]
        public string Tagline { get; set; }

        [JsonPropertyName("thumb")]
        public string Thumb { get; set; }

        [JsonPropertyName("art")]
        public string Art { get; set; }

        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        [JsonPropertyName("originallyAvailableAt")]
        public string OriginallyAvailableAt { get; set; }

        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("addedAt")]
        public long AddedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonPropertyName("audienceRatingImage")]
        public string AudienceRatingImage { get; set; }

        [JsonPropertyName("chapterSource")]
        public string ChapterSource { get; set; }

        [JsonPropertyName("primaryExtraKey")]
        public string PrimaryExtraKey { get; set; }

        [JsonPropertyName("originalTitle")]
        public string OriginalTitle { get; set; }

        [JsonPropertyName("Media")]
        public List<Medium> Media { get; set; }

        [JsonPropertyName("Genre")]
        public List<Genre> Genres { get; set; }

        [JsonPropertyName("Director")]
        public List<Director> Directors { get; set; }

        [JsonPropertyName("Producer")]
        public List<Producer> Producers { get; set; }

        [JsonPropertyName("Writer")]
        public List<Writer> Writers { get; set; }

        [JsonPropertyName("Country")]
        public List<Country> Countries { get; set; }

        [JsonPropertyName("Guid")]
        public List<ScrapingId> ScrapingIds { get; set; }

        [JsonPropertyName("Collection")]
        public List<Collection> Collections { get; set; }

        [JsonPropertyName("Role")]
        public List<MediaRole> Roles { get; set; }

        [JsonPropertyName("Similar")]
        public List<Similar> Similar { get; set; }

        [JsonPropertyName("Chapter")]
        public List<Chapter> Chapters { get; set; }

        [JsonPropertyName("Extras")]
        public Extras Extras { get; set; }

        [JsonPropertyName("Review")]
        public List<Review> Reviews { get; set; }

        [JsonPropertyName("Field")]
        public List<MetadataField> Fields { get; set; }

        [JsonPropertyName("Preferences")]
        public Preference Preferences { get; set; }
    }
}
