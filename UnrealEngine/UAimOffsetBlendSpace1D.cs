using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D4 RID: 2004
	[UnrealObjectPath("/Script/Engine.AimOffsetBlendSpace1D")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UAimOffsetBlendSpace1D : UBlendSpace1D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006ACE RID: 27342 RVA: 0x00099E1E File Offset: 0x0009801E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAimOffsetBlendSpace1D._ClassPtr;
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x00099E2C File Offset: 0x0009802C
		public UAimOffsetBlendSpace1D() : this(BuiltinUtils.AllocNativeUObject(UAimOffsetBlendSpace1D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x00099E54 File Offset: 0x00098054
		[NullableContext(1)]
		public UAimOffsetBlendSpace1D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAimOffsetBlendSpace1D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00099E87 File Offset: 0x00098087
		static UAimOffsetBlendSpace1D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AimOffsetBlendSpace1D");
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x00099E95 File Offset: 0x00098095
		protected UAimOffsetBlendSpace1D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003367 RID: 13159
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AimOffsetBlendSpace1D";

		// Token: 0x04003368 RID: 13160
		private static IntPtr _ClassPtr;

		// Token: 0x04003369 RID: 13161
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
