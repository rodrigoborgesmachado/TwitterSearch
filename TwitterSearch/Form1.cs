using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterSearch
{
    public partial class FO_Principal : Form
    {

        #region Atributos e Proriedades

        /// <summary>
        /// Controle de eventos na tela
        /// </summary>
        bool lockchage = false;

        #endregion Atributos e Proriedades

        #region Eventos

        /// <summary>
        /// Evento disparado na alteração do valor do check box todos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckb_todosSaida_CheckedChanged(object sender, EventArgs e)
        {
            if (lockchage)
            {
                return;
            }

            lockchage = true;

            ckb_csv.Checked = ckb_json.Checked = ckb_sql.Checked = ckb_xml.Checked = ckb_todosSaida.Checked;

            lockchage = false;
        }

        /// <summary>
        /// Evento disparado na alteração do valor do campo check box da opção json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckb_saida_CheckedChanged(object sender, EventArgs e)
        {
            if (lockchage)
            {
                return;
            }

            lockchage = true;

            ControleTodosCheckSaida();

            lockchage = false;
        }

        /// <summary>
        /// Evento lançado no clique do botão folder da tela para seleção de onde os arquivos serão salvos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_folder_Click(object sender, EventArgs e)
        {
            SelecionaFolder();
        }

        /// <summary>
        /// Evento disparado no clique do botão gerar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerar_Click(object sender, EventArgs e)
        {
            Gerar();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public FO_Principal()
        {
            InitializeComponent();
            InicializaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o form
        /// </summary>
        private void InicializaForm()
        {
            this.tbx_saida.Enabled = false;
        }

        /// <summary>
        /// Método que faz o controle de todos os check box de saída
        /// </summary>
        private void ControleTodosCheckSaida()
        {
            if (lockchage)
            {
                return;
            }

            lockchage = true;

            if (!ckb_csv.Checked || !ckb_json.Checked || !ckb_sql.Checked || !ckb_xml.Checked)
            {
                ckb_todosSaida.Checked = false;
            }
            else
            {
                ckb_todosSaida.Checked = false;
            }

            lockchage = false;
        }

        /// <summary>
        /// Método que seleciona a pasta de saída
        /// </summary>
        private void SelecionaFolder()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Diretório de saída.";
            if (dialog.ShowDialog() == DialogResult.OK)
                this.tbx_saida.Text = dialog.SelectedPath.ToString();
        }

        /// <summary>
        /// Método que gera o arquivo json e chama aplicação
        /// </summary>
        private void Gerar()
        {
            if (!Directory.Exists(Util.Global.app_python_directory))
            {
                MessageBox.Show("Não é possível gerar, a pasta com os arquivos do python não está disponível!");
                return;
            }

            StringBuilder saida = new StringBuilder();
            saida.Append("[{\n");
            saida.Append("\"use_limit\":" + (this.ckb_utilizaLimite.Checked ? "true":"false") + ",\n");
            saida.Append("\"max_tweets\":" + (string.IsNullOrEmpty(mtb_numeTweets.Text) ? "0" : mtb_numeTweets.Text) + ",\n");
            saida.Append("\"query_search\":\"" + tbx_buscaTexto.Text + "\",\n");
            saida.Append("\"by_username\":\"" + tbx_usuario.Text + "\",\n");
            saida.Append("\"use_date\":" + (ckb_intervalo_datas.Checked ? "true" : "false") + ",\n");
            saida.Append("\"date_since\":\"" + dtp_dataInicial.Value.Year.ToString() + "/" + dtp_dataInicial.Value.Month.ToString() + "/" + dtp_dataInicial.Value.Day.ToString() + "\",\n");
            saida.Append("\"date_until\":\"" + dtp_dataFinal.Value.Year.ToString() +"/" + dtp_dataFinal.Value.Month.ToString() + "/" + dtp_dataFinal.Value.Day.ToString() + "\",\n");
            saida.Append("\"top_tweets\":" + (this.ckb_topTweets.Checked ? "true" : "false") + ",\n");
            saida.Append("\"use_place\":" + (this.ckb_utilizaLocalizacao.Checked ? "true" : "false") + ",\n");
            saida.Append("\"place\":\"" + this.tbx_local.Text + "\",\n");
            saida.Append("\"area\":\"" + this.mtb_area.Text + "\",\n");
            saida.Append("\"use_geoLocales\":" + (this.ckb_geolocalizacao.Checked ? "true" : "false") + ",\n");
            saida.Append("\"geo\":\"" + this.tbx_geolocaliacao.Text + "\",\n");
            saida.Append("\"arquivo_saida\":\"" + 
                (ckb_csv.Checked ? ".csv;" : "") +
                (ckb_json.Checked ? ".json;" : "") +
                (ckb_sql.Checked ? ".sql;" : "") +
                (ckb_xml.Checked ? ".xml;" : "") 
                + "\",\n");
            saida.Append("\"log\":" + (this.ckb_log_detalhado.Checked ? "true" : "false") + "\n");
            saida.Append("}]\n");

            // Salva o arquivo json
            if (!SalvarArquivoJson(saida))
            {
                MessageBox.Show("Erro ao salvar o arquivo!");
            }

            // Executa o arquivo bat
            if (!ExecutaBat())
            {
                MessageBox.Show("Erro ao executar o python!");
            }

            // Copia os arquivos de saida
            if (CopiaArquivosSaida())
            {
                MessageBox.Show("Arquivos disponibilizados no diretório " + tbx_saida.Text + "!");
            }
            else
            {
                MessageBox.Show("Arquivos disponibilizados no diretório " + Util.Global.app_python_out_directory + "!");
            }
        }

        /// <summary>
        /// Método que copia os arquivos de saida para o diretório colocado
        /// </summary>
        /// <returns></returns>
        private bool CopiaArquivosSaida()
        {
            if (string.IsNullOrEmpty(tbx_saida.Text))
            {
                return false;
            }

            if (!Directory.Exists(tbx_saida.Text))
            {
                return false;
            }

            try
            {
                foreach(string info in Directory.GetFiles(Util.Global.app_python_out_directory))
                {
                    File.Copy(info, tbx_saida.Text);
                }

                return true;
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro ao salvar o arquivo! Erro: " + e.Message);
                return false;
            }
        }

        /// <summary>
        /// Método que cria o arquivo bat para execução
        /// </summary>
        /// <returns></returns>
        private void CriaBat()
        {
            File.Delete(Util.Global.app_python_bat_file);

            StringBuilder builder = new StringBuilder();
            builder.Append("echo off\n");
            builder.Append("cls\n");
            builder.Append("cd " + Util.Global.app_python_directory + "\n");
            builder.Append("python tweet\\main.py\n");
            builder.Append("pause\n");

            Util.CL_Files files = new Util.CL_Files(Util.Global.app_python_bat_file);

            files.WriteOnTheEnd(builder.ToString());
        }

        /// <summary>
        /// Método que executa o arquivo bat
        /// </summary>
        /// <returns></returns>
        private bool ExecutaBat()
        {
            try
            {
                CriaBat();
                System.Diagnostics.Process.Start(Util.Global.app_python_bat_file).WaitForExit();
                return true;
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro ao salvar o arquivo! Erro: " + e.Message);
                return false;
            }
        }

        /// <summary>
        /// Método que salva o arquivo json de entrada do programa python
        /// </summary>
        /// <param name="builder">String a ser salva no arquivo</param>
        /// <returns>True -> Foi possível salvar o arquivo; false -> erro ao salvar o arquivo</returns>
        private bool SalvarArquivoJson(StringBuilder builder)
        {
            try
            {
                File.Delete(Util.Global.app_python_in_file);

                Util.CL_Files files = new Util.CL_Files(Util.Global.app_python_in_file);

                files.WriteOnTheEnd(builder.ToString());

                return true;
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro ao salvar o arquivo! Erro: " + e.Message);
                return false;
            }
        }

        #endregion Métodos

    }
}
