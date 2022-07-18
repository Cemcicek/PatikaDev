SELECT first_name, last_name FROM customer
WHERE customer_id =
(
SELECT customer_id FROM payment
GROUP BY customer_id
HAVING customer_id=ANY
(
	SELECT DISTINCT(customer_id) FROM payment
)
ORDER BY COUNT(payment_id) DESC
LIMIT 1
);
