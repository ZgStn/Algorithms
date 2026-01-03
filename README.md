# Lab 1 – Finding Numbers in a String (C# Console Application)

**This was my first lab assignment in the program**, completed about one month after I started my programming studies.  

---

## Assignment Overview

This console application reads a text string from the user and searches it for specific numeric substrings that meet defined criteria.  
Each valid number found is highlighted in color in the console output, and all valid numbers are summed and printed at the end.

---

## Problem Description

The program should:

1. Ask the user to enter a text string.
2. Search the string for all substrings that are valid numbers according to the rules below.
3. For each valid substring:
   - Print the **entire original string**
   - Highlight the matching substring using a different console color (`Console.ForegroundColor`)
4. Add together all valid numbers found and print the total at the end of the program.

---

## Rules for a Valid Number

A substring is considered a valid number if:

- It consists of **digits only**
- It **starts and ends with the same digit**
- The starting/ending digit **must not appear anywhere inside** the number
- No letters or other non-digit characters are allowed

### Examples

| Substring | Valid | Reason |
|----------|-------|--------|
| `3463`   | ✅ Yes | Starts and ends with `3`, no other `3` inside |
| `34363`  | ❌ No  | Contains an extra `3` inside |
| `95a9`   | ❌ No  | Contains a letter |

![Example output](Exempel output for input.jpg)




