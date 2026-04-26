-- ====================
-- 1. Database
-- ====================
CREATE DATABASE IF NOT EXISTS teszt_db;
USE teszt_db;

-- ====================
-- 2. Users
-- ====================
CREATE TABLE users (
	user_id INT PRIMARY KEY AUTO_INCREMENT,
	username VARCHAR(50) UNIQUE NOT NULL,
	password VARCHAR(255) NOT NULL,
	email VARCHAR(100) UNIQUE NOT NULL,
	created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    user_status ENUM('active', 'pending', 'suspended') NOT NULL DEFAULT 'pending'
);

-- ====================
-- 3. Categories
-- ====================
CREATE TABLE categories (
	category_id INT PRIMARY KEY AUTO_INCREMENT,
	user_id INT NOT NULL,
	name VARCHAR(50) NOT NULL,
	type ENUM('income', 'expense') NOT NULL,
    in_use BOOLEAN DEFAULT true,
    
	FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
);

-- ====================
-- 4. Planner
-- ====================
CREATE TABLE entry_planner (
	id INT PRIMARY KEY AUTO_INCREMENT,
	user_id INT NOT NULL,
	category_id INT NOT NULL,
	name VARCHAR(100) NOT NULL,
	amount INT NOT NULL,
	day_of_month INT NOT NULL,
	active BOOLEAN DEFAULT true,
    
    CHECK (day_of_month BETWEEN 1 AND 31),
    
	FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE,
	FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

-- ====================
-- 5. Entries
-- ====================
	CREATE TABLE entries (
	entry_id INT PRIMARY KEY AUTO_INCREMENT,
	user_id INT NOT NULL,
	category_id INT NOT NULL,
	amount INT NOT NULL CHECK (amount > 0),
	description VARCHAR(100),
	date DATE NOT NULL,
	completed BOOLEAN DEFAULT false,
    
	planned_entry_id INT NULL,
    
	created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    
	FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE,
	FOREIGN KEY (category_id) REFERENCES categories(category_id),
	FOREIGN KEY (planned_entry_id) REFERENCES entry_planner(id)
);

-- ====================
-- 6. Feedback
-- ====================
CREATE TABLE feedback (
	feedback_id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(50),
    message VARCHAR(255) NOT NULL,
    user_id INT,
    foreign_email VARCHAR(100),
    is_read BOOLEAN DEFAULT false,
    
    FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE SET NULL
);

-- ====================
-- 7. Indexes
-- ====================
CREATE INDEX idx_entries_user_date ON entries(user_id, date);
CREATE INDEX idx_entries_planned ON entries(planned_entry_id);

-- ====================
-- 8. Procedure
-- ====================

DELIMITER //

DROP PROCEDURE IF EXISTS generate_entry_planner//

CREATE PROCEDURE generate_entry_planner(
	IN p_user_id INT,
    IN p_year INT,
    IN p_month INT
)
BEGIN
	INSERT INTO entries (
		user_id,
        category_id,
        amount,
        description,
        date,
        planned_entry_id
	)
    SELECT
		r.user_id,
        r.category_id,
        r.amount,
        r.name,
        DATE(CONCAT(p_year, '-', p_month, '-', r.day_of_month)),
        r.id
	FROM entry_planner r
    WHERE r.user_id = p_user_id
	AND r.active = true
    
    AND NOT EXISTS (
		SELECT 1 FROM entries e
        WHERE e.planned_entry_id = r.id
        AND YEAR(e.date) = p_year
        AND MONTH(e.date) = p_month
	);
END //

DELIMITER ;

-- userid INT NOT NULL
--  	minden usernek saját kategóriái vannak
-- type ENUM('income', 'expense')
-- 		nem amount dönti el a típust hanem kategória
-- day_of_month INT
-- 		ebből generáljuk a dátumot
-- active BOOLEAN
-- 		nem törüljük csak kikapcsoljuk a tervezett entryt
-- 		amount INT NOT NULL
-- 		mindig pozitív szám, kategória mondja meg a jelentését
-- paid BOOLEAN
-- 		ki van e fizetve
-- 		planned_id INT NULL
-- 		null ha manuális entry, van érték akkor tervezetből jön

-- GPT ajánlás:
-- DATE_ADD(
--    DATE(CONCAT(p_year, '-', p_month, '-01')),
--    INTERVAL LEAST(
--        r.day_of_month,
--        DAY(LAST_DAY(DATE(CONCAT(p_year, '-', p_month, '-01'))))
--    ) - 1 DAY
-- )