using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EB1 RID: 3761
	[UnrealObjectPath("/Script/Engine.Model")]
	[UnrealStructLayout(992, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 992)]
	public class UModel : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CB9C RID: 52124 RVA: 0x00128D28 File Offset: 0x00126F28
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UModel._ClassPtr;
		}

		// Token: 0x0600CB9D RID: 52125 RVA: 0x00128D34 File Offset: 0x00126F34
		public UModel() : this(BuiltinUtils.AllocNativeUObject(UModel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CB9E RID: 52126 RVA: 0x00128D5C File Offset: 0x00126F5C
		[NullableContext(1)]
		public UModel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UModel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600CB9F RID: 52127 RVA: 0x00128D8F File Offset: 0x00126F8F
		static UModel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Model");
		}

		// Token: 0x0600CBA0 RID: 52128 RVA: 0x00128D9D File Offset: 0x00126F9D
		protected UModel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006DB6 RID: 28086
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Model";

		// Token: 0x04006DB7 RID: 28087
		private static IntPtr _ClassPtr;

		// Token: 0x04006DB8 RID: 28088
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
