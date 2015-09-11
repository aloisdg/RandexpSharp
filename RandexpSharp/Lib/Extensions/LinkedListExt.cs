using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandexpSharp.Lib.Extensions
{
	public class LinkedListExt<T> : LinkedList<T>
	{
		public new T RemoveFirst()
		{
			var first = this.First();
			base.RemoveFirst();
			return first;
		}

		public new T RemoveLast()
		{
			var last = this.Last();
			base.RemoveLast();
			return last;
		}

		public int IndexOf<T>(T item)
		{
			var count = 0;
			for (var node = this.First; node != null; node = node.Next, count++)
			{
				if (item.Equals(node.Value))
					return count;
			}
			return -1;
		}
	}
}
