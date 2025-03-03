import { readReadme } from "./readme_reader";
import { promises as fs } from "fs";
import { join } from "path";

test("readReadme should return file content", async () => {
    const tempPath = join(__dirname, "temp_README.md");
    await fs.writeFile(tempPath, "Sample README content");

    const content = await readReadme(tempPath);
    expect(content).toBe("Sample README content");

    await fs.unlink(tempPath);
});

test("readReadme should throw error if file not found", async () => {
    await expect(readReadme("non_existent.md")).rejects.toThrow("README.md not found.");
});
