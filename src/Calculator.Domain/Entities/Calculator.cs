using Calculadora.Domain.Entities.Operations;

namespace Calculadora.Domain.Entities;

public sealed class Calculator
{
    private Tuple<Operation, decimal>[] OperationHistory { get; set; }

    public Calculator()
    {
        OperationHistory = new Tuple<Operation, decimal>[3];
    }

    private void AddOperationOnHistory(Operation operation, decimal result)
    {
        var currentIndex = OperationHistory.Length - 1;

        if (OperationHistory[currentIndex] != null)
        {
            for (int i = 0; i < OperationHistory.Length - 1; i++)
            {
                OperationHistory[i] = OperationHistory[i + 1];
            }
        }

        OperationHistory[currentIndex] = new Tuple<Operation, decimal>(operation, result);
    }

    public Tuple<Operation, decimal>[] GetOperationHistory()
    {
        return OperationHistory;
    }

    public decimal Execute(Operation operation)
    {
        var result = operation.Result();

        AddOperationOnHistory(operation, result);

        return result;
    }
}
