using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200009F RID: 159
	public class UE
	{
		// Token: 0x06000C66 RID: 3174 RVA: 0x000140EC File Offset: 0x000122EC
		[NullableContext(1)]
		public static T NewObject<[Nullable(0)] T>(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) where T : UnrealUObject, IUnrealUObject
		{
			return BuiltinUtils.CreateUObjectByNativePointer_Internal(BuiltinUtils.AllocNativeUObject(IUnrealUObject.StaticClass().NativePtr, Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags)) as T;
		}
	}
}
