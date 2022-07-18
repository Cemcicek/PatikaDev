import PropTypes from "prop-types";

function User({name, surname, age, isLoggedIn, friends, addres}){
    return(
        <>
            <h1>
                {isLoggedIn ? `${name} ${surname} (${age})` : 'Giriş Yapmadınız!'}
            </h1>

            {addres.title} {addres.zip}
            <br />

            {friends.map((friend) => (
                <div key={friend.id}>{friend.name}</div>
            ))}
        </>
    )
}

User.propTypes = {
    name: PropTypes.string.isRequired,
    surname: PropTypes.string.isRequired,
    isLoggedIn: PropTypes.bool,
    age: PropTypes.oneOfType([PropTypes.number, PropTypes.string]),
    friend: PropTypes.array,
    addres: PropTypes.shape({
        title: PropTypes.string,
        zip: PropTypes.number
    })
}

export default User;