using ReadSecretsConsole;

var secretAppsettingReader = new SecretAppsettingReader();

var secretValues = secretAppsettingReader.ReadSection<SecretValues>("MySecretValues");

Console.WriteLine($"The user name is: {secretValues.Username}, and the password is: {secretValues.Password}");

Console.ReadKey();