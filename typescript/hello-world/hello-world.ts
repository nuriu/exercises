class HelloWorld {
    static hello(name?: string) {
        if (name) {
            return "Hello, " + name + "!";
        } else {
            return "Hello, World!";
        }
    }
}

export default HelloWorld;
