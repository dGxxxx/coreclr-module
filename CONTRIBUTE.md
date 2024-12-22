# How to Contribute

## Implementing [cpp-sdk](https://github.com/altmp/cpp-sdk) Changes

To implement a new `cpp-sdk` change or add a missing implementation, follow these steps:

1. **Create a New Branch**  
   - Start by creating a new branch based on the [dev](https://github.com/altmp/coreclr-module/tree/dev) branch.
   - In the submodule `runtime`, create another branch also based on the [dev](https://github.com/altmp/coreclr-module-runtime/tree/dev) branch.

2. **Update the cpp-sdk Version**  
   - If required, update the `cpp-sdk` version in the `runtime` branch.

3. **Add the cpp-sdk Method**  
   - Add the new `cpp-sdk` method to the appropriate classes.  
     For example, to implement [IPlayer.GetSocialClubId()](https://github.com/altmp/cpp-sdk/blob/30b5e35ab7081f7e8ff7ac2bc0568aa7cf38e6be/objects/IPlayer.h#L90C20-L90C31), update the following runtime classes:
     - [player.h](https://github.com/altmp/coreclr-module-runtime/blob/dev/c-api/entities/player.h)
     - [player.cpp](https://github.com/altmp/coreclr-module-runtime/blob/dev/c-api/entities/player.cpp)

4. **Run the CApi Generator**  
   - Run the [CApi Generator](https://github.com/altmp/coreclr-module/blob/dev/api/AltV.Net.CApi.Generator/Program.cs) with the `runtime/c-api` folder as the working directory.

5. **Push Changes**  
   - Push all changes to the `runtime` branch.

6. **Implement the Method in the C# Module**  
   - Use the `runtime` branch to implement the method within the C# module.  
     For the example above, add the `SocialClubId` as a getter to the `IPlayer` interface.

7. **Add the Getter Implementation**  
   - Implement the getter in the `Player` class to invoke the unsafe runtime call `Core.Library.*`.

8. **Extend the AsyncPlayer Class**  
   - Add the method to the `AsyncPlayer` class, ensuring it calls the parent method from the `Player` class.

9. **Push Changes**  
   - Push all changes to the `module` branch.

10. **Submit Pull Requests**  
   - Create separate pull requests for both the `module` branch and the `runtime` branch.
