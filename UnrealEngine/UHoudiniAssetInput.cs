using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014A7 RID: 5287
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetInput")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UHoudiniAssetInput : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060132E5 RID: 78565 RVA: 0x001C3647 File Offset: 0x001C1847
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetInput._ClassPtr;
		}

		// Token: 0x060132E6 RID: 78566 RVA: 0x001C3654 File Offset: 0x001C1854
		public UHoudiniAssetInput() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060132E7 RID: 78567 RVA: 0x001C367C File Offset: 0x001C187C
		[NullableContext(1)]
		public UHoudiniAssetInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060132E8 RID: 78568 RVA: 0x001C36AF File Offset: 0x001C18AF
		static UHoudiniAssetInput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetInput");
		}

		// Token: 0x060132E9 RID: 78569 RVA: 0x001C36BD File Offset: 0x001C18BD
		protected UHoudiniAssetInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5BC RID: 42428
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetInput";

		// Token: 0x0400A5BD RID: 42429
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5BE RID: 42430
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
