using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014AB RID: 5291
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetParameterButton")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UHoudiniAssetParameterButton : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060132F9 RID: 78585 RVA: 0x001C3846 File Offset: 0x001C1A46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetParameterButton._ClassPtr;
		}

		// Token: 0x060132FA RID: 78586 RVA: 0x001C3854 File Offset: 0x001C1A54
		public UHoudiniAssetParameterButton() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterButton.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060132FB RID: 78587 RVA: 0x001C387C File Offset: 0x001C1A7C
		[NullableContext(1)]
		public UHoudiniAssetParameterButton(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetParameterButton.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060132FC RID: 78588 RVA: 0x001C38AF File Offset: 0x001C1AAF
		static UHoudiniAssetParameterButton()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetParameterButton");
		}

		// Token: 0x060132FD RID: 78589 RVA: 0x001C38BD File Offset: 0x001C1ABD
		protected UHoudiniAssetParameterButton(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5C8 RID: 42440
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetParameterButton";

		// Token: 0x0400A5C9 RID: 42441
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5CA RID: 42442
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
