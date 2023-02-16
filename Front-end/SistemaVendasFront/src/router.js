import { createWebHistory, createRouter } from "vue-router";
const routes = [
    {
        path: "/",
        component: () => import("./components/Home.vue")
    },
    {
        path: "/vendedor/listar",
        component: () => import("./components/vendedor/ListarVendedores.vue")
    },
    {
        path: "/vendedor/cadastrar",
        component: () => import("./components/vendedor/Cadastrar.vue")
    },
    {
        path: "/vendedor/:id",
        component: () => import("./components/vendedor/Atualizar.vue")
    },
    {
        path: "/cliente/listar",
        component: () => import("./components/cliente/ListarCliente.vue")
    },
    {
        path: "/cliente/cadastrar",
        component: () => import("./components/cliente/Cadastrar.vue")
    },
    {
        path: "/cliente/:id",
        component: () => import("./components/cliente/Atualizar.vue")
    },
    {
        path: "/servico/listar",
        component: () => import("./components/servicos/ListarServicos.vue")
    },
    {
        path: "/servico/cadastrar",
        component: () => import("./components/servicos/Cadastrar.vue")
    },
    {
        path: "/servico/:id",
        component: () => import("./components/servicos/Atualizar.vue")
    },
    {
        path: "/itemPedido/listar",
        component: () => import("./components/itemPedido/ListarItensPedido.vue")
    },
    {
        path: "/itemPedido/cadastrar",
        component: () => import("./components/itemPedido/Cadastrar.vue")
    },
    {
        path: "/itemPedido/:id",
        component: () => import("./components/itemPedido/Atualizar.vue")
    },
    {
        path: "/pedido/listar",
        component: () => import("./components/pedido/ListarPedidos.vue")
    },
    {
        path: "/pedido/cadastrar",
        component: () => import("./components/pedido/Cadastrar.vue")
    },
    {
        path: "/pedido/:id",
        component: () => import("./components/pedido/Atualizar.vue")
    }
];
const router = createRouter({
    history: createWebHistory(),
    routes
});
export default router;