' Title: Hangman
' Author: Timothy Revans
' Desccription: A console application to generate a game of hangman for the user to play against, used to experiment with GitHub.

Module Program

    Sub Main(args As String())

        ' used as an infinite loop to make the game replayable
        While True

            ' initial variable declarations
            Dim incorrectGuessesMade As Integer = 0
            Dim wordToGuess As String = getWord()
            Dim letterGuessed As Char
            Dim incorrectGuesses(25) As Char

            ' set the full letterGuessed to a number of "-" equal to the length of the array
            Dim fullGuess As Char() = wordToGuess.ToCharArray

            For i As Integer = 0 To fullGuess.Length - 1

                fullGuess(i) = "-"

            Next

            ' a loop to continue until the game as finished
            Do

                ' a loop to continue until a valid letterGuessed has been made
                Do

                    PrintUI(fullGuess, incorrectGuesses, incorrectGuessesMade)
                    Console.Write("Please enter your letterGuessed: ")
                    letterGuessed = Console.ReadLine().ToLower

                Loop While ArrayContains(incorrectGuesses, letterGuessed) OrElse ArrayContains(fullGuess, letterGuessed)

                ' check whether the wordToGuess contains the letterGuessed
                Dim containsLetter As Boolean = False

                For i As Integer = 0 To wordToGuess.Length - 1

                    If wordToGuess(i) = letterGuessed Then

                        containsLetter = True
                        fullGuess(i) = letterGuessed

                    End If

                Next

                ' store letterGuessed as incorrect if it is not contained in the wordToGuess
                If containsLetter = False Then

                    incorrectGuesses(incorrectGuessesMade) = letterGuessed
                    incorrectGuessesMade += 1

                End If

            Loop Until fullGuess = wordToGuess Or incorrectGuessesMade = 10

            PrintUI(fullGuess, incorrectGuesses, incorrectGuessesMade)

            ' print out winning and losing
            If fullGuess = wordToGuess Then

                Console.WriteLine("Congratulations! You win!")

            Else

                Console.WriteLine("You Lose!")
                Console.WriteLine("")
                Console.WriteLine("The correct answer is " & wordToGuess & ".")

            End If

            Console.WriteLine("Press any button to continue...")
            Console.ReadKey()
            Console.Clear()

        End While

    End Sub

    ' a subroutine to print out the UI to make code neater and avoid repetition
    Sub PrintUI(ByVal fullGuess() As Char, ByVal incorrectGuesses() As Char, incorrectGuessesMade As Integer)

        Console.Clear()

        Select Case incorrectGuessesMade
            Case 0
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
            Case 1
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("    _|___")
            Case 2
                Console.WriteLine("")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("    _|___")
            Case 3
                Console.WriteLine("      _______")
                Console.WriteLine("     |/")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("    _|___")
            Case 4
                Console.WriteLine("      _______")
                Console.WriteLine("     |/      |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("    _|___")
            Case 5
                Console.WriteLine("      _______")
                Console.WriteLine("     |/      |")
                Console.WriteLine("     |      (_)")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("    _|___")
            Case 6
                Console.WriteLine("      _______")
                Console.WriteLine("     |/      |")
                Console.WriteLine("     |      (_)")
                Console.WriteLine("     |       |")
                Console.WriteLine("     |       |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("    _|___")
            Case 7
                Console.WriteLine("      _______")
                Console.WriteLine("     |/      |")
                Console.WriteLine("     |      (_)")
                Console.WriteLine("     |      \|")
                Console.WriteLine("     |       |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("    _|___")
            Case 8
                Console.WriteLine("      _______")
                Console.WriteLine("     |/      |")
                Console.WriteLine("     |      (_)")
                Console.WriteLine("     |      \|/")
                Console.WriteLine("     |       |")
                Console.WriteLine("     |")
                Console.WriteLine("     |")
                Console.WriteLine("    _|___")
            Case 9
                Console.WriteLine("      _______")
                Console.WriteLine("     |/      |")
                Console.WriteLine("     |      (_)")
                Console.WriteLine("     |      \|/")
                Console.WriteLine("     |       |")
                Console.WriteLine("     |      / ")
                Console.WriteLine("     |")
                Console.WriteLine("    _|___")
            Case 10
                Console.WriteLine("      _______")
                Console.WriteLine("     |/      |")
                Console.WriteLine("     |      (_)")
                Console.WriteLine("     |      \|/")
                Console.WriteLine("     |       |")
                Console.WriteLine("     |      / \")
                Console.WriteLine("     |")
                Console.WriteLine("    _|___")
        End Select

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine(fullGuess)
        Console.WriteLine()
        Console.WriteLine("Letters Guessed:")

        For Each letter In incorrectGuesses

            Console.Write(letter)
            Console.Write(" ")

        Next

        Console.WriteLine()
        Console.WriteLine()

    End Sub

    ' a function to check if the array passed to it contains a specified character
    Function ArrayContains(ByVal arr() As Char, ByVal check As Char) As Boolean

        For Each item In arr

            If item = check Then

                Return True

            End If

        Next

        Return False

    End Function

    ' a function to return a randomized wordToGuess from a list of ~200
    Function getWord() As String

        Dim words() As String = {
            "abruptly",
            "absurd",
            "abyss",
            "affix",
            "askew",
            "avenue",
            "awkward",
            "axiom",
            "azure",
            "bagpipes",
            "bandwagon",
            "banjo",
            "bayou",
            "beekeeper",
            "bikini",
            "blitz",
            "blizzard",
            "boggle",
            "bookworm",
            "boxcar",
            "boxful",
            "buckaroo",
            "buffalo",
            "buffoon",
            "buxom",
            "buzzard",
            "buzzing",
            "buzzwords",
            "caliph",
            "cobweb",
            "cockiness",
            "croquet",
            "crypt",
            "curacao",
            "cycle",
            "daiquiri",
            "dirndl",
            "disavow",
            "dizzying",
            "duplex",
            "dwarves",
            "embezzle",
            "equip",
            "espionage",
            "euouae",
            "exodus",
            "faking",
            "fishhook",
            "fixable",
            "fjord",
            "flapjack",
            "flopping",
            "fluffiness",
            "flyby",
            "foxglove",
            "frazzled",
            "frizzled",
            "fuchsia",
            "funny",
            "gabby",
            "galaxy",
            "galvanize",
            "gazebo",
            "giaour",
            "gizmo",
            "glowworm",
            "glyph",
            "gnarly",
            "gnostic",
            "gossip",
            "grogginess",
            "haiku",
            "haphazard",
            "hyphen",
            "iatrogenic",
            "icebox",
            "injury",
            "ivory",
            "ivy",
            "jackpot",
            "jaundice",
            "jawbreaker",
            "jaywalk",
            "jazziest",
            "jazzy",
            "jelly",
            "jigsaw",
            "jinx",
            "jiujitsu",
            "jockey",
            "jogging",
            "joking",
            "jovial",
            "joyful",
            "juicy",
            "jukebox",
            "jumbo",
            "kayak",
            "kazoo",
            "keyhole",
            "khaki",
            "kilobyte",
            "kiosk",
            "kitsch",
            "kiwifruit",
            "klutz",
            "knapsack",
            "larynx",
            "lengths",
            "lucky",
            "luxury",
            "lymph",
            "marquis",
            "matrix",
            "megahertz",
            "microwave",
            "mnemonic",
            "mystify",
            "naphtha",
            "nightclub",
            "nowadays",
            "numbskull",
            "nymph",
            "onyx",
            "ovary",
            "oxidize",
            "oxygen",
            "pajama",
            "peekaboo",
            "phlegm",
            "pixel",
            "pizazz",
            "pneumonia",
            "polka",
            "pshaw",
            "psyche",
            "puppy",
            "puzzling",
            "quartz",
            "queue",
            "quips",
            "quixotic",
            "quiz",
            "quizzes",
            "quorum",
            "razzmatazz",
            "rhubarb",
            "rhythm",
            "rickshaw",
            "schnapps",
            "scratch",
            "shiv",
            "snazzy",
            "sphinx",
            "spritz",
            "squawk",
            "staff",
            "strength",
            "strengths",
            "stretch",
            "stronghold",
            "stymied",
            "subway",
            "swivel",
            "syndrome",
            "thriftless",
            "thumbscrew",
            "topaz",
            "transcript",
            "transgress",
            "transplant",
            "triphthong",
            "twelfth",
            "twelfths",
            "unknown",
            "unworthy",
            "unzip",
            "uptown",
            "vaporize",
            "vixen",
            "vodka",
            "voodoo",
            "vortex",
            "voyeurism",
            "walkway",
            "waltz",
            "wave",
            "wavy",
            "waxy",
            "wellspring",
            "wheezy",
            "whiskey",
            "whizzing",
            "whomever",
            "wimpy",
            "witchcraft",
            "wizard",
            "woozy",
            "wristwatch",
            "wyvern",
            "xylophone",
            "yachtsman",
            "yippee",
            "yoked",
            "youthful",
            "yummy",
            "zephyr",
            "zigzag",
            "zigzagging",
            "zilch",
            "zipper",
            "zodiac",
            "zombie"
        }

        Randomize()
        Dim rand As Integer = Math.Floor((Rnd()) * (words.Length))

        Return words(rand)

    End Function

End Module
