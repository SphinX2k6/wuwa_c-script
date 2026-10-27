using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028A0 RID: 10400
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMTransitionTransaction")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FSMTransitionTransaction : FSMTransaction_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026938 RID: 158008 RVA: 0x003ADB81 File Offset: 0x003ABD81
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMTransitionTransaction._ScriptStructPtr != 0) ? FSMTransitionTransaction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMTransitionTransaction", ref FSMTransitionTransaction._ScriptStructPtr);
		}

		// Token: 0x170094C5 RID: 38085
		// (get) Token: 0x06026939 RID: 158009 RVA: 0x003ADBA5 File Offset: 0x003ABDA5
		// (set) Token: 0x0602693A RID: 158010 RVA: 0x003ADBB9 File Offset: 0x003ABDB9
		public unsafe FGuid BaseGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMTransitionTransaction.__PropertyOffset_BaseGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMTransitionTransaction.__PropertyOffset_BaseGuid) = value;
			}
		}

		// Token: 0x170094C6 RID: 38086
		// (get) Token: 0x0602693B RID: 158011 RVA: 0x003ADBD0 File Offset: 0x003ABDD0
		// (set) Token: 0x0602693C RID: 158012 RVA: 0x003ADC13 File Offset: 0x003ABE13
		public TArray<FGuid> AdditionalGuids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._AdditionalGuids) == null)
				{
					result = (this._AdditionalGuids = new TArray<FGuid>(base.NativePtr + (IntPtr)FSMTransitionTransaction.__PropertyOffset_AdditionalGuids, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdditionalGuids.CopyAssign(value);
			}
		}

		// Token: 0x170094C7 RID: 38087
		// (get) Token: 0x0602693D RID: 158013 RVA: 0x003ADC24 File Offset: 0x003ABE24
		// (set) Token: 0x0602693E RID: 158014 RVA: 0x003ADC67 File Offset: 0x003ABE67
		public FDateTime Timestamp
		{
			get
			{
				base.FastCheckIsValid();
				FDateTime result;
				if ((result = this._Timestamp) == null)
				{
					result = (this._Timestamp = new FDateTime(base.NativePtr + (IntPtr)FSMTransitionTransaction.__PropertyOffset_Timestamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDateTime.StaticStruct(), base.NativePtr + (IntPtr)FSMTransitionTransaction.__PropertyOffset_Timestamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170094C8 RID: 38088
		// (get) Token: 0x0602693F RID: 158015 RVA: 0x003ADC88 File Offset: 0x003ABE88
		// (set) Token: 0x06026940 RID: 158016 RVA: 0x003ADC98 File Offset: 0x003ABE98
		public unsafe float ActiveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMTransitionTransaction.__PropertyOffset_ActiveTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMTransitionTransaction.__PropertyOffset_ActiveTime) = value;
			}
		}

		// Token: 0x06026941 RID: 158017 RVA: 0x003ADCA9 File Offset: 0x003ABEA9
		public FSMTransitionTransaction()
		{
		}

		// Token: 0x06026942 RID: 158018 RVA: 0x003ADCB1 File Offset: 0x003ABEB1
		public FSMTransitionTransaction(FGuid BaseGuid, TArray<FGuid> AdditionalGuids, FDateTime Timestamp, float ActiveTime, ESMTransactionType TransactionType, bool bOriginatedFromServer)
		{
			this.BaseGuid = BaseGuid;
			this.AdditionalGuids = AdditionalGuids;
			this.Timestamp = Timestamp;
			this.ActiveTime = ActiveTime;
			base.TransactionType = TransactionType;
			base.bOriginatedFromServer = bOriginatedFromServer;
		}

		// Token: 0x06026943 RID: 158019 RVA: 0x003ADCE6 File Offset: 0x003ABEE6
		protected override IntPtr GetUStructPtr()
		{
			return FSMTransitionTransaction.StaticStruct();
		}

		// Token: 0x06026944 RID: 158020 RVA: 0x003ADCF2 File Offset: 0x003ABEF2
		[NullableContext(2)]
		public FSMTransitionTransaction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026945 RID: 158021 RVA: 0x003ADCFC File Offset: 0x003ABEFC
		public FSMTransitionTransaction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026946 RID: 158022 RVA: 0x003ADD07 File Offset: 0x003ABF07
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMTransitionTransaction(Pointer, false, true);
		}

		// Token: 0x06026947 RID: 158023 RVA: 0x003ADD11 File Offset: 0x003ABF11
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMTransitionTransaction(Pointer, MemoryOwner);
		}

		// Token: 0x0401530D RID: 86797
		public new const string __ObjectPath = "/Script/SMSystem.SMTransitionTransaction";

		// Token: 0x0401530E RID: 86798
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401530F RID: 86799
		internal static int __PropertyOffset_BaseGuid;

		// Token: 0x04015310 RID: 86800
		internal static int __PropertyOffset_AdditionalGuids;

		// Token: 0x04015311 RID: 86801
		[Nullable(2)]
		private TArray<FGuid> _AdditionalGuids;

		// Token: 0x04015312 RID: 86802
		internal static int __PropertyOffset_Timestamp;

		// Token: 0x04015313 RID: 86803
		[Nullable(2)]
		private FDateTime _Timestamp;

		// Token: 0x04015314 RID: 86804
		internal static int __PropertyOffset_ActiveTime;
	}
}
