class Paquete
{
    public string Hotel { get; private set; } 
    public string Aereo { get; set; } 
    public string Excursion { get; set; } 

    public Paquete(string hotel, string aereo, string excursion){
        hotel = Hotel;
        aereo = Aereo;
        excursion = Excursion;
    }
}
