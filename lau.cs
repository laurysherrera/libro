//clase principal
public class libreria{
//metodo principal
    public static void Main(String[]args){
//Define euna instancia de libro como LaBellaylaBestia y la inicializo como nueva
    libro LaBellaylaBestia = new libro();
//Configurar ISBN
    LaBellaylaBestia.configurarISBN("3156784390503");
//Configurar Autor
    LaBellaylaBestia.configurarautor("Jeanne-Marrie");
//Configurar paginas
    LaBellaylaBestia.configurarnumerodepaginas(196);
    LaBellaylaBestia.configurartitulo("La bella y la bestia");


//Define una instancia de libro como ParaisoPerdido y la inicializo como nueva
    libro ParaisoPerdido = new libro();
//Configurar ISBN
    ParaisoPerdido.configurarISBN("357865432198");
//Configurar Autor
    ParaisoPerdido.configurarautor("John Milton");
//Configurar Paginas
    ParaisoPerdido.configurarnumerodepaginas(315);
    ParaisoPerdido.configurartitulo("Paraiso perdido");
//Lee unos valores, los convierte y los muestra en pantalla
LaBellaylaBestia.tostring();

//Lee unos valores, los convierte y los muestra en pantalla
ParaisoPerdido.tostring();

//condicional si
if(LaBellaylaBestia.consultarnumerodepaginas()>=ParaisoPerdido.consultarnumerodepaginas()){
    //Muestra en pantalla LaBellaylaBestia tiene mas paginas
    Console.WriteLine("LaBellaylaBestia tiene mas paginas");
    //Condicional SiNo
} else{
//Muestra en pantalla ParaisoPerdido tiene mas paginas
    Console.WriteLine("Paraiso Perdido tiene mas paginas");
} 
}
}