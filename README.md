# ProjectPRG272Final1

## Group Details
* **Project Name:** Baobab Ridge Wildlife Rehabilitation Records System
* **Module Code:** PRG272
* **Group Registration Number:** Group 5

### Group Members:
* **Louwrens Jacobs 603964 
* **Sizwe Malinga 600595
* **Resegofetsoe Mokwena 601666
* **Samantha Ndlovu 603492

  ## How to Build and Run the Program
1. Ensure you have **Visual Studio 2022** installed with the **.NET Desktop Development** workload.
2. Clone this repository onto your local machine using the command:
   ```bash
   git clone [Insert Your GitHub Repository URL Here]
   ```
3. Open the folder and launch the solution file: `ProjectPRG272Final1.slnx` (or your `.sln` file).
4. Verify that the starter dataset file `animals.txt` is visible in your Solution Explorer under the project root folder.
5. In Visual Studio, click **Build > Build Solution** to restore dependencies.
6. Press **F5** or click the **Start/Debug** button to run the Windows Forms application.

## Application Features Implemented
* **Feature 1 - Add a New Animal:** Enforces strict validation rules (ID formatting, Name/Species length constraints, Age/Score numeric ranges) and calculates Status/Housing metrics automatically.
* **Feature 2 - View All Animals:** Loads records directly from the flat text storage and renders valid entries inside a read-only DataGridView on system initialization. Handles malformed lines gracefully.
* **Feature 3 - Update an Animal:** Loads a chosen entity via grid selection or strict ID search parameter execution, allows modification of tracking fields, and recalculates dependent health brackets.
* **Feature 4 - Delete an Animal:** Prompts the user with a mandatory confirmation popup before executing permanent row deletion tracking.
* **Feature 5 - Summary Report:** Generates live counts, calculates total age/score metric evaluations to two decimal places under invariant configurations, and writes output files.\

  ## File Structure and Formats

### 1. `animals.txt`
* **Location:** Stored directly inside the compiled binary execution folder (`bin/Debug/` or alongside the `.exe`).
* **Format:** Flat UTF-8 plain text file without header elements. Fields are parsed on a single-line string sequence broken by a pipe separator (`|`) constraint in this exact index layout:
  `ID|Name|Species|Age|Score|Status|Housing Unit`
* **Example Entry:**
  `WR-0002|Pop|Meercat|1|30|Serious|High-Dependacy Ward`

### 2. `summary.txt`
* **Location:** Overwritten locally alongside the system execution paths every time a manager triggers calculation features.
* **Format:** Structured textual summary layout containing a localized standard timestamp tracking sequence (`yyyy-MM-dd HH:mm`) and metric indicators.
* **Example Entry:**
  ```text
  BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE
  ANIMAL SUMMARY REPORT
  Generated: 2026-10-20 22:55
  ----------------------------------------
  Total animals: 3
  Average age (years): 4.33
  Average recovery score: 56.67
  ----------------------------------------
  Animals per status:
   Critical: 0
   Serious: 1
   Stable: 1
   Recovering: 0
   Release-Ready: 1
  ```

  ## ⚠️ Known Limitations
  * Possible data mix up if not properly entered. Problem with Update if age and recovery score is are the same.
