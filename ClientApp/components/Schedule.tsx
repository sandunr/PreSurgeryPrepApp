import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import Form from './form';

interface CounterState {
    patients: any;
}

export class Schedule extends React.Component<RouteComponentProps<{}>, CounterState> {
    
    state : CounterState = { patients: null };

    public render() {
        return (
            <div>
                <h2>Schedule New Patient</h2>
                <Form />
            </div>
        )
    }
}
