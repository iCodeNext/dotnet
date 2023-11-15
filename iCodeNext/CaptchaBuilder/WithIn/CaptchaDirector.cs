namespace CaptchaBuilder.WithIn;

public class CaptchaDirector
{
    private ICaptchaBuilder _captchaBuilder;

    public void SetCaptchaBuilder(ICaptchaBuilder captchaBuilder)
        => _captchaBuilder = captchaBuilder;

    public Captcha GenerateCaptcha()
    {
        _captchaBuilder.SetText();
        _captchaBuilder.SetLength();
        _captchaBuilder.SetImageDimensions();
        return _captchaBuilder.Build();
    }
}

