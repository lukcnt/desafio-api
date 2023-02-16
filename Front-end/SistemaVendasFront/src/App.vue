<script setup>
</script>

<template>

<div class="navbar">
  <router-link to="/">Home</router-link>
  <div class="dropdown">
    <button class="dropbtn">Vendedor 
      <i class="fa fa-caret-down"></i>
    </button>
    <div class="dropdown-content">
      <router-link to="/vendedor/listar">Listar</router-link>
      <router-link to="/vendedor/cadastrar">Cadastrar</router-link>
    </div>
  </div>
  <div class="dropdown">
    <button class="dropbtn">Cliente 
      <i class="fa fa-caret-down"></i>
    </button>
    <div class="dropdown-content">
      <router-link to="/cliente/cadastrar">Cadastrar</router-link>
      <router-link to="/cliente/listar">Listar</router-link>
    </div>
  </div>
  <div class="dropdown">
    <button class="dropbtn">Serviços 
      <i class="fa fa-caret-down"></i>
    </button>
    <div class="dropdown-content">
      <router-link to="/servico/cadastrar">Cadastrar</router-link>
      <router-link to="/servico/listar">Listar</router-link>
    </div>
  </div> 
  <div class="dropdown">
    <button class="dropbtn">Pedido 
      <i class="fa fa-caret-down"></i>
    </button>
    <div class="dropdown-content">
      <router-link to="/pedido/cadastrar">Cadastrar</router-link>
      <router-link to="/pedido/listar">Listar</router-link>
    </div>
  </div>
  <div class="dropdown">
    <button class="dropbtn">Itens 
      <i class="fa fa-caret-down"></i>
    </button>
    <div class="dropdown-content">
      <router-link to="/itemPedido/cadastrar">Cadastrar</router-link>
      <router-link to="/itemPedido/listar">Listar</router-link>
    </div>
  </div> 
</div>
<router-view />
</template>

<style scoped>
body {
  font-family: Arial, Helvetica, sans-serif;
}

.navbar {
  display: flex;
  justify-content: flex-start;
  background-color: #333;
}

.navbar a {
  font-size: 16px;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

.dropdown .dropbtn {
  font-size: 16px;  
  border: none;
  outline: none;
  color: white;
  padding: 14px 16px;
  background-color: inherit;
  font-family: inherit;
  margin: 0;
}

.navbar a:hover, .dropdown:hover .dropbtn {
  background-color: red;
}

.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f9f9f9;
  min-width: 160px;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
}

.dropdown-content a {
  color: black;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
  text-align: left;
}

.dropdown-content a:hover {
  background-color: #ddd;
}

.dropdown:hover .dropdown-content {
  display: block;
}
</style>
