import User from "./components/User";

const friends = [
  {
    id: 1,
    name: 'Cem'
  },
  {
    id: 2,
    name: 'Ahmet'
  },
  {
    id: 3,
    name: 'Cenk'
  },
];

function App() {
  return (
    <>
    <User 
      name="Cem" 
      surname="Çiçek" 
      isLoggedIn={true}  
      age={22}
      friends={friends}
      addres={{
        title: "Bayraklı/İzmir",
        zip: 351999
      }}
    />
    </>
  );
}

export default App;
