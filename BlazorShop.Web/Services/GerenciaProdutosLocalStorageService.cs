using Blazored.LocalStorage;
using BlazorShop.Models.DTOs;

namespace BlazorShop.Web.Services;

public class GerenciaProdutosLocalStorageService : IGerenciaProdutosLocalStorageService
{
    private const string key = "ProdutoCollection";

    private readonly ILocalStorageService localStorageService;
    private readonly IProdutoService produtoService;

    public GerenciaProdutosLocalStorageService(ILocalStorageService localStorageService,
        IProdutoService produtoService)
    {
        this.localStorageService = localStorageService;
        this.produtoService = produtoService;
    }

    public async Task<IEnumerable<ProdutoDto>> GetCollection()
    {
        var produtos = await produtoService.GetItens();
        if (produtos != null)
        {
            await localStorageService.SetItemAsync(key, produtos);
        }
        return produtos;
    }

    public async Task RemoveCollection()
    {
        await localStorageService.RemoveItemAsync(key);
    }
}
