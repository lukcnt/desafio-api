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
    }
];
const router = createRouter({
    history: createWebHistory(),
    routes
});
export default router;