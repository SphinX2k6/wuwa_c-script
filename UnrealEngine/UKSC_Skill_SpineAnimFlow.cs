using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E52 RID: 7762
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_SpineAnimFlow")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UKSC_Skill_SpineAnimFlow : UKSC_Skill, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D8C0 RID: 121024 RVA: 0x002BA10A File Offset: 0x002B830A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_SpineAnimFlow._ClassPtr;
		}

		// Token: 0x0601D8C1 RID: 121025 RVA: 0x002BA118 File Offset: 0x002B8318
		public UKSC_Skill_SpineAnimFlow() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_SpineAnimFlow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D8C2 RID: 121026 RVA: 0x002BA140 File Offset: 0x002B8340
		[NullableContext(1)]
		public UKSC_Skill_SpineAnimFlow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_SpineAnimFlow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007701 RID: 30465
		// (get) Token: 0x0601D8C3 RID: 121027 RVA: 0x002BA173 File Offset: 0x002B8373
		// (set) Token: 0x0601D8C4 RID: 121028 RVA: 0x002BA187 File Offset: 0x002B8387
		public unsafe UKSC_DA_Skill_SpineAnimFlow DA_SpineAnimFlow_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_SpineAnimFlow>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_SpineAnimFlow.__PropertyOffset_DA_SpineAnimFlow_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_SpineAnimFlow.__PropertyOffset_DA_SpineAnimFlow_, value);
			}
		}

		// Token: 0x17007702 RID: 30466
		// (get) Token: 0x0601D8C5 RID: 121029 RVA: 0x002BA19C File Offset: 0x002B839C
		// (set) Token: 0x0601D8C6 RID: 121030 RVA: 0x002BA1B0 File Offset: 0x002B83B0
		public unsafe UKSC_Shape2D_World KscShapeWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_SpineAnimFlow.__PropertyOffset_KscShapeWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_SpineAnimFlow.__PropertyOffset_KscShapeWorld, value);
			}
		}

		// Token: 0x0601D8C7 RID: 121031 RVA: 0x002BA1C5 File Offset: 0x002B83C5
		static UKSC_Skill_SpineAnimFlow()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_SpineAnimFlow");
		}

		// Token: 0x0601D8C8 RID: 121032 RVA: 0x002BA1D3 File Offset: 0x002B83D3
		protected UKSC_Skill_SpineAnimFlow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010049 RID: 65609
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_SpineAnimFlow";

		// Token: 0x0401004A RID: 65610
		private static IntPtr _ClassPtr;

		// Token: 0x0401004B RID: 65611
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401004C RID: 65612
		internal static int __PropertyOffset_DA_SpineAnimFlow_;

		// Token: 0x0401004D RID: 65613
		internal static int __PropertyOffset_KscShapeWorld;
	}
}
