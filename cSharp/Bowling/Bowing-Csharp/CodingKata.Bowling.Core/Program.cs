// See https://aka.ms/new-console-template for more information
/// If the player scores a spare knocking down all pins
/// in two turns this will total based on the 2rd turn from the player.
/// ----------------------------------------------------------------
/// exmaple: you if score a spare in the first frame, say an 6 and a 4,
/// then got an 8 and a 1 in the second frame, you would score 18 (6+4+8)
/// for the first frame, and 9 for the second frame, making a total of 27 after two frames.
/// ----------------------------------------------------------------
/// If a X in scored then the next turn will be added to total score as a bonus as well.

using CodingKata.Bowling.Core;

// var game = new Game();
// game.GameInit();
// Console.WriteLine($"Total: {Game.GameInit()}");

var list = new List<int>();
var num = 10;
list.Add(num);

list.Insert(0, 29 + num);

Console.WriteLine(list[0]);
// TODO: Might need to use this type of list insertion instead