/*
  CPSC 450
  Final Project
  Tyler C
*/

using ScottPlot;
using System.Diagnostics;
using static Algorithms.Algorithms;

GenerateLargeN();
GenerateSmallN();


TimeSpan TimeTask(Action action) {
  var stopwatch = new Stopwatch();
  stopwatch.Start();
  action();
  stopwatch.Stop();
  return stopwatch.Elapsed;
}


void GenerateSmallN() {
  List<int> counts = new();
  for (int i = 0; i<1000; i += 100) {
    counts.Add(i);
  }

  List<double> eratosthenesTimes = new();
  List<double> atkinTimes = new();
  foreach (int count in counts) {
    Console.WriteLine("Getting Primes To: " + count);
    var time = TimeTask(() => SieveOfEratosthenes(count));
    eratosthenesTimes.Add(time.TotalMilliseconds);

    time = TimeTask(() => SieveOfAtkin(count));
    atkinTimes.Add(time.TotalMilliseconds);
  }

  Plot plot = new();
  var eLine = plot.Add.Scatter(counts, eratosthenesTimes);
  eLine.LegendText = "Eratosthenes";
  var aLine = plot.Add.Scatter(counts, atkinTimes);
  aLine.LegendText = "Atkin";
  plot.ShowLegend();
  plot.Axes.Bottom.Label.Text = "Generated Primes To";
  plot.Axes.Left.Label.Text = "Time (ms)";
  plot.SavePng("times-small.png", 400, 300);
}

void GenerateLargeN() {
  List<int> counts = new();
  for (int i = 0; i<1000000; i += 100000) {
    counts.Add(i);
  }

  List<double> eratosthenesTimes = new();
  List<double> atkinTimes = new();
  foreach (int count in counts) {
    Console.WriteLine("Getting Primes To: " + count);
    var time = TimeTask(() => SieveOfEratosthenes(count));
    eratosthenesTimes.Add(time.TotalMilliseconds);

    time = TimeTask(() => SieveOfAtkin(count));
    atkinTimes.Add(time.TotalMilliseconds);
  }

  Plot plot = new();
  var eLine = plot.Add.Scatter(counts, eratosthenesTimes);
  eLine.LegendText = "Eratosthenes";
  var aLine = plot.Add.Scatter(counts, atkinTimes);
  aLine.LegendText = "Atkin";
  plot.ShowLegend();
  plot.Axes.Bottom.Label.Text = "Generated Primes To";
  plot.Axes.Left.Label.Text = "Time (ms)";
  plot.SavePng("times-large.png", 400, 300);
}
