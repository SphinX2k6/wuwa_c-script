using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C79 RID: 7289
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeGlobalData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class URopeGlobalData : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C48D RID: 115853 RVA: 0x0029B367 File Offset: 0x00299567
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URopeGlobalData._ClassPtr;
		}

		// Token: 0x0601C48E RID: 115854 RVA: 0x0029B374 File Offset: 0x00299574
		public URopeGlobalData() : this(BuiltinUtils.AllocNativeUObject(URopeGlobalData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C48F RID: 115855 RVA: 0x0029B39C File Offset: 0x0029959C
		[NullableContext(1)]
		public URopeGlobalData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URopeGlobalData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C490 RID: 115856
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHarquebusEndPosition(in FVector InPosition);

		// Token: 0x0601C491 RID: 115857
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetHarquebusEndPosition();

		// Token: 0x0601C492 RID: 115858 RVA: 0x0029B3CF File Offset: 0x002995CF
		static URopeGlobalData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeGlobalData");
		}

		// Token: 0x0601C493 RID: 115859 RVA: 0x0029B3DD File Offset: 0x002995DD
		protected URopeGlobalData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F35B RID: 62299
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeGlobalData";

		// Token: 0x0400F35C RID: 62300
		private static IntPtr _ClassPtr;

		// Token: 0x0400F35D RID: 62301
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
