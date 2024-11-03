namespace LanguageLocaliser
{
    /// <summary>
    /// Identifies Locale information
    /// </summary>
    public struct LocaleInfo : IEquatable<LocaleInfo>
    {
        /// <summary>
        /// The readable name for the locale, e.g. English (US)
        /// </summary>
        public string Name;

        /// <summary>
        /// The language code for the locale, e.g. en
        /// </summary>
        public string Language;

        /// <summary>
        /// The region for the locale, e.g. US
        /// </summary>
        public string Region;

        /// <summary>
        /// Determines if the locale has all information filled in
        /// </summary>
        public bool Valid
        {
            get
            {
                return !String.IsNullOrEmpty(Name) && !String.IsNullOrEmpty(Language) && !String.IsNullOrEmpty(Region);
            }
        }

        /// <summary>
        /// Gets the ID in the format {langCode}_{region}
        /// </summary>
        public string Id 
        {
            get 
            {
                return $"{Language}_{Region}";
            }
        }

        /// <summary>
        /// Determines if two locale informations are equal
        /// </summary>
        /// <param name="other">The other one to compare it to</param>
        /// <returns>True if they are equal</returns>
        public bool Equals(LocaleInfo other)
        {
            return this.Id == other.Id;
        }

        /// <summary>
        /// Gets the hash code for the locale information
        /// </summary>
        /// <returns>The hash code</returns>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        /// <summary>
        /// Formats the locale information
        /// </summary>
        /// <returns>A string representing the locale information</returns>
        public override readonly string ToString()
        {
            return $"[Name='{Name}', Language='{Language}', Region='{Region}']";
        }

        /// <summary>
        /// Creates a new localisation information item
        /// </summary>
        /// <param name="language">The language for the item (e.g. en)</param>
        /// <param name="region">The region for the item (e.g. US)</param>
        /// <returns></returns>
        public static LocaleInfo Create(string language, string region)
        {
            return new LocaleInfo() {
                Language = language,
                Region = region
            };
        }

        /// <summary>
        /// Determines if two locale informations are equal
        /// </summary>
        /// <param name="obj">The other one to compare it to</param>
        /// <returns>True if they are equal</returns>
        public override bool Equals(object obj)
        {
            return obj is LocaleInfo info && Equals(info);
        }
    }
}