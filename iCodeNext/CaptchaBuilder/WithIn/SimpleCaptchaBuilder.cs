using CaptchaBuilder.WithIn;

class SimpleCaptchaBuilder : ICaptchaBuilder
{
    private readonly Captcha _captcha = new();

    public void SetText()
        => _captcha.Text = GenerateRandomText(6);

    public void SetLength(int length = 6)
         => _captcha.Length = length;

    public void SetImageDimensions(int width = 120, int height = 40)
    {
        _captcha.ImageWidth = width;
        _captcha.ImageHeight = height;
    }

    private static string GenerateRandomText(int length)
    {
        Random random = new ();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public Captcha Build()
        => _captcha;
}
 