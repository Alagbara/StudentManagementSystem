import React, { Component } from 'react';
import HeroBanner from '../../frontfacing/home/HeroBanner';
import { Dashboard } from '../dashboard/Dashboard';
import { Container } from 'reactstrap';
import { Logout } from '../logout/Logout';
import { Button } from 'reactstrap';
import '../logout/logout.css';

export class AdminLayout extends Component {
  static displayName = AdminLayout.name;

  constructor(props) {
    super(props);
  }

  render() {
    return (
      <div>
        {/* <Dashboard></Dashboard> */}
        <Container id="render_container_admin">{this.props.children}</Container>
      </div>
    );
  }
}
