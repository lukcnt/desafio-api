<template>
    <h3>Lista de Serviços</h3>
    <hr/>
    <table class="table table-striped table-hover">
      <thead class="thead-dark">
        <tr>
          <th scope="col">Id</th>
          <th scope="col">Nome</th>
          <th scope="col">Descrição</th>
          <th scope="col">Ações</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(servico,index) in servicos" :key = "index">
          <td>{{ servico.id }}</td>
          <td>{{ servico.nome }}</td>
          <td>{{ servico.descricao }}</td>
          <td>
            <button class="btn btn-success" @click="atualizarServico(servico.id)">Editar</button>
            <button class="btn btn-danger" @click="excluirServico(servico)">Excluir</button>
          </td>
        </tr>
      </tbody>
    </table>
  </template>
  
  <script>
import ServicoDataService from '../../services/ServicoDataService';

export default {
      data(){
        return{
          servicos: []
        }
      },
      methods:{
        obterServicos() {
          ServicoDataService.listar()
            .then(response => {
              this.servicos = response.data;
            });
        },
        atualizarServico(id) {
          this.$router.push('/servico/' + id);
        },
        async excluirServico(servico) {
          if (confirm(`Tem certeza que deseja excluir o servico ${servico.nome}?`)) {
              await ServicoDataService.deletar(servico.id);
              this.obterServicos();
            }
        }
      },
      mounted() {
        this.obterServicos();
      }
    }
</script>