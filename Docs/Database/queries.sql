-- ====================
-- 1. User
-- ====================
-- 1.1 Login
-- SELECT user_id, user_status
-- 	FROM users
-- 		WHERE username = 'admin'
-- 		AND password = 'Almafa123';

-- 1.2 Registration
-- INSERT INTO users (username, password, email) VALUES
-- 	('user6', 'Almafa123', 'user6@test.com');

-- 1.3 Set status
-- UPDATE users
-- 	SET user_status = 'active'
--    WHERE user_id = 7;

-- ====================
-- 2. Categories
-- ====================
-- 2.1 Get categories
-- SELECT c.name, c.type
-- 	FROM categories c
--    JOIN users u ON c.user_id = u.user_id
--    WHERE c.user_id = 2
--    AND c.in_use = true;

-- 2.2 Add category
-- INSERT INTO categories (user_id, name, type) VALUES
-- 	( 1, 'Fizetés', 'income');

-- 2.3 "Delete" category (not actual delete just make it unused)
-- UPDATE categories
-- 	SET in_use = false
--    WHERE category_id = 12
--    AND user_id = 1

-- ====================
-- 3. Entries
-- ====================
-- 3.1 Get entries
-- SELECT
-- 	u.username,
--     c.name,
--     e.description,
-- 	CASE
-- 		WHEN c.type = 'expense' THEN -e.amount
--         ELSE e.amount
-- 	END AS amount,
--    e.date,
--    e.completed

-- FROM entries e
-- JOIN categories c ON e.category_id = c.category_id
-- JOIN users u ON e.user_id = u.user_id
-- WHERE u.user_id = 2
-- 	AND u.user_status = 'active'
--    AND YEAR(e.date) = 2026
--    AND MONTH(e.date) = 6;

-- 3.2 Get monthly balance
-- SELECT
-- 	SUM(
-- 		CASE
-- 			WHEN c.type = 'income' THEN e.amount
--            WHEN c.type = 'expense' THEN -e.amount
-- 		END
--    ) AS monthly_balance
-- FROM entries e
-- JOIN categories c on e.category_id =c.category_id
-- WHERE e.user_id = 2
-- 	AND MONTH (e.date) = 4;
--    -- indexfriendly, faster
--    -- AND e.date >= '2026-04-01'
--    -- AND e.date < '2026-05-01'

-- 3.3 Generate monthly plan (user_id, year, month)
-- CALL generate_entry_planner(2, 2026, 6);

-- 3.4 Insert monthly plan
-- INSERT INTO entry_planner (user_id, category_id, name, amount, day_of_month) VALUES
-- 	(4, 8, 'Villany', 18000, 3);

-- 3.5 Insert entry
-- INSERT INTO entries (user_id, category_id, amount, description, date, completed) VALUES
-- 	(4, 7, 310000, 'Fizetés', '2026-04-01', true);

-- ====================
-- 4. Feedback
-- ====================
-- 4.1 Get feedbacks
-- SELECT feedback_id, title, message
-- 	FROM feedback
--    WHERE is_read = false;
    
-- 4.2 Add feedback
-- INSERT INTO feedback (title, message, user_id) VALUES
-- 	('új üzenet', 'miért nincs még kész?', 1);
    
-- INSERT INTO feedback (title, message, foreign_email) VALUES
-- 	('új üzenet2', 'hello world', 'anonim@valaki.uk');
-- 4.3 Mark as read
-- UPDATE feedback
-- 	SET is_read = true
--    WHERE feedback_id = 11;
