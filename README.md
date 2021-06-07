# CSharp Web Server

A simple C# web server created for educational purposes.

Steps to create a similar web server from sratch.

1. Choose the localhost IP address (127.0.0.1) and free local port.
2. Create a TcpListener and accept incomming client request asynchronously. 
3. Write a valid HTTP response and convert it into byte array.
4. Add Content-Type and Content-Length headers (be careful with UTF8 characters).
5. Read the request in chunks (1024 bytes each) and store it in a StringBuilder.
6. Extract separate Server and Http classes.
7. Parse the HTTP request.
8. Create routing table which should allow verous HTTP methods.
9. Make sure the HTTP server can populate the routing table.
10. Create specific HTTP response classes - TextResponse, for example.
11. Implement the ToString method for the HTTP response class.
12. Implament the routing table for storing and retrieving request and mapping.
13. Use the routing table in the HTTP server for actual request-response matching.
14. Separate the URL and parse the query string if it exists
15. Introduct the option to use the request by storing request-fucntions in the routing table.
16. Introduce base controllers and extract common functionalities.
17. Shortem the route syntax and add support for controllers.
18. Add redirect HTTP responses and use the Location header to control the flow.