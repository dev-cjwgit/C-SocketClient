I didn't throw exceptions.

How connect to server?
add Start Program to "new ServerService(ip, port);"
Ex : ProgramMain - LoginFrm.xaml - public LoginFrm(){} - new ServerService(ip, port);
Server connect finish

How recv to server data?
Answer : "SocketComponent - ServerConnect.cs - private void recvData()"A from to "ProgramMain - ServerService.cs - RecvPacket(byte[] data)"B
A to B
A delegate to B
If data comes from the server, it will come to ServerService.cs-RecvPacket() from Delegate.

How should I use about PacketComponent?
Answer :
ReadPacket
ReadPacket r = new ReadPacket(data); // data is byte[]
r.readType(); // r.readInt(), r.readShort(), r.readDouble() ... extra

SendPacket
SendPacket s = new SendPacket();
s.writeType(); // s.wrtieInt() ... extra
ServerService.send(s.getPacket()); // It is important!!!

