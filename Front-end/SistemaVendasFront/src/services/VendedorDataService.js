import http from "../http-common";

class VendedorDataService {
    listar() {
        return http.get('/Vendedor/ListarVendedores');
    }

    cadastrar(vendedor) {
        return http.post('/Vendedor', vendedor);
    }
}

export default new VendedorDataService();