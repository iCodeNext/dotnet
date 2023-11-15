namespace CaptchaBuilder.WithIn;

public interface ICaptchaBuilder
{
    void SetText();
    void SetLength(int length = 6);
    void SetImageDimensions(int width = 120, int height = 40);
    Captcha Build();
}