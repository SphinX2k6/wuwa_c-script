using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DAC RID: 7596
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2DAnim")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UKSC_DA_Shape2DAnim : UKSC_DA_Anim, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D099 RID: 118937 RVA: 0x002AEA66 File Offset: 0x002ACC66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2DAnim._ClassPtr;
		}

		// Token: 0x0601D09A RID: 118938 RVA: 0x002AEA74 File Offset: 0x002ACC74
		public UKSC_DA_Shape2DAnim() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2DAnim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D09B RID: 118939 RVA: 0x002AEA9C File Offset: 0x002ACC9C
		public UKSC_DA_Shape2DAnim(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2DAnim.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007524 RID: 29988
		// (get) Token: 0x0601D09C RID: 118940 RVA: 0x002AEAD0 File Offset: 0x002ACCD0
		// (set) Token: 0x0601D09D RID: 118941 RVA: 0x002AEB09 File Offset: 0x002ACD09
		public TMap<EKSC_Shape2D_BaseAnimState, FKSC_SpineAnimItem> BaseStateAnimMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_Shape2D_BaseAnimState, FKSC_SpineAnimItem> result;
				if ((result = this._BaseStateAnimMap) == null)
				{
					result = (this._BaseStateAnimMap = new TMap<EKSC_Shape2D_BaseAnimState, FKSC_SpineAnimItem>(base.NativePtr + (IntPtr)UKSC_DA_Shape2DAnim.__PropertyOffset_BaseStateAnimMap, this));
				}
				return result;
			}
			set
			{
				this.BaseStateAnimMap.CopyAssign(value);
			}
		}

		// Token: 0x17007525 RID: 29989
		// (get) Token: 0x0601D09E RID: 118942 RVA: 0x002AEB18 File Offset: 0x002ACD18
		// (set) Token: 0x0601D09F RID: 118943 RVA: 0x002AEB51 File Offset: 0x002ACD51
		public TMap<EKSC_Shape2D_SpecialAnimState, FKSC_SpineAnimItem> SpecialStateAnimMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_Shape2D_SpecialAnimState, FKSC_SpineAnimItem> result;
				if ((result = this._SpecialStateAnimMap) == null)
				{
					result = (this._SpecialStateAnimMap = new TMap<EKSC_Shape2D_SpecialAnimState, FKSC_SpineAnimItem>(base.NativePtr + (IntPtr)UKSC_DA_Shape2DAnim.__PropertyOffset_SpecialStateAnimMap, this));
				}
				return result;
			}
			set
			{
				this.SpecialStateAnimMap.CopyAssign(value);
			}
		}

		// Token: 0x17007526 RID: 29990
		// (get) Token: 0x0601D0A0 RID: 118944 RVA: 0x002AEB60 File Offset: 0x002ACD60
		// (set) Token: 0x0601D0A1 RID: 118945 RVA: 0x002AEB99 File Offset: 0x002ACD99
		public TMap<EKSC_Shape2D_SpecialAnimState, FGameplayTagContainer> SpecialStateAnimTagMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_Shape2D_SpecialAnimState, FGameplayTagContainer> result;
				if ((result = this._SpecialStateAnimTagMap) == null)
				{
					result = (this._SpecialStateAnimTagMap = new TMap<EKSC_Shape2D_SpecialAnimState, FGameplayTagContainer>(base.NativePtr + (IntPtr)UKSC_DA_Shape2DAnim.__PropertyOffset_SpecialStateAnimTagMap, this));
				}
				return result;
			}
			set
			{
				this.SpecialStateAnimTagMap.CopyAssign(value);
			}
		}

		// Token: 0x17007527 RID: 29991
		// (get) Token: 0x0601D0A2 RID: 118946 RVA: 0x002AEBA7 File Offset: 0x002ACDA7
		// (set) Token: 0x0601D0A3 RID: 118947 RVA: 0x002AEBB7 File Offset: 0x002ACDB7
		public unsafe bool RemoveOnDeathAnimComplete
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2DAnim.__PropertyOffset_RemoveOnDeathAnimComplete) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2DAnim.__PropertyOffset_RemoveOnDeathAnimComplete) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D0A4 RID: 118948 RVA: 0x002AEBC8 File Offset: 0x002ACDC8
		static UKSC_DA_Shape2DAnim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2DAnim");
		}

		// Token: 0x0601D0A5 RID: 118949 RVA: 0x002AEBD6 File Offset: 0x002ACDD6
		protected UKSC_DA_Shape2DAnim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC35 RID: 64565
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2DAnim";

		// Token: 0x0400FC36 RID: 64566
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC37 RID: 64567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC38 RID: 64568
		internal static int __PropertyOffset_BaseStateAnimMap;

		// Token: 0x0400FC39 RID: 64569
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKSC_Shape2D_BaseAnimState, FKSC_SpineAnimItem> _BaseStateAnimMap;

		// Token: 0x0400FC3A RID: 64570
		internal static int __PropertyOffset_SpecialStateAnimMap;

		// Token: 0x0400FC3B RID: 64571
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKSC_Shape2D_SpecialAnimState, FKSC_SpineAnimItem> _SpecialStateAnimMap;

		// Token: 0x0400FC3C RID: 64572
		internal static int __PropertyOffset_SpecialStateAnimTagMap;

		// Token: 0x0400FC3D RID: 64573
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKSC_Shape2D_SpecialAnimState, FGameplayTagContainer> _SpecialStateAnimTagMap;

		// Token: 0x0400FC3E RID: 64574
		internal static int __PropertyOffset_RemoveOnDeathAnimComplete;
	}
}
