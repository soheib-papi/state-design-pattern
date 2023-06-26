
using state_design_pattern.state;

var canvas = new Canvas();
canvas.SetCurrentTool(new EraserTool());
canvas.MouseDown();
canvas.MouseUp();

Console.ReadLine();