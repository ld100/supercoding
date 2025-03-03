import { readReadme } from "./readme_reader";

async function main() {
  try {
    const content = await readReadme();
    console.log(content);
  } catch (error) {
    if (error instanceof Error) {
      console.error(error.message);
    } else {
      console.error("An unknown error occurred.");
    }
  }
}

main();
