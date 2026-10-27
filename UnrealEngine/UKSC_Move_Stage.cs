using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E08 RID: 7688
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Stage")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKSC_Move_Stage : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5BA RID: 120250 RVA: 0x002B568C File Offset: 0x002B388C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Stage._ClassPtr;
		}

		// Token: 0x0601D5BB RID: 120251 RVA: 0x002B5698 File Offset: 0x002B3898
		public UKSC_Move_Stage() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Stage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5BC RID: 120252 RVA: 0x002B56C0 File Offset: 0x002B38C0
		[NullableContext(1)]
		public UKSC_Move_Stage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Stage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007678 RID: 30328
		// (get) Token: 0x0601D5BD RID: 120253 RVA: 0x002B56F3 File Offset: 0x002B38F3
		// (set) Token: 0x0601D5BE RID: 120254 RVA: 0x002B5707 File Offset: 0x002B3907
		[Nullable(2)]
		public unsafe UKSC_DA_Move_Stage DA_MoveStage
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Move_Stage>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_Stage.__PropertyOffset_DA_MoveStage);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_Stage.__PropertyOffset_DA_MoveStage, value);
			}
		}

		// Token: 0x0601D5BF RID: 120255 RVA: 0x002B571C File Offset: 0x002B391C
		static UKSC_Move_Stage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Stage");
		}

		// Token: 0x0601D5C0 RID: 120256 RVA: 0x002B572A File Offset: 0x002B392A
		protected UKSC_Move_Stage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEC5 RID: 65221
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Stage";

		// Token: 0x0400FEC6 RID: 65222
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEC7 RID: 65223
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEC8 RID: 65224
		internal static int __PropertyOffset_DA_MoveStage;
	}
}
