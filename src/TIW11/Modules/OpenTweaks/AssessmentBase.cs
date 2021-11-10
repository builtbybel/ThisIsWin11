namespace ThisIsWin11.OpenTweaks.Assessment
{
    public abstract class AssessmentBase
    {
        /// <summary>
        /// Name of Assessment
        /// </summary>
        /// <returns>The asssessment name</returns>
        public abstract string ID();

        /// <summary>
        /// Tooltip text of sssessments
        /// </summary>
        /// <returns>The asssessment tooltip</returns>
        public abstract string Info();

        /// <summary>
        /// Checks whether assessments should be applied
        /// </summary>
        /// <returns>Returns true if the asssessment should be applied, false otherwise.</returns>
        public abstract bool CheckAssessment();

        /// <summary>
        /// Applies the Assessment
        /// </summary>
        /// <returns>Returns true if the asssessment was successfull, false otherwise.</returns>
        public abstract bool DoAssessment();

        /// <summary>
        /// Revert the Assessment
        /// </summary>
        /// <returns>Returns true if the asssessment was successfull, false otherwise.</returns>
        public abstract bool UndoAssessment();
    }
}