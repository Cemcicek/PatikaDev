SELECT rating, COUNT(*) as fa FROM film
GROUP BY rating
HAVING rating =ANY (SELECT DISTINCT(rating) FROM film)
ORDER BY fa DESC
LIMIT 1;
