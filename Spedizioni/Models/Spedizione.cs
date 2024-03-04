using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Spedizioni.Models
{
    public class Spedizione
    {
        public int IdSpedizione { get; set; }
        public int IdCliente { get; set; }
        [DisplayName("Crea codice tracciamento")]
        [Required(ErrorMessage = "Il codice è obbligatorio")]
        [StringLength(12, MinimumLength = 12,
        ErrorMessage = "Il codice deve essere di 12 caratteri")]
        public string CodTraccia { get; set; }

        public DateTime DataSpedizione { get; set; }
        [DisplayName("Inserisci il peso della spedizione")]
        [Required(ErrorMessage = "Il codice è obbligatorio")]
        public decimal PesoSpedizione { get; set; }
        [DisplayName("Inserisci la citta di destinazione")]
        [Required(ErrorMessage = "la destinazione e' obbligatoria")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "la citta deve essere compresa tra 3 e 50 caratteri")]
        public string CittaDestinazione { get; set; }
        [DisplayName("Inserisci l'indirizzo di destinazione")]
        [Required(ErrorMessage = "l'indirizzo di destinazione e' obbligatorio")]
        public string IndirizzoDestinazione { get; set; }
        [DisplayName("Inserisci il nominativo del destinatario")]
        [Required(ErrorMessage = "Il nominativo del destinatario e' obbligatorio")]
        [StringLength(255, MinimumLength = 3,
            ErrorMessage = "Il nominativo del destinatario deve essere compreso tra 3 e 255 caratteri")]
        public string NomeDestinatario { get; set; }
        [DisplayName("Inserisci il costo della spedizione")]
        [Required(ErrorMessage = "Il costo della spedizione e' obbligatorio")]
        public decimal CostoSpedizione { get; set; }
        public DateTime DataConsegna { get; set; }
    }
}