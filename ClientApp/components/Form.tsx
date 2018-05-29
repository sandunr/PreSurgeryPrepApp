import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import axios from 'axios';

interface HomeProps { /* declare your component's props here */ }
interface FormState {
    Name: any,
    Phone: any,
    surgeryDate: any,
    surgeryType: any
}

export default class Form extends React.Component<HomeProps, FormState> {
    
    constructor() {
        super();
        this.handleSubmit = this.handleSubmit.bind(this);
        this.onChange = this.onChange.bind(this);
        this.state = {
            Name: '',
            Phone: '',
            surgeryDate: '',
            surgeryType: ''
        };
    }

    handleSubmit(event) {
        event.preventDefault();
        axios.post(`http://localhost:50495/api/Schedule`, {
            Name: this.state.Name,
            Phone: this.state.Phone,
            SurgeryDate: this.state.surgeryDate,
            SurgeryType: this.state.surgeryType
        });
    }

    onChange = (e) => {
        const state = this.state
        state[e.target.name] = e.target.value;
        this.setState(state);
    }

    public render() {
        const { Name, Phone, surgeryDate, surgeryType } = this.state;
        return (
            <div id="form_container">
                <form onSubmit={this.handleSubmit}>
                    <div className="form-group">
                        <label>Patient Name</label>
                        <input name="Name" type="text" value={Name} className="form-control" aria-describedby="emailHelp" placeholder="Enter Patient Name" onChange={this.onChange} />
                    </div>
                    <div className="form-group">
                        <label>Patient Phone Number</label>
                        <input name="Phone" value={Phone} type="text" className="form-control" placeholder="Patient Phone" onChange={this.onChange} />
                    </div>
                    <div className="form-group">
                        <label>Patient Surgery Date</label>
                        <input value={surgeryDate} name="surgeryDate" type="text" className="form-control" placeholder="Surgery Date" onChange={this.onChange} />
                    </div>
                    <div className="form-group">
                        <label>Surgery Type:</label>
                        <select defaultValue={surgeryType} name="surgeryType" className="form-control" onChange={this.onChange} >
                            <option value="Abdominal Hysterectomies" name="surgeryType">Abdominal Hysterectomies (Laparoscopic, Open & Robotic)</option>
                            <option value="Colorectal" name="surgeryType">Colorectal (Laparoscopic, Open & Robotic)</option>
                            <option value="Cardiac & Sternal Surgery" name="surgeryType">Cardiac & Sternal Surgery</option>
                        </select>
                    </div>
                    <button type="submit" className="btn btn-primary">Submit</button>
                </form>
            </div>);
    }
}