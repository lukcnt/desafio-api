<template>
    <h3>Alterar Serviço</h3>
    <hr/>
    <div class="form" style="padding: 1;">
        <div class="col-8">
            <div>
                <label class="form-label">Id</label>
                <input type="text" disabled class="form-control" v-model="servico.id" placeholder="Id">
            </div>
            <div>
                <label class="form-label">Nome</label>
                <input type="text" class="form-control" v-model="servico.nome"  placeholder="Nome">
            </div>
            <div>
                <label class="form-label">Descrição</label>
                <input type="text" class="form-control" v-model="servico.descricao"  placeholder="Descrição">
            </div>
            <button type="submit" class="btn btn-success" style="margin-top: 5px; padding 2px" @click="atualizarServico">Atualizar Serviço</button>
        </div>
    </div>
</template>

<script>
import ServicoDataService from '../../services/ServicoDataService';

export default {
    data() {
        return {
            servico: { }
        }
    },
    methods: {
        atualizarServico() {
            ServicoDataService.atualizar(this.servico.id,this.servico)
                .then(() => {
                    this.$router.push('listar');
                });
            },
        obterServico(id) {
            ServicoDataService.obterPorId(id)
                .then((response) => {
                    this.servico = response.data;
                });
            }
        },
    mounted() {
        this.obterServico(this.$route.params.id);
    }
}
</script>