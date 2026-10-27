using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Interface
{
	// Token: 0x02002B18 RID: 11032
	public interface IUnrealScriptStructProxy : IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060284E8 RID: 165096
		[NullableContext(1)]
		public abstract static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer);

		// Token: 0x060284E9 RID: 165097
		[NullableContext(1)]
		public abstract static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner);
	}
}
