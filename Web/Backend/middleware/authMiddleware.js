
function authMiddleware(req, res, next) {
    req.userid = 2
    if (!req.userid) return res.status(401).json({message: "You are not loged in"});
    next();
}

export default authMiddleware;