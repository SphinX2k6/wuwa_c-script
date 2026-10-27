using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000BA RID: 186
	public class UE
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x000193C8 File Offset: 0x000175C8
		[NullableContext(1)]
		public static T NewObject<[Nullable(0)] T>(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) where T : UnrealUObject, IUnrealUObject
		{
			return BuiltinUtils.CreateUObjectByNativePointer_Internal(BuiltinUtils.AllocNativeUObject(IUnrealUObject.StaticClass().NativePtr, Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags)) as T;
		}
	}
}
