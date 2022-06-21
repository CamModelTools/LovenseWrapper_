# LovenseWrapper_
This project is working in progress and a working pre-alpha release ...

It's a managed netcore wrapper around the Lovense native-sdk which is unmanaged.
Built with the help of CppSharp.
Added some more functionality to return managed types instead of pointers and curated a bit the code.
To build the binaries it is necessary to allow unsafe code.
It is essential to dispose all references to the objects in this wrapper.

To use this wrapper in your projects it is needed to generate to correct binary for the platform and to include the correct versions (x86, x64) 
of the binaries of the lovense native-sdk.

The binaries created get built for netcore 3.0 onwards.

If there are any questions please don't hesitate to contact me here or on Discord: Lovense Devs :)
