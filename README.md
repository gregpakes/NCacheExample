# Example repository for Alachisoft to demonstrate bug https://github.com/Alachisoft/NCache/issues/35

The example uses the WebActivatorEx nuget package (22 million downloads) to run an application prestart event.  
This is a good place to perform application initialization code.  If you attempt to initialize the NCache Cache here
and are relying on the config files being in the root of the application, you will get an exception.

This is because NCache relies on the HttpContext.Current not being null to determine that it should look
for the config files in the root of the application.  If it is null, it simply gets ignored.  Using HttpContext.Current
for determining whether you are in a web application is not reliable and should not be used.  
