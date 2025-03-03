import os

def read_readme(filepath="../../README.md"):
    """Reads the README.md file and returns its content."""
    if not os.path.exists(filepath):
        raise FileNotFoundError("README.md not found.")
    
    with open(filepath, "r", encoding="utf-8") as file:
        return file.read()

if __name__ == "__main__":
    print(read_readme())
