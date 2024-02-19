# Coding_Assignment_DevOn
LOGGER LIBRARY
You have to design and implement a logger library that applications can use to log messages 
Requirements -
  Client/application make use of your logger library to log messages to a sink
  Message -
      - has content which is of type string has a level associated with it
    - is directed to a destination (sink)
    - has namespace associated with it to identify the part of application that sent the message
  Sink-
    - This is the destination for a message (eg text file, database, console, etc) Sink is tied to one or more message level
Logger Library - 
  - Requires configuration during sink setup
  - Accepts messages from client(s)
  - Routes messages to appropriate sink based on the level
   - Supports following message level in the order of priority: FATAL, ERROR, WARN, INFO, DEBUG 

Sending messages-
• Sink need not be mentioned while sending a message to the logger library.
• You specify message content and level 

Logger configuration- 

• Specifies all the details required to use the logger library.
•Library can accept one or more configuration for an application 
