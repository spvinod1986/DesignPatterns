namespace ChainOfResponsibility
{
    // Abstract base class for all the rules
    public abstract class Rule
    {
        // Reference to next rule to be executed in the chain
        private Rule next;

        public Rule(Rule next)
        {
            this.next = next;
        }

        // Defines a template for rule execution
        public bool ExecuteRule(UserRequest request)
        {
            // If any rule fails then exits to the caller
            if (!RunRule(request))
                return false;

            // If current rule execution succeeds then recursively 
            // execute the template for next rule 
            if (next != null)
                next.ExecuteRule(request);

            return true;
        }

        // Abstract method to be implemented by all concrete rules
        public abstract bool RunRule(UserRequest request);
    }
}