<template>
  <h1>Lista de Clientes</h1>
  <div class="col-7">
    <hr/>
    <table class="table table-striped table-hover">
      <thead class="thead-dark">
        <tr>
          <th scope="col">Id</th>
          <th scope="col">Nome</th>
          <th scope="col">Login</th>
          <th scope="col">Ações</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for= "(cliente,index) in clientes" :key = "index">
          <td>{{ cliente.id }}</td>
          <td>{{ cliente.nome }}</td>
          <td>{{ cliente.login }}</td>
          <td>
            <button class="btn btn-success" @click="atualizarCliente(cliente.id)">Editar</button>
            <button class="btn btn-danger" @click="excluirCliente(cliente)">Excluir</button>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
  import ClienteDataService from '../../services/ClienteDataService';
  export default {
    data(){
      return{
        clientes: []
      }
    },
    methods:{
      obterClientes() {
        ClienteDataService.listar()
          .then(response => {
            this.clientes = response.data;
          });
      },
      atualizarCliente(id) {
        this.$router.push('/cliente/' + id);
      },
      async excluirCliente(cliente) {
        if (confirm(`Tem certeza que deseja excluir cliente ${cliente.nome}?`)) {
            await ClienteDataService.deletar(cliente.id);
            this.obterClientes();
          }
      }
    },
    mounted() {
      this.obterClientes();
    }
  }
</script>