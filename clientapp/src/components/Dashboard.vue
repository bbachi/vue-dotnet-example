<template>
  <div class="hello">
    <Header />
    <div class="container mrgnbtm">
          <div class="row">
            <div class="col-md-8">
                <CreateUser @createUser="userCreate($event)" />
            </div>
           <div class="col-md-4">
                <DisplayBoard :numberOfUsers="numberOfUsers" @getAllUsers="getUsers()" />
            </div>
          </div>
    </div>
    <div class="row mrgnbtm">
        <Users v-if="users.length > 0" :users="users" />
    </div>
  </div>
</template>

<script>
import Header from './Header.vue'
import CreateUser from './CreateUser.vue'
import DisplayBoard from './DisplayBoard.vue'
import Users from './Users.vue'
import { getAllUsers, createUser } from '../services/UserService'

export default {
  name: 'Dashboard',
  components: {
    Header,
    CreateUser,
    DisplayBoard,
    Users
  },
  data() {
      return {
          users: [],
          numberOfUsers: 0
      }
  },
  methods: {
    getUsers() {
      getAllUsers().then(res => {
        this.users = res;
        console.log(this.users)
        this.numberOfUsers = this.users.length
      });
    },
    userCreate(data) {
      console.log(data);
      createUser(data).then(res => {
        this.getUsers();
        console.log('res:::', res);
      });
    }
  },
  mounted () {
    this.getUsers();
  }
}
</script>