using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Marshal
{
	// Token: 0x020008BC RID: 2236
	internal interface IPropertyMarshallingProcessor<[Nullable(2)] T>
	{
		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x0600BE79 RID: 48761
		int Size { get; }

		// Token: 0x0600BE7A RID: 48762
		public unsafe abstract static void Write(byte* buffer, ref int offset, [Nullable(1)] in T value);

		// Token: 0x0600BE7B RID: 48763
		[return: Nullable(2)]
		public unsafe abstract static T Read(byte* buffer, ref int offset);
	}
}
