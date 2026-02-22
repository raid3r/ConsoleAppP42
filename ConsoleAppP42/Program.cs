
using ConsoleAppP42.LogsExample;
using ConsoleAppP42.Serialization;
using log4net.Config;
using NLog;
using Serilog;


Logger logger = LogManager.GetCurrentClassLogger();

/*
 * Додайте в свій проєкт 
 *  Serilog
    Serilog.Sinks.Console
    Serilog.Sinks.File
Сконфігуруйте Serilog для логування в консоль та файл 
Додате інформацію про результати операцій в коді
які дані були, результа перетворень
 * 
 */


// Serilog
//Log.Logger = new LoggerConfiguration()
//    .MinimumLevel.Debug()
//    .WriteTo.Console(
//    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug,
//    outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}"
//    )
//    .WriteTo.File(
//        path: "log_.log", // Шаблон імені файлу з підстановкою дати
//        rollingInterval: RollingInterval.Day, // Щоденне створення нового файлу
//        retainedFileCountLimit: 7, // Зберігати лише останні 7 файлів
//        fileSizeLimitBytes: 10 * 1024 * 1024, // Максимальний розмір файлу 10 МБ
//        outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}",
//        restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug
//    )
//    .CreateLogger();

// log4net
//XmlConfigurator.Configure(new FileInfo("log4net.config"));
//var log4netLogger = log4net.LogManager.GetLogger(typeof(Program));


var random = new Random();

var arraySize = 20;

var randomNumbers = Enumerable.Range(0, arraySize)
    .Select(_ => random.Next(0, 100))
    .ToList();

// Логувати згенеровані випадкові числа
logger.Info($"Згенеровані випадкові числа: {string.Join(", ", randomNumbers)}");
//AppLogger.Info($"Згенеровані випадкові числа: {string.Join(", ", randomNumbers)}");

//Console.WriteLine("Згенеровані випадкові числа:");
//Console.WriteLine(string.Join(", ", randomNumbers));

// 1. Парні числа

var evenNumbers = randomNumbers.Where(n => n % 2 == 0).ToList();
//Console.WriteLine("\nПарні числа:");
//Console.WriteLine(string.Join(", ", evenNumbers));

// Логувати кількість парних чисел
logger.Info($"Кількість парних чисел: {evenNumbers.Count}");
// Логувати самі парні числа
logger.Info($"Парні числа: {string.Join(", ", evenNumbers)}");

var bar = new Bar();
bar.Foo();
bar.DoSomething();


logger.Error("Це повідомлення про помилку {code}: {error}");

var student = new Student { Id = 1, Name = "John Doe", Age = 20, AverageGrade = 3.5, Group = new StudentGroup { Id = 1, Name = "PV42" } };

logger.Info("Створено студента: {@Student}");

// Рівні повідомлень логування
// - DEBUG - для детальної інформації, яка може бути корисною для розробників під час налагодження.
// - INFO - для загальної інформації про роботу програми, яка може бути корисною для моніторингу та аналізу.
// - WARNING - для повідомлень про потенційні проблеми або незвичайні ситуації, які не є критичними, але можуть вимагати уваги.
// - ERROR - для повідомлень про помилки, які виникли під час виконання програми і можуть впливати на її роботу.
// - CRITICAL - для повідомлень про серйозні помилки, які можуть призвести до збоїв або втрати даних.



