class Person {
    name: string;
    private type: string;
    protected age: number;
    constructor(name: string, public username: string)
    {
        this.name = name;
    }
    public getUsername() {
        return this.username;
    }
}

const person = new Person("Moses", "moses");
console.log('person.name: ', person.name);
console.log('person.username: ', person.username);
console.log(person.getUsername());
