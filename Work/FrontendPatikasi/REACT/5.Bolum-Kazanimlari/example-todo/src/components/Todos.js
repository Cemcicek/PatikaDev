import { useState } from 'react'

function Todos({todo, todos, setTodos}) {

  const deleteTodos = (ID) => {
    setTodos(todos.filter( (item) => item.id !== ID))
  }

  const completedFunction = () => {
    setTodos(todos.map((item) => {
      if (item.id === todo.id) {
        return{
          ...item, completed : !item.completed
        }
      }
      console.log(item);
      return item
    }))
  }

  return (
    <div>
      <li className={todo.completed ? 'completed' :  ""}>
        <div className='view'>
          <input className='toggle' type="checkbox" onClick={() => {
            completedFunction();
          }} />
          <label>{todo.name}</label>
          <button className='destroy' onClick={() => {
            deleteTodos(todo.id)
          }}></button>
        </div>
      </li>
    </div>
  )
}

export default Todos