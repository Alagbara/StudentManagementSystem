import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from '../nav/NavMenu';
import HeroBanner from '../home/HeroBanner';
import { Login } from '../login/Login';
import '../layout/layout.css';

export class Layout extends Component {
  static displayName = Layout.name;

  render() {
    return (
      <div>
        <HeroBanner />
        <NavMenu />
        <Login />
        <Container id="render_container">{this.props.children}</Container>
      </div>
    );
  }
}
