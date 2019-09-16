import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from '../nav/NavMenu';
import HeroBanner from '../home/HeroBanner';
import { Login } from '../login/Login';
import './layout.css';

export class Layout extends Component {
  static displayName = Layout.name;
  constructor(props) {
    super(props);
  }

  componentDidMount() {
    //this.props.userHasAuthenticated(false);
  }

  // login() {
  //   alert('yehh');
  // }

  render() {
    return (
      <div>
        <HeroBanner />
        <NavMenu />
        {/* <Login login={this.login} /> */}
        <Container id="render_container">{this.props.children}</Container>
      </div>
    );
  }
}
