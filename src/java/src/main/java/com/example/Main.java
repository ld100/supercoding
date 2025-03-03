package com.example;

public class Main {
    public static void main(String[] args) {
        try {
            String content = ReadmeReader.readReadme("../../README.md");
            System.out.println(content);
        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
}
