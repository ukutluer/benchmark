

exports.greet = function(req, res, next) {
    res.send("Hello " + req.params["name"])
};