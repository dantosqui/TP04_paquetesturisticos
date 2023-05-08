class OrtWorld {


    static public List<string> ListaDestinos {get; private set;} = new List<string> {"Ushuaia", "Lima", "Ciudad del Cabo", "Berlin", "San Petersburgo", "Kabul", "San Fransisco", "Mar del Plata", "Avellaneda", "Isla Rapa Nui"};
    static public List<string> ListaHotles {get; private set;} = new List<string> {"hotel00.jfif","hotel01.jfif","hotel02.jfif","hotel03.jfif","hotel04.jfif","hotel06.jfif","hotel06.jfif","hotel05.jfif","hotel08.jfif","hotel09.jfif"};
    static public List<string> ListaAereos {get; private set;} =new List<string> {"aereos00.jfif", "aereos01.jfif", "aereos02.jfif", "aereos03.jpg", "aereos04.jfif", "aereos05.jfif", "aereos06.jfif", "aereos07.jfif", "aereos08.jfif", "aereos09.jfif"};
    static public List<string> ListaExcursiones {get; private set;} = new List<string>  {"excur00.jfif", "excur01.jfif", "excur02.jfif", "excur03.jfif", "excur04.jfif", "excur05.jpg", "excur06.jfif", "excur07.jfif", "excur08.jfif", "excur09.jfif"};
    static public Dictionary<string,Paquete> Paquetes {get; private set;}

    
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete) {
        bool e;

        e=Paquetes.ContainsKey(destinoSeleccionado);
        if (!e) Paquetes.Add(destinoSeleccionado, paquete);

        return e;
    }
}