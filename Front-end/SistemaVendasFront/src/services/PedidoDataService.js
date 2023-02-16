import http from "../http-common";

class PedidoDataService {
    listar() {
        return http.get('/Pedido/ListarPedidos');
    }
    cadastrar(pedido){
        return http.post('/Pedido',pedido);
    }
    atualizar(id,pedido){
        return http.put(`/Pedido/${id}`,pedido);
    }
    obterPorId(id){
        return http.get(`/Pedido/${id}`);
    }
    async deletar(id){
        return await http.delete(`/Pedido/${id}`);
    }
}
export default new PedidoDataService();