using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        foreach (string arquivo in GetArquivos("C:\\")) //Mude aqui para definir o ponto de partida
        {
            Console.WriteLine(arquivo); 
        }
    }

    static IEnumerable<string> GetArquivos(string path)
    {
        Queue<string> fila = new(); //Declara fila
        fila.Enqueue(path); //Adiciona o diretório inicial na fila
        while (fila.Count > 0) //Só termina quando acaba 
        {
            path = fila.Dequeue(); //Retira elemento da fila o armazenando no Path
            if (Directory.Exists(path)) //Caso esse elemento for um diretório
            {
                string[] arquivos;
                try //Explora arquivos
                {
                    arquivos = Directory.GetFiles(path);
                }
                catch (UnauthorizedAccessException) //Case não tenha acesso ao repositório, ele passa
                {
                    continue;
                }

                foreach (string arquivo in arquivos)
                {
                    yield return arquivo; //retorna cada elemento do array sem encerrar o método
                }

                foreach (string subDiretorio in Directory.GetDirectories(path))
                {
                    fila.Enqueue(subDiretorio); // Enfileira os subdiretórios para exploração
                }
            }
        }
    }
}