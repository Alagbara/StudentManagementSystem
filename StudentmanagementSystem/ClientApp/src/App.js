import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/layout/Layout';
import { Home } from './components/home/Home';
import { Department } from './components/department/Department';
import { Annoucements } from './components/annoucements/Annoucements';
import { ContactUs } from './components/contactus/ContactUs';
import { AboutUs } from './components/aboutus/AboutUs';

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Route exact path="/" component={Home} />
        <Route path="/department" component={Department} />
        <Route path="/annoucements" component={Annoucements} />
        <Route path="/contactus" component={ContactUs} />
        <Route path="/aboutus" component={AboutUs} />
      </Layout>
    );
  }
}
