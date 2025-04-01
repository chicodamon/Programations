namespace ConversorDeMoedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCurrencies();
        }

        private void InitializeCurrencies()
        {
            cb_currency_original.Items.AddRange(new string[] { "EUR", "USD", "GBP" });
            cb_currency_destination.Items.AddRange(new string[] { "EUR", "USD", "GBP" });
            cb_currency_original.SelectedIndex = 0;
            cb_currency_destination.SelectedIndex = 1;
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(input_textbox.Text, out decimal valor))
            {
                MessageBox.Show("Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string moedaOrigem = cb_currency_original.SelectedItem?.ToString();
            string moedaDestino = cb_currency_destination.SelectedItem?.ToString();

            if (moedaOrigem == moedaDestino)
            {
                MessageBox.Show("As moedas de origem e destino não podem ser iguais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal taxaCambio = ObterTaxaCambio(moedaOrigem, moedaDestino);
            decimal resultado = valor * taxaCambio;
            lbl_result.Text = $"Resultado: {resultado:F2} {moedaDestino}";
        }

        private decimal ObterTaxaCambio(string origem, string destino)
        {
            if (origem == "EUR" && destino == "USD") return 1.08m;  //m -> tipo decimal
            if (origem == "EUR" && destino == "GBP") return 0.85m;  //se nao tivese o m o numero ficava como double!
            if (origem == "USD" && destino == "EUR") return 0.93m;
            if (origem == "USD" && destino == "GBP") return 0.79m;
            if (origem == "GBP" && destino == "EUR") return 1.17m;
            if (origem == "GBP" && destino == "USD") return 1.26m;
            return 1m;
        }
    }
}
