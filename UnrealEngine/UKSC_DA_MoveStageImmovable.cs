using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D9B RID: 7579
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_MoveStageImmovable")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_DA_MoveStageImmovable : UKSC_DA_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CFFC RID: 118780 RVA: 0x002ADC67 File Offset: 0x002ABE67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_MoveStageImmovable._ClassPtr;
		}

		// Token: 0x0601CFFD RID: 118781 RVA: 0x002ADC74 File Offset: 0x002ABE74
		public UKSC_DA_MoveStageImmovable() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageImmovable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CFFE RID: 118782 RVA: 0x002ADC9C File Offset: 0x002ABE9C
		[NullableContext(1)]
		public UKSC_DA_MoveStageImmovable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageImmovable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007500 RID: 29952
		// (get) Token: 0x0601CFFF RID: 118783 RVA: 0x002ADCCF File Offset: 0x002ABECF
		// (set) Token: 0x0601D000 RID: 118784 RVA: 0x002ADCDF File Offset: 0x002ABEDF
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_MoveStageImmovable.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_MoveStageImmovable.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x0601D001 RID: 118785 RVA: 0x002ADCF0 File Offset: 0x002ABEF0
		static UKSC_DA_MoveStageImmovable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_MoveStageImmovable");
		}

		// Token: 0x0601D002 RID: 118786 RVA: 0x002ADCFE File Offset: 0x002ABEFE
		protected UKSC_DA_MoveStageImmovable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBD9 RID: 64473
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_MoveStageImmovable";

		// Token: 0x0400FBDA RID: 64474
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBDB RID: 64475
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBDC RID: 64476
		internal static int __PropertyOffset_Duration;
	}
}
