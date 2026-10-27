using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E02 RID: 7682
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Approach")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UKSC_Move_Approach : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D57A RID: 120186 RVA: 0x002B510D File Offset: 0x002B330D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Approach._ClassPtr;
		}

		// Token: 0x0601D57B RID: 120187 RVA: 0x002B511C File Offset: 0x002B331C
		public UKSC_Move_Approach() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Approach.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D57C RID: 120188 RVA: 0x002B5144 File Offset: 0x002B3344
		[NullableContext(1)]
		public UKSC_Move_Approach(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Approach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D57D RID: 120189 RVA: 0x002B5177 File Offset: 0x002B3377
		[NullableContext(2)]
		public void SetTargetEntity(AKSC_Entity Entity)
		{
			UKSC_Move_Approach.__SetTargetEntity_Internal(base.NativePtr, (Entity != null) ? Entity.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D57E RID: 120190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetEntity_Internal(IntPtr @this, IntPtr Entity);

		// Token: 0x0601D57F RID: 120191 RVA: 0x002B5194 File Offset: 0x002B3394
		static UKSC_Move_Approach()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Approach");
		}

		// Token: 0x0601D580 RID: 120192 RVA: 0x002B51A2 File Offset: 0x002B33A2
		protected UKSC_Move_Approach(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEAD RID: 65197
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Approach";

		// Token: 0x0400FEAE RID: 65198
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEAF RID: 65199
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
