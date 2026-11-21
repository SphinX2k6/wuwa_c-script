using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Interface
{
	// Token: 0x020008C8 RID: 2248
	public interface IUnrealScriptStructProxy : IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600BEA2 RID: 48802
		[NullableContext(1)]
		public abstract static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer);

		// Token: 0x0600BEA3 RID: 48803
		[NullableContext(1)]
		public abstract static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner);
	}
}
