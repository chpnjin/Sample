/*
 * 這個方法是用來建立 ASP.NET Core 應用程式的應用程式主機建構器（Application Host Builder）。
 * 該方法返回一個 WebApplicationBuilder 物件，用於配置並建立 ASP.NET Core 應用程式的主機（Host）。
 */
var builder = WebApplication.CreateBuilder(args);

/*
 * 在 ASP.NET Core 應用程式中調用 AddRazorPages() 方法時，它會註冊與 Razor Pages 相關的服務，以便能夠使用 Razor Pages 的功能。
 */
builder.Services.AddRazorPages();

//建立 ASP.NET Core 應用程式主機（Application Host）的實例。
var app = builder.Build();

//判斷是否為開發環境
if (!app.Environment.IsDevelopment())
{
    //使用錯誤處理頁面
    app.UseExceptionHandler("/Error");

    //該網站只能透過 HTTPS 連接進行通信，而不允許使用非加密的 HTTP 連接。
    //這有助於防止中間人攻擊（Man-in-the-Middle Attacks）和協助保護使用者免受SSL/TLS憑證信任問題的風險。
    app.UseHsts();
}
//將 HTTP 請求重新導向到 HTTPS
app.UseHttpsRedirection();
//啟用靜態檔案(ex.圖片、JavaScript檔案、CSS檔)中介軟體
app.UseStaticFiles();
//啟用路由
app.UseRouting();
//啟用資源訪問權限檢查
app.UseAuthorization();
//設定 Razor Pages 路由
app.MapRazorPages();
//結束請求管道處理並生成最終回應
app.Run();
