import * as React from 'react';
import { RouteComponentProps } from 'react-router';
// import patients from '../data/patients';

const patients = [
    {
        id: 1,
        first: "Sarah",
        last: "Johnson",
        phone: "(425) 338-9289",
        surgeryDate: "29 May, 2018"
    },
    {
        id: 2,
        first: "Caldwell",
        last: "Thompson",
        phone: "(206) 206-2727",
        surgeryDate: "06 June, 2018"
    },
    {
        id: 3,
        first: "Hart",
        last: "Maynard",
        phone: "(425) 009-9098",
        surgeryDate: "17 June, 2018"
    },
    {
        id: 4,
        first: "Demetrius",
        last: "McGregor",
        phone: "(425) 773-3333",
        surgeryDate: "14 July, 2018"
    },
    {
        id: 5,
        first: "Larry",
        last: "Bird",
        phone: "(206) 374-8597",
        surgeryDate: "05 June, 2018"
    }
]

interface HomeProps { /* declare your component's props here */ }
interface HomeState { patients :  any, term: string}

function searchFor(term:any) {
    return function(x:any) {
        return x.first.toLowerCase().includes(term.toLowerCase()) || !term;
    }
}

export class Home extends React.Component<RouteComponentProps<{}>, HomeState> {

    constructor() {
        super();
        this.state = {
            patients: patients,
            term: ''
        };

        this.searchFilter = this.searchFilter.bind(this);
    }

    searchFilter(event:any) {
        this.setState({term: event.target.value})
    }

    public render() {
        const {term, patients} = this.state;
        return <div>
            <h1>Pre-Surgery Patient Preparedness</h1>
            <br/>
            <br/>
            <h3>Current Subscribed Patients</h3>
            <br/>
            <div className="row">
                <div className="col-sm-5">
                    <div className="input-group">
                        <input type="text" className="form-control" placeholder="Search for a patient..."
                                        onChange={this.searchFilter} value={term} />
                        <span className="input-group-btn">
                            <button className="btn btn-default" type="button">Search</button>
                        </span>
                    </div>
                </div>
            </div>
            <br/>
            <table className="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Name</th>
                        <th scope="col">Phone</th>
                        <th scope="col">Surgery Date <span className="glyphicon glyphicon-time"></span></th>
                        <th scope="col"></th>
                    </tr> 
                </thead>
                <tbody>
                    {
                        patients.filter(searchFor(term)).map( patient =>
                            <tr>
                                <th scope="row">{patient.id}</th>
                                <td><a href="html_images.asp">{patient.first + " " + patient.last}</a></td>
                                <td>{patient.phone}</td>
                                <td>{patient.surgeryDate}</td>
                                <td>
                                    <button type="button" className="btn btn-primary btn-md">Edit</button>
                                    &nbsp;<button type="button" className="btn btn-danger btn-md">Delete</button>
                                </td>
                            </tr>
                        )
                    
                    }
                </tbody>
            </table>
        </div>;
    }
}
