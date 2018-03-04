# Interface Design Workshop

This repository is helping me to keep my examples up-to-date and reachable for everyone who reads my blog or attend my "Interface Design" workshop.

I 'll update this readme as soon as I publish my blog-post.

### Step 1
* Demostrate hard-coupling and difficulties to write (unit) test.

### Step 2
* Introducing public interfaces
* Implementation of these new interfaces. But, Service1 still uses a "new" keyword for the service2 implementation, which makes no difference with the mocking problem on the test side.

### Step 3
* Introducing a "service locator" (Static one, to spare a context for the demo)
* Usage of registration in production and test to mock the dependencies
* Talk about the evil "new" keyword.

Problem with the service locator: 
* Only the consumers know the dependencies. 
* In order to use the "consumer" we need to know which dependency used by which consumer, so we can register the dependencies to the locator.

### Step 4
Introduce Dependency Injection 
* Poor Men's

### Step 5
Introduce Dependency Injection 
* Ninject

### Step 6
Examples 

* Law of Demeter and Interface-Chain
* Principle of least astonishment
* Single Level of Abstraction and problems
* Interface segragation
* A-cyclic dependencies
* Service Broker and Shearing Layers

