// --- UX / IHC: Saudação e Contexto ---
Console.Clear();
Console.WriteLine("========================================");
Console.WriteLine("   SISTEMA EXPERT: Módulo de Boas-Vindas");
Console.WriteLine("========================================\n");

// --- Entrada de Dados ---
Console.Write("Olá, Recruta! Qual é o seu nome de Desenvolvedor(a)? ");
string nome = Console.ReadLine();

Console.Write($"Prazer, {nome}! Em qual ano você começou a programar? ");
string entradaAno = Console.ReadLine();

// --- Lógica Simples ---
int anoInicio = int.Parse(entradaAno);
int anosDeJornada = DateTime.Now.Year - anoInicio;

// --- Feedback Visual ---
Console.WriteLine("\n----------------------------------------");
Console.WriteLine($"STATUS DO PERFIL: {nome.ToUpper()}");
Console.WriteLine($"TEMPO DE ESTRADA: {anosDeJornada} ano(s) de experiência.");
Console.WriteLine("----------------------------------------");

Console.WriteLine("\n[Missão Cumprida! Pressione qualquer tecla para encerrar]");
Console.ReadKey();