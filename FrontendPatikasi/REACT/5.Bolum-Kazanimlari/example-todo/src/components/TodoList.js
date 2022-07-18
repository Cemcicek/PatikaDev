import React from 'react'
import Todos from './Todos'

function TodoList({todos, setTodos, filtered}) {
    return (
        <div>
            <ul className='todo-list'>
                {filtered.map ( (todo) => (
                    <Todos key={todo.id} todo={todo} todos={todos} setTodos={setTodos} />
                ))}
            </ul>
        </div>
    )
}

export default TodoList