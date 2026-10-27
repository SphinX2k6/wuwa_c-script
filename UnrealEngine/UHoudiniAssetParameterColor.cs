using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014AD RID: 5293
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterColor")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UHoudiniAssetParameterColor : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013303 RID: 78595 RVA: 0x001C3946 File Offset: 0x001C1B46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterColor._ClassPtr;
		}

		// Token: 0x06013304 RID: 78596 RVA: 0x001C3954 File Offset: 0x001C1B54
		public UHoudiniAssetParameterColor() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013305 RID: 78597 RVA: 0x001C397C File Offset: 0x001C1B7C
		[NullableContext(1)]
		public UHoudiniAssetParameterColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013306 RID: 78598 RVA: 0x001C39AF File Offset: 0x001C1BAF
		static UHoudiniAssetParameterColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterColor");
		}

		// Token: 0x06013307 RID: 78599 RVA: 0x001C39BD File Offset: 0x001C1BBD
		protected UHoudiniAssetParameterColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5CE RID: 42446
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterColor";

		// Token: 0x0400A5CF RID: 42447
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5D0 RID: 42448
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
