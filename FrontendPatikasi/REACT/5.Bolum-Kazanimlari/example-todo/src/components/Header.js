import { useState } from 'react';
import TodoList from './TodoList';
import Footer from './Footer';

function Header() {

    const [inputValue, setInputValue] = useState("");
    
    const [todos, setTodos] = useState([]);

    const [filtered, setFiltered] = useState(todos);

    const addTodos = (e) => {
        e.preventDefault()
        const newTodos = {
            name : inputValue,
            id : new Date().getTime(),
            completed : false
        }
        setTodos([...todos, newTodos])
        setInputValue("");
    }

    return (
        <div className='Header'>
            <h1>Todos</h1>
            <form onSubmit={(e) => {addTodos(e)}}>
                <input className='new-todo' placeholder='What needs to be done?' value={inputValue} onChange={(e) => {
                    setInputValue(e.target.value)
                }}/>
            </form>
            <TodoList todos={todos} setTodos={setTodos} filtered={filtered} />
            <Footer todos={todos} setTodos={setTodos} filtered={filtered} setFiltered={setFiltered} />
        </div>
    )
}

export default Header