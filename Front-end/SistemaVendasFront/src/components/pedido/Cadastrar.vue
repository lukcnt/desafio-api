<template>
    <div id="cadastro-pedido">
      <h3>Novo Pedido</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Data</label>
              <input type="text" class="form-control" disabled :value="toLocaleDate(dateToView)">
          </div>
          <div>
              <label for="" class="form-label">Vendedor</label>
              <input type="text" required class="form-control" placeholder="Id do Vendedor" v-model="pedido.vendedorId">
          </div>
          <div>
              <label for="" class="form-label">Cliente</label>
              <input type="password" required class="form-control" placeholder="Id do Cliente" v-model="pedido.clienteId">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="cadastrarVendedor">Cadastrar</button>
      </div>
    </div>
  </template>
  
<script>
import PedidoDataService from '../../services/PedidoDataService'

export default {
      data(){
          return{
              dateToView: new Date(),
              pedido: {
                  data: new Date().toISOString(),
                  vendedorId: "",
                  clienteId: ""
              }
          }
      },
      methods: {
        toLocaleDate(date){
              let localeDate = date
              return localeDate.toLocaleString()
        },

        cadastrarVendedor(){
            if (this.pedido.clienteId === '' || this.pedido.vendedorId === '')
            {
                alert("Todos os campos devem ser preenchido!");
            }
            else
            {
                var data = {
                    data: this.pedido.data,
                    vendedorId: this.pedido.vendedorId,
                    clienteId: this.pedido.clienteId
                };

                PedidoDataService.cadastrar(data)
                  .then(() => {
                      this.$router.push('listar')
                  });
            }
        }

      }
  }
  </script>