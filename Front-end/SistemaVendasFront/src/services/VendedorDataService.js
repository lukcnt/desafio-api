import http from "../http-common";

class VendedorDataService {
    listar() {
        return http.get('/Vendedor/ListarVendedores');
    }
}

export default new VendedorDataService();