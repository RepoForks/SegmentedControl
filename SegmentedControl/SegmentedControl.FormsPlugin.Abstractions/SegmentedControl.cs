﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SegmentedControl.FormsPlugin.Abstractions
{
    /// <summary>
    /// SegmentedControl Interface
    /// </summary>
    public class SegmentedControl : View, IViewContainer<SegmentedControlOption>
	{
		public IList<SegmentedControlOption> Children { get; set; }

		public SegmentedControl()
		{
			Children = new List<SegmentedControlOption>();
		}

		public static readonly BindableProperty TintColorProperty = BindableProperty.Create("TintColor", typeof(Color), typeof(SegmentedControl), Color.Blue);

		public Color TintColor
		{
			get { return (Color)GetValue(TintColorProperty); }
			set { SetValue(TintColorProperty, value); }
		}

		public static readonly BindableProperty SelectedTextColorProperty = BindableProperty.Create("SelectedTextColor", typeof(Color), typeof(SegmentedControl), Color.White);

		public Color SelectedTextColor
		{
			get { return (Color)GetValue(SelectedTextColorProperty); }
			set { SetValue(SelectedTextColorProperty, value); }
		}

		public static readonly BindableProperty SelectedSegmentProperty = BindableProperty.Create("SelectedSegment", typeof(int), typeof(SegmentedControl), 0);

		public int SelectedSegment
		{
			get { 
				return (int)GetValue(SelectedSegmentProperty); 
			}
			set { 
				SetValue(SelectedSegmentProperty, value);
			}
		}

        public EventHandler ValueChanged;
		//public event ValueChangedEventHandler ValueChanged;
		//public delegate void ValueChangedEventHandler(object sender, EventArgs e);
    }

	public class SegmentedControlOption : View
	{
		public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(SegmentedControlOption), string.Empty);

		public string Text
		{
			get { return (string)GetValue(TextProperty); }
			set { SetValue(TextProperty, value); }
		}
	}
}
