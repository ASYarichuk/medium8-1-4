class Player
{
    private string _name;
    private int _age;
}

class Mover
{
    private float _directionX;
    private float _directionY;
    private float _speed;

    public void Move()
    {
        
    }
}

class Weapon
{
    private float _cooldown;
    private int _damage;

    public void Attack()
    {
        
    }

    public bool IsReloading()
    {
        throw new NotImplementedException();
    }
}