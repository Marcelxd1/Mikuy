
package pe.edu.pucp.lp2soft.caja.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.caja.model.Gasto;


public interface GastoDAO {
    ArrayList<Gasto> listarTodas();
    ArrayList<Gasto> listarXNombre(String nombre) ;
    int insertar(Gasto gasto);
    int modificar(Gasto gasto);
    int eliminar(int IdGasto);
}
