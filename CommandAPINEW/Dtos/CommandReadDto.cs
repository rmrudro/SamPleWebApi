using System.ComponentModel.DataAnnotations;

namespace CommandAPINEW.Dtos
{
    public class CommandReadDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Howto { get; set; }
        [Required]
        public string Line { get; set; }
       

    }
}
