SELECT category.name, COUNT(*) FROM category
JOIN film_category ON film_category.category_id = category.category_id
GROUP BY category.name;
