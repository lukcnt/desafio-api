<template>
    <h3>Lista de Pedidos</h3>
    <hr />
    <table class="table table-striped table-hover">
      <thead class="thead-dark">
        <tr>
          <th scope="col">Id</th>
          <th scope="col">Data</th>
          <th scope="col">Id do Vendedor</th>
          <th scope="col">Id do Cliente</th>
          <th scope="col">Valor Total</th>
          <th scope="col">Ações</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(itemPedido, index) in itensPedidos" :key="index">
          <td>{{ itemPedido.pedido.id }}</td>
          <td>{{ itemPedido.pedido.data }}</td>
          <td>{{ itemPedido.pedido.vendedorId }}</td>
          <td>{{ itemPedido.pedido.clienteId }}</td>
          <td>{{ itemPedido.valor * itemPedido.quantidade }}</td>
          <td>
            <button class="btn btn-success" @click="atualizarPedido(pedido.id)">Editar</button>
            <button class="btn btn-danger" @click="excluirPedido(pedido)">Excluir</button>
          </td>
        </tr>
      </tbody>
    </table>
  </template>
  
  <script>
  import PedidoDataService from '../../services/PedidoDataService';
  import ItemPedidoDataService from '../../services/ItemPedidoDataService';
  
  export default {
    data() {
      return {
        pedido: [],
        itensPedidos: []
      }
    },
    methods: {
      obterPedido() {
        PedidoDataService.listar()
          .then(response => {
            this.pedidos = response.data;
          });
      },
      atualizarPedido(id) {
        this.$router.push('/pedido/' + id);
      },
      async excluirPedido(pedido) {
        if (confirm(`Tem certeza que deseja excluir o pedido ${pedido.id}?`)) {
          await PedidoDataService.deletar(pedido.id);
          this.obterPedido();
        }
      },
      obterItensPedidos() {
        ItemPedidoDataService.listar()
          .then(response => {
                this.itensPedidos = response.data;
                this.somaTotal();
              });
      },
    },
    mounted() {
      this.obterPedido();
      this.obterItensPedidos();
    },
  }
  </script>
  