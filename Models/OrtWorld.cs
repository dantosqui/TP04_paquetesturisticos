class OrtWorld {


    static public List<string> ListaDestinos {get; private set;} = new List<string> {"Ushuaia", "Lima", "Ciudad del Cabo", "Berlin", "San Petersburgo", "Kabul", "San Fransisco", "Mar del Plata", "Avellaneda", "Isla Rapa Nui"};
    static public List<string> ListaHotles {get; private set;} = new List<string> {"~/img/hotel00.jfif","~/img/hotel01.jfif","~/img/hotel02.jfif","~/img/hotel03.jfif","~/img/hotel04.jfif","~/img/hotel06.jfif","~/img/hotel07.jfif","~/img/hotel05.jfif","~/img/hotel08.jfif","~/img/hotel09.jfif"};
    static public List<string> ListaAereos {get; private set;} =new List<string> {"~/img/aereos00.jfif", "~/img/aereos01.jfif", "~/img/aereos02.jfif", "~/img/aereos03.jpg", "~/img/aereos04.jfif", "~/img/aereos05.jfif", "~/img/aereos06.jfif", "~/img/aereos07.jfif", "~/img/aereos08.jfif", "~/img/aereos09.jfif"};
    static public List<string> ListaExcursiones {get; private set;} = new List<string>  {"~/img/excur00.jfif", "~/img/excur01.jfif", "~/img/excur02.jfif", "~/img/excur03.jfif", "~/img/excur04.jfif", "~/img/excur05.jpg", "~/img/excur06.jfif", "~/img/excur07.jfif", "~/img/excur08.jfif", "~/img/excur09.jfif"};
    static public Dictionary<string,Paquete> Paquetes {get; private set;} = new Dictionary<string, Paquete>();
    static public bool hayPaquetes {get; private set;}= false;
    
    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete) {
        bool e;

        e=Paquetes.ContainsKey(destinoSeleccionado);
        if (!e) Paquetes.Add(destinoSeleccionado, paquete);
        hayPaquetes=true;
        return e;
    }
    public static void BorrarPaquete(string destino) {
        Paquetes.Remove(destino);
    }
}