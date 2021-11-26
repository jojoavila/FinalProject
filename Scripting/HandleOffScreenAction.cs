using System;
using System.Collections.Generic;
using FinalProject.Casting;
using FinalProject.Scripting;

namespace FinalProject.Scripting
{
    /// <summary>
    /// An action, so the ball bounces off the walls and ceiling.
    /// It also erases balls that go under the bottom of the window.
    /// </summary>
    public class HandleOffScreenAction : Action
    {
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            throw new NotImplementedException();
        }
    }
}