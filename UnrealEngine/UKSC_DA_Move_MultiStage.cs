using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DA3 RID: 7587
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Move_MultiStage")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKSC_DA_Move_MultiStage : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D03C RID: 118844 RVA: 0x002AE216 File Offset: 0x002AC416
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Move_MultiStage._ClassPtr;
		}

		// Token: 0x0601D03D RID: 118845 RVA: 0x002AE224 File Offset: 0x002AC424
		public UKSC_DA_Move_MultiStage() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_MultiStage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D03E RID: 118846 RVA: 0x002AE24C File Offset: 0x002AC44C
		public UKSC_DA_Move_MultiStage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_MultiStage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700750C RID: 29964
		// (get) Token: 0x0601D03F RID: 118847 RVA: 0x002AE280 File Offset: 0x002AC480
		// (set) Token: 0x0601D040 RID: 118848 RVA: 0x002AE2B9 File Offset: 0x002AC4B9
		public TArray<UKSC_DA_Move_Stage> Stages
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Move_Stage> result;
				if ((result = this._Stages) == null)
				{
					result = (this._Stages = new TArray<UKSC_DA_Move_Stage>(base.NativePtr + (IntPtr)UKSC_DA_Move_MultiStage.__PropertyOffset_Stages, this));
				}
				return result;
			}
			set
			{
				this.Stages.CopyAssign(value);
			}
		}

		// Token: 0x1700750D RID: 29965
		// (get) Token: 0x0601D041 RID: 118849 RVA: 0x002AE2C7 File Offset: 0x002AC4C7
		// (set) Token: 0x0601D042 RID: 118850 RVA: 0x002AE2D7 File Offset: 0x002AC4D7
		public unsafe bool ManualStageSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_MultiStage.__PropertyOffset_ManualStageSwitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_MultiStage.__PropertyOffset_ManualStageSwitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D043 RID: 118851 RVA: 0x002AE2E8 File Offset: 0x002AC4E8
		static UKSC_DA_Move_MultiStage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Move_MultiStage");
		}

		// Token: 0x0601D044 RID: 118852 RVA: 0x002AE2F6 File Offset: 0x002AC4F6
		protected UKSC_DA_Move_MultiStage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBFE RID: 64510
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Move_MultiStage";

		// Token: 0x0400FBFF RID: 64511
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC00 RID: 64512
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC01 RID: 64513
		internal static int __PropertyOffset_Stages;

		// Token: 0x0400FC02 RID: 64514
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Move_Stage> _Stages;

		// Token: 0x0400FC03 RID: 64515
		internal static int __PropertyOffset_ManualStageSwitch;
	}
}
