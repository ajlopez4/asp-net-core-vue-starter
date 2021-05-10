import { ActionTree } from 'vuex';
import axios from 'axios';
import { LoginState } from './types';
import { RootState } from '../types';

export const actions: ActionTree<LoginState, RootState> = {
    retrieveToken(context, credentials) {
        axios.post('UserService/Authenticate', {
            username: credentials.username,
            password: credentials.password,
        }).then(response => {
            console.log(response);
        }).catch(error => {
            console.log(error)
        })
    }
    
};
