import jwt from 'jsonwebtoken';

export function createAccessToken(user) {
    return jwt.sign(
        {
            userId: user.user_id,
            username: user.username
        },
        process.env.ACCESS_TOKEN_SECRET,
        { expiresIn: process.env.ACCESS_TOKEN_EXPIRES || "15m" }
    );
}

export function createRefreshToken(user) {
    return jwt.sign(
        {
            userId: user.user_id
        },
        process.env.REFRESH_TOKEN_SECRET,
        { expiresIn: process.env.REFRESH_TOKEN_EXPIRES || "7d" }
    );
}