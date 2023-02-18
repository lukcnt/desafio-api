<template>
    <h3>Lista de Itens Pedidos</h3>
    <hr/>
    <table class="table table-striped table-hover">
      <thead class="thead-dark">
        <tr>
          <th scope="col">Id</th>
          <th scope="col">Id do Pedido</th>
          <th scope="col">Id do Serviço</th>
          <th scope="col">Quantidade</th>
          <th scope="col">Valor Unitário</th>
          <th scope="col">Valor Total</th>
          <th scope="col">Ações</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(itemPedido,index) in itensPedidos" :key = "index">
          <td>{{ itemPedido.id }}</td>
          <td>{{ itemPedido.pedidoId }}</td>        
          <td>{{ itemPedido.servicoId }}</td>
          <td>{{ itemPedido.quantidade }}</td>
          <td>{{ itemPedido.valor }}</td>
          <td>{{ itemPedido.valor * itemPedido.quantidade }}</td>
          <td>
            <button class="btn btn-success" @click="atualizarItemPedido(itemPedido.id)">Editar</button>
            <button class="btn btn-danger" @click="excluirItemPedido(itemPedido)">Excluir</button>
          </td>
        </tr>
      </tbody>
    </table>
</template>
  
<script>
import ItemPedidoDataService from '../../services/ItemPedidoDataService';

export default {
      data(){
        return{
          itensPedidos: []
        }
      },
      methods:{
        obterItensPedidos() {
          ItemPedidoDataService.listar()
            .then(response => {
              this.itensPedidos = response.data;
            });
        },
        atualizarItemPedido(id) {
          this.$router.push('/itemPedido/' + id);
        },
        async excluirItemPedido(itemPedido) {
          if (confirm(`Tem certeza que deseja excluir o item pedido ${itemPedido.id}?`)) {
              await ItemPedidoDataService.deletar(itemPedido.id);
              this.obterItensPedidos();
            }
        }
      },
      mounted() {
        this.obterItensPedidos();
      }
    }
</script>