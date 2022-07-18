import { useState, useEffect } from 'react'
import List from './List'
import Form from './Form'
import  './styles.css'

function Contacts() {

    const [contacts, setContacts] = useState([
        {
            fullname: 'Cem',
            phone_number: '123123123'
        },
        {
            fullname: 'Emir',
            phone_number: '456456456'
        },
        {
            fullname: 'Ayşe',
            phone_number: '789789789'
        }
    ]);
    useEffect(() => {
        console.log(contacts)
    }, [contacts])


    return (
        <div id='container'>
            <h1>Contacts</h1>
            <List  contacts={contacts}/>
            <Form addContact={setContacts} contacts={contacts}/>
        </div>
    )
}

export default Contacts