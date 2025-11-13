public class Veicolo
{
    public string Marca { get; set; }
    public string Modello { get; set; }
    public int NumeroPorte { get; set; }
    public int Cilindrata { get; set; }
    
}
public class Auto: Veicolo
{
    public int NumeroPosti { get; set; }
}