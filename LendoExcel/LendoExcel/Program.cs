using Microsoft.Office.Interop.Excel;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LendoExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int arquivosPendentes = Directory.GetFiles(@"C:\ROBO\Encerramento\Pendentes", "*", SearchOption.AllDirectories).Length;

                if (arquivosPendentes == 0)
                {
                    //Log nenhum arquivo
                }
                else if (arquivosPendentes == 1)
                {
                    string filepath = @"C:\ROBO\Encerramento\Pendentes";
                    DirectoryInfo d = new DirectoryInfo(filepath);

                    foreach (var file in d.GetFiles("*.csv"))
                    {
                        using (var reader = new StreamReader(file.FullName))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(';');

                            }
                        }
                        Directory.Move(file.FullName, @"C:\ROBO\Encerramento\Processados\" + file.Name);
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
