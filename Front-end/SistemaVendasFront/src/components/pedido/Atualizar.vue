<template>
    <h3>Atualizar Pedidos</h3>
    <hr/>
    <div class="form" style="padding: 1%;">
        <div class="col-8">
            <div>
                <label class="form-label">Id</label>
                <input type="text" disabled class="form-control" v-model="pedido.id" placeholder="Id">
            </div>
            <div>
                <label class="form-label">Data</label>
                <input type="text" disabled class="form-control" v-model="pedido.data"  placeholder="Data">
            </div>
            <div>
                <label class="form-label">Id do Vendedor</label>
                <input type="text" class="form-control" v-model="pedido.vendedorId"  placeholder="Id do Vendedor">
            </div>
            <div>
                <label class="form-label">Id do Cliente</label>
                <input type="text" class="form-control" v-model="pedido.clienteId"  placeholder="Id do Cliente">
            </div>
            <div>
                <label class="form-label">Valor Total</label>
                <input type="text" class="form-control" placeholder="Valor Total">
            </div>
            <button type="submit" class="btn btn-success" style="margin-top: 5px; padding 2px" @click="atualizarPedidos">Atualizar</button>
        </div>
    </div>
</template>

<script>
import PedidoDataService from '../../services/PedidoDataService';

export default {
    data() {
        return {
            pedido: { }
        }
    },
    methods: {
        atualizarPedidos() {
            PedidoDataService.atualizar(this.pedido.id,this.pedido)
                .then(() => {
                    this.$router.push('listar');
                });
            },
        obterPedidos(id) {
            PedidoDataService.obterPorId(id)
                .then((response) => {
                    this.pedido = response.data;
                });
            }
        },
    mounted() {
        this.obterPedidos(this.$route.params.id);
    }
}
</script>