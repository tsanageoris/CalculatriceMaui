namespace CalculatriceMaui;

public partial class MainPage : ContentPage
{
    private string currentValue = "0";
    private string firstNumber = "";
    private string currentOperator = "";
    private bool isNewNumber = true;
    private bool hasError = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnNumberClicked(object? sender, EventArgs e)
    {
        if (hasError)
        {
            ResetCalculator();
        }

        if (sender is not Button button)
            return;

        string number = button.Text;

        if (isNewNumber)
        {
            currentValue = number;
            isNewNumber = false;
        }
        else
        {
            if (currentValue == "0")
            {
                currentValue = number;
            }
            else
            {
                currentValue += number;
            }
        }

        UpdateDisplay();
    }

    private void OnDecimalClicked(object? sender, EventArgs e)
    {
        if (hasError)
        {
            ResetCalculator();
        }

        if (isNewNumber)
        {
            currentValue = "0.";
            isNewNumber = false;
        }
        else
        {
            if (!currentValue.Contains("."))
            {
                currentValue += ".";
            }
        }

        UpdateDisplay();
    }

    private void OnOperatorClicked(object? sender, EventArgs e)
    {
        if (hasError)
        {
            ResetCalculator();
            return;
        }

        if (sender is not Button button)
            return;

        string operatorSymbol = button.Text;

        if (!string.IsNullOrEmpty(currentOperator) && !isNewNumber)
        {
            CalculateResult();
        }

        firstNumber = currentValue;
        currentOperator = operatorSymbol;
        isNewNumber = true;

        UpdateDisplay();
    }

    private void OnEqualsClicked(object? sender, EventArgs e)
    {
        if (hasError)
        {
            ResetCalculator();
            return;
        }

        if (!string.IsNullOrEmpty(currentOperator) && !string.IsNullOrEmpty(firstNumber))
        {
            CalculateResult();
            currentOperator = "";
            firstNumber = "";
            isNewNumber = true;
        }
    }

    private void OnClearClicked(object? sender, EventArgs e)
    {
        ResetCalculator();
    }

    private void OnBackspaceClicked(object? sender, EventArgs e)
    {
        if (hasError)
        {
            ResetCalculator();
            return;
        }

        if (currentValue.Length > 1)
        {
            currentValue = currentValue.Substring(0, currentValue.Length - 1);
        }
        else
        {
            currentValue = "0";
            isNewNumber = true;
        }

        UpdateDisplay();
    }

    private void OnToggleSignClicked(object? sender, EventArgs e)
    {
        if (hasError)
        {
            ResetCalculator();
            return;
        }

        if (currentValue != "0")
        {
            if (currentValue.StartsWith("-"))
            {
                currentValue = currentValue.Substring(1);
            }
            else
            {
                currentValue = "-" + currentValue;
            }
        }

        UpdateDisplay();
    }

    private void OnPercentClicked(object? sender, EventArgs e)
    {
        if (hasError)
        {
            ResetCalculator();
            return;
        }

        try
        {
            double value = double.Parse(currentValue);
            value = value / 100;
            currentValue = value.ToString();
            isNewNumber = true;
            UpdateDisplay();
        }
        catch
        {
            ShowError();
        }
    }

    private void CalculateResult()
    {
        try
        {
            double first = double.Parse(firstNumber);
            double second = double.Parse(currentValue);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = first + second;
                    break;
                case "−":
                    result = first - second;
                    break;
                case "×":
                    result = first * second;
                    break;
                case "÷":
                    if (second == 0)
                    {
                        ShowError();
                        return;
                    }
                    result = first / second;
                    break;
            }

            currentValue = result.ToString();
            UpdateDisplay();
        }
        catch
        {
            ShowError();
        }
    }

    private void UpdateDisplay()
    {
        ResultLabel.Text = currentValue;

        if (!string.IsNullOrEmpty(currentOperator) && !string.IsNullOrEmpty(firstNumber))
        {
            OperationLabel.Text = $"{firstNumber} {currentOperator}";
        }
        else
        {
            OperationLabel.Text = "";
        }
    }

    private void ResetCalculator()
    {
        currentValue = "0";
        firstNumber = "";
        currentOperator = "";
        isNewNumber = true;
        hasError = false;
        UpdateDisplay();
    }

    private void ShowError()
    {
        hasError = true;
        currentValue = "Erreur";
        OperationLabel.Text = "Division impossible";
        UpdateDisplay();
    }
}
