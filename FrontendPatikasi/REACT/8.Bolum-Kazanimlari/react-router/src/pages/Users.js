import axios from 'axios';
import { useEffect, useState } from 'react'
import { Link, Outlet } from 'react-router-dom'


function Users() {

  const [loading, setLoading] = useState(true);

  const [users, setUsers] = useState([]);

  useEffect(() => {
    axios('https://jsonplaceholder.typicode.com/users')
      .then(res => setUsers(res.data))
      .finally(() => setLoading(false));
  }, [])

  return (
    <div>
      <nav>
        <h1>Users</h1>
        {loading && <div>Loading...</div>}
        <ul>
          {
            users.map((user) => (
              <li key={user.id}>
                <Link to={`/user/${user.id}`}>{user.name}</Link>
              </li>
            ))
          }
        </ul>
        </nav>
        
        <Outlet/>
    </div>
  )
}

export default Users