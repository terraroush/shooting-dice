namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            int otherRoll = other.Roll();
            int myRoll = otherRoll + 1;

            DeclareWinner(this, myRoll, other, otherRoll);
        }
    }
}