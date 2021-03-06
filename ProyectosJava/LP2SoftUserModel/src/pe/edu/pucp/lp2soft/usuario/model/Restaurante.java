package pe.edu.pucp.lp2soft.usuario.model;

public class Restaurante {
    private int id_restaurante ; 
    private String ruc; 
    private String nombre ;
    private String telefono ; 
    private String direccion ;
    private double dineroActual ;
    private boolean activo;
    
    public Restaurante(){}
    public Restaurante(String ruc, String nombre, String telefono, String direccion, double dineroActual) {
        this.ruc = ruc;
        this.nombre = nombre;
        this.telefono = telefono;
        this.direccion = direccion;
        this.dineroActual = dineroActual;
        this.activo = true;
    }
    
    
    
    public int getId_restaurante() {
        return id_restaurante;
    }

    public void setId_restaurante(int id_restaurante) {
        this.id_restaurante = id_restaurante;
    }

    public String getRuc() {
        return ruc;
    }

    public void setRuc(String ruc) {
        this.ruc = ruc;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public double getDineroActual() {
        return dineroActual;
    }

    public void setDineroActual(double dineroActual) {
        this.dineroActual = dineroActual;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
}
