# Menu Permissions Project

## Introduction
Senior Developer technical assessment from Chillisoft.
The instructions for this assessment can be found in `instructions/Instructions.MD`

## Setup Instructions
### Requirements
1. Windows
2. dotnet (can install from [here](http://dotnet.microsoft.com/download) - 9.0 recommended)

### Run
The self contained executable is found in the root directory of the repo. To run it use:
```
./menupermissions <PathToUserInputFile> <PathToMenuInputFile>
```

Example:
```
./menupermissions users.txt menus.txt
```

To write the output to an output file:
```
./menupermissions users.txt menus.txt > output.json
```

### Acknowledgements
I was instructed to use as little AI as possible, and so I did. I was told maximum ratio of 60/40 % AI is tolerated. I only used some Copilot prompts - asking advice for the best setup for easiest submission and receipt on Chillisoft side, and IDE autocomplete for speed while coding, so 0% AI code, 100% my **own code**.

### Versioning
I have voluntarily used git, from good habit, as it's a great version tracking and history tool. It is also the industry standard.

## Final Comments
I just wanted to say thank you Chillisoft for this assessment and for considering me. I apologize I had to rush it to a degree, the week I had to do it in was filled with exams, UIF applications (and other urgent admin), other interviews, applications and assessments.

### Future Considerations
More time on this could result in:
- More error handling - for an improved user experience.
- Extended tests - better safeguard in more scenarios.
- Logging - verbosity and debugging purposes.
