' Title: Hangman
' Author: Timothy Revans
' Desccription: A console application to generate a game of hangman for the user to play against, used to experiment with GitHub.
Module Program
    Sub Main(args As String())

        Dim word As String
        Dim guess As Char

        While True

            Dim i As Integer = 0

            word = getWord()

            Dim fullGuess As Char() = word.ToCharArray
            Dim incorrectGuesses(25) As Char

            For j As Integer = 0 To fullGuess.Length - 1

                fullGuess(j) = "-"

            Next

            Do

                Do

                    printUI(fullGuess, incorrectGuesses, i)

                    Console.Write("Please enter your guess: ")
                    guess = Console.ReadLine().ToLower

                Loop While arrayContains(incorrectGuesses, guess) OrElse arrayContains(fullGuess, guess)

                Dim contain As Boolean = False

                For j As Integer = 0 To word.Length - 1

                    If word(j) = guess Then

                        contain = True
                        fullGuess(j) = guess

                    End If

                Next

                If contain = False Then

                    incorrectGuesses(i) = guess
                    i += 1

                End If

            Loop Until fullGuess = word Or i = 10

            printUI(fullGuess, incorrectGuesses, i)

            If fullGuess = word Then

                Console.WriteLine("Congratulations! You win!")

            Else

                Console.WriteLine("You Lose!")
                Console.WriteLine("")
                Console.WriteLine("The correct answer is " & word & ".")
                Console.WriteLine("The correct answer is " & word & ".")

            End If

            Console.WriteLine("Press any button to continue...")
            Console.ReadKey()

            Console.Clear()

        End While

    End Sub

    Sub printUI(ByVal fullGuess() As Char, ByVal incorrectGuesses() As Char, i As Integer)

        Console.Clear()
        printMan(i)
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine(fullGuess)
        Console.WriteLine()
        Console.WriteLine("Letters Guessed:")
        printArray(incorrectGuesses)
        Console.WriteLine()
        Console.WriteLine()

    End Sub

    Sub printMan(ByVal num)

        Select Case num
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

    End Sub

    Sub printArray(ByVal arr() As Char)

        For Each letter In arr

            Console.Write(letter)
            Console.Write(" ")

        Next

    End Sub

    Function arrayContains(ByVal arr() As Char, ByVal check As Char) As Boolean

        For Each item In arr

            If item = check Then

                Return True

            End If

        Next

        Return False

    End Function

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
