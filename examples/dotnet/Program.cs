using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Asd = Pulumi.Asd;

return await Deployment.RunAsync(() => 
{
    var myRandomResource = new Asd.Random("myRandomResource", new()
    {
        Length = 24,
    });

    return new Dictionary<string, object?>
    {
        ["output"] = 
        {
            { "value", myRandomResource.Result },
        },
    };
});

