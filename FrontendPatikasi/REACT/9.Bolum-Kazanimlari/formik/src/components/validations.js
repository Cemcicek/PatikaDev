import * as yup from 'yup';

const validations = yup.object().shape({
    email: yup.string().email('Geçerli bir email giriniz').required('Zorunlu alan'),
    password: yup.string().min(5, 'Minimum 5 karakter giriniz').required('Zorunlu alan'),
    passwordConfirm: yup.string().oneOf([yup.ref('password')], 'Parolalar uyuşmuyor').required('Zorunlu alan')
});

export default validations;