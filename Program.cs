public class libro {
    private string ISBN="";
    private string titulo="";
    private string autor="";
    private int numerodepaginas;

    public string consultarISBN(){
        return this.ISBN;
    } //consultar el isbn
    public void configurarISBN(string isbn){
        this.ISBN=isbn;
    }//configura el isbn
    public string consultartitulo(){
        return this.titulo;
    }// consulta el titulo
    public void configurartitulo(string titulo){
        this.titulo=titulo;
    } // configurar el titul
    public string consultarautor(){
        return this.autor;
    } // consultar autor
    public void configurarautor(string autor){
        this.autor=autor;
    } //configurar autor
    public int consultarnumerodepaginas(){
        return this.numerodepaginas;
    } // consultar numero de paginas
        public void configurarnumerodepaginas(int num){
         this.numerodepaginas=num;
    } //configurar numero de paginas

public void setautor(string nombre){
    this.autor=nombre;
}

public void tostring(){
    Console.WriteLine("el libro "+this.titulo+" con ISBN "+this.ISBN+"creado por el autor"+this.autor+"tiene "+this.numerodepaginas);
}
}




