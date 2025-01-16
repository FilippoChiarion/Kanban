using System.ComponentModel.DataAnnotations;

namespace Kanban.Dto
{
    public class CadastroAtividadeDto
    {
        [Required(ErrorMessage = "Enter the title")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Enter the description")]
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Select a status")]
        public int StatusId { get; set; }
    }
}
