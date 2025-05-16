package app.components;

public class GreeterBean {
    
    private String person;

    private String period;

    private int greetings;

    public final String getPerson() {
        return person;
    }

    public final void setPerson(String value) {
        person = value;
    }

    public final String getPeriod() {
        return period;
    }

    public final void setPeriod(String value) {
        period = value;
    }

    public synchronized String getGreetingMessage() {
        if(person == null)
            return "Welcome Visitor";
        ++greetings;
        return String.format("Good %s %s", period, person);
    }

    public int getGreetCount() {
        return greetings;
    }
}
