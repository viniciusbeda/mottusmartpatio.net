namespace MottuSmartPatio.Models
{
    public class Moto
    {
        /// <example>1</example>
        public int Id { get; set; }

        /// <example>ABC1234</example>
        public string Placa { get; set; } = string.Empty;

        /// <example>Honda CG 160</example>
        public string Modelo { get; set; } = string.Empty;

        /// <example>Ativa</example>
        public string Status { get; set; } = string.Empty;
    }
}
