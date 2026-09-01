class User {
    constructor (name, password, email, status, role) {
        this.name = name;
        this.password = password;
        this.email = email;
        this.status = status;
        this.role = role;
    }
}

/*
min 8 char, Uppercase, digit, special char
*/

const testUsers = [
    new User('admin', 'Almafa123-', 'admin@test.com', 'active', 'admin'),
    new User('user1', 'Almafa123-', 'user1@test.com', 'active', 'moderator'),
    new User('user2', 'Almafa123-', 'user2@test.com', 'active', 'user'),
    new User('user3', 'Almafa123-', 'user3@test.com', 'active', 'user'),
    new User('user4', 'Almafa123-', 'user4@test.com', 'pending', 'user'),
    new User('user5', 'Almafa123-', 'user5@test.com', 'suspended', 'user'),
    new User('BitMiller', 'Almafa123-', 'bitmiller@test.com', 'active', 'user'),
    new User('TestUser01', 'Password01!', 'bitmiller@test.com', 'active', 'user')
];

function setLoginUser(idx) {
    e_in_dbgApi_authLogin_userName.value = testUsers[idx].name;
    e_in_dbgApi_authLogin_password.value = testUsers[idx].password;
}

