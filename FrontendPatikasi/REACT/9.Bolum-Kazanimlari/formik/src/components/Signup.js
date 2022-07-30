import React from 'react'
import { useFormik } from 'formik';
import validationSchema from './validations';
import '../App.css';

function Signup() {

    const { handleSubmit, handleChange, handleBlur, values, errors, touched } = useFormik({
        initialValues: {
            email: '',
            password: '',
            passwordConfirm: '',
        },
        onSubmit: values => {
            console.log(values);
        },
        validationSchema,
    })

    return (
        <div>
            <h1>Sign Up</h1>
            <form onSubmit={handleSubmit}>

                <label>Email: </label>
                <input 
                    name="email" 
                    value={values.email} 
                    onChange={handleChange} 
                    onBlur={handleBlur}
                    placeholder="jane@acme.com" 
                />
                {errors.email && touched.email && (<div className='errorEmail'>{errors.email}</div>)}

                <br /><br />

                <label>Password: </label>
                <input 
                    name="password" 
                    value={values.password} 
                    onChange={handleChange}
                    onBlur={handleBlur}
                    placeholder="*******" 
                />
                {errors.password && touched.password && (<div className='errorEmail'>{errors.password}</div>)}

                <br /><br />

                <label>Confirm Password: </label>
                <input 
                    name="passwordConfirm" 
                    value={values.passwordConfirm} 
                    onChange={handleChange}
                    onBlur={handleBlur}
                    placeholder="*******" 
                />
                {errors.passwordConfirm && touched.passwordConfirm && (<div className='errorEmail'>{errors.passwordConfirm}</div>)}

                <br /><br />

                <button type="submit">Submit</button>

                <br /><br />

                {JSON.stringify(values)}
            </form>
        </div>
    )
}

export default Signup