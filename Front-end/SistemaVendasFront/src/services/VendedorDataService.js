import http from "../http-common";

class VendedorDataService {
    listar() {
        return http.get('/Vendedor/ListarVendedores');
    }

    cadastrar(vendedor) {
        return http.post('/Vendedor', vendedor);
    }

    atualizar(id, vendedor) {
        return http.put(`/Vendedor/${id}`, vendedor);
    }

    obterPorId(id) {
        return http.get(`/Vendedor/${id}`);
    }

    async deletar(id) {
        return await http.delete(`/Vendedor/${id}`);
    }
}

export default new VendedorDataService();