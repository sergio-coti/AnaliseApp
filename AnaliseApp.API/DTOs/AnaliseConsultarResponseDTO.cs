namespace AnaliseApp.API.DTOs
{
    public class AnaliseConsultarResponseDTO
    {
        private Guid? Id { get; set; }//OK
        private string? Descricao { get; set; } //OK
        private DateTime DaEmissao { get; set; } //OK
        private double? Valor { get; set; } //OK
        private Guid? EmpresaId { get; set; }//OK

        private Guid? PessoaId { get; set; } //OK

    }
}
