package main

import (
	"net/http"
	"strings"
)

func main() {

	http.HandleFunc("/greetings/", headers)

	http.ListenAndServe(":6000", nil)
}

func headers(w http.ResponseWriter, req *http.Request) {
	name := strings.TrimPrefix(req.URL.Path, "/greetings/")
	w.Write([]byte("Hello " + name))
}
