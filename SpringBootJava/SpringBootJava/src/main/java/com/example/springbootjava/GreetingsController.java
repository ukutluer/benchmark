package com.example.springbootjava;

import org.springframework.web.bind.annotation.*;

@RestController
public class GreetingsController {


    @PostMapping("/greetings/{name}")
    @ResponseBody
    public String getEmployeesById(@PathVariable String name) {
        return "Hello " + name;
    }
}
