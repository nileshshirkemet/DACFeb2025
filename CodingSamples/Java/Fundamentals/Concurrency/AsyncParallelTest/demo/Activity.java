class Activity {

    public static long perform(int value) {
        long count = value;
        try{
            Thread.sleep(100 * value);
        }catch(InterruptedException e){}
        return count * value;
    }
}