using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; } //O campo ID é necessário para o banco de dados para a chave primária.
        public string? Title { get; set; }
        [DataType(DataType.Date)] //Um atributo [DataType] que especifica o tipo de dados na ReleaseDate propriedade. O usuário não precisa inserir informações de hora no campo de data. Somente a data é exibida, não as informações de tempo.
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; } //O ponto de interrogação após string indica que a propriedade é anulável. 
        public decimal price { get; set; }
    }
}
