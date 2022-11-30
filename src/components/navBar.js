import AlUsr from "./AlUsr";
import React from 'react';
import "../component/style.css"

class navBar extends React.Component {
    constructor(props){
        super(props);
        this.state={user:[], loading:false};
        this.updateState = this.updateState.bind(this);

    }

    updateState() {
        document.getElementById("main").style.display = "inline-block";
        const url = "https://reqres.in/api/users?page=1";
        fetch(url)
            .then((response) => response.json())
            .then((users) => {
                this.setState({ user: users.data, loading: false });
                console.log(users.data);
            })
            .catch((error) => {
                console.error(error);
            });
    }

    render() {
        return (<>
            <nav>
                <div className="row">
                    <div className="col-1">
                        <h1>LetsGrowMore Task2</h1>
                    </div>
                    <div className="col-2">
                        <button onClick = { this.updateState }>Get Users</button>
                    </div>
                </div>
            </nav>
            <div className="api-data">
                <AlUsr loading={this.state.loading} users={this.state.user}/>
            </div>
        </>);
    }
}

export default navBar;
