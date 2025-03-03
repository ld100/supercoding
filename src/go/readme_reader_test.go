package main

import (
	"os"
	"testing"
)

func TestReadReadme(t *testing.T) {
	tempFile, err := os.CreateTemp("../", "README.md")
	if err != nil {
		t.Fatalf("Failed to create temp file: %v", err)
	}
	defer os.Remove(tempFile.Name())

	expectedContent := "Sample README content"
	if _, err := tempFile.WriteString(expectedContent); err != nil {
		t.Fatalf("Failed to write to temp file: %v", err)
	}
	tempFile.Close()

	content, err := ReadReadme(tempFile.Name())
	if err != nil {
		t.Fatalf("Expected no error, got %v", err)
	}

	if content != expectedContent {
		t.Errorf("Expected %s, got %s", expectedContent, content)
	}
}

func TestReadmeNotFound(t *testing.T) {
	_, err := ReadReadme("non_existent.md")
	if err == nil {
		t.Fatal("Expected an error but got nil")
	}
}
