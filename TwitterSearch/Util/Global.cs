using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterSearch.Util
{
    public static class Global
    {
        // Caminho principal da aplicação
        public static string app_main_directory = System.IO.Directory.GetCurrentDirectory() + "\\";

        // Caminho da pasta de logs do sistema
        public static string app_logs_directoty = app_main_directory + "Log\\";

        // Diretório da pasta dos arquivos python
        public static string app_python_directory = app_main_directory + "python\\";

        // Diretório da pasta dos arquivos python
        public static string app_python_in_file = app_python_directory + "entrada.json";

        // Diretório da pasta dos arquivos python
        public static string app_python_bat_file = app_python_directory + "execute.bat";

        // Disretório dos arquivos de saida do python
        public static string app_python_out_directory = app_python_directory + "OUT\\";
    }
}
