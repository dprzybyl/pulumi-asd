import * as pulumi from "@pulumi/pulumi";
import * as asd from "@pulumi/asd";

const myRandomResource = new asd.Random("myRandomResource", {length: 24});
export const output = {
    value: myRandomResource.result,
};
