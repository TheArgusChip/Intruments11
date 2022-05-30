namespace Intruments11.Model
{
    internal class Information
    {
        private Simplex _simplex;

        public Information(DataGridView dataGridView)
        {
            var creator = new MatrixCreator(dataGridView);
            _simplex = new Simplex(creator.Result);
        }

        public string PInfo => CalculateDescription(_simplex.Coeffs);

        public string QInfo => CalculateDescription(_simplex.Result);

        private string CalculateDescription(double[] array)
        {
            return $"({string.Join(' ', array.Select(element => Math.Round(element, 3)))}, {Math.Round(_simplex.GamePrice, 3)})";
        }
    }
}
