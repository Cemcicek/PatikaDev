const name = "Cem";
const surname = "Çiçek";
const isLoogedIn = true;

function App() {
  return (
    <>
    <h1>
      {isLoogedIn ? `Benim adım ${name}, soyadım ${surname}` : "Giriş yapmadınız." }
    </h1>
    </>
  );
}

export default App;
