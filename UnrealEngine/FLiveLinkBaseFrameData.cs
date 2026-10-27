using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021F3 RID: 8691
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkBaseFrameData")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FLiveLinkBaseFrameData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021223 RID: 135715 RVA: 0x0030DB7A File Offset: 0x0030BD7A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkBaseFrameData._ScriptStructPtr != 0) ? FLiveLinkBaseFrameData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkBaseFrameData", ref FLiveLinkBaseFrameData._ScriptStructPtr);
		}

		// Token: 0x17008162 RID: 33122
		// (get) Token: 0x06021224 RID: 135716 RVA: 0x0030DBA0 File Offset: 0x0030BDA0
		// (set) Token: 0x06021225 RID: 135717 RVA: 0x0030DBE3 File Offset: 0x0030BDE3
		public FLiveLinkWorldTime WorldTime
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkWorldTime result;
				if ((result = this._WorldTime) == null)
				{
					result = (this._WorldTime = new FLiveLinkWorldTime(base.NativePtr + (IntPtr)FLiveLinkBaseFrameData.__PropertyOffset_WorldTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkWorldTime.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkBaseFrameData.__PropertyOffset_WorldTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008163 RID: 33123
		// (get) Token: 0x06021226 RID: 135718 RVA: 0x0030DC04 File Offset: 0x0030BE04
		// (set) Token: 0x06021227 RID: 135719 RVA: 0x0030DC47 File Offset: 0x0030BE47
		public FLiveLinkMetaData MetaData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkMetaData result;
				if ((result = this._MetaData) == null)
				{
					result = (this._MetaData = new FLiveLinkMetaData(base.NativePtr + (IntPtr)FLiveLinkBaseFrameData.__PropertyOffset_MetaData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkMetaData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkBaseFrameData.__PropertyOffset_MetaData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008164 RID: 33124
		// (get) Token: 0x06021228 RID: 135720 RVA: 0x0030DC68 File Offset: 0x0030BE68
		// (set) Token: 0x06021229 RID: 135721 RVA: 0x0030DCAB File Offset: 0x0030BEAB
		public TArray<float> PropertyValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PropertyValues) == null)
				{
					result = (this._PropertyValues = new TArray<float>(base.NativePtr + (IntPtr)FLiveLinkBaseFrameData.__PropertyOffset_PropertyValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyValues.CopyAssign(value);
			}
		}

		// Token: 0x0602122A RID: 135722 RVA: 0x0030DCB9 File Offset: 0x0030BEB9
		public FLiveLinkBaseFrameData()
		{
		}

		// Token: 0x0602122B RID: 135723 RVA: 0x0030DCC1 File Offset: 0x0030BEC1
		public FLiveLinkBaseFrameData(FLiveLinkWorldTime WorldTime, FLiveLinkMetaData MetaData, TArray<float> PropertyValues)
		{
			this.WorldTime = WorldTime;
			this.MetaData = MetaData;
			this.PropertyValues = PropertyValues;
		}

		// Token: 0x0602122C RID: 135724 RVA: 0x0030DCDE File Offset: 0x0030BEDE
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkBaseFrameData.StaticStruct();
		}

		// Token: 0x0602122D RID: 135725 RVA: 0x0030DCEA File Offset: 0x0030BEEA
		[NullableContext(2)]
		public FLiveLinkBaseFrameData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602122E RID: 135726 RVA: 0x0030DCF4 File Offset: 0x0030BEF4
		public FLiveLinkBaseFrameData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602122F RID: 135727 RVA: 0x0030DCFF File Offset: 0x0030BEFF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkBaseFrameData(Pointer, false, true);
		}

		// Token: 0x06021230 RID: 135728 RVA: 0x0030DD09 File Offset: 0x0030BF09
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkBaseFrameData(Pointer, MemoryOwner);
		}

		// Token: 0x04011AE4 RID: 72420
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkBaseFrameData";

		// Token: 0x04011AE5 RID: 72421
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011AE6 RID: 72422
		internal static int __PropertyOffset_WorldTime;

		// Token: 0x04011AE7 RID: 72423
		[Nullable(2)]
		private FLiveLinkWorldTime _WorldTime;

		// Token: 0x04011AE8 RID: 72424
		internal static int __PropertyOffset_MetaData;

		// Token: 0x04011AE9 RID: 72425
		[Nullable(2)]
		private FLiveLinkMetaData _MetaData;

		// Token: 0x04011AEA RID: 72426
		internal static int __PropertyOffset_PropertyValues;

		// Token: 0x04011AEB RID: 72427
		[Nullable(2)]
		private TArray<float> _PropertyValues;
	}
}
