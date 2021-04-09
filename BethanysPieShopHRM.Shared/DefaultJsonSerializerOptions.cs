using System.Text.Json;
using System.Text.Json.Serialization;

namespace BethanysPieShopHRM.Shared {
    public static class Defaults {

        public static JsonSerializerOptions JsonSerializerOptions { get; }

        static Defaults() {
            JsonSerializerOptions
                = new() {
                    PropertyNameCaseInsensitive = true,
                    ReferenceHandler = ReferenceHandler.Preserve
                };
        }

    }
}
