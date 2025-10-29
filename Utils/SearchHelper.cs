using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellUp.Utils
{
    public static class SearchHelper
    {
        public static bool PerformSearch(DataGridView productsDataGridView, string searchText)
        {
            if (string.IsNullOrEmpty(searchText) || productsDataGridView == null)
            {
                MessageBox.Show("Please enter a valid search term.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool anyProductFound = false;

            foreach (DataGridViewRow row in productsDataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;

                string idValue = row.Cells["Id"].Value?.ToString() ?? string.Empty;
                string nameValue = row.Cells["Name"].Value?.ToString() ?? string.Empty;
                string typeValue = row.Cells["Type"].Value?.ToString() ?? string.Empty;

                bool isNumberSearch = int.TryParse(searchText, out int searchNumber);

                // Step 1: First, search for an exact match in "Id" (priority search)
                if (isNumberSearch && idValue.Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    anyProductFound = true;
                }
                // Step 2: Search "Type" if it matches the search text
                else if (typeValue.Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    anyProductFound = true;
                }
                // Step 3: Always search "Name" if it starts with the search text (for string searches)
                else if (nameValue.StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    anyProductFound = true;
                }
            }

            return anyProductFound;
        }
    }
}
