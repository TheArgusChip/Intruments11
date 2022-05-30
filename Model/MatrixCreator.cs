namespace Intruments11.Model
{
    internal class MatrixCreator
    {
        private DataGridView _dataGridView;

        public MatrixCreator(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }

        public double[,] Result => GetTableToCalculate();

        private double[,] GetTableToCalculate()
        {
            CreateResult(out double[,] result);
            FillFirstColumn(ref result);
            FillLastRow(ref result);
            AddDataFromDataGridView(ref result);

            return result;
        }

        private void CreateResult(out double[,] result)
        {
            int columnsCount = _dataGridView.Columns.Count + 1;
            int rowsCount = _dataGridView.Rows.Count + 1;

            result = new double[rowsCount, columnsCount];
        }

        private void FillFirstColumn(ref double[,] array)
        {
            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                array[i, 0] = 1;
            }

            array[array.GetLength(0) - 1, 0] = 0;
        }
        private void FillLastRow(ref double[,] result)
        {
            for (int i = 1; i < result.GetLength(1); i++)
            {
                result[result.GetLength(0) - 1, i] = -1;
            }
        }

        private void AddDataFromDataGridView(ref double[,] result)
        {
            for (int i = 0; i < result.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < result.GetLength(1); j++)
                {
                    result[i, j] = Convert.ToDouble(_dataGridView[j - 1, i].Value);
                }
            }
        }
    }
}
