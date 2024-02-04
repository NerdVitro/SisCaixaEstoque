using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SisCaixaEstoque.Classes
{
    public class DataGridViewComum
    {
        readonly DataGridView dataGridView;
        List<GridViewColunas>? objLstColunas;

        public DataGridViewComum(ref DataGridView parDataGridView)
        {
            dataGridView = parDataGridView;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            Inicializar();
        }
        private void Inicializar()
        {
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();
            objLstColunas = new List<GridViewColunas>();
            dataGridView.AutoGenerateColumns = false;
        }

        public void AdicionaColuna(GridViewColunas parColuna)
        {
            objLstColunas ??= new List<GridViewColunas>();
            objLstColunas.Add(parColuna);
        }
        
        public void Finalizar(Object listaObjetos)
        {
            if (objLstColunas is null)
            {
                throw new(nameof(objLstColunas));
            }
            GridViewColunas objColuna;
            dataGridView.DataSource = listaObjetos;
            Configurar();

            for (int iixTable = 0; iixTable < objLstColunas.Count; iixTable++)
            {
                objColuna = objLstColunas[iixTable];

                if (!objColuna.ColunaSelecao)
                {
                    DataGridViewTextBoxColumn coluna = new()
                    {
                        HeaderText = objColuna.Titulo
                    };
                    coluna.HeaderCell.Style.Alignment = objColuna.Alinhamento;
                    coluna.Name = objColuna.NomeCampo;
                    coluna.Visible = objColuna.ColunaVisivel;
                    coluna.ReadOnly = objColuna.ReadOnly;
                    coluna.Resizable = DataGridViewTriState.True;
                    coluna.DefaultCellStyle.Alignment = objColuna.Alinhamento;
                    coluna.Width = objColuna.Tamanho;
                    coluna.SortMode = DataGridViewColumnSortMode.Programmatic;
                    coluna.DefaultCellStyle.BackColor = objColuna.CorFundo;
                    coluna.DefaultCellStyle.ForeColor = objColuna.CorFonte;
                    coluna.DefaultCellStyle.Format = objColuna.Mascara;
                    coluna.DataPropertyName = objColuna.NomeCampo;
                    coluna.AutoSizeMode = objColuna.AutoSizeMode;
                    dataGridView.Columns.Add(coluna);
                }
                else
                {
                    DataGridViewCheckBoxColumn coluna = new(false)
                    {
                        HeaderText = objColuna.Titulo,
                        Name = objColuna.NomeCampo,
                        Visible = objColuna.ColunaVisivel,
                        ReadOnly = false,
                        Selected = false,
                        Resizable = DataGridViewTriState.True,
                        Width = objColuna.Tamanho,
                        SortMode = DataGridViewColumnSortMode.Programmatic,
                        DataPropertyName = objColuna.NomeCampo,
                        FalseValue = false,
                        TrueValue = true,
                        IndeterminateValue = false,
                        AutoSizeMode = objColuna.AutoSizeMode,
                        ValueType = typeof(bool)
                    };
                    dataGridView.EditMode = DataGridViewEditMode.EditOnF2;
                    dataGridView.ReadOnly = false;
                    dataGridView.Columns.Add(coluna);
                }
            }

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
        public void Finalizar(Object listaObjetos, bool CentralizarTitulos = false)
        {
            if (objLstColunas is null)
            {
                throw new(nameof(objLstColunas));
            }
            GridViewColunas objColuna;
            dataGridView.DataSource = listaObjetos;
            Configurar();

            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor;

            for (int iixTable = 0; iixTable < objLstColunas.Count; iixTable++)
            {
                objColuna = objLstColunas[iixTable];
                if (CentralizarTitulos)
                {
                    if (!objColuna.ColunaSelecao)
                    {
                        DataGridViewTextBoxColumn coluna = new()
                        {
                            HeaderText = objColuna.Titulo,
                            Name = objColuna.NomeCampo,
                            Visible = objColuna.ColunaVisivel,
                            ReadOnly = objColuna.ReadOnly,
                            Resizable = DataGridViewTriState.True,
                            Width = objColuna.Tamanho,
                            SortMode = DataGridViewColumnSortMode.Programmatic,
                            DataPropertyName = objColuna.NomeCampo,
                            AutoSizeMode = objColuna.AutoSizeMode
                        };

                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        coluna.DefaultCellStyle.Alignment = objColuna.Alinhamento;
                        coluna.DefaultCellStyle.BackColor = objColuna.CorFundo;
                        coluna.DefaultCellStyle.ForeColor = objColuna.CorFonte;
                        coluna.DefaultCellStyle.Format = objColuna.Mascara;
                        if (objColuna.MinimunSizeWidth > 2)
                        {
                            coluna.MinimumWidth = objColuna.MinimunSizeWidth;
                        }
                        dataGridView.Columns.Add(coluna);

                    }
                    else
                    {
                        DataGridViewCheckBoxColumn coluna = new(false)
                        {
                            HeaderText = objColuna.Titulo,
                            Name = objColuna.NomeCampo,
                            Visible = objColuna.ColunaVisivel,
                            ReadOnly = false,
                            Selected = false,
                            Resizable = DataGridViewTriState.True,
                            Width = objColuna.Tamanho,
                            SortMode = DataGridViewColumnSortMode.Programmatic,
                            DataPropertyName = objColuna.NomeCampo,
                            FalseValue = false,
                            TrueValue = true,
                            IndeterminateValue = false,
                            AutoSizeMode = objColuna.AutoSizeMode,
                            ValueType = typeof(bool),

                        };
                        if (objColuna.MinimunSizeWidth > 2)
                        {
                            coluna.MinimumWidth = objColuna.MinimunSizeWidth;
                        }
                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        coluna.DefaultCellStyle.BackColor = objColuna.CorFundo;
                        dataGridView.EditMode = DataGridViewEditMode.EditOnF2;
                        dataGridView.ReadOnly = false;
                        dataGridView.Columns.Add(coluna);
                    }
                }
                else
                {
                    if (!objColuna.ColunaSelecao)
                    {
                        DataGridViewTextBoxColumn coluna = new()
                        {
                            HeaderText = objColuna.Titulo,
                            Name = objColuna.NomeCampo,
                            Visible = objColuna.ColunaVisivel,
                            ReadOnly = objColuna.ReadOnly,
                            Resizable = DataGridViewTriState.True,
                            Width = objColuna.Tamanho,
                            SortMode = DataGridViewColumnSortMode.Programmatic,
                            DataPropertyName = objColuna.NomeCampo,
                            AutoSizeMode = objColuna.AutoSizeMode
                        };

                        coluna.HeaderCell.Style.Alignment = objColuna.Alinhamento;
                        coluna.DefaultCellStyle.Alignment = objColuna.Alinhamento;
                        coluna.DefaultCellStyle.BackColor = objColuna.CorFundo;
                        coluna.DefaultCellStyle.ForeColor = objColuna.CorFonte;
                        coluna.DefaultCellStyle.Format = objColuna.Mascara;
                        if (objColuna.MinimunSizeWidth > 2)
                        {
                            coluna.MinimumWidth = objColuna.MinimunSizeWidth;
                        }
                        dataGridView.Columns.Add(coluna);
                    }
                    else
                    {
                        DataGridViewCheckBoxColumn coluna = new(false)
                        {
                            HeaderText = objColuna.Titulo,
                            Name = objColuna.NomeCampo,
                            Visible = objColuna.ColunaVisivel,
                            ReadOnly = false,
                            Selected = false,
                            Resizable = DataGridViewTriState.True,
                            Width = objColuna.Tamanho,
                            SortMode = DataGridViewColumnSortMode.Programmatic,
                            DataPropertyName = objColuna.NomeCampo,
                            FalseValue = false,
                            TrueValue = true,
                            IndeterminateValue = false,
                            AutoSizeMode = objColuna.AutoSizeMode,
                            ValueType = typeof(bool),
                        };
                        if (objColuna.MinimunSizeWidth > 2)
                        {
                            coluna.MinimumWidth = objColuna.MinimunSizeWidth;
                        }
                        dataGridView.EditMode = DataGridViewEditMode.EditOnF2;
                        dataGridView.ReadOnly = false;
                        dataGridView.Columns.Add(coluna);
                    }
                }
            }
        }

        private void Configurar()
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Forma de seleção será linha inteira
            dataGridView.AllowUserToDeleteRows = false;     // Usuário NÃO pode excluir linhas
            dataGridView.AllowUserToResizeRows = false;     // Usuário NÃO pode redimencionar as LINHAS
            dataGridView.AllowUserToResizeColumns = true;   // Usuário pode redimencionar as colunas
            dataGridView.AllowUserToOrderColumns = true;    // Usuário pode trocar as colunas de lugar
            dataGridView.AllowUserToAddRows = false;        // Usuário NÃO pode adicionar linhas
            dataGridView.MultiSelect = false;               // NÃO pode selecionar mais que uma linha por vez
            dataGridView.ColumnHeadersVisible = true;       // Cabeçalhos das colunas são visíveis
        }
    }
    public class GridViewColunas
    {
        private string? _Titulo;
        private string? _NomeCampo;
        private int? _Tamanho; 
        private DataGridViewContentAlignment? _Alinhamento;  
        private bool? _ColunaSelecao;
        private string? _Mascara;  
        private Color? _CorFonte;
        private Color? _CorFundo;
        private bool? _ColunaVisivel;
        private bool? _ReadOnly;
        private DataGridViewAutoSizeColumnMode? _AutoSizeMode;
        private int? _MinimunSizeWidth;
        //private int _MaximunSizeWidth;

        public GridViewColunas(string parTitulo,
                                  string parNomeCampo,
                                  int parTamanho,
                                  bool parColunaVisivel,
                                  DataGridViewContentAlignment parAlinhamento = DataGridViewContentAlignment.MiddleLeft,
                                  bool parColunaSelecao = false,
                                  string parMascara = "",
                                  Color parCorFonte = new Color(),
                                  Color parCorFundo = new Color(),
                                  bool parReadOnly = true,
                                  DataGridViewAutoSizeColumnMode parAutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet)
        {
            this.Titulo = parTitulo;
            this.NomeCampo = parNomeCampo;
            this.Tamanho = parTamanho;
            this.Alinhamento = parAlinhamento;
            this.ColunaSelecao = parColunaSelecao;
            this.Mascara = parMascara;
            this.CorFonte = parCorFonte;
            this.CorFundo = parCorFundo;
            this.ColunaVisivel = parColunaVisivel;
            this.ReadOnly = parReadOnly;
            this.AutoSizeMode = parAutoSizeMode;
        }
        public GridViewColunas(string parTitulo,
                                  string parNomeCampo,
                                  DataGridViewAutoSizeColumnMode parAutoSizeMode,
                                  int parTamanho,
                                  bool parColunaVisivel,
                                  DataGridViewContentAlignment parAlinhamento = DataGridViewContentAlignment.MiddleLeft,
                                  bool parColunaSelecao = false,
                                  string parMascara = "",
                                  Color parCorFonte = new Color(),
                                  Color parCorFundo = new Color(),
                                  bool parReadOnly = true)
        {
            this.Titulo = parTitulo;
            this.NomeCampo = parNomeCampo;
            this.Tamanho = parTamanho;
            this.Alinhamento = parAlinhamento;
            this.ColunaSelecao = parColunaSelecao;
            this.Mascara = parMascara;
            this.CorFonte = parCorFonte;
            this.CorFundo = parCorFundo;
            this.ColunaVisivel = parColunaVisivel;
            this.ReadOnly = parReadOnly;
            this.AutoSizeMode = parAutoSizeMode;
        }

        public GridViewColunas(string parTitulo,
                                  string parNomeCampo,
                                  DataGridViewAutoSizeColumnMode parAutoSizeMode,
                                  int parTamanho,
                                  int parMinimunSizeWidth,
                                  bool parColunaVisivel,
                                  DataGridViewContentAlignment parAlinhamento = DataGridViewContentAlignment.MiddleLeft,
                                  bool parColunaSelecao = false,
                                  string parMascara = "",
                                  Color parCorFonte = new Color(),
                                  Color parCorFundo = new Color(),
                                  bool parReadOnly = true)
        {
            this.Titulo = parTitulo;
            this.NomeCampo = parNomeCampo;
            this.Tamanho = parTamanho;
            this.Alinhamento = parAlinhamento;
            this.ColunaSelecao = parColunaSelecao;
            this.Mascara = parMascara;
            this.CorFonte = parCorFonte;
            this.CorFundo = parCorFundo;
            this.ColunaVisivel = parColunaVisivel;
            this.ReadOnly = parReadOnly;
            this.AutoSizeMode = parAutoSizeMode;
            this.MinimunSizeWidth = parMinimunSizeWidth;
        }
        public string Titulo { get => _Titulo?? ""; set => _Titulo = value; }
        public string NomeCampo { get => _NomeCampo ?? ""; set => _NomeCampo = value; }
        public int Tamanho { get => _Tamanho ?? 0; set => _Tamanho = value; }
        public DataGridViewContentAlignment Alinhamento { get => _Alinhamento ?? new DataGridViewContentAlignment(); set => _Alinhamento = value; }
        public bool ColunaSelecao { get => _ColunaSelecao ?? false; set => _ColunaSelecao = value; }
        public string Mascara { get => _Mascara ?? ""; set => _Mascara = value; }
        public Color CorFonte { get => _CorFonte ?? new Color(); set => _CorFonte = value; }
        public Color CorFundo { get => _CorFundo ?? new Color(); set => _CorFundo = value; }
        public bool ColunaVisivel { get => _ColunaVisivel ?? false; set => _ColunaVisivel = value; }
        public bool ReadOnly { get => _ReadOnly ?? false; set => _ReadOnly = value; }
        public DataGridViewAutoSizeColumnMode AutoSizeMode { get => _AutoSizeMode ?? new DataGridViewAutoSizeColumnMode(); set => _AutoSizeMode = value; }
        public int MinimunSizeWidth { get => _MinimunSizeWidth ?? 0; set => _MinimunSizeWidth = value; }
    }
}
