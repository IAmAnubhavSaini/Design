function Child(name) {
  this.name = name;
  this.observers = [];
}
Child.prototype.addObserver = function (observer) {
  this.observers.push(observer);
}
Child.prototype.greet = function(g) {
  var self = this;
  this.observers.forEach(function (o) {
    o.notify(self.name + ' says: ' + g);
  });
}

function Mother() {
  this.children = [];
}
Mother.prototype.notify = function (message) {
  console.log(message);
}
Mother.prototype.addChild = function (child) {
  this.children.push(child);
}
Mother.prototype.observeChild = function (child) {
  child.addObserver(this);
}

var a = new Child('anubhav');
var m = new Mother();
m.observeChild(a);

// run
a.greet('Good morning');
