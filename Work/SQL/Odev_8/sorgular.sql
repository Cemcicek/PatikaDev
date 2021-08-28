UPDATE employee
 SET name ='Cem Cicek',
 birthday='1999-10-19',
 email='cemcicek@gmail.com'
 WHERE id = 1;
 
 
 UPDATE employee
 SET name ='Emir Cicek',
 birthday='2004-01-26',
 email='emircicek@gmail.com'
 WHERE name = 'Consolata Hulke';
 
 UPDATE employee
 SET name ='Asya Deneme',
 birthday='2000-07-15',
 email='asyadeneme@gmail.com'
 WHERE email ='lfahrenbachb@microsoft.com';


 UPDATE employee
 SET name ='Mustafa Deneme',
 birthday='1999-12-18',
 email='mustafa@gmail.com'
 WHERE name LIKE 'Harr%';
 
  UPDATE employee
 SET name ='deneme2 Deneme',
 birthday='2003-06-24',
 email='deneme2@gmail.com'
 WHERE id = 13;


 DELETE FROM employee
 WHERE id = 8;
 
 DELETE FROM employee
 WHERE id = 18;

 DELETE FROM employee
 WHERE name = 'Siegfried Garrow';
 
 DELETE FROM employee
 WHERE email LIKE 'agoldv%';
 
 DELETE FROM employee
 WHERE id >= 48 ;
