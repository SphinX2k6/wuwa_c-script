using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014B7 RID: 5303
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterString")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UHoudiniAssetParameterString : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013335 RID: 78645 RVA: 0x001C3E46 File Offset: 0x001C2046
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterString._ClassPtr;
		}

		// Token: 0x06013336 RID: 78646 RVA: 0x001C3E54 File Offset: 0x001C2054
		public UHoudiniAssetParameterString() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterString.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013337 RID: 78647 RVA: 0x001C3E7C File Offset: 0x001C207C
		[NullableContext(1)]
		public UHoudiniAssetParameterString(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013338 RID: 78648 RVA: 0x001C3EAF File Offset: 0x001C20AF
		static UHoudiniAssetParameterString()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterString");
		}

		// Token: 0x06013339 RID: 78649 RVA: 0x001C3EBD File Offset: 0x001C20BD
		protected UHoudiniAssetParameterString(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5EC RID: 42476
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterString";

		// Token: 0x0400A5ED RID: 42477
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5EE RID: 42478
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
