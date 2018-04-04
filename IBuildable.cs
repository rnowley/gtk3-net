namespace gtk3_net
{
    public interface IBuildable
    {
        /// <summary>
        /// Sets the name of the buildable object.
        /// </summary>
        /// <param name="name">The value to set the name to.</param>
        void SetName(string name);

        /// <summary>
        /// Gets the name of the buildable object. 
        /// </summary>
        /// <returns>The name set by <see cref="SetName"/></returns>
        string GetName();

        /// <summary>
        /// Adds a child to buildable. type is an optional string describing how the child should be added.
        /// </summary>
        /// <param name="builder">A UIBuilder object</param>
        /// <param name="childToAdd">The child that we want to add toi the Buildable object.</param>
        /// <param name="type">The kind of child or null.</param>
        void AddChild(UIBuilder builder, Widget childToAdd, string type);

        void SetBuildableProperty(UIBuilder builder, string name, object value);
    }
}