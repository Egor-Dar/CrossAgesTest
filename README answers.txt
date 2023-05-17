VCS

1.What is a VCS?

VCS (Version Control System) is a software tool used by developers to manage source code changes over time. It helps keep track of changes made to code, keeps a history of those changes, and allows developers to collaborate on code. Also, in case of errors in the code, it provides the ability to edit (cancel / add) corrections.

2.Why is it important to use a VSC?

It is important to use a VCS because it provides several benefits such as version control, backup, and collaboration. With version control, you can easily track changes made to your code over time, view who made the changes, and when. It also provides backup and recovery options in case of accidental changes or data loss. Finally, VCS makes it easier to collaborate on code by allowing multiple developers to work on the same codebase without conflicts.

3.What VCS are you usually using?

Git is the VCS that I usually use. It is widely adopted and has become the industry standard for version control.

4.What workflow would you have in a team of 5 programmers?

In a team of 5 programmers, I would recommend using a Git workflow such as Gitflow or GitHub flow. This workflow allows for collaboration while ensuring that changes are thoroughly reviewed and tested before being merged into the main branch.

5.For the rest, we will assume Git as our VCS. How can you avoid merge commits and keep a linear history?

To avoid merge commits and keep a linear history, you can use a rebase instead of a merge. This involves incorporating changes from one branch into another by reapplying each commit in the order they were originally made, effectively creating a linear history.

6.Why is it important to have a linear history and in what case are you allowed to break it (and thus having merge commit)?

It is important to have a linear history because it provides a clear and concise view of the changes made to code over time. Breaking the linear history with merge commits can make it more difficult to trace the evolution of the codebase. However, in some cases, merge commits are necessary such as when merging two branches that have diverged significantly.

7.What is cherry-picking?

Cherry-picking is a Git command that allows you to apply a specific commit from one branch to another. It is useful when you only want to apply a specific change without merging the entire branch.

8.What is a rebase? What is the difference between a rebase between two branches and a pull-rebase?

A rebase is a Git command that allows you to move the entire branch to a new base commit. This is useful when you want to incorporate changes from another branch into your own branch. The difference between a rebase between two branches and a pull-rebase is that a pull-rebase combines the "fetch" and "rebase" commands into one step.

9.What is a force push? When should you use it or not? What are the consequences?

A force push is a Git command that allows you to overwrite remote changes with your local changes. It should be used with caution as it can cause data loss if not done properly. It is recommended to only use force push in certain situations, such as when fixing a mistake in a recent commit that has not been pushed to the remote repository yet.

10.What is LF and CRLF? What should you use and why?

LF (line feed) and CRLF (carriage return line feed) are different ways of representing line breaks in text files. LF is used in Unix-based systems while CRLF is used in Windows-based systems. When working with Git, it is recommended to use LF line endings as it is the default for Git.

11.What characters (including case) are you recommending in your naming convention?

Naming conventions recommend using lowercase letters, hyphens, or underscores to separate words, as well as descriptive names that reflect the purpose of the code. Avoid using spaces or special characters that can cause problems with Git or other tools. But as a UNITY programmer, I use a slightly different rule, Serialized variables are always the first in my script, names start with a small letter and each subsequent word with a capital one. then there are public variables whose names begin with a capital letter. and then there are private variables whose names begin with an underscore.


Miscellaneous

1.How do you manage your credentials?

It's important to keep credentials secure and not commit them to source control. One way to do this is to use environment variables or a configuration file that is excluded from source control. I typically use a combination of environment variables and a configuration file that is read at runtime.

2.Do you use environment variables and why?

Yes, I use environment variables because they allow me to keep sensitive information (like API keys and passwords) separate from my codebase and easily manage them across different environments (e.g. local development, staging, production).

3.How do you make sure your project is small enough to be deployed on stores and light enough to work on low end devices?

I use optimization techniques such as reducing texture sizes, using lower-poly models, minimizing draw calls, and using platform-specific optimizations. I also use profiling tools to identify performance bottlenecks and optimize them.

4.What is MVC? How would you implement it in your Unity Project?

MVC stands for Model-View-Controller, a software design pattern commonly used in creating user interfaces. In a Unity project, the model will be the game data and state, the view will be the UI and graphics, and the controller will handle user input and update the model and view accordingly. One way to implement MVC in a Unity project is to use the Unity UI system for the view, C# scripts for the model and controller, and events or delegates to communicate between them. I was working on a project where I needed to use MBC because it was an application where I needed to interact with a server. I needed to create an application where game designers, sound designers, animators and level designers (arrangement of triggers, spawners and points indicating the number of characters and their location). The task of View is to display the necessary data and also to be able to receive data for transfer to the Model for further formation of the JSON and sending it to the Controller in order to put the document on the server.

5.What is dependency injection? Did you already used it and how?

Dependency injection is a design pattern that helps manage dependencies between components in a software system. It involves creating and injecting objects or components that are required by other objects or components, rather than having those objects or components create them themselves. I have used dependency injection in various projects, including Unity projects, to make components more modular and testable. One way to implement dependency injection in a Unity project is to use a dependency injection container such as Zenject.

6.What is Linq? Do you use it?

LINQ (Language-Integrated Query) is a feature of C# that allows for querying and manipulating data from different sources, including collections, arrays, and databases. I have used LINQ extensively in C# projects for filtering, sorting, and transforming data. In your Algorithm test I also used LINQ.
 
7.What is the difference between a graph and a tree?

A graph is a collection of nodes (vertices) and edges (connections) between them, while a tree is a specific type of graph with a hierarchical structure and no cycles. In a tree, there is only one path between any two nodes, while in a graph there can be multiple paths between nodes.

8.What video games do you play?

Counter-Strike, Doom Eternal, Clash Royale, Red Alert 2, Warzone 2100, Ori and Blind the Forest, Ori and the Will of the Wisps, V-Rising.

9.Did you already contributed to open source projects or community projects (including 3rd party software around video games)? If yes, which ones?

No, I have not contributed to projects with correct source code.