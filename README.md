# SoapDemo

## Introduction
This project provide a sample that shows how to create, host and consume a **SOAP service** in .Net 6.  
I also wrote an article in the following address that compare REST and SOAP services and completely explains implementation of **SOAP** service in C#:  
https://www.linkedin.com/pulse/rest-vs-soap-implementation-using-c-amir-doosti-l7cmf  

I also have two articles for **Understanding REST** and **Understanding SOAP** that may help you to understand REST and SOAP better.  
https://www.linkedin.com/pulse/understanding-soap-amir-doosti-rbcnf/  
https://www.linkedin.com/pulse/understanding-rest-amir-doosti-2epkf/  


## Structure of soution
The solution contains three projects in a solution, SoapServer, SoapHost and SoapConsumer.  
SoapServer is a WCF Service Library written in .Net Framework 4.8 and create a sample math SOAP server.
SoapHost is a console application again written in .Net Framework 4.8 and used to host the SOAP server from command line.
SoapConsumer is a console application written in .Net 6 and it uses SoapServer to do some calculations.  

## Technology stack
- OS: Windows 10 Enterprise - 64 bits
- IDE: Visual Studio Enterprise 2022 (64 bits) - version 17.2.5
- Framework: .Net Framework 4.8 & .Net 6
- Language: C#
- WCF

## How to run
After building all projects in the solution, first run SoapHost to run the service and the in another console, run SoapConsumer.  


