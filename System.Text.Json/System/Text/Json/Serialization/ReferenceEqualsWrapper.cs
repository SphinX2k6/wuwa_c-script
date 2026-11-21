using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization
{
	// Token: 0x0200009A RID: 154
	internal readonly struct ReferenceEqualsWrapper : IEquatable<ReferenceEqualsWrapper>
	{
		// Token: 0x06000910 RID: 2320 RVA: 0x00028344 File Offset: 0x00026544
		public ReferenceEqualsWrapper(object obj)
		{
			this._object = obj;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00028350 File Offset: 0x00026550
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is ReferenceEqualsWrapper)
			{
				ReferenceEqualsWrapper obj2 = (ReferenceEqualsWrapper)obj;
				return this.Equals(obj2);
			}
			return false;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00028375 File Offset: 0x00026575
		public bool Equals(ReferenceEqualsWrapper obj)
		{
			return this._object == obj._object;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00028385 File Offset: 0x00026585
		public override int GetHashCode()
		{
			return RuntimeHelpers.GetHashCode(this._object);
		}

		// Token: 0x0400029C RID: 668
		private readonly object _object;
	}
}
