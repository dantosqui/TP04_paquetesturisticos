class OrtWorld {


    static public List<string> ListaDestinos {get; private set;} = new List<string> {"Ushuaia", "Lima", "Ciudad del Cabo", "Berlin", "San Petersburgo", "Kabul", "San Fransisco", "Mar del Plata", "Avellaneda", "Isla Rapa Nui"};
    static public List<string> ListaHotles {get; private set;} = new List<string> {"hotel00","hotel01","hotel02","hotel03","hotel04","hotel06","hotel06","hotel05","hotel08","hotel09", };
    static public List<string> ListaAereos {get; private set;} =new List<string> {"aereo00", "aereo01", "aereo02", "aereo03", "aereo04", "aereo05", "aereo06", "aereo07", "aereo08", "aereo09", };
    static public List<string> ListaExcursiones {get; private set;} = new List<string>  {"excur00", "excur01", "excur02", "excur03", "excur04", "excur05", "excur06", "excur07", "excur08", "excur09", };
    static public Dictionary<string,Paquete> Paquetes {get; private set;}

    
    bool IngresarPaquete(string destinoSeleccionado, Paquete paquete) {
        bool e;

        e=Paquetes.ContainsKey(destinoSeleccionado);
        if (!e) Paquetes.Add(destinoSeleccionado, paquete);

        return e;
    }
}