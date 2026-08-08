<script setup>
    import { ref } from "vue";
    const userName = ref("Base");
    const password = ref("Pwd");

    function login() {
        //alert("Username: " + userName.value + "\nPassword: " + password.value);
        alert(`Username: ${userName.value}\nPassword: ${password.value}`);
    }

    function isBothFilled() {
        if ()
    }
</script>

<template>
    <h1>BudgetBrain</h1>
    <label>Username:</label>
    <br>
    <input type="text" v-model="userName">
    <br>
    <label>Password:</label>
    <br>
    <input type="password" v-model="password">
    <br>
    <p>You typed: {{ userName }}, {{ password }}</p>
    <br>
    <button @click="login">Login</button>
</template>

<style scoped>
    h1 {
        color: grey;
        background-color: black;
    }
</style>
