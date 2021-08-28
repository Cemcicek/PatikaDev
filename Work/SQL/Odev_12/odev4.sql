SELECT customer_id, COUNT(payment_id) AS cd FROM payment
GROUP BY customer_id
HAVING customer_id = ANY
(
  SELECT DISTINCT(customer_id) FROM payment
)
ORDER BY cd DESC;
