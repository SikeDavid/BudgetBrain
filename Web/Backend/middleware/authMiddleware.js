import jwt from 'jsonwebtoken';

function authMiddleware(req, res, next) {
    // const authHeader = req.headers.authorization;

    // if (!authHeader) return res.status(401).json({message: "Missing authorization header"});

    // const [type, token] = authHeader.split(" ");

    // if (type != "Bearer" || !token) return res.status(401).json({message: "Invalid authorization format"});

    // try {
    //     const decoded = jwt.verify(token, process.env.ACCESS_TOKEN_SECRET);

    //     req.user = decoded.userId;
    //     req.user = {
    //         id: decoded.userId,
    //         username: decoded.username
    //     };
    //     next();
    // } catch (err) {
    //     console.error("Server error", err);
    //     return res.status(500).json({message: "Invalid or expired token"});
    // }
    req.user = { id: 2}
    if (!req.user.id) return res.status(401).json({message: "You are not loged in"});
    next();
}

export default authMiddleware;