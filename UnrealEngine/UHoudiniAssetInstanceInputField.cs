using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014A9 RID: 5289
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetInstanceInputField")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UHoudiniAssetInstanceInputField : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060132EF RID: 78575 RVA: 0x001C3746 File Offset: 0x001C1946
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetInstanceInputField._ClassPtr;
		}

		// Token: 0x060132F0 RID: 78576 RVA: 0x001C3754 File Offset: 0x001C1954
		public UHoudiniAssetInstanceInputField() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetInstanceInputField.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060132F1 RID: 78577 RVA: 0x001C377C File Offset: 0x001C197C
		[NullableContext(1)]
		public UHoudiniAssetInstanceInputField(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetInstanceInputField.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060132F2 RID: 78578 RVA: 0x001C37AF File Offset: 0x001C19AF
		static UHoudiniAssetInstanceInputField()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetInstanceInputField");
		}

		// Token: 0x060132F3 RID: 78579 RVA: 0x001C37BD File Offset: 0x001C19BD
		protected UHoudiniAssetInstanceInputField(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5C2 RID: 42434
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetInstanceInputField";

		// Token: 0x0400A5C3 RID: 42435
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5C4 RID: 42436
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
