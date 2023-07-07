# ASP.NET MVC Single Page Application

This repository contains an ASP.NET MVC application that consists of a single page, `Index`, which displays a view model named `IndexViewModel`.
The application displays the following information to the user:

1. `CurrentDate`: This would be the current date at the time of viewing the application. The format of the date will be dependent on the localization settings of the application.

2. `WeightOfMoon`: This would represent the weight of the Moon. The exact meaning and representation of this value may depend on the context in which the application is being used. The unit and value would be determined by the underlying logic of the application.

3. `LengthOfFootballField`: This would indicate the length of a football field. Again, the unit (e.g., meters, yards) would be determined by the application's logic and could vary based on the localization settings.

4. `CapacityOfGlass`: This would be the capacity of a glass. The value and unit (e.g., milliliters, fluid ounces) would be determined by the application's logic and could vary based on the localization settings.

5. `YourLuckyNumber`: This would display a number that's presumably "lucky" for the user. The generation of this number would be determined by the application's logic. This could be a random number or could be generated based on user's input or some other parameters.

## Localization

This application supports localization and includes resources for the following cultures:

- English (United States) - `en-US`
- Ukrainian (Ukraine) - `uk-UA`
- French (France) - `fr-FR`

The route pattern provided implies that the culture is specified as the first segment in the URL. The default culture is `en-US`, but you can change the culture by specifying it explicitly in the URL. 

Here are examples of how to change the locale in the application:

1. To change the locale to Ukrainian (Ukraine), you would use the following URL:

   ```
   http://localhost:5000/uk-UA/Home/Index
   ```

2. To change the locale to French (France), you would use the following URL:

   ```
   http://localhost:5000/fr-FR/Home/Index
   ```

Remember to replace `localhost:5000` with your actual server address and port. The part `Home/Index` specifies that you want to access the `Index` action of the `Home` controller.

## Setup

1. Clone the repository to your local machine.
   ```
   git clone https://github.com/username/repository.git
   ```
2. Navigate to the project directory.
   ```
   cd repository
   ```
3. Restore the NuGet packages.
   ```
   dotnet restore
   ```
4. Build the application.
   ```
   dotnet build
   ```
5. Run the application.
   ```
   dotnet run
   ```

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License

Please see the `LICENSE.md` file for details.