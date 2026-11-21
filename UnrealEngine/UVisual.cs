using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000873 RID: 2163
	[UnrealObjectPath("/Script/UMG.Visual")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UVisual : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BC0E RID: 48142 RVA: 0x0012CD1D File Offset: 0x0012AF1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVisual._ClassPtr;
		}

		// Token: 0x0600BC0F RID: 48143 RVA: 0x0012CD2C File Offset: 0x0012AF2C
		public UVisual() : this(BuiltinUtils.AllocNativeUObject(UVisual.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BC10 RID: 48144 RVA: 0x0012CD54 File Offset: 0x0012AF54
		[NullableContext(1)]
		public UVisual(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVisual.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BC11 RID: 48145 RVA: 0x0012CD87 File Offset: 0x0012AF87
		static UVisual()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Visual");
		}

		// Token: 0x0600BC12 RID: 48146 RVA: 0x0012CD95 File Offset: 0x0012AF95
		protected UVisual(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005514 RID: 21780
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.Visual";

		// Token: 0x04005515 RID: 21781
		private static IntPtr _ClassPtr;

		// Token: 0x04005516 RID: 21782
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
