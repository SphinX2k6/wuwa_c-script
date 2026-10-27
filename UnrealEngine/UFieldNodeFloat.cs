using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012AD RID: 4781
	[UnrealObjectPath("/Script/FieldSystemEngine.FieldNodeFloat")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UFieldNodeFloat : UFieldNodeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011854 RID: 71764 RVA: 0x0019B5A6 File Offset: 0x001997A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFieldNodeFloat._ClassPtr;
		}

		// Token: 0x06011855 RID: 71765 RVA: 0x0019B5B4 File Offset: 0x001997B4
		public UFieldNodeFloat() : this(BuiltinUtils.AllocNativeUObject(UFieldNodeFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011856 RID: 71766 RVA: 0x0019B5DC File Offset: 0x001997DC
		[NullableContext(1)]
		public UFieldNodeFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFieldNodeFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011857 RID: 71767 RVA: 0x0019B60F File Offset: 0x0019980F
		static UFieldNodeFloat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.FieldNodeFloat");
		}

		// Token: 0x06011858 RID: 71768 RVA: 0x0019B61D File Offset: 0x0019981D
		protected UFieldNodeFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009635 RID: 38453
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.FieldNodeFloat";

		// Token: 0x04009636 RID: 38454
		private static IntPtr _ClassPtr;

		// Token: 0x04009637 RID: 38455
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
