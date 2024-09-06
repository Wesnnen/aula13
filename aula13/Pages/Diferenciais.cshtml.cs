using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Escola.Pages
{
    public class DiferenciaisModel : PageModel
    {
        public List<Professor> x { get; set; } = new List<Professor>();
        public void OnGet()
        {
            x = new List<Professor>
    {
        new Professor
{
    Nome = "Alvaro Cunha",
    Descricao = @"
Especialista em Seguran�a Cibern�tica e Prote��o de Dados",
    ImagemUrl = "Imagens/beard.jpg"
},
new Professor
{
    Nome = "Willy Bronca",
    Descricao = @"
Especialista em Intelig�ncia Artificial e Machine Learning",
    ImagemUrl = "Imagens/cigar.jpg"
},
new Professor
{
     Nome = "Leoncio Junior",
    Descricao = @"
Desenvolvedor de Software e Arquitetura de Sistemas",
    ImagemUrl = "Imagens/human.jpg"
},
new Professor
{
    Nome = "Olivia Cabelo",
    Descricao = @"
Consultora em Infraestrutura de TI e Redes",
    ImagemUrl = "Imagens/girl.jpg"
},
new Professor
{
    Nome = "Elviz Pretzel",
    Descricao = @"
Engenheiro de Dados e An�lise de Big Data",
    ImagemUrl = "Imagens/fashion.jpg"
},
new Professor
{
    Nome = "Zeca Oliveira",
    Descricao = @"
Especialista em Desenvolvimento de Aplica��es M�veis",
    ImagemUrl = "Imagens/man.jpg"
},
new Professor
{
    Nome = "Maria Ana Ramalho",
    Descricao = @"
Analista de Sistemas e Gerenciamento de Projetos de TI",
    ImagemUrl = "Imagens/woman.jpg"
},
new Professor
{
    Nome = "Am�lia Ramos",
    Descricao = @"
Especialista em Usabilidade e Design de Interfaces",
    ImagemUrl = "Imagens/womam.jpg"
},
new Professor
{
    Nome = "Oscar Jos�",
    Descricao = @"
Consultor em Transforma��o Digital e Inova��o Tecnol�gica",

    ImagemUrl = "Imagens/Prof.png"
}



        };
        }
    }
}
