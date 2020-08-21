# wcf-by-example-on-netnamedpipebinding

netNamedPipeBinding is the best binding for interprocess communication which crosses process boundaries on the same machine.

With netNamedPipeBinding the security can be achieved only through transport level security as it does not support message level security. 
However, messages are secured as only the same machine can call the service operations.

## Files
1. [WCF Service](https://github.com/geeksarray/wcf-by-example-on-netnamedpipebinding/tree/master/WCF%20Service%20with%20NetNamedPipeBindings/Northwind%20Services/NorthwindServices) - with Service contract implementation to read data from XML files.

1. [Windows Service](https://github.com/geeksarray/wcf-by-example-on-netnamedpipebinding/tree/master/WCF%20Service%20with%20NetNamedPipeBindings/Northwind%20Services/NorthwindHost)   - hosting WCF service

You can add Reference to client using net.pipe like

![Add reference to client using net.pipe](http://dotnetmentors.com/Images/NetNamedPipeBinding-Reference.png)

for more details visit - https://geeksarray.com/blog/wcf-by-example-on-netnamedpipebinding

