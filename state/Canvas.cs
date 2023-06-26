namespace state_design_pattern.state;
public class Canvas
{
    private ITool _currentTool;

    public ITool GetCurrentTool() => _currentTool;

    public void SetCurrentTool(ITool tool) => _currentTool = tool;

    public void MouseDown()
    {
        _currentTool.MouseDown();
    }

    public void MouseUp()
    {
        _currentTool.MouseUp();
    }
}
