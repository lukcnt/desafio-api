<template>
    <div>
      <h3>Novo Servico</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Id Pedido</label>
              <input type="text" class="form-control" required placeholder="Id Pedido" v-model="cadastro.pedidoId">
          </div>
          <div>
              <label for="" class="form-label">Id Servico</label>
              <input type="text" class="form-control" required placeholder="Id Servico" v-model="cadastro.servicoId">
          </div>
          <div>
              <label for="" class="form-label">Quantidade</label>
              <input type="text" class="form-control" required placeholder="Quantidade" v-model="cadastro.quantidade">
          </div>
          <div>
              <label for="" class="form-label">Valor</label>
              <input type="text" class="form-control" required placeholder="Valor" v-model="cadastro.valor">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarItemPedido">Cadastrar</button>
      </div>
    </div>
</template>
  
<script>
import ItemPedidoDataService from '../../services/ItemPedidoDataService';

export default {
      data(){
          return{
              cadastro: {
                  pedidoId: "",
                  servicoId: "",
                  quantidade: "",
                  valor: ""
              }
          }
      },
      methods: {
        cadastrarItemPedido(){
            if (this.cadastro.pedidoId === '' || this.cadastro.servicoId === '' || this.cadastro.quantidade === '' || this.cadastro.valor === '')
            {
                alert("Todos os campos devem ser preenchidos!");
            }
            else
            {
                var data = {
                pedidoId: this.cadastro.pedidoId,
                servicoId: this.cadastro.servicoId,
                quantidade: this.cadastro.quantidade,
                valor: this.cadastro.valor,
                };

                ItemPedidoDataService.cadastrar(data)
                  .then(() => {
                      this.$router.push('listar')
                  });
            }
        }
      }
  }
  </script>