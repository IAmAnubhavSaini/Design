class Child {
  constructor(name) {
    this.name = name;
    this.observers = [];
  }
  addObserver(observer) {
    this.observers.push(observer);
  }
  greet(greeting) {
    this.observers.forEach(o => o.notify(`${this.name} says: ${greeting}`));
  }
}

class Mother {
  constructor() {
    this.children = [];
  }
  notify(message) {
    console.log(message);
  }
  addChild(child) {
    this.children.push(child);
  }
  observeChild(child) {
    child.addObserver(this)
  }
}

const a = new Child('anubhav');
const m = new Mother();
m.observeChild(a);

// run
a.greet('Good, morning.');

