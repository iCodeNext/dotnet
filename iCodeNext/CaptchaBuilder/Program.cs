
using CaptchaBuilder.WithOut;

var type = Console.ReadLine();


if (type == CaptchaType.Simple.ToString())
{
    Captcha captcha = new()
    {
        Text = RandomGenerator.Generate(6),
        Length = 6,
        ImageHeight = 24,
        ImageWidth = 24,
    };

} else if(type == CaptchaType.PersianNumbers.ToString())
{

}
