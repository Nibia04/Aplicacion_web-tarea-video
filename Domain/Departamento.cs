namespace Domain;

public class Departamento
{
  public int Id { get; set; }
  public string Nombre { get; set; } = string.Empty;
}
public interface IDepartamentoRepository
{
  Task<List<Departamento>> GetAllAsync();
  Task<Departamento?> GetByIdAsync(int id);
  Task<Departamento> CreateAsync(Departamento departamento);
  Task<Departamento?> UpdateAsync(Departamento departamento);
  Task<bool> DeleteAsync(int id);
}
