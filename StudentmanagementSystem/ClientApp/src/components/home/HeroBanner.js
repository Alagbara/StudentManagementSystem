import React from 'react';
import '../home/HeroBanner.css';
import classnames from 'classnames';

function HeroBanner() {
  return (
    <div className="hero hero-lg mb-3">
      <div className="hero-body text-left text-dark">
        <h1>University Of Africa</h1>
        <p className="mb-5">A leading Institute for Education</p>
      </div>
      <hr></hr>
    </div>
  );
}

export default HeroBanner;
