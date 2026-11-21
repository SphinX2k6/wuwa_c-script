using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000B2 RID: 178
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ReferenceResolver
	{
		// Token: 0x060009EB RID: 2539
		public abstract void AddReference(string referenceId, object value);

		// Token: 0x060009EC RID: 2540
		public abstract string GetReference(object value, out bool alreadyExists);

		// Token: 0x060009ED RID: 2541
		public abstract object ResolveReference(string referenceId);

		// Token: 0x060009EE RID: 2542 RVA: 0x000235D5 File Offset: 0x000217D5
		internal virtual void PopReferenceForCycleDetection()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000235D5 File Offset: 0x000217D5
		internal virtual void PushReferenceForCycleDetection(object value)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000235D5 File Offset: 0x000217D5
		internal virtual bool ContainsReferenceForCycleDetection(object value)
		{
			throw new InvalidOperationException();
		}
	}
}
