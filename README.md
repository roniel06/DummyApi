# DummyApi
This is a DumyApi, it's only purpose is to test the Incomming calls in the with the multiple HttpVerbs like POST, PUT, Delete,Get
and validate wether you are sending a correct payload or not.

It receives a String as the payload and returns the same string back. 

If the string object is filled it will return a HttpStatusCode - 200


If the string object is null or empty it will return a HttpStatusCode - 400
