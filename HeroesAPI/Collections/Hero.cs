using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace HeroesAPI.Collections
{
    [Table("Heroes")]
    [BsonIgnoreExtraElements]
    public class Hero
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nome")]
        [JsonPropertyName("Nome")]
        public string Nome { get; set; }

        [BsonElement("time")]
        [JsonPropertyName("Time")]
        public string Time { get; set; }

        [BsonElement("idade")]
        [JsonPropertyName("Idade")]
        public int Idade { get; set; }

        [BsonElement("genero")]
        [JsonPropertyName("Genero")]
        public string Genero { get; set; }

        [BsonElement("habilidades")]
        [JsonPropertyName("Habilidades")]
        public List<string> Habilidades { get; set; }

        [BsonElement("usaCapa")]
        [JsonPropertyName("UsaCapa")]
        public Boolean UsaCapa { get; set; }

        [BsonElement("universo")]
        [JsonPropertyName("Universo")]
        public string Universo { get; set; }
    }
}