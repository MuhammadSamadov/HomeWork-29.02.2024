

using task2;
Car avto1 =new Car("BMW", "F90", "Black", 6);
Car avto2 =new Car("NISSAN", "Maxima", "Green", 2);
Car avto3 =new Car("LEXUS", "GX460", "Black", 4);
Car avto4 =new Car("MERCEDES", "CLS", "Black", 6);
CargoCar crca1= new CargoCar("KAMAZ","djd","yellow",2); 
CargoCar crca2= new CargoCar("GAZ", "aks", "white",3);
CargoCar crca3= new CargoCar("DAF","sdk","orange",4);
CargoPlane cplane1=new CargoPlane("Airbus","A400","white",5);
CargoPlane cplane2=new CargoPlane("Boeing","|||","blackwhite",5);
CargoPlane cplane3=new CargoPlane("AH","124","white",5);
PassengerPlane pplane1=new PassengerPlane("Airbus","A310","white",7);
PassengerPlane pplane2=new PassengerPlane("Boeing","747","white",6);
PassengerPlane pplane3=new PassengerPlane("IL","96","white",7);
Train train1 =new Train("Locomotion","skdl","red",8);
Train train2 =new Train("Afrosiyob","dkfj","black",8);
Train train3 =new Train("AGV","575","white",8);
Transport transport = new Transport("Traffic","dnf","black",3);
transport.Print();
avto1.GetInfo();
avto2.GetInfo();
avto3.GetInfo();
avto4.GetInfo();
System.Console.WriteLine("--------------------------");
crca2.GetInfo();
crca2.GetInfo();
crca3.GetInfo();
System.Console.WriteLine("--------------------------");
cplane1.GetInfo();
cplane2.GetInfo();
cplane3.GetInfo();
System.Console.WriteLine("--------------------------");
pplane1.GetInfo();
pplane2.GetInfo();
pplane3.GetInfo();
System.Console.WriteLine("--------------------------");
train1.GetInfo();
train1.GetInfo();
train3.GetInfo();
System.Console.WriteLine("--------------------------");


