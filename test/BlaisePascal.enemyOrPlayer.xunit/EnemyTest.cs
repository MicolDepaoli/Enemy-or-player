using blaisePascal.EnemyOrPlayer.Domain;

namespace BlaisePascal.enemyOrPlayer.xunit
{
    public class EnemyTest
    {
        [Fact]
        public void Player_ShouldStartAtLvevelOne()
        {
            Player player=new Player("Mario");


            Assert.Equal(1, player.Level);

        }
    }
}
