// Ruslan Georgiev
// Canvas id: aj0701


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class FoodSchedule
    {
        List<string> foodDescriptionList;

        /// <summary>
        /// Initializes a new instance of the FoodSchedule class.
        /// </summary>
        public FoodSchedule()
        {
            foodDescriptionList = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the FoodSchedule class.
        /// </summary>
        public FoodSchedule(List<string> foodList)
        {
            if (foodList != null)
            {
                this.foodDescriptionList = foodList;
            }
        }

        /// <summary>
        /// Gets the number of elements inside the foodDescriptionList.
        /// </summary>
        int Count
        {
            get { return foodDescriptionList.Count; }
        }

        /// <summary>
        /// Checks if an index is within a valid range in relation to the
        /// number of elements inside the foodDescriptionList.
        /// </summary>
        private bool IsValidIndex(int index)
        {
            if ((index >= 0) || (index < foodDescriptionList.Count))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Adds food schedule item to the food description list.
        /// </summary>
        public bool AddFoodScheduleItem(string foodScheduleItem)
        {
            if (!string.IsNullOrEmpty(foodScheduleItem.Trim()))
            {
                foodDescriptionList.Add(foodScheduleItem);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Changes a food schedule item at a specific index.
        /// </summary>
        public bool ChangeFoodScheduleItem(int index, string foodScheduleItem)
        {
            if (IsValidIndex(index) || (!string.IsNullOrEmpty(foodScheduleItem.Trim())))
            {
                foodDescriptionList[index] = foodScheduleItem;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Removes a food schedule item at a specific index.
        /// </summary>
        public bool DeleteFoodScheduleItem(int index)
        {
            if (IsValidIndex(index))
            {
                foodDescriptionList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        // TODO: I don't know what is this method supposed to do.
        public string DescribeNoFeedingRequired()
        {
            string text = "";
            return text;
            
        }

        // TODO: I don't know what is this method supposed to do.
        public string GetFoodSchedule()
        {
            string text = "";
            return text;
        }

        /// <summary>
        /// Returns a string that represents the FoodSchedule object.
        /// </summary>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string item in foodDescriptionList)
            {
                stringBuilder.Append(item);
                stringBuilder.Append(Environment.NewLine);
            }
            return stringBuilder.ToString();

        }




    }
}
