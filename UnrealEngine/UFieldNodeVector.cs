using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012AF RID: 4783
	[UnrealObjectPath("/Script/FieldSystemEngine.FieldNodeVector")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UFieldNodeVector : UFieldNodeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601185E RID: 71774 RVA: 0x0019B6A6 File Offset: 0x001998A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFieldNodeVector._ClassPtr;
		}

		// Token: 0x0601185F RID: 71775 RVA: 0x0019B6B4 File Offset: 0x001998B4
		public UFieldNodeVector() : this(BuiltinUtils.AllocNativeUObject(UFieldNodeVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011860 RID: 71776 RVA: 0x0019B6DC File Offset: 0x001998DC
		[NullableContext(1)]
		public UFieldNodeVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFieldNodeVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011861 RID: 71777 RVA: 0x0019B70F File Offset: 0x0019990F
		static UFieldNodeVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.FieldNodeVector");
		}

		// Token: 0x06011862 RID: 71778 RVA: 0x0019B71D File Offset: 0x0019991D
		protected UFieldNodeVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400963B RID: 38459
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.FieldNodeVector";

		// Token: 0x0400963C RID: 38460
		private static IntPtr _ClassPtr;

		// Token: 0x0400963D RID: 38461
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
