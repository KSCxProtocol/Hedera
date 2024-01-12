namespace Kar.Web3.Hedera;

public static class HederaDbProperties
{
    public static string DbTablePrefix { get; set; } = "Hedera";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Hedera";
}
