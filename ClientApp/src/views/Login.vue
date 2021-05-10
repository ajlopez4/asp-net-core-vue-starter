<template>
 <div>
     <h1>Sign in</h1>
    <form @submit.prevent="login" id="check-login-form">
     <label>User name</label>
     <v-text-field required v-model="username" name="username" id="username" label="username" solo></v-text-field>
     <label>Password</label>
     <v-text-field required v-model="password" name="password" id="password" label="password" solo></v-text-field>
     <v-btn type="submit" class="ma-2" color="info" form="check-login-form">Login</v-btn>
     <!-- <label>Password</label>
     <input required v-model="password" type="password" placeholder="Password"/>
     <hr/>
     <v-btn type="submit" color="success" form="check-login-form">Login</v-btn>
     <button type="submit" @click="submit">Login</button> -->
     </form>

 </div>
</template>
<script>
import Vue from 'vue';
import Vuex from 'vuex';
import { Action} from 'vuex-class';
export default Vue.extend({
    data() {
      return {
        username: '',
        password:''
        }
      
  },
  methods: {
      login() {
           this.$store.dispatch('retrieveToken', {
             username: this.username,
             password: this.password
           })
        }
  }
});
</script>

