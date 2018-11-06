var Person = /** @class */ (function () {
    function Person(name, username) {
        this.username = username;
        this.name = name;
    }
    /**
     * name
     */
    Person.prototype.getUsername = function () {
        return this.username;
    };
    return Person;
}());
var person = new Person("Moses", "moses");
console.log('person.name: ', person.name);
console.log('person.username: ', person.username);
console.log(person.getUsername());
