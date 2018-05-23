import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Schedule } from './components/Schedule';

export const routes = <Layout>
    <Route exact path='/' component={ Home } />
    <Route path='/schedule' component={ Schedule } />
</Layout>;
