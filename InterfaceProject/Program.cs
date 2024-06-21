using InterfaceProject;

IUser user = new User();
IUser googleUser = new GoogleUser();
AndroidUser androidUser = new AndroidUser();   

user.Register();
googleUser.Register();
androidUser.Register();
androidUser.Login();