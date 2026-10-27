using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001019 RID: 4121
	[UnrealObjectPath("/Script/Engine.Polys")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UPolys : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E17B RID: 57723 RVA: 0x0014B6A4 File Offset: 0x001498A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPolys._ClassPtr;
		}

		// Token: 0x0600E17C RID: 57724 RVA: 0x0014B6B0 File Offset: 0x001498B0
		public UPolys() : this(BuiltinUtils.AllocNativeUObject(UPolys.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E17D RID: 57725 RVA: 0x0014B6D8 File Offset: 0x001498D8
		[NullableContext(1)]
		public UPolys(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPolys.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600E17E RID: 57726 RVA: 0x0014B70B File Offset: 0x0014990B
		static UPolys()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Polys");
		}

		// Token: 0x0600E17F RID: 57727 RVA: 0x0014B719 File Offset: 0x00149919
		protected UPolys(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007913 RID: 30995
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Polys";

		// Token: 0x04007914 RID: 30996
		private static IntPtr _ClassPtr;

		// Token: 0x04007915 RID: 30997
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
