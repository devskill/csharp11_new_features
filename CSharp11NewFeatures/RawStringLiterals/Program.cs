string longMessage = """
    This is a long message.
    It has several lines.
        Some are indented
                more than others.
    Some should start at the first column.
    Some have "quoted text" in them.
    """;

Console.WriteLine(longMessage);

var Longitude = 34.933835;
var Latitude = 93.373838;

Console.WriteLine();

var location = $$"""
   You are at {{{Longitude}}, {{Latitude}}}
   """;

Console.WriteLine(location);