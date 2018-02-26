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

### Step 4
* Build poor men's DI'
