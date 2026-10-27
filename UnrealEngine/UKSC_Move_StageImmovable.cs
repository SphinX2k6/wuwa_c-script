using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E0B RID: 7691
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_StageImmovable")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UKSC_Move_StageImmovable : UKSC_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5CF RID: 120271 RVA: 0x002B58A2 File Offset: 0x002B3AA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_StageImmovable._ClassPtr;
		}

		// Token: 0x0601D5D0 RID: 120272 RVA: 0x002B58B0 File Offset: 0x002B3AB0
		public UKSC_Move_StageImmovable() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageImmovable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5D1 RID: 120273 RVA: 0x002B58D8 File Offset: 0x002B3AD8
		[NullableContext(1)]
		public UKSC_Move_StageImmovable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageImmovable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700767B RID: 30331
		// (get) Token: 0x0601D5D2 RID: 120274 RVA: 0x002B590B File Offset: 0x002B3B0B
		// (set) Token: 0x0601D5D3 RID: 120275 RVA: 0x002B591F File Offset: 0x002B3B1F
		[Nullable(2)]
		public unsafe UKSC_DA_MoveStageImmovable DA_Move
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_MoveStageImmovable>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_StageImmovable.__PropertyOffset_DA_Move);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_StageImmovable.__PropertyOffset_DA_Move, value);
			}
		}

		// Token: 0x0601D5D4 RID: 120276 RVA: 0x002B5934 File Offset: 0x002B3B34
		static UKSC_Move_StageImmovable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_StageImmovable");
		}

		// Token: 0x0601D5D5 RID: 120277 RVA: 0x002B5942 File Offset: 0x002B3B42
		protected UKSC_Move_StageImmovable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FED2 RID: 65234
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_StageImmovable";

		// Token: 0x0400FED3 RID: 65235
		private static IntPtr _ClassPtr;

		// Token: 0x0400FED4 RID: 65236
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FED5 RID: 65237
		internal static int __PropertyOffset_DA_Move;
	}
}
