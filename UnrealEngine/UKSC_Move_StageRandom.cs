using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E0D RID: 7693
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_StageRandom")]
	[UnrealStructLayout(536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 536)]
	public class UKSC_Move_StageRandom : UKSC_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5DB RID: 120283 RVA: 0x002B59CA File Offset: 0x002B3BCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_StageRandom._ClassPtr;
		}

		// Token: 0x0601D5DC RID: 120284 RVA: 0x002B59D8 File Offset: 0x002B3BD8
		public UKSC_Move_StageRandom() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageRandom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5DD RID: 120285 RVA: 0x002B5A00 File Offset: 0x002B3C00
		public UKSC_Move_StageRandom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700767C RID: 30332
		// (get) Token: 0x0601D5DE RID: 120286 RVA: 0x002B5A33 File Offset: 0x002B3C33
		// (set) Token: 0x0601D5DF RID: 120287 RVA: 0x002B5A47 File Offset: 0x002B3C47
		[Nullable(2)]
		public unsafe UKSC_DA_MoveStageRandom DA_Move
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_MoveStageRandom>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_StageRandom.__PropertyOffset_DA_Move);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_StageRandom.__PropertyOffset_DA_Move, value);
			}
		}

		// Token: 0x1700767D RID: 30333
		// (get) Token: 0x0601D5E0 RID: 120288 RVA: 0x002B5A5C File Offset: 0x002B3C5C
		// (set) Token: 0x0601D5E1 RID: 120289 RVA: 0x002B5A95 File Offset: 0x002B3C95
		public TArray<FVector> MovePoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._MovePoints) == null)
				{
					result = (this._MovePoints = new TArray<FVector>(base.NativePtr + (IntPtr)UKSC_Move_StageRandom.__PropertyOffset_MovePoints, this));
				}
				return result;
			}
			set
			{
				this.MovePoints.CopyAssign(value);
			}
		}

		// Token: 0x0601D5E2 RID: 120290 RVA: 0x002B5AA3 File Offset: 0x002B3CA3
		static UKSC_Move_StageRandom()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_StageRandom");
		}

		// Token: 0x0601D5E3 RID: 120291 RVA: 0x002B5AB1 File Offset: 0x002B3CB1
		protected UKSC_Move_StageRandom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FED9 RID: 65241
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_StageRandom";

		// Token: 0x0400FEDA RID: 65242
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEDB RID: 65243
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEDC RID: 65244
		internal static int __PropertyOffset_DA_Move;

		// Token: 0x0400FEDD RID: 65245
		internal static int __PropertyOffset_MovePoints;

		// Token: 0x0400FEDE RID: 65246
		[Nullable(2)]
		private TArray<FVector> _MovePoints;
	}
}
