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