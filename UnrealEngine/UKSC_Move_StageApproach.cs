using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E09 RID: 7689
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_StageApproach")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 552)]
	public class UKSC_Move_StageApproach : UKSC_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5C1 RID: 120257 RVA: 0x002B5733 File Offset: 0x002B3933
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_StageApproach._ClassPtr;
		}

		// Token: 0x0601D5C2 RID: 120258 RVA: 0x002B5740 File Offset: 0x002B3940
		public UKSC_Move_StageApproach() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageApproach.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5C3 RID: 120259 RVA: 0x002B5768 File Offset: 0x002B3968
		public UKSC_Move_StageApproach(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageApproach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007679 RID: 30329
		// (get) Token: 0x0601D5C4 RID: 120260 RVA: 0x002B579B File Offset: 0x002B399B
		// (set) Token: 0x0601D5C5 RID: 120261 RVA: 0x002B57AF File Offset: 0x002B39AF
		[Nullable(2)]
		public unsafe UKSC_DA_MoveStageApproach DA_Move
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_MoveStageApproach>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_StageApproach.__PropertyOffset_DA_Move);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move_StageApproach.__PropertyOffset_DA_Move, value);
			}
		}

		// Token: 0x1700767A RID: 30330
		// (get) Token: 0x0601D5C6 RID: 120262 RVA: 0x002B57C4 File Offset: 0x002B39C4
		// (set) Token: 0x0601D5C7 RID: 120263 RVA: 0x002B57FD File Offset: 0x002B39FD
		public TArray<FVector> MovePoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._MovePoints) == null)
				{
					result = (this._MovePoints = new TArray<FVector>(base.NativePtr + (IntPtr)UKSC_Move_StageApproach.__PropertyOffset_MovePoints, this));
				}
				return result;
			}
			set
			{
				this.MovePoints.CopyAssign(value);
			}
		}

		// Token: 0x0601D5C8 RID: 120264 RVA: 0x002B580B File Offset: 0x002B3A0B
		static UKSC_Move_StageApproach()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_StageApproach");
		}

		// Token: 0x0601D5C9 RID: 120265 RVA: 0x002B5819 File Offset: 0x002B3A19
		protected UKSC_Move_StageApproach(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEC9 RID: 65225
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_StageApproach";

		// Token: 0x0400FECA RID: 65226
		private static IntPtr _ClassPtr;

		// Token: 0x0400FECB RID: 65227
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FECC RID: 65228
		internal static int __PropertyOffset_DA_Move;

		// Token: 0x0400FECD RID: 65229
		internal static int __PropertyOffset_MovePoints;

		// Token: 0x0400FECE RID: 65230
		[Nullable(2)]
		private TArray<FVector> _MovePoints;
	}
}
