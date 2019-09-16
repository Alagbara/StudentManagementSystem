import React, { Component } from 'react';
import { Route, Router } from 'react-router';
import { BrowserRouter } from 'react-router-dom';
import { Layout } from './components/frontfacing/layout/Layout';
import { Home } from './components/frontfacing/home/Home';
import { Department } from './components/frontfacing/department/Department';
import { Annoucements } from './components/frontfacing/annoucements/Annoucements';
import { ContactUs } from './components/frontfacing/contactus/ContactUs';
import { AboutUs } from './components/frontfacing/aboutus/AboutUs';
import { AdminLayout } from './components/admin/adminlayout/AdminLayout';
import { Dashboard } from './components/admin/dashboard/Dashboard';
import { Login } from './components/frontfacing/login/Login';
import { Logout } from './components/admin/logout/Logout';

export default class App extends Component {
  static displayName = App.name;
  constructor(props) {
    super(props);
    //this.userHasAuthenticated = this.userHasAuthenticated.bind(this);
  }

  state = {
    isAuthenticated: false
  };

  login(authenticated) {
    //  alert('We are in logging in ' + authenticated);
    //debugger;
    localStorage.setItem('isAuthenticated', authenticated);
    this.setState({ isAuthenticated: authenticated });
  }

  logout(authenticated) {
    //alert('We are logging out ' + authenticated);
    //debugger;
    localStorage.setItem('isAuthenticated', authenticated);
    this.setState({ isAuthenticated: authenticated });
    //window.location.assign('/');
  }

  userHasAuthenticated(authenticated) {
    //console.log(authenticated);
    //update localstorage
    //debugger;
    localStorage.setItem('isAuthenticated', authenticated);
    this.setState({ isAuthenticated: authenticated });
    //alert(authenticated);
  }

  componentDidMount() {
    const authentication = localStorage.getItem('isAuthenticated');
    this.setState({ isAuthenticated: authentication });
    //this.props.userHasAuthenticated(false);
    //debugger;
    //localStorage.setItem('isAuthenticated', this.state.isAuthenticated);
  }

  componentWillUnmount() {
    //debugger;
    const authentication = localStorage.getItem('isAuthenticated');
    this.setState({ isAuthenticated: authentication });
    //localStorage.set('isAuthenticated', JSON.stringify(this.state));
  }

  render() {
    // const childProps = {
    //   isAuthenticated: this.state.isAuthenticated,
    //   userHasAuthenticated: this.userHasAuthenticated
    // };
    return (
      <div>
        {this.state.isAuthenticated ? (
          <AdminLayout>
            <Logout logout={e => this.logout(e)} />
            <Route exact path="/Admin" component={Dashboard} />
          </AdminLayout>
        ) : (
          <Layout>
            <Login login={e => this.login(e)} />
            <Route exact path="/" component={Home} />
            <Route path="/department" component={Department} />
            <Route path="/annoucements" component={Annoucements} />
            <Route path="/contactus" component={ContactUs} />
            <Route path="/aboutus" component={AboutUs} />
          </Layout>
        )}
      </div>
    );
  }
}
