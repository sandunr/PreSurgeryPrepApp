import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';

export class NavMenu extends React.Component<{}, {}> {
    public render() {
        return <div className='main-nav' id="navig">
                <div className='navbar navbar-inverse'>
                <div className='navbar-header'>
                    <button type='button' className='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>
                        <span className='sr-only'>Toggle navigation</span>
                        <span className='icon-bar'></span>
                        <span className='icon-bar'></span>
                        <span className='icon-bar'></span>
                    </button>
                    <img src="/SwedishLogo.jpg" width="300px" id="logo" />
                </div>
                <div className='clearfix'></div>
                <div className='navbar-collapse collapse'>
                <br/>
                    <ul className='nav navbar-nav'>
                        <li>
                            <NavLink to={ '/' } exact activeClassName='active'>
                                <span className='glyphicon glyphicon-home'></span> Home
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={ '/schedule' } activeClassName='active'>
                                <span className='glyphicon glyphicon-user'></span> Schedule New Patient
                            </NavLink>
                        </li>
                    </ul>
                </div>
            </div>
        </div>;
    }
}
