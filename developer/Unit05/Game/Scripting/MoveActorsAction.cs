using System.Collections.Generic;
using Unit05.Game.Casting;


namespace Unit05.Game.Scripting
{
    // TODO: Implement the MoveActorsAction class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Action class.

    /// <summary>
    /// <para>An update action that moves all the actors.</para>
    /// <para>
    /// The responsibility of MoveActorsAction is to move all the actors.
    /// </para>
    /// </summary>
    public class MoveActorsAction : Action
    {
        // 2) Add the constructor. Use the following constructor comment. Make sure you
        //    call the base constructor.

        /// <summary>
        /// Creates a new move actors action.
        /// </summary>
        public MoveActorsAction(): base()
        {
        }

        // 3) Add the Execute method. Use the following method comment. Make sure you
        //    override the base class method.

        /// <summary>
        /// Moves all the actors.
        /// </summary>
        /// <param name="cast">The cast to update.</param>
        /// <param name="stage">The stage to update.</param>
        public override void Execute(Cast cast, Stage stage)
        {
            // 4) Add the following local variables:
            //    - actors: a list of actors
            //    - actor: an actor

            List<Actor> actors;
            Actor actor;

            // 5) Get the list of actors from the cast. Use the following code:
            //    actors = cast.GetActors();

            actors = cast.GetActors();

            // 6) Use a foreach loop to iterate through the actors. Use the following code:
            //    foreach (actor in actors)
            //    {

            foreach (Actor a in actors)
            {
                actor = a;
                actor.Move();
            }
        }
    }
}