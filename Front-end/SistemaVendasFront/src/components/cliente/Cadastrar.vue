<template>
    <h3>Novo Cliente</h3>
    <div class="form" style="padding: 1%;">
        <hr/>
        <div class="col-3">
            <div>
                <label class="form-label">Nome</label>
                <input type="text" class="form-control" required placeholder="Nome" v-model="cadastro.nome">
            </div>
            <div>
                <label class="form-label">Login</label>
                <input type="text" class="form-control" required placeholder="Login" v-model="cadastro.login">
            </div>
            <div>
                <label class="form-label">Senha</label>
                <input type="password" class="form-control" required v-model="cadastro.senha">
            </div>
            <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarCliente">Cadastrar</button>
        </div>
    </div>
</template>
  
<script>
import ClienteDataService from '../../services/ClienteDataService'; 

export default {
      name: "CadastroCliente",
      data(){
          return{
              cadastro: {
                  nome: "",
                  login: "",
                  senha: ""
              }
          }
      },
      methods: {
          cadastrarCliente(){
            if (this.cadastro.nome === '' || this.cadastro.login === '' || this.cadastro.senha === '')
            {
                alert("Todos os campos devem ser preenchidos!");
            }
            else
            {
                var data = {
                  Nome: this.cadastro.nome,
                  Login: this.cadastro.login,
                  Senha: this.cadastro.senha,
                }
                ClienteDataService.cadastrar(data)
                    .then(() => {
                        this.$router.push('/cliente/listar');
                    });
            }
          }
      }
  }
  </script>