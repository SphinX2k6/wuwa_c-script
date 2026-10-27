using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D5F RID: 7519
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_EventHandler")]
	[UnrealStructLayout(528, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UKSC_DA_Buff_EventHandler : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CCCA RID: 117962 RVA: 0x002A9156 File Offset: 0x002A7356
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_EventHandler._ClassPtr;
		}

		// Token: 0x0601CCCB RID: 117963 RVA: 0x002A9164 File Offset: 0x002A7364
		public UKSC_DA_Buff_EventHandler() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_EventHandler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CCCC RID: 117964 RVA: 0x002A918C File Offset: 0x002A738C
		public UKSC_DA_Buff_EventHandler(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_EventHandler.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073FB RID: 29691
		// (get) Token: 0x0601CCCD RID: 117965 RVA: 0x002A91C0 File Offset: 0x002A73C0
		// (set) Token: 0x0601CCCE RID: 117966 RVA: 0x002A91F9 File Offset: 0x002A73F9
		public TArray<UKSC_EventListener> Listeners
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_EventListener> result;
				if ((result = this._Listeners) == null)
				{
					result = (this._Listeners = new TArray<UKSC_EventListener>(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_Listeners, this));
				}
				return result;
			}
			set
			{
				this.Listeners.CopyAssign(value);
			}
		}

		// Token: 0x170073FC RID: 29692
		// (get) Token: 0x0601CCCF RID: 117967 RVA: 0x002A9208 File Offset: 0x002A7408
		// (set) Token: 0x0601CCD0 RID: 117968 RVA: 0x002A9241 File Offset: 0x002A7441
		public TArray<UKSC_EventResponder> Responders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_EventResponder> result;
				if ((result = this._Responders) == null)
				{
					result = (this._Responders = new TArray<UKSC_EventResponder>(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_Responders, this));
				}
				return result;
			}
			set
			{
				this.Responders.CopyAssign(value);
			}
		}

		// Token: 0x170073FD RID: 29693
		// (get) Token: 0x0601CCD1 RID: 117969 RVA: 0x002A924F File Offset: 0x002A744F
		// (set) Token: 0x0601CCD2 RID: 117970 RVA: 0x002A925F File Offset: 0x002A745F
		public unsafe float CoolDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_CoolDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_CoolDown) = value;
			}
		}

		// Token: 0x170073FE RID: 29694
		// (get) Token: 0x0601CCD3 RID: 117971 RVA: 0x002A9270 File Offset: 0x002A7470
		// (set) Token: 0x0601CCD4 RID: 117972 RVA: 0x002A9280 File Offset: 0x002A7480
		public unsafe int Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_Probability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_Probability) = value;
			}
		}

		// Token: 0x170073FF RID: 29695
		// (get) Token: 0x0601CCD5 RID: 117973 RVA: 0x002A9291 File Offset: 0x002A7491
		// (set) Token: 0x0601CCD6 RID: 117974 RVA: 0x002A92A1 File Offset: 0x002A74A1
		public unsafe bool bUseAttrProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_bUseAttrProbability) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_bUseAttrProbability) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007400 RID: 29696
		// (get) Token: 0x0601CCD7 RID: 117975 RVA: 0x002A92B2 File Offset: 0x002A74B2
		// (set) Token: 0x0601CCD8 RID: 117976 RVA: 0x002A92C2 File Offset: 0x002A74C2
		public unsafe EKSC_AttrType ProbabilityAttr
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_ProbabilityAttr));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_ProbabilityAttr) = (byte)value;
			}
		}

		// Token: 0x17007401 RID: 29697
		// (get) Token: 0x0601CCD9 RID: 117977 RVA: 0x002A92D3 File Offset: 0x002A74D3
		// (set) Token: 0x0601CCDA RID: 117978 RVA: 0x002A92E3 File Offset: 0x002A74E3
		public unsafe int ResponseCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_ResponseCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_ResponseCount) = value;
			}
		}

		// Token: 0x17007402 RID: 29698
		// (get) Token: 0x0601CCDB RID: 117979 RVA: 0x002A92F4 File Offset: 0x002A74F4
		// (set) Token: 0x0601CCDC RID: 117980 RVA: 0x002A9304 File Offset: 0x002A7504
		public unsafe bool bFinishAfterResponse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_bFinishAfterResponse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_bFinishAfterResponse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007403 RID: 29699
		// (get) Token: 0x0601CCDD RID: 117981 RVA: 0x002A9318 File Offset: 0x002A7518
		// (set) Token: 0x0601CCDE RID: 117982 RVA: 0x002A9351 File Offset: 0x002A7551
		public FKSC_TagFilter ResponseTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._ResponseTagFilter) == null)
				{
					result = (this._ResponseTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_ResponseTagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_EventHandler.__PropertyOffset_ResponseTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CCDF RID: 117983 RVA: 0x002A9372 File Offset: 0x002A7572
		static UKSC_DA_Buff_EventHandler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_EventHandler");
		}

		// Token: 0x0601CCE0 RID: 117984 RVA: 0x002A9380 File Offset: 0x002A7580
		protected UKSC_DA_Buff_EventHandler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9E6 RID: 63974
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_EventHandler";

		// Token: 0x0400F9E7 RID: 63975
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9E8 RID: 63976
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9E9 RID: 63977
		internal static int __PropertyOffset_Listeners;

		// Token: 0x0400F9EA RID: 63978
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_EventListener> _Listeners;

		// Token: 0x0400F9EB RID: 63979
		internal static int __PropertyOffset_Responders;

		// Token: 0x0400F9EC RID: 63980
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_EventResponder> _Responders;

		// Token: 0x0400F9ED RID: 63981
		internal static int __PropertyOffset_CoolDown;

		// Token: 0x0400F9EE RID: 63982
		internal static int __PropertyOffset_Probability;

		// Token: 0x0400F9EF RID: 63983
		internal static int __PropertyOffset_bUseAttrProbability;

		// Token: 0x0400F9F0 RID: 63984
		internal static int __PropertyOffset_ProbabilityAttr;

		// Token: 0x0400F9F1 RID: 63985
		internal static int __PropertyOffset_ResponseCount;

		// Token: 0x0400F9F2 RID: 63986
		internal static int __PropertyOffset_bFinishAfterResponse;

		// Token: 0x0400F9F3 RID: 63987
		internal static int __PropertyOffset_ResponseTagFilter;

		// Token: 0x0400F9F4 RID: 63988
		[Nullable(2)]
		private FKSC_TagFilter _ResponseTagFilter;
	}
}
