import './App.css';
import {BrowserRouter, Routes, Route} from 'react-router-dom';

import Home from './pages/Home';
import About from './pages/About';
import Users from './pages/Users';
import Post from './pages/Post';
import Layout from './Layout';
import User from './pages/User';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/*' element={<Layout></Layout>}>
          <Route path='' element={<Home />} />
          <Route path='about' element={<About />} />
          <Route path='users' element={<Users />} />
          <Route path='user/:id' element={<User />}/>
          <Route path='blog/:postId' element={<Post />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
