import { promises as fs, existsSync } from 'fs';
import { join } from 'path';

export async function readReadme(filePath: string = "../../README.md"): Promise<string> {
    if (!existsSync(filePath)) {
        throw new Error("README.md not found.");
    }
    return fs.readFile(filePath, 'utf-8');
}

if (require.main === module) {
    readReadme()
        .then(content => console.log(content))
        .catch(error => console.error(error.message));
}
