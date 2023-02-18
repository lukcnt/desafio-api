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
          <th scope="col">Ações</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(pedido, index) in pedidos" :key="index">
          <td>{{ pedido.id }}</td>
          <td>{{ pedido.data }}</td>
          <td>{{ pedido.vendedorId }}</td>
          <td>{{ pedido.clienteId }}</td>
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
  
  export default {
    data() {
      return {
        pedidos: [],
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
      }
    },
    mounted() {
      this.obterPedido();
    },
  }
  </script>
  