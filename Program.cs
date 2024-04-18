Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPerc = random.Next(10, 50);
string msg = "Your Subscription";

var expiring = daysUntilExpiration;
var offper = discountPerc;

Console.WriteLine($"\t{msg} will expire in {expiring}\n\tRenew now and save {offper} %");

if ((expiring < 25) && (expiring > 2))
{
	Console.WriteLine($"\n\t{msg} expires soon!");
	offper = 25;
}
else if (expiring == 1)
{
	Console.WriteLine($"\n\t{msg} expires within a day!");
	offper = 50;
}

if (expiring == 0)
{
	Console.WriteLine($"\n\t{msg} has expired.");
}

string Warning = "\n\tYou should renew, so you don't lose your perks";
string outroTxt = "\n\tPlease (:";

var wrn = Warning;
var txtmsg = outroTxt;

Console.WriteLine(wrn+txtmsg);
