<template>
    <h3>Atualizar Cliente</h3>
    <hr/>
    <div class="form" style="padding: 1;">
        <div class="col-8">
            <div>
                <label class="form-label">Id</label>
                <input type="text" disabled class="form-control" v-model="cliente.id" placeholder="Id">
            </div>
            <div>
                <label class="form-label">Nome</label>
                <input type="text" class="form-control" v-model="cliente.nome"  placeholder="Nome">
            </div>
            <div>
                <label class="form-label">Login</label>
                <input type="text" disabled class="form-control" v-model="cliente.login"  placeholder="Login">
            </div>
            <div>
                <label class="form-label">Senha</label>
                <input type="password" class="form-control" v-model="cliente.senha"  placeholder="Senha">
            </div>
            <button type="submit" class="btn btn-success" style="margin-top: 5px; padding 2px" @click="atualizarCliente">Atualizar</button>
        </div>
    </div>
</template>

<script>
import ClienteDataService from '../../services/ClienteDataService';

export default {
    data() {
        return {
            cliente: { }
        }
    },
    methods: {
        atualizarCliente() {
            ClienteDataService.atualizar(this.cliente.id,this.cliente)
                .then(() => {
                    this.$router.push('listar');
                });
            },
        obterCliente(id) {
            ClienteDataService.obterPorId(id)
                .then((response) => {
                    this.cliente = response.data;
                });
            }
        },
    mounted() {
        this.obterCliente(this.$route.params.id);
    }
}
</script>