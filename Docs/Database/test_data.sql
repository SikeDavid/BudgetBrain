-- ====================
-- USERS
-- ====================
INSERT INTO users (username, password, email, user_status) VALUES
('admin', 'Almafa123', 'admin@test.com', 'active'),
('user1', 'Almafa123', 'user1@test.com', 'active'),
('user2', 'Almafa123', 'user2@test.com', 'active'),
('user3', 'Almafa123', 'user3@test.com', 'active'),
('user4', 'Almafa123', 'user4@test.com', 'pending'),
('user5', 'Almafa123', 'user5@test.com', 'suspended');

-- ====================
-- CATEGORIES (minden usernek saját!)
-- ====================

-- user1 (userid = 2)
INSERT INTO categories (user_id, name, type) VALUES
(2, 'Fizetés', 'income'),
(2, 'Élelmiszer', 'expense'),
(2, 'Szórakozás', 'expense');

-- user2 (userid = 3)
INSERT INTO categories (user_id, name, type) VALUES
(3, 'Fizetés', 'income'),
(3, 'Lakbér', 'expense'),
(3, 'Közlekedés', 'expense');

-- user3 (userid = 4)
INSERT INTO categories (user_id, name, type) VALUES
(4, 'Fizetés', 'income'),
(4, 'Rezsi', 'expense'),
(4, 'Internet', 'expense');

-- ====================
-- ENTRIES (manuális)
-- ====================

-- user1
INSERT INTO entries (user_id, category_id, amount, description, date, completed) VALUES
(2, 1, 300000, 'Fizetés', '2026-04-01', true),
(2, 2, 12000, 'Bolt', '2026-04-03', true),
(2, 2, 8000, 'Piac', '2026-04-05', false),
(2, 3, 5000, 'Mozi', '2026-04-10', true),
(2, 3, 7000, 'Éttermek', '2026-04-12', false);

-- user2
INSERT INTO entries (user_id, category_id, amount, description, date, completed) VALUES
(3, 4, 280000, 'Fizetés', '2026-04-01', true),
(3, 5, 150000, 'Lakbér', '2026-04-02', true),
(3, 6, 5000, 'Busz bérlet', '2026-04-04', true),
(3, 6, 2000, 'Taxi', '2026-04-06', false),
(3, 6, 3000, 'Vonat', '2026-04-08', false);

-- user3
INSERT INTO entries (user_id, category_id, amount, description, date, completed) VALUES
(4, 7, 310000, 'Fizetés', '2026-04-01', true),
(4, 8, 20000, 'Villany', '2026-04-03', true),
(4, 8, 15000, 'Gáz', '2026-04-05', false),
(4, 9, 7000, 'Internet', '2026-04-06', true),
(4, 9, 3000, 'Mobilnet', '2026-04-07', false);

-- ====================
-- PLANNER (recurring)
-- ====================

-- user1
INSERT INTO entry_planner (user_id, category_id, name, amount, day_of_month) VALUES
(2, 2, 'Heti bevásárlás', 10000, 5),
(2, 3, 'Netflix', 3990, 10),
(2, 3, 'Spotify', 1990, 15);

-- user2
INSERT INTO entry_planner (user_id, category_id, name, amount, day_of_month) VALUES
(3, 5, 'Lakbér', 150000, 2),
(3, 6, 'Bérlet', 9500, 1),
(3, 6, 'Üzemanyag', 20000, 12);

-- user3
INSERT INTO entry_planner (user_id, category_id, name, amount, day_of_month) VALUES
(4, 8, 'Villany', 18000, 3),
(4, 8, 'Gáz', 15000, 5),
(4, 9, 'Internet', 7000, 6);

-- CALL generate_entry_planner(2, 2026, 4);
-- CALL generate_entry_planner(3, 2026, 4);
-- CALL generate_entry_planner(4, 2026, 4);

INSERT INTO feedback (title, message, user_id, foreign_email, is_read) VALUES

-- USERES visszajelzések
('Bug report', 'Nem működik a havi összesítés.', 2, NULL, false),
('Feature', 'Jó lenne grafikon a kiadásokról.', 2, NULL, false),
('UI issue', 'Mobilon elcsúszik a layout.', 3, NULL, true),
('Suggestion', 'Kategóriák színezése hasznos lenne.', 3, NULL, false),
('Feedback', 'Nagyon tetszik az alkalmazás!', 4, NULL, true),

-- LÁTOGATÓK (nem regisztrált)
('Contact', 'Szeretnék érdeklődni az app felől.', NULL, 'guest1@test.com', false),
('Bug', 'Nem jön meg a megerősítő email.', NULL, 'guest2@test.com', false),
('Suggestion', 'Lehetne sötét mód.', NULL, 'guest3@test.com', true),
('Question', 'Van mobil app verzió?', NULL, 'guest4@test.com', false),
('Feedback', 'Egyszerű és átlátható rendszer.', NULL, 'guest5@test.com', true);