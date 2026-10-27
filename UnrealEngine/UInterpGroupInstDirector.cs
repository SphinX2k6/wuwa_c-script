using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C84 RID: 3204
	[UnrealObjectPath("/Script/Engine.InterpGroupInstDirector")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UInterpGroupInstDirector : UInterpGroupInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A29E RID: 41630 RVA: 0x000E6EF2 File Offset: 0x000E50F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpGroupInstDirector._ClassPtr;
		}

		// Token: 0x0600A29F RID: 41631 RVA: 0x000E6F00 File Offset: 0x000E5100
		public UInterpGroupInstDirector() : this(BuiltinUtils.AllocNativeUObject(UInterpGroupInstDirector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x000E6F28 File Offset: 0x000E5128
		[NullableContext(1)]
		public UInterpGroupInstDirector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpGroupInstDirector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x000E6F5B File Offset: 0x000E515B
		static UInterpGroupInstDirector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpGroupInstDirector");
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x000E6F69 File Offset: 0x000E5169
		protected UInterpGroupInstDirector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005940 RID: 22848
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpGroupInstDirector";

		// Token: 0x04005941 RID: 22849
		private static IntPtr _ClassPtr;

		// Token: 0x04005942 RID: 22850
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
