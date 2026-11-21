using System;
using System.Collections.Generic;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000092 RID: 146
	internal sealed class IgnoreReferenceResolver : ReferenceResolver
	{
		// Token: 0x060008FB RID: 2299 RVA: 0x00028175 File Offset: 0x00026375
		internal override void PopReferenceForCycleDetection()
		{
			this._stackForCycleDetection.Pop();
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00028183 File Offset: 0x00026383
		internal override bool ContainsReferenceForCycleDetection(object value)
		{
			Stack<ReferenceEqualsWrapper> stackForCycleDetection = this._stackForCycleDetection;
			return stackForCycleDetection != null && stackForCycleDetection.Contains(new ReferenceEqualsWrapper(value));
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0002819C File Offset: 0x0002639C
		internal override void PushReferenceForCycleDetection(object value)
		{
			ReferenceEqualsWrapper item = new ReferenceEqualsWrapper(value);
			if (this._stackForCycleDetection == null)
			{
				this._stackForCycleDetection = new Stack<ReferenceEqualsWrapper>();
			}
			this._stackForCycleDetection.Push(item);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000235D5 File Offset: 0x000217D5
		public override void AddReference(string referenceId, object value)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000235D5 File Offset: 0x000217D5
		public override string GetReference(object value, out bool alreadyExists)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000235D5 File Offset: 0x000217D5
		public override object ResolveReference(string referenceId)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x04000296 RID: 662
		private Stack<ReferenceEqualsWrapper> _stackForCycleDetection;
	}
}
