
    1. How long did you spend on the coding test? What would you add to your solution if you had more time?
       If you didn't spend much time on the coding test then use this as an opportunity to explain what you would add.
    
    Total time spent was about 4 hours, if more time was allotted, I would:
      - Add validation on outcode to prevent incorrect input
      - Abstract the REST API into its own interface so it could be replaced with another REST implementation if required
      - Provide a concrete return value instead of "object" on API calls so that they can be properly tested
      - Refactor jQuery table population after receiving JSON data to increase readability
    
    2. What was the most useful feature that was added to the latest version of your chosen language? 
       Please include a snippet of code that shows how you've used it.
    
    The RestSharp NuGet package allowed for a clean implementation of the REST API with minimal setup required:
    
        var client = new RestClient(restUrl);
        var request = new RestRequest(requestUrl, Method.GET);
        foreach(RestParameters param in parameters)
        {
            request.AddParameter(param.ParameterName, param.ParameterValue);
        }
        
        var response = client.Execute(request) as RestResponse;
    
    3. How would you track down a performance issue in an application? Have you ever had to do this?
    
    We use Nlog to track activity on our current applications, code that becomes an area of concern typically manifests
    through error messages or long periods of inactivity in the log table. One of our applications had an inermittent error
    that was occurring more frequently as time passed due to an increased number of clients on the system. Logging helped 
    to identify this trend and allow us to address the issue.
    
    4. How would you improve the JUST EAT APIs that you just used?
    
    Provide documentation for the methods available for use documenting purpose, parameters and call scenarios. 
    E.g. 
    Resource: /restaurants
    Type: GET
    Description: Retrieves list of restaurants based on outcode parameter
    Parameters: "q"
    Response Errors: 400, 401, 404, 415, 500
    
    5. Please describe yourself using JSON.
    
    {
      Raymond: {
        age: 23,
        occupation: "Junior Software Engineer",
        interests: ["Games", "Cycling", "Badminton", "Fitness", "Technology"],
        skills: ["ASP.NET MVC", "Javascript", "SQL", "TDD"],
        bio: "An avid gamer with a great thirst for knowledge, Raymond aims to solve problems and keep things simple and maintainable. " +
          "He is always on the lookout for the latest and greatest technologies he can apply to his own solutions and is not a half bad " +
          "chef either!"
      }
    }
