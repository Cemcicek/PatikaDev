import React, { useEffect, useState } from 'react'
import { useParams, Link } from 'react-router-dom'
import axios from 'axios';

function User() {

    const [loading, setLoading] = useState(true);

    const { id } = useParams();

    const [user, setUser] = useState({});

    useEffect(() => {
        axios(`https://jsonplaceholder.typicode.com/users/${id}`)
        .then(res => setUser(res.data)).finally(() => setLoading(false));
    }, [id])

    return (
        <div>
            <h1>User Detail</h1>
            {loading && <div>Loading...</div>}
            {!loading &&  <code>{JSON.stringify(user)}</code>}

            <br />
            <br />
            <br />
            <Link to={`/user/${parseInt(id) + 1}`}>Next User ({parseInt(id) + 1 })</Link>
        </div>
    )
}

export default User