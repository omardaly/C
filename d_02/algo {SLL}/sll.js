// Node Class
 class Node {
constructor(value){
    this.value = value
    this.next = null
}

 }
class SLL {
    constructor(){
        this.head = null;
    }
    isEmpty(){
        if(this.head == null){
            return true
        }else {
            return false
        }
    }
    addToFront(value){
        let newNode = new Node(value);
        if(this.isEmpty()== true){
            this.head = new newNode;
            return this
        }else{
            newNode.next = this.head;
            this.head = newNode;
            return this;
        }
    }
}
 let nodeOne = new Node(10);
 let nodeTwo = new Node(-2);
 const sll = new SLL()
 const sllTwo = new SLL()
 nodeOne.next = nodeTwo;
 sll.head = nodeOne;
//  let nodeThree = new Node(7);
 console.log("sll one Before :",sll);
 console.log("sll Two Before :",sllTwo);

 sll.addToFront(7)
 sllTwo.addToFront(7)
 console.log("sll one Before :",sll);
 console.log("sll Two Before :",sllTwo);
// 
// console.log(sll);