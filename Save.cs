using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class Save
{

    //Accessible levels will be the first elt of each theme's list
    //If the length of the list is greater than 0
    public List<Level> levels;

    public Save()
    {
        var level0 = new Level("Level0_0");
        var level1_1 = new Level("Level1_1");
        var level1_2 = new Level("Level1_2");
        var level1_3 = new Level("Level1_3");
        var level2_1 = new Level("Level2_1");
        var level2_2 = new Level("Level2_2");

        level0.setLevelStatus(1);

        level0.nextLevels = new Level[]{ level1_1, level2_1 };

        level1_1.prerequisites = new Level[]{ level0 };
        level1_1.nextLevels = new Level[]{ level1_2};

        level1_2.prerequisites = new Level[] { level1_1 };
        level1_2.nextLevels = new Level[] { level1_3 };

        level1_3.prerequisites = new Level[] { level1_2 };
        level1_3.nextLevels = new Level[] { };

        level2_1.prerequisites = new Level[] { level0 };
        level2_1.nextLevels = new Level[] { level2_2 };

        level2_2.prerequisites = new Level[] { level2_1 };
        level2_2.nextLevels = new Level[] { };

        this.levels = new List<Level> { level0, level1_1, level1_2, level1_3, level2_1, level2_2 };
    }

    public Save(SaveData data)
    {

        levels = new List<Level>();
        (string, string, string[], string[])[] saveData = data.getData();

        foreach ((string id, string status, _ , _) in saveData)
        {
            levels.Add(new Level(id, status));
        }

        foreach((string id, _ , string[] prerequisites, string[] nextLevelstr) in saveData)
        {
            Level targetLevel = getLevelById(id);
            Level[] prereqLevels = new Level[prerequisites.Length];
            for(int i =0; i < prerequisites.Length; i++)
            {
                prereqLevels[i] = getLevelById(prerequisites[i]);
            }
            targetLevel.prerequisites = prereqLevels;

            Level[] nextLevels = new Level[nextLevelstr.Length];
            for(int i = 0; i < nextLevelstr.Length; i++)
            {
                nextLevels[i] = getLevelById(nextLevelstr[i]);
            }
            targetLevel.nextLevels = nextLevels;
        }
    }

    public Level getLevelById(string id)
    {
        foreach(Level lev in levels)
        {
            if (lev.identifier.Equals(id))
            {
                return lev;
            }
        }
        return null;
    }

    public SaveData GenerateSaveData()
    {
        (string, string, string[], string[])[] saveData = new (string, string, string[], string[])[levels.Count];
        for (int i = 0; i < levels.Count; i++)
        {
            Level l = levels[i];
            saveData[i] = (
                l.identifier,
                l.levelStatus,
                l.prerequisites.Select(x => x.ToString()).ToArray(),
                l.nextLevels.Select(x => x.ToString()).ToArray()
                );
        }
        return new SaveData(saveData);
    }
}

[Serializable]
public class SaveData
{
    (string, string, string[], string[])[] saveInfo;

    public SaveData((string, string, string[], string[])[] data)
    {
        saveInfo = data;
    }

    public (string, string, string[], string[])[] getData()
    {
        return saveInfo;
    }
}

public class Level
{
    public Level[] prerequisites;
    public Level[] nextLevels;
    public string identifier;
    public string levelStatus;

    public Level(string identifier)
    {
        this.identifier = identifier;
        this.levelStatus = MapSelectionObjectScript.LevelStatus.unavailable;
        this.prerequisites = new Level[0];
        this.nextLevels = new Level[0];
    }

    public Level(string identifier, string status)
    {
        this.identifier = identifier;
        this.levelStatus = status;
        this.prerequisites = new Level[0];
        this.nextLevels = new Level[0];
    }

    public void setLevelStatus(int status)
    {
        switch (status)
        {
            case 0:
                levelStatus = MapSelectionObjectScript.LevelStatus.unavailable;
                break;
            case 1:
                if (levelStatus.Equals(MapSelectionObjectScript.LevelStatus.completed))
                {
                    break;
                }
                foreach(Level level in prerequisites)
                {
                    if (!level.levelStatus.Equals(MapSelectionObjectScript.LevelStatus.completed))
                    {
                        break;
                    }
                }
                levelStatus = MapSelectionObjectScript.LevelStatus.available;
                break;
            case 2:
                levelStatus = MapSelectionObjectScript.LevelStatus.completed;
                foreach(Level level in nextLevels)
                {
                    level.setLevelStatus(1);
                }
                break;
            default:
                throw new System.Exception("invalid status id: " + status);
        }
    }

    public override string ToString()
    {
        return identifier;
    }
}
