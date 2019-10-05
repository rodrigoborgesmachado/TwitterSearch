namespace TwitterSearch
{
    partial class FO_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FO_Principal));
            this.pan_botoes = new System.Windows.Forms.Panel();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.pan_info = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ckb_log_detalhado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_saida = new System.Windows.Forms.GroupBox();
            this.ckb_sql = new System.Windows.Forms.CheckBox();
            this.btn_folder = new System.Windows.Forms.Button();
            this.ckb_xml = new System.Windows.Forms.CheckBox();
            this.lbl_caminhoSaida = new System.Windows.Forms.Label();
            this.ckb_csv = new System.Windows.Forms.CheckBox();
            this.tbx_saida = new System.Windows.Forms.TextBox();
            this.ckb_todosSaida = new System.Windows.Forms.CheckBox();
            this.ckb_json = new System.Windows.Forms.CheckBox();
            this.pan_limit_tweet = new System.Windows.Forms.Panel();
            this.grb_limiteNumerico = new System.Windows.Forms.GroupBox();
            this.mtb_numeTweets = new System.Windows.Forms.MaskedTextBox();
            this.lbl_limite = new System.Windows.Forms.Label();
            this.ckb_utilizaLimite = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grb_local = new System.Windows.Forms.GroupBox();
            this.ckb_geolocalizacao = new System.Windows.Forms.CheckBox();
            this.tbx_geolocaliacao = new System.Windows.Forms.TextBox();
            this.mtb_area = new System.Windows.Forms.MaskedTextBox();
            this.lbl_geolocalizacao = new System.Windows.Forms.Label();
            this.ckb_utilizaLocalizacao = new System.Windows.Forms.CheckBox();
            this.tbx_local = new System.Windows.Forms.TextBox();
            this.lbl_local = new System.Windows.Forms.Label();
            this.lbl_abrangencia = new System.Windows.Forms.Label();
            this.lbl_km = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_data = new System.Windows.Forms.GroupBox();
            this.dtp_dataFinal = new System.Windows.Forms.DateTimePicker();
            this.lbl_dataInicial = new System.Windows.Forms.Label();
            this.dtp_dataInicial = new System.Windows.Forms.DateTimePicker();
            this.ckb_intervalo_datas = new System.Windows.Forms.CheckBox();
            this.lbl_dataFinal = new System.Windows.Forms.Label();
            this.pan_search = new System.Windows.Forms.Panel();
            this.grb_texto = new System.Windows.Forms.GroupBox();
            this.ckb_topTweets = new System.Windows.Forms.CheckBox();
            this.tbx_usuario = new System.Windows.Forms.TextBox();
            this.tbx_buscaTexto = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.pan_botoes.SuspendLayout();
            this.pan_info.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grb_saida.SuspendLayout();
            this.pan_limit_tweet.SuspendLayout();
            this.grb_limiteNumerico.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grb_local.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grb_data.SuspendLayout();
            this.pan_search.SuspendLayout();
            this.grb_texto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_botoes
            // 
            this.pan_botoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.pan_botoes.Controls.Add(this.btn_gerar);
            this.pan_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botoes.Location = new System.Drawing.Point(0, 460);
            this.pan_botoes.Name = "pan_botoes";
            this.pan_botoes.Size = new System.Drawing.Size(401, 37);
            this.pan_botoes.TabIndex = 0;
            // 
            // btn_gerar
            // 
            this.btn_gerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerar.Location = new System.Drawing.Point(291, 6);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(107, 28);
            this.btn_gerar.TabIndex = 21;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // pan_info
            // 
            this.pan_info.AutoScroll = true;
            this.pan_info.Controls.Add(this.panel4);
            this.pan_info.Controls.Add(this.pan_limit_tweet);
            this.pan_info.Controls.Add(this.panel3);
            this.pan_info.Controls.Add(this.panel1);
            this.pan_info.Controls.Add(this.pan_search);
            this.pan_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_info.Location = new System.Drawing.Point(0, 0);
            this.pan_info.Name = "pan_info";
            this.pan_info.Size = new System.Drawing.Size(401, 460);
            this.pan_info.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ckb_log_detalhado);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.grb_saida);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 563);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 158);
            this.panel4.TabIndex = 7;
            // 
            // ckb_log_detalhado
            // 
            this.ckb_log_detalhado.AutoSize = true;
            this.ckb_log_detalhado.Location = new System.Drawing.Point(11, 76);
            this.ckb_log_detalhado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_log_detalhado.Name = "ckb_log_detalhado";
            this.ckb_log_detalhado.Size = new System.Drawing.Size(157, 20);
            this.ckb_log_detalhado.TabIndex = 19;
            this.ckb_log_detalhado.Text = "Gerar Logs Detalhados";
            this.ckb_log_detalhado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos de Saída:";
            // 
            // grb_saida
            // 
            this.grb_saida.Controls.Add(this.ckb_sql);
            this.grb_saida.Controls.Add(this.btn_folder);
            this.grb_saida.Controls.Add(this.ckb_xml);
            this.grb_saida.Controls.Add(this.lbl_caminhoSaida);
            this.grb_saida.Controls.Add(this.ckb_csv);
            this.grb_saida.Controls.Add(this.tbx_saida);
            this.grb_saida.Controls.Add(this.ckb_todosSaida);
            this.grb_saida.Controls.Add(this.ckb_json);
            this.grb_saida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_saida.Location = new System.Drawing.Point(0, 0);
            this.grb_saida.Name = "grb_saida";
            this.grb_saida.Size = new System.Drawing.Size(384, 158);
            this.grb_saida.TabIndex = 2;
            this.grb_saida.TabStop = false;
            this.grb_saida.Text = "Saída";
            // 
            // ckb_sql
            // 
            this.ckb_sql.AutoSize = true;
            this.ckb_sql.Location = new System.Drawing.Point(254, 48);
            this.ckb_sql.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_sql.Name = "ckb_sql";
            this.ckb_sql.Size = new System.Drawing.Size(53, 20);
            this.ckb_sql.TabIndex = 18;
            this.ckb_sql.Text = "SQL";
            this.ckb_sql.UseVisualStyleBackColor = true;
            this.ckb_sql.CheckedChanged += new System.EventHandler(this.ckb_saida_CheckedChanged);
            // 
            // btn_folder
            // 
            this.btn_folder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_folder.Location = new System.Drawing.Point(317, 96);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(61, 24);
            this.btn_folder.TabIndex = 20;
            this.btn_folder.Text = "Folder";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // ckb_xml
            // 
            this.ckb_xml.AutoSize = true;
            this.ckb_xml.Location = new System.Drawing.Point(198, 48);
            this.ckb_xml.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_xml.Name = "ckb_xml";
            this.ckb_xml.Size = new System.Drawing.Size(57, 20);
            this.ckb_xml.TabIndex = 17;
            this.ckb_xml.Text = "XML";
            this.ckb_xml.UseVisualStyleBackColor = true;
            this.ckb_xml.CheckedChanged += new System.EventHandler(this.ckb_saida_CheckedChanged);
            // 
            // lbl_caminhoSaida
            // 
            this.lbl_caminhoSaida.AutoSize = true;
            this.lbl_caminhoSaida.Location = new System.Drawing.Point(9, 99);
            this.lbl_caminhoSaida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_caminhoSaida.Name = "lbl_caminhoSaida";
            this.lbl_caminhoSaida.Size = new System.Drawing.Size(113, 16);
            this.lbl_caminhoSaida.TabIndex = 0;
            this.lbl_caminhoSaida.Text = "Caminho de Saída:";
            // 
            // ckb_csv
            // 
            this.ckb_csv.AutoSize = true;
            this.ckb_csv.Location = new System.Drawing.Point(142, 48);
            this.ckb_csv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_csv.Name = "ckb_csv";
            this.ckb_csv.Size = new System.Drawing.Size(53, 20);
            this.ckb_csv.TabIndex = 16;
            this.ckb_csv.Text = "CSV";
            this.ckb_csv.UseVisualStyleBackColor = true;
            this.ckb_csv.CheckedChanged += new System.EventHandler(this.ckb_saida_CheckedChanged);
            // 
            // tbx_saida
            // 
            this.tbx_saida.Location = new System.Drawing.Point(130, 96);
            this.tbx_saida.Name = "tbx_saida";
            this.tbx_saida.Size = new System.Drawing.Size(181, 23);
            this.tbx_saida.TabIndex = 1;
            // 
            // ckb_todosSaida
            // 
            this.ckb_todosSaida.AutoSize = true;
            this.ckb_todosSaida.Location = new System.Drawing.Point(12, 49);
            this.ckb_todosSaida.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_todosSaida.Name = "ckb_todosSaida";
            this.ckb_todosSaida.Size = new System.Drawing.Size(62, 20);
            this.ckb_todosSaida.TabIndex = 14;
            this.ckb_todosSaida.Text = "Todos";
            this.ckb_todosSaida.UseVisualStyleBackColor = true;
            this.ckb_todosSaida.CheckedChanged += new System.EventHandler(this.ckb_todosSaida_CheckedChanged);
            // 
            // ckb_json
            // 
            this.ckb_json.AutoSize = true;
            this.ckb_json.Location = new System.Drawing.Point(78, 49);
            this.ckb_json.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_json.Name = "ckb_json";
            this.ckb_json.Size = new System.Drawing.Size(61, 20);
            this.ckb_json.TabIndex = 15;
            this.ckb_json.Text = "JSON";
            this.ckb_json.UseVisualStyleBackColor = true;
            this.ckb_json.CheckedChanged += new System.EventHandler(this.ckb_saida_CheckedChanged);
            // 
            // pan_limit_tweet
            // 
            this.pan_limit_tweet.Controls.Add(this.grb_limiteNumerico);
            this.pan_limit_tweet.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_limit_tweet.Location = new System.Drawing.Point(0, 447);
            this.pan_limit_tweet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pan_limit_tweet.Name = "pan_limit_tweet";
            this.pan_limit_tweet.Size = new System.Drawing.Size(384, 116);
            this.pan_limit_tweet.TabIndex = 0;
            // 
            // grb_limiteNumerico
            // 
            this.grb_limiteNumerico.Controls.Add(this.mtb_numeTweets);
            this.grb_limiteNumerico.Controls.Add(this.lbl_limite);
            this.grb_limiteNumerico.Controls.Add(this.ckb_utilizaLimite);
            this.grb_limiteNumerico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_limiteNumerico.Location = new System.Drawing.Point(0, 0);
            this.grb_limiteNumerico.Name = "grb_limiteNumerico";
            this.grb_limiteNumerico.Size = new System.Drawing.Size(384, 116);
            this.grb_limiteNumerico.TabIndex = 4;
            this.grb_limiteNumerico.TabStop = false;
            this.grb_limiteNumerico.Text = "Limite de Tweets";
            // 
            // mtb_numeTweets
            // 
            this.mtb_numeTweets.Location = new System.Drawing.Point(125, 47);
            this.mtb_numeTweets.Mask = "0000";
            this.mtb_numeTweets.Name = "mtb_numeTweets";
            this.mtb_numeTweets.Size = new System.Drawing.Size(100, 23);
            this.mtb_numeTweets.TabIndex = 13;
            this.mtb_numeTweets.ValidatingType = typeof(int);
            // 
            // lbl_limite
            // 
            this.lbl_limite.AutoSize = true;
            this.lbl_limite.Location = new System.Drawing.Point(6, 50);
            this.lbl_limite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_limite.Name = "lbl_limite";
            this.lbl_limite.Size = new System.Drawing.Size(108, 16);
            this.lbl_limite.TabIndex = 0;
            this.lbl_limite.Text = "Limite de Tweets:";
            // 
            // ckb_utilizaLimite
            // 
            this.ckb_utilizaLimite.AutoSize = true;
            this.ckb_utilizaLimite.Location = new System.Drawing.Point(9, 24);
            this.ckb_utilizaLimite.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_utilizaLimite.Name = "ckb_utilizaLimite";
            this.ckb_utilizaLimite.Size = new System.Drawing.Size(162, 20);
            this.ckb_utilizaLimite.TabIndex = 12;
            this.ckb_utilizaLimite.Text = "Utiliza Limite de Tweets";
            this.ckb_utilizaLimite.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grb_local);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 252);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 195);
            this.panel3.TabIndex = 5;
            // 
            // grb_local
            // 
            this.grb_local.Controls.Add(this.ckb_geolocalizacao);
            this.grb_local.Controls.Add(this.tbx_geolocaliacao);
            this.grb_local.Controls.Add(this.mtb_area);
            this.grb_local.Controls.Add(this.lbl_geolocalizacao);
            this.grb_local.Controls.Add(this.ckb_utilizaLocalizacao);
            this.grb_local.Controls.Add(this.tbx_local);
            this.grb_local.Controls.Add(this.lbl_local);
            this.grb_local.Controls.Add(this.lbl_abrangencia);
            this.grb_local.Controls.Add(this.lbl_km);
            this.grb_local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_local.Location = new System.Drawing.Point(0, 0);
            this.grb_local.Name = "grb_local";
            this.grb_local.Size = new System.Drawing.Size(384, 195);
            this.grb_local.TabIndex = 4;
            this.grb_local.TabStop = false;
            this.grb_local.Text = "Localização";
            // 
            // ckb_geolocalizacao
            // 
            this.ckb_geolocalizacao.AutoSize = true;
            this.ckb_geolocalizacao.Location = new System.Drawing.Point(9, 100);
            this.ckb_geolocalizacao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_geolocalizacao.Name = "ckb_geolocalizacao";
            this.ckb_geolocalizacao.Size = new System.Drawing.Size(148, 20);
            this.ckb_geolocalizacao.TabIndex = 10;
            this.ckb_geolocalizacao.Text = "Utiliza Geolocalização";
            this.ckb_geolocalizacao.UseVisualStyleBackColor = true;
            // 
            // tbx_geolocaliacao
            // 
            this.tbx_geolocaliacao.Location = new System.Drawing.Point(125, 123);
            this.tbx_geolocaliacao.Name = "tbx_geolocaliacao";
            this.tbx_geolocaliacao.Size = new System.Drawing.Size(247, 23);
            this.tbx_geolocaliacao.TabIndex = 11;
            // 
            // mtb_area
            // 
            this.mtb_area.Location = new System.Drawing.Point(125, 72);
            this.mtb_area.Mask = "0000";
            this.mtb_area.Name = "mtb_area";
            this.mtb_area.Size = new System.Drawing.Size(100, 23);
            this.mtb_area.TabIndex = 9;
            this.mtb_area.ValidatingType = typeof(int);
            // 
            // lbl_geolocalizacao
            // 
            this.lbl_geolocalizacao.AutoSize = true;
            this.lbl_geolocalizacao.Location = new System.Drawing.Point(6, 126);
            this.lbl_geolocalizacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_geolocalizacao.Name = "lbl_geolocalizacao";
            this.lbl_geolocalizacao.Size = new System.Drawing.Size(94, 16);
            this.lbl_geolocalizacao.TabIndex = 0;
            this.lbl_geolocalizacao.Text = "Geolocalização:";
            // 
            // ckb_utilizaLocalizacao
            // 
            this.ckb_utilizaLocalizacao.AutoSize = true;
            this.ckb_utilizaLocalizacao.Location = new System.Drawing.Point(9, 22);
            this.ckb_utilizaLocalizacao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_utilizaLocalizacao.Name = "ckb_utilizaLocalizacao";
            this.ckb_utilizaLocalizacao.Size = new System.Drawing.Size(96, 20);
            this.ckb_utilizaLocalizacao.TabIndex = 7;
            this.ckb_utilizaLocalizacao.Text = "Utiliza Local";
            this.ckb_utilizaLocalizacao.UseVisualStyleBackColor = true;
            // 
            // tbx_local
            // 
            this.tbx_local.Location = new System.Drawing.Point(125, 42);
            this.tbx_local.Name = "tbx_local";
            this.tbx_local.Size = new System.Drawing.Size(247, 23);
            this.tbx_local.TabIndex = 8;
            // 
            // lbl_local
            // 
            this.lbl_local.AutoSize = true;
            this.lbl_local.Location = new System.Drawing.Point(6, 47);
            this.lbl_local.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(42, 16);
            this.lbl_local.TabIndex = 0;
            this.lbl_local.Text = "Local:";
            // 
            // lbl_abrangencia
            // 
            this.lbl_abrangencia.AutoSize = true;
            this.lbl_abrangencia.Location = new System.Drawing.Point(8, 76);
            this.lbl_abrangencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_abrangencia.Name = "lbl_abrangencia";
            this.lbl_abrangencia.Size = new System.Drawing.Size(38, 16);
            this.lbl_abrangencia.TabIndex = 0;
            this.lbl_abrangencia.Text = "Área:";
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Location = new System.Drawing.Point(230, 75);
            this.lbl_km.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(26, 16);
            this.lbl_km.TabIndex = 0;
            this.lbl_km.Text = "km";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grb_data);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 116);
            this.panel1.TabIndex = 3;
            // 
            // grb_data
            // 
            this.grb_data.Controls.Add(this.dtp_dataFinal);
            this.grb_data.Controls.Add(this.lbl_dataInicial);
            this.grb_data.Controls.Add(this.dtp_dataInicial);
            this.grb_data.Controls.Add(this.ckb_intervalo_datas);
            this.grb_data.Controls.Add(this.lbl_dataFinal);
            this.grb_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_data.Location = new System.Drawing.Point(0, 0);
            this.grb_data.Name = "grb_data";
            this.grb_data.Size = new System.Drawing.Size(384, 116);
            this.grb_data.TabIndex = 3;
            this.grb_data.TabStop = false;
            this.grb_data.Text = "Intervalo de Datas";
            // 
            // dtp_dataFinal
            // 
            this.dtp_dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataFinal.Location = new System.Drawing.Point(277, 38);
            this.dtp_dataFinal.Name = "dtp_dataFinal";
            this.dtp_dataFinal.Size = new System.Drawing.Size(95, 23);
            this.dtp_dataFinal.TabIndex = 6;
            // 
            // lbl_dataInicial
            // 
            this.lbl_dataInicial.AutoSize = true;
            this.lbl_dataInicial.Location = new System.Drawing.Point(6, 41);
            this.lbl_dataInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dataInicial.Name = "lbl_dataInicial";
            this.lbl_dataInicial.Size = new System.Drawing.Size(75, 16);
            this.lbl_dataInicial.TabIndex = 0;
            this.lbl_dataInicial.Text = "Data Inicial:";
            // 
            // dtp_dataInicial
            // 
            this.dtp_dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataInicial.Location = new System.Drawing.Point(88, 38);
            this.dtp_dataInicial.Name = "dtp_dataInicial";
            this.dtp_dataInicial.Size = new System.Drawing.Size(95, 23);
            this.dtp_dataInicial.TabIndex = 5;
            // 
            // ckb_intervalo_datas
            // 
            this.ckb_intervalo_datas.AutoSize = true;
            this.ckb_intervalo_datas.Location = new System.Drawing.Point(9, 18);
            this.ckb_intervalo_datas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_intervalo_datas.Name = "ckb_intervalo_datas";
            this.ckb_intervalo_datas.Size = new System.Drawing.Size(168, 20);
            this.ckb_intervalo_datas.TabIndex = 4;
            this.ckb_intervalo_datas.Text = "Utiliza Intervalo de Datas";
            this.ckb_intervalo_datas.UseVisualStyleBackColor = true;
            // 
            // lbl_dataFinal
            // 
            this.lbl_dataFinal.AutoSize = true;
            this.lbl_dataFinal.Location = new System.Drawing.Point(195, 41);
            this.lbl_dataFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dataFinal.Name = "lbl_dataFinal";
            this.lbl_dataFinal.Size = new System.Drawing.Size(68, 16);
            this.lbl_dataFinal.TabIndex = 0;
            this.lbl_dataFinal.Text = "Data Final:";
            // 
            // pan_search
            // 
            this.pan_search.Controls.Add(this.grb_texto);
            this.pan_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_search.Location = new System.Drawing.Point(0, 0);
            this.pan_search.Name = "pan_search";
            this.pan_search.Size = new System.Drawing.Size(384, 136);
            this.pan_search.TabIndex = 1;
            // 
            // grb_texto
            // 
            this.grb_texto.Controls.Add(this.ckb_topTweets);
            this.grb_texto.Controls.Add(this.tbx_usuario);
            this.grb_texto.Controls.Add(this.tbx_buscaTexto);
            this.grb_texto.Controls.Add(this.lbl_usuario);
            this.grb_texto.Controls.Add(this.lbl_search);
            this.grb_texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_texto.Location = new System.Drawing.Point(0, 0);
            this.grb_texto.Name = "grb_texto";
            this.grb_texto.Size = new System.Drawing.Size(384, 136);
            this.grb_texto.TabIndex = 2;
            this.grb_texto.TabStop = false;
            this.grb_texto.Text = "Texto e Usuário";
            // 
            // ckb_topTweets
            // 
            this.ckb_topTweets.AutoSize = true;
            this.ckb_topTweets.Location = new System.Drawing.Point(9, 78);
            this.ckb_topTweets.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckb_topTweets.Name = "ckb_topTweets";
            this.ckb_topTweets.Size = new System.Drawing.Size(150, 20);
            this.ckb_topTweets.TabIndex = 3;
            this.ckb_topTweets.Text = "Utiliza Top 10 Tweets";
            this.ckb_topTweets.UseVisualStyleBackColor = true;
            // 
            // tbx_usuario
            // 
            this.tbx_usuario.Location = new System.Drawing.Point(125, 50);
            this.tbx_usuario.Name = "tbx_usuario";
            this.tbx_usuario.Size = new System.Drawing.Size(247, 23);
            this.tbx_usuario.TabIndex = 2;
            // 
            // tbx_buscaTexto
            // 
            this.tbx_buscaTexto.Location = new System.Drawing.Point(125, 22);
            this.tbx_buscaTexto.Name = "tbx_buscaTexto";
            this.tbx_buscaTexto.Size = new System.Drawing.Size(247, 23);
            this.tbx_buscaTexto.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(6, 51);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(54, 16);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(6, 22);
            this.lbl_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(94, 16);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "Busca de texto:";
            // 
            // FO_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(401, 497);
            this.Controls.Add(this.pan_info);
            this.Controls.Add(this.pan_botoes);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FO_Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros";
            this.pan_botoes.ResumeLayout(false);
            this.pan_info.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grb_saida.ResumeLayout(false);
            this.grb_saida.PerformLayout();
            this.pan_limit_tweet.ResumeLayout(false);
            this.grb_limiteNumerico.ResumeLayout(false);
            this.grb_limiteNumerico.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grb_local.ResumeLayout(false);
            this.grb_local.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grb_data.ResumeLayout(false);
            this.grb_data.PerformLayout();
            this.pan_search.ResumeLayout(false);
            this.grb_texto.ResumeLayout(false);
            this.grb_texto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_botoes;
        private System.Windows.Forms.Panel pan_info;
        private System.Windows.Forms.Panel pan_limit_tweet;
        private System.Windows.Forms.CheckBox ckb_utilizaLimite;
        private System.Windows.Forms.Label lbl_limite;
        private System.Windows.Forms.MaskedTextBox mtb_numeTweets;
        private System.Windows.Forms.Panel pan_search;
        private System.Windows.Forms.TextBox tbx_buscaTexto;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_dataFinal;
        private System.Windows.Forms.DateTimePicker dtp_dataInicial;
        private System.Windows.Forms.Label lbl_dataFinal;
        private System.Windows.Forms.CheckBox ckb_intervalo_datas;
        private System.Windows.Forms.Label lbl_dataInicial;
        private System.Windows.Forms.TextBox tbx_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.CheckBox ckb_topTweets;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ckb_utilizaLocalizacao;
        private System.Windows.Forms.Label lbl_local;
        private System.Windows.Forms.TextBox tbx_local;
        private System.Windows.Forms.MaskedTextBox mtb_area;
        private System.Windows.Forms.Label lbl_abrangencia;
        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.CheckBox ckb_geolocalizacao;
        private System.Windows.Forms.Label lbl_geolocalizacao;
        private System.Windows.Forms.TextBox tbx_geolocaliacao;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckb_sql;
        private System.Windows.Forms.CheckBox ckb_xml;
        private System.Windows.Forms.CheckBox ckb_csv;
        private System.Windows.Forms.CheckBox ckb_json;
        private System.Windows.Forms.CheckBox ckb_log_detalhado;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.GroupBox grb_data;
        private System.Windows.Forms.GroupBox grb_texto;
        private System.Windows.Forms.GroupBox grb_limiteNumerico;
        private System.Windows.Forms.GroupBox grb_local;
        private System.Windows.Forms.GroupBox grb_saida;
        private System.Windows.Forms.Label lbl_caminhoSaida;
        private System.Windows.Forms.TextBox tbx_saida;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.CheckBox ckb_todosSaida;
    }
}

