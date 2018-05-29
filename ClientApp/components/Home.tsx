import * as React from 'react';
import { RouteComponentProps } from 'react-router';

interface HomeProps { /* declare your component's props here */ }
interface HomeState { patients :  any, term: string}

function searchFor(term:any) {
    return function(x:any) {
        return x.name.toLowerCase().includes(term.toLowerCase()) || !term;
    }
}

export class Home extends React.Component<RouteComponentProps<{}>, HomeState> {

    state: HomeState = { patients: null, term: '' };

    constructor() {
        super();
        this.searchFilter = this.searchFilter.bind(this);
    }

    componentDidMount() {
        fetch('http://localhost:50495/api/DisplayPatients')
            .then(results => results.json())
            .then(results => {
                this.setState({
                    patients: results
                })
            });
    }

    searchFilter(event:any) {
        this.setState({term: event.target.value})
    }

    public render() {
        const { term, patients } = this.state;
        if (!patients) return <p>Loading...</p>
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
                        <th scope="col">Name</th>
                        <th scope="col">Phone</th>
                        <th scope="col">Surgery Date <span className="glyphicon glyphicon-time"></span></th>
                        <th scope="col">Surgery Type</th>
                        <th scope="col"></th>
                    </tr> 
                </thead>
                <tbody>
                    {
                        patients.filter(searchFor(term)).map( patient =>
                            <tr>
                                <td><a href="html_images.asp">{patient.name}</a></td>
                                <td>{patient.phone}</td>
                                <td>{patient.surgeryDate}</td>
                                <td>{patient.surgeryType}</td>
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
