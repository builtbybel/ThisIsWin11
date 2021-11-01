using System;
using System.Collections.Generic;
using System.ComponentModel;

internal class PluginsBindingList<T> : BindingList<T>
{
    private PropertyDescriptor sortProperty;
    private ListSortDirection sortDirection;
    private bool isSorted = false;

    protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
    {
        ((List<T>)Items).Sort(new Comparison<T>((T x, T y) => ((IComparable)property.GetValue(x)).CompareTo(property.GetValue(y)) * (direction == ListSortDirection.Ascending ? -1 : 1)));

        sortProperty = property;
        sortDirection = direction;
        isSorted = true;
    }

    protected override void RemoveSortCore()
    {
        sortProperty = null;
        sortDirection = ListSortDirection.Ascending;
        isSorted = false;
    }

    protected override bool SupportsSortingCore => true;

    protected override ListSortDirection SortDirectionCore => sortDirection;

    protected override PropertyDescriptor SortPropertyCore => sortProperty;

    protected override bool IsSortedCore => isSorted;
}