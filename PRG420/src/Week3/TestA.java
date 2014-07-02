package Week33;

//TestA class has default access and the private class method is accessible to all other parts of the same class.
public class TestA {
    public void methodPublic(){
        methodPrivate();
    }
    
    protected void methodProtected(){
        methodPrivate();
    }
    
    void methodDefault(){
        methodPrivate();
    }
    
    private void methodPrivate(){}
}
