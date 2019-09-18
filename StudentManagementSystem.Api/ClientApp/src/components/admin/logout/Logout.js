import React, { Component } from 'react';
import { Button } from 'reactstrap';
import './logout.css';

export class Logout extends Component {
  constructor(props) {
    super(props);
  }

  handleLogoutOnClick(e) {
    console.log('returning to logout page');
    this.props.logout(false);
  }

  render() {
    return (
      <div id="logout_container">
        <Button color="success" onClick={e => this.handleLogoutOnClick(e)}>
          Logout
        </Button>
      </div>
    );
  }
}
