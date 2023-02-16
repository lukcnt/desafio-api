<template>
    <h3>Alterar Item Pedido</h3>
    <hr/>
    <div class="form" style="padding: 1;">
        <div class="col-8">
            <div>
                <label class="form-label">Id do Item Pedido</label>
                <input type="text" disabled class="form-control" v-model="itemPedido.id" placeholder="Id do Item Pedido">
            </div>
            <div>
                <label class="form-label">Id do Serviço</label>
                <input type="text" disabled class="form-control" v-model="itemPedido.servicoId" placeholder="Id do Serviço">
            </div>
            <div>
                <label class="form-label">Id do Pedido</label>
                <input type="text" disabled class="form-control" v-model="itemPedido.pedidoId"  placeholder="Id do Pedido">
            </div>
            <div>
                <label class="form-label">Quantidade</label>
                <input type="text" class="form-control" v-model="itemPedido.quantidade"  placeholder="Quantidade">
            </div>
            <div>
                <label class="form-label">Valor</label>
                <input type="text" class="form-control" v-model="itemPedido.valor"  placeholder="Valor">
            </div>
            <button type="submit" class="btn btn-success" style="margin-top: 5px; padding 2px" @click="atualizarItemPedido">Atualizar</button>
        </div>
    </div>
</template>

<script>
import ItemPedidoDataService from '../../services/ItemPedidoDataService';
export default {
    data() {
        return {
            itemPedido: { }
        }
    },
    methods: {
        atualizarItemPedido() {
            ItemPedidoDataService.atualizar(this.itemPedido.id,this.itemPedido)
                .then(() => {
                    this.$router.push('listar');
                });
            },
        obterItemPedido(id) {
            ItemPedidoDataService.obterPorId(id)
                .then((response) => {
                    this.itemPedido = response.data;
                });
            }
        },
    mounted() {
        this.obterItemPedido(this.$route.params.id);
    }
}
</script>