package main

import (
	"errors"
	"fmt"
	"os"
)

func ReadReadme(filepath string) (string, error) {
	if _, err := os.Stat(filepath); errors.Is(err, os.ErrNotExist) {
		return "", errors.New("README.md not found")
	}

	content, err := os.ReadFile(filepath)
	if err != nil {
		return "", fmt.Errorf("error reading file: %w", err)
	}

	return string(content), nil
}

func main() {
	content, err := ReadReadme("../../README.md")
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(content)
}
