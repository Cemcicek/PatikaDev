import { useState, useEffect } from 'react'

function Footer({todos, setTodos, filtered, setFiltered }) {

    const [completed, setCompleted] = useState();

    useEffect(() => {
        setCompleted(todos.filter((item) => item.completed !== true))
        setFiltered(todos)
    }, [todos])

    const deleteCompleted = () => {
        setTodos(todos.filter((item) => item.completed === false))
    }

    return (
        <div className='footer'>
            <span className='todo-count'>
                <b>{completed ? completed.length : 0} items left</b>
            </span>
            <ul className='filters'>
                <li>
                    <a href='#/' className='selected' onClick={() => {
                        setFiltered(todos)
                    }}>All</a>
                </li>
                <li>
                    <a href='#/' onClick={() => {
                        setFiltered(todos.filter((item) =>(
                            item.completed === false
                        )))
                    }}>Active</a>
                </li>
                <li>
                    <a href="#/" onClick={() => {
                        setFiltered(todos.filter( (item) => (
                            item.completed === true
                        )))
                    }}> Completed</a>
                </li>
            </ul>
            <button className='clear-completed' onClick={() => {
                deleteCompleted()
            }}>Clear Completed</button>
        </div>
    )
}

export default Footer