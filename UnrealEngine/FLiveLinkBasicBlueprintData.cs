using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021F6 RID: 8694
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FLiveLinkBasicBlueprintData : FLiveLinkBaseBlueprintData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021242 RID: 135746 RVA: 0x0030DE34 File Offset: 0x0030C034
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkBasicBlueprintData._ScriptStructPtr != 0) ? FLiveLinkBasicBlueprintData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData", ref FLiveLinkBasicBlueprintData._ScriptStructPtr);
		}

		// Token: 0x17008166 RID: 33126
		// (get) Token: 0x06021243 RID: 135747 RVA: 0x0030DE58 File Offset: 0x0030C058
		// (set) Token: 0x06021244 RID: 135748 RVA: 0x0030DE9B File Offset: 0x0030C09B
		public FLiveLinkBaseStaticData StaticData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkBaseStaticData result;
				if ((result = this._StaticData) == null)
				{
					result = (this._StaticData = new FLiveLinkBaseStaticData(base.NativePtr + (IntPtr)FLiveLinkBasicBlueprintData.__PropertyOffset_StaticData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkBaseStaticData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkBasicBlueprintData.__PropertyOffset_StaticData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008167 RID: 33127
		// (get) Token: 0x06021245 RID: 135749 RVA: 0x0030DEBC File Offset: 0x0030C0BC
		// (set) Token: 0x06021246 RID: 135750 RVA: 0x0030DEFF File Offset: 0x0030C0FF
		public FLiveLinkBaseFrameData FrameData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkBaseFrameData result;
				if ((result = this._FrameData) == null)
				{
					result = (this._FrameData = new FLiveLinkBaseFrameData(base.NativePtr + (IntPtr)FLiveLinkBasicBlueprintData.__PropertyOffset_FrameData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkBaseFrameData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkBasicBlueprintData.__PropertyOffset_FrameData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021247 RID: 135751 RVA: 0x0030DF20 File Offset: 0x0030C120
		public FLiveLinkBasicBlueprintData()
		{
		}

		// Token: 0x06021248 RID: 135752 RVA: 0x0030DF28 File Offset: 0x0030C128
		public FLiveLinkBasicBlueprintData(FLiveLinkBaseStaticData StaticData, FLiveLinkBaseFrameData FrameData)
		{
			this.StaticData = StaticData;
			this.FrameData = FrameData;
		}

		// Token: 0x06021249 RID: 135753 RVA: 0x0030DF3E File Offset: 0x0030C13E
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkBasicBlueprintData.StaticStruct();
		}

		// Token: 0x0602124A RID: 135754 RVA: 0x0030DF4A File Offset: 0x0030C14A
		[NullableContext(2)]
		public FLiveLinkBasicBlueprintData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602124B RID: 135755 RVA: 0x0030DF54 File Offset: 0x0030C154
		public FLiveLinkBasicBlueprintData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602124C RID: 135756 RVA: 0x0030DF5F File Offset: 0x0030C15F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkBasicBlueprintData(Pointer, false, true);
		}

		// Token: 0x0602124D RID: 135757 RVA: 0x0030DF69 File Offset: 0x0030C169
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkBasicBlueprintData(Pointer, MemoryOwner);
		}

		// Token: 0x04011AF2 RID: 72434
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkBasicBlueprintData";

		// Token: 0x04011AF3 RID: 72435
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011AF4 RID: 72436
		internal static int __PropertyOffset_StaticData;

		// Token: 0x04011AF5 RID: 72437
		[Nullable(2)]
		private FLiveLinkBaseStaticData _StaticData;

		// Token: 0x04011AF6 RID: 72438
		internal static int __PropertyOffset_FrameData;

		// Token: 0x04011AF7 RID: 72439
		[Nullable(2)]
		private FLiveLinkBaseFrameData _FrameData;
	}
}
