using Godot;

namespace Embers;

public partial class ClickerExample : Container
{
    private int _score;

    private Label _scoreLabel;
    private Button _clickButton;

    public override void _Ready()
    {
        _scoreLabel = GetNode<Label>("ScoreLabel");
        _clickButton = GetNode<Button>("ClickButton");
        _clickButton.Pressed += OnButtonPressed;
    }

    private void OnButtonPressed()
    {
        _score++;
        _scoreLabel.Text = $"Score: {_score}";
    }
}