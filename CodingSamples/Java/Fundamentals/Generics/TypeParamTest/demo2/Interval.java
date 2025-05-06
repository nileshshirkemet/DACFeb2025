class Interval implements Comparable<Interval> {
    
    private int min;
    private int sec;

    public Interval(int m, int s) {
        min = m + s / 60;
        sec = s % 60;
    }

    public int minutes() {
        return min;
    }

    public int seconds() {
        return sec;
    }

    public int time() {
        return 60 * min + sec;
    }

    public Interval add(Interval other) {
        return new Interval(min + other.min, sec + other.sec);
    }

    //overriding toString() method of java.lang.Object to return
    //a string containing values of fields within the instance
    public String toString() {
        if(sec < 10)
            return min + ":0" + sec;
        return min + ":" + sec;
    }

    //overriding hashCode() method of java.lang.Object to return
    //an integer so that same integer is returned for two instances
    //with matching values of instance fields
    public int hashCode() {
        return min + sec;
    }

    public boolean equals(Object other) {
        if(other instanceof Interval){
            Interval that = (Interval) other; //explicit down-casting
            return min == that.min && sec == that.sec; 
        }
        return false;
    }

    public int compareTo(Interval that) {
        return this.time() - that.time();
    }
}
