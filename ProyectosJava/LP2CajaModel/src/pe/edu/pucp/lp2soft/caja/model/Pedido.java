package pe.edu.pucp.lp2soft.caja.model;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.negocio.model.Mesa;
import pe.edu.pucp.lp2soft.usuario.model.Persona;
import pe.edu.pucp.lp2soft.usuario.model.Usuario;

public class Pedido extends Transaccion {

    private int idPedido; //deberia ser heredado de transaccion
    private Mesa mesa;
    private char tipoPago; //{tarjeta contado}
    private Usuario mesero;//el mesero maneja todo para llevar y para mesa
    private Usuario cajero;
    private char tipoPedido;//llevar o mesa
    private Persona cliente;
    private char tipoComprobante;//boleta factura
    private int numeroComprobante;
    private char estado;// 3 estados creo
    private ArrayList<LineaPedido> list_lineaPedido;

    //private Restaurante rest;
    public Pedido(char tipoPago, Usuario mesero, Usuario cajero, char tipoPedido, Persona cliente, char tipoComp, int numComp, char estado) {
        //this.idPedido = idPedido; no se puede asignar es generado por el sistema
        this.tipoPago= tipoPago;
        this.mesero= mesero;
        this.cajero= cajero;
        this.tipoPedido= tipoPedido;
        this.cliente= cliente;
        this.tipoComprobante= tipoComp;
        this.numeroComprobante= numComp;
        this.estado= estado;
    }

    /**
     * @return the idPedido
     */
    public int getIdPedido() {
        return idPedido;
    }

    /**
     * @param idPedido the idPedido to set
     */
    public void setIdPedido(int idPedido) {
        this.idPedido = idPedido;
    }

    /**
     * @return the mesa
     */
    public Mesa getMesa() {
        return mesa;
    }

    /**
     * @param mesa the mesa to set
     */
    public void setMesa(Mesa mesa) {
        this.mesa = mesa;
    }

    /**
     * @return the tipoPago
     */
    public char getTipoPago() {
        return tipoPago;
    }

    /**
     * @param tipoPago the tipoPago to set
     */
    public void setTipoPago(char tipoPago) {
        this.tipoPago = tipoPago;
    }

    /**
     * @return the mesero
     */
    public Usuario getMesero() {
        return mesero;
    }

    /**
     * @param mesero the mesero to set
     */
    public void setMesero(Usuario mesero) {
        this.mesero = mesero;
    }

    /**
     * @return the cajero
     */
    public Usuario getCajero() {
        return cajero;
    }

    /**
     * @param cajero the cajero to set
     */
    public void setCajero(Usuario cajero) {
        this.cajero = cajero;
    }

    /**
     * @return the tipoPedido
     */
    public char getTipoPedido() {
        return tipoPedido;
    }

    /**
     * @param tipoPedido the tipoPedido to set
     */
    public void setTipoPedido(char tipoPedido) {
        this.tipoPedido = tipoPedido;
    }

    /**
     * @return the cliente
     */
    public Persona getCliente() {
        return cliente;
    }

    /**
     * @param Cliente the cliente to set
     */
    public void setCliente(Persona Cliente) {
        this.cliente = Cliente;
    }

    /**
     * @return the tipoComprobante
     */
    public char getTipoComprobante() {
        return tipoComprobante;
    }

    /**
     * @param tipoComprobante the tipoComprobante to set
     */
    public void setTipoComprobante(char tipoComprobante) {
        this.tipoComprobante = tipoComprobante;
    }

    /**
     * @return the numeroComprobante
     */
    public int getNumeroComprobante() {
        return numeroComprobante;
    }

    /**
     * @param numeroComprobante the numeroComprobante to set
     */
    public void setNumeroComprobante(int numeroComprobante) {
        this.numeroComprobante = numeroComprobante;
    }

    /**
     * @return the estado
     */
    public char getEstado() {
        return estado;
    }

    /**
     * @param estado the estado to set
     */
    public void setEstado(char estado) {
        this.estado = estado;
    }

    /**
     * @return the list_lineaPedido
     */
    public ArrayList<LineaPedido> getList_lineaPedido() {
        return list_lineaPedido;
    }

    /**
     * @param list_lineaPedido the list_lineaPedido to set
     */
    public void setList_lineaPedido(ArrayList<LineaPedido> list_lineaPedido) {
        this.list_lineaPedido = list_lineaPedido;
    }
    

   
}
