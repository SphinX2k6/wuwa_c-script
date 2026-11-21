using System;
using System.Collections.Generic;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000AC RID: 172
	internal sealed class PreserveReferenceResolver : ReferenceResolver
	{
		// Token: 0x060009D5 RID: 2517 RVA: 0x0002A496 File Offset: 0x00028696
		public PreserveReferenceResolver(bool writing)
		{
			if (writing)
			{
				this._objectToReferenceIdMap = new Dictionary<object, string>(ReferenceEqualityComparer.Instance);
				return;
			}
			this._referenceIdToObjectMap = new Dictionary<string, object>();
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0002A4BD File Offset: 0x000286BD
		public override void AddReference(string referenceId, object value)
		{
			if (!this._referenceIdToObjectMap.TryAdd(referenceId, value))
			{
				ThrowHelper.ThrowJsonException_MetadataDuplicateIdFound(referenceId);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0002A4D4 File Offset: 0x000286D4
		public override string GetReference(object value, out bool alreadyExists)
		{
			string text;
			if (this._objectToReferenceIdMap.TryGetValue(value, out text))
			{
				alreadyExists = true;
			}
			else
			{
				this._referenceCount += 1U;
				text = this._referenceCount.ToString();
				this._objectToReferenceIdMap.Add(value, text);
				alreadyExists = false;
			}
			return text;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0002A524 File Offset: 0x00028724
		public override object ResolveReference(string referenceId)
		{
			object result;
			if (!this._referenceIdToObjectMap.TryGetValue(referenceId, out result))
			{
				ThrowHelper.ThrowJsonException_MetadataReferenceNotFound(referenceId);
			}
			return result;
		}

		// Token: 0x040002B5 RID: 693
		private uint _referenceCount;

		// Token: 0x040002B6 RID: 694
		private readonly Dictionary<string, object> _referenceIdToObjectMap;

		// Token: 0x040002B7 RID: 695
		private readonly Dictionary<object, string> _objectToReferenceIdMap;
	}
}
