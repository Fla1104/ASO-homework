using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models // Am schimbat din TodoApp în BlazorApp ca să se potrivească cu proiectul tău
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Titlul este obligatoriu!")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        public bool IsCompleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}