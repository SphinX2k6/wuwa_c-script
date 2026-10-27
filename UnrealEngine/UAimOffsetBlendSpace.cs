using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D3 RID: 2003
	[UnrealObjectPath("/Script/Engine.AimOffsetBlendSpace")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UAimOffsetBlendSpace : UBlendSpace, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006AC9 RID: 27337 RVA: 0x00099D9F File Offset: 0x00097F9F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAimOffsetBlendSpace._ClassPtr;
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x00099DAC File Offset: 0x00097FAC
		public UAimOffsetBlendSpace() : this(BuiltinUtils.AllocNativeUObject(UAimOffsetBlendSpace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x00099DD4 File Offset: 0x00097FD4
		[NullableContext(1)]
		public UAimOffsetBlendSpace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAimOffsetBlendSpace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x00099E07 File Offset: 0x00098007
		static UAimOffsetBlendSpace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AimOffsetBlendSpace");
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x00099E15 File Offset: 0x00098015
		protected UAimOffsetBlendSpace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003364 RID: 13156
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AimOffsetBlendSpace";

		// Token: 0x04003365 RID: 13157
		private static IntPtr _ClassPtr;

		// Token: 0x04003366 RID: 13158
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
