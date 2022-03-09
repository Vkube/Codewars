import { test, expect } from "@jest/globals";
import { toBinary } from "../tobinary";

test("toBinary", () => {
  expect(toBinary(1)).toEqual(1);
  // expect(toBinary(2).toEqual(10));
});
