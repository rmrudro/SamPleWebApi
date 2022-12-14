using System.ComponentModel.DataAnnotations;

namespace CommandAPINEW.Dtos
{
    public class CommandCreateDto
    {
        
        [Required] 
        [MaxLength(255)]
        public string Howto { get; set; }
        [Required]
        public string Line { get; set; }

        [Required] 
        public string Platform { get; set; }

    }
}
