import React, { Component } from 'react';
import './Login.css';
import '@fortawesome/fontawesome-free';
import { Button } from 'reactstrap';

export class Login extends Component {
  constructor(props) {
    super(props);
    //this.userHasAuthenticated = this.userHasAuthenticated.bind(this);
  }

  state = {
    email: '',
    password: ''
  };

  validateLoginForm() {
    return this.state.email.length > 0 && this.state.password.length > 0;
  }

  handleLoginOnClick(e) {
    window.location.assign('/Admin/');
    //this.props.login(true);
  }

  render() {
    return (
      <div id="login_container">
        <h1>Login</h1>
        <Button color="success" onClick={e => this.handleLoginOnClick(e)}>
          Login
        </Button>
      </div>
    );
  }
}
