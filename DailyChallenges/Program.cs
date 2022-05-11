using DailyChallenges;

ChallengeRepository _repo = new ChallengeRepository();


// 05

int[] intArr = { 10, 12, 112, 14, 13, 18, 11, 19, 1 };

int sum = _repo.Sum(intArr);

decimal average = _repo.Average(intArr);

decimal averageWithOutOutliers = _repo.Average(intArr, 20, 9);

Console.WriteLine("SUM: " + sum);
Console.WriteLine("AVERAGE: " + average);
Console.WriteLine("AVERAGE WITHOUT OUTLIERS: " + averageWithOutOutliers);


// 06

List<float> listOfMiles = new List<float>() { 3.56f, 6.890f, 12.7548f, 0.234f };

_repo.ConvertFromMilesToKm(listOfMiles);



// 07

_repo.GetUserChoiceAndPrintReaction();