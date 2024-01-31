import pulumi
import pulumi_xyz as asd

my_random_resource = asd.Random("myRandomResource", length=24)
pulumi.export("output", {
    "value": my_random_resource.result,
})
