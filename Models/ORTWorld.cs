class ORTWorld
{
    public static List<string> ListaDestinos { get; private set; } = new List<string> { "Berlin, Madrid, Barcelona, Viena, Florida, Miami, Seoul, Valencia, Londres, Manchester" };
    public static List<string> ListaHoteles { get; private set; } = new List<string> { "hotelBerlin.jfif, hotelMadrid.jpg, hotelBarcelona.jpg, hotelViena.jpg, hotelFlorida.jpg, hotelMiami.jpg, hotelSeoul.jpg, hotelValencia.jpg, hotelLondres.jpg, hotelManchester.jpg" };
    public static List<string> ListaAereos { get; private set; } = new List<string> { "vueling.jpg, americanairlines.jpg, qatar.jpg, airfrance.jpg, aireuropa.jpg, latam.jpg, flybondi.jpg, iberia.png, aerolineasargentinas.jpg, avianca.jpg" };
    public static List<string> ListaExcursiones { get; private set; } = new List<string> { "ex1.jpg, ex2.jpg, ex3.jpg, ex4.jpg, ex5.jfif, ex6.jpg, ex7.jpg, ex8.jpg, ex9.jpg, ex10.jpg" };
    public static Dictionary<string, Paquete> Paquetes { get; private set; }



    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        destinoSeleccionado = IngresarString("Ingrese el destino seleccionado");
        
        bool coincide = false;
        if (ListaDestinos.Contains(destinoSeleccionado) == true)
        { // Verifica que el destino no exista previamente
            coincide = true;
        }

        return coincide;
    }

    private static string IngresarString(string msg){
        Console.WriteLine(msg);
        return Console.ReadLine(); 
    }
}