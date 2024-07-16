using PuppeteerExtraSharp;
using PuppeteerExtraSharp.Plugins.AnonymizeUa;
using PuppeteerExtraSharp.Plugins.ExtraStealth;
using PuppeteerSharp;

public class BrowserService : IDisposable
{
    private IBrowser _browser;
    private bool _disposed;
    public IBrowser Browser
    {
        get
        {
            if (_disposed) throw new ObjectDisposedException("BrowserService");
            return _browser;
        }
    }

    public async Task InitializeAsync()
    {

        if (_browser != null || _disposed)
            throw new InvalidOperationException("BrowserService is already initialized or disposed.");

        var launchOptions = new LaunchOptions
        {
            Headless = true,
            Args = new[]
        {
            "--disable-web-security",
            "--disable-features=IsolateOrigins,site-per-process",
            "--allow-running-insecure-content",
            "--disable-blink-features=AutomationControlled",
            "--no-sandbox",
            "--mute-audio",
            "--no-zygote",
            "--no-xshm",
            "--window-size=1920,1080",
            "--no-first-run",
            "--no-default-browser-check",
            "--disable-dev-shm-usage",
            "--disable-gpu",
            "--enable-webgl",
            "--ignore-certificate-errors",
            "--lang=en-US,en;q=0.9",
            "--password-store=basic",
            "--disable-gpu-sandbox",
            "--disable-software-rasterizer",
            "--disable-background-timer-throttling",
            "--disable-backgrounding-occluded-windows",
            "--disable-renderer-backgrounding",
            "--disable-infobars",
            "--disable-breakpad",
            "--disable-canvas-aa",
            "--disable-2d-canvas-clip-aa",
            "--disable-gl-drawing-for-tests",
            "--enable-low-end-device-mode"
        }
        };
        //  await new BrowserFetcher().DownloadAsync();

        var extra = new PuppeteerExtra().Use(new AnonymizeUaPlugin()).Use(new StealthPlugin());

//#if DEBUG
//        var browserFetcher = new BrowserFetcher();
       
//        var installedBrowsers =  browserFetcher.GetInstalledBrowsers();
//        var isBrowserInstalled = installedBrowsers.Count() > 0;

//        if (!isBrowserInstalled)
//        {
//            await browserFetcher.DownloadAsync();
//        }
//#endif

        _browser = await extra.LaunchAsync(launchOptions);
    }
    public async Task<IPage> NewPageAsync()
    {
        if (_browser == null)
            throw new InvalidOperationException("BrowserService is not initialized.");

        return await _browser.NewPageAsync();
    }
    public void Dispose()
    {
        if (!_disposed)
        {
            _browser?.Dispose();
            _disposed = true;
        }
    }
}
