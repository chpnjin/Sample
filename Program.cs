/*
 * �o�Ӥ�k�O�Ψӫإ� ASP.NET Core ���ε{�������ε{���D���غc���]Application Host Builder�^�C
 * �Ӥ�k��^�@�� WebApplicationBuilder ����A�Ω�t�m�ëإ� ASP.NET Core ���ε{�����D���]Host�^�C
 */
var builder = WebApplication.CreateBuilder(args);

/*
 * �b ASP.NET Core ���ε{�����ե� AddRazorPages() ��k�ɡA���|���U�P Razor Pages �������A�ȡA�H�K����ϥ� Razor Pages ���\��C
 */
builder.Services.AddRazorPages();

//�إ� ASP.NET Core ���ε{���D���]Application Host�^����ҡC
var app = builder.Build();

//�P�_�O�_���}�o����
if (!app.Environment.IsDevelopment())
{
    //�ϥο��~�B�z����
    app.UseExceptionHandler("/Error");

    //�Ӻ����u��z�L HTTPS �s���i��q�H�A�Ӥ����\�ϥΫD�[�K�� HTTP �s���C
    //�o���U�󨾤���H�����]Man-in-the-Middle Attacks�^�M��U�O�@�ϥΪ̧K��SSL/TLS���ҫH�����D�����I�C
    app.UseHsts();
}
//�N HTTP �ШD���s�ɦV�� HTTPS
app.UseHttpsRedirection();
//�ҥ��R�A�ɮ�(ex.�Ϥ��BJavaScript�ɮסBCSS��)�����n��
app.UseStaticFiles();
//�ҥθ���
app.UseRouting();
//�ҥθ귽�X���v���ˬd
app.UseAuthorization();
//�]�w Razor Pages ����
app.MapRazorPages();
//�����ШD�޹D�B�z�åͦ��̲צ^��
app.Run();
