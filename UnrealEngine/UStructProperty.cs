using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000768 RID: 1896
	[UnrealObjectPath("/Script/CoreUObject.StructProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UStructProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063AE RID: 25518 RVA: 0x0008F1D6 File Offset: 0x0008D3D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStructProperty._ClassPtr;
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x0008F1E4 File Offset: 0x0008D3E4
		public UStructProperty() : this(BuiltinUtils.AllocNativeUObject(UStructProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x0008F20C File Offset: 0x0008D40C
		[NullableContext(1)]
		public UStructProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStructProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x0008F23F File Offset: 0x0008D43F
		static UStructProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.StructProperty");
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x0008F24D File Offset: 0x0008D44D
		protected UStructProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FC8 RID: 12232
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.StructProperty";

		// Token: 0x04002FC9 RID: 12233
		private static IntPtr _ClassPtr;

		// Token: 0x04002FCA RID: 12234
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
