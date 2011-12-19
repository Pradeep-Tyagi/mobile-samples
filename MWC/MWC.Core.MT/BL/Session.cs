using System;
using System.Collections.Generic;

namespace MWC.BL
{
	public class Session : Contracts.BusinessEntityBase
	{
		public string Title { get; set; }
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
		public string Overview { get; set; }
		public IList<string> Speakers
		{
			get { return this.speakers; }
			set { this.speakers = value; }
		}
		protected IList<string> speakers = new List<string>();
		
		public Session ()
		{
		}
	}
}

