import { useState } from "react";

function App() {

  const [name, setName] = useState('Cem');
  const [age, setAge] = useState(22);
  const [friends, setFriends] = useState(['Cem', 'Emir']);
  const [address, setAddress] = useState({title: 'İzmir', zip: 3535});

  return (
    <div>
      <h1>Merhaba { name }</h1>
      <h2> { age } </h2>
      <button onClick={() => setName("Çiçek")}>Change name</button>
      <button onClick={() => setAge(23)}>Change age</button>

      <hr />
      <br/>

      <h2>Friends</h2>
      {
        friends.map(
          (friend, index) => (<div key={index}>{friend}</div>)
        )
      }

      <br/>

      <button onClick={() => setFriends([...friends, 'Ayşe'])}>Add new friend</button>

      <hr/>
      <br/>

      <h2>Address</h2>
      <div>{ address.title } { address.zip }</div>

      <br/>

      <button onClick={() => setAddress({ ...address, title: 'Ankara' })}> Change the address</button>

    </div>
  );
}

export default App;
