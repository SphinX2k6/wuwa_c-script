using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002229 RID: 8745
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FLiveLinkTransformBlueprintData : FLiveLinkBaseBlueprintData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214C6 RID: 136390 RVA: 0x0031146E File Offset: 0x0030F66E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTransformBlueprintData._ScriptStructPtr != 0) ? FLiveLinkTransformBlueprintData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData", ref FLiveLinkTransformBlueprintData._ScriptStructPtr);
		}

		// Token: 0x170081F5 RID: 33269
		// (get) Token: 0x060214C7 RID: 136391 RVA: 0x00311494 File Offset: 0x0030F694
		// (set) Token: 0x060214C8 RID: 136392 RVA: 0x003114D7 File Offset: 0x0030F6D7
		public FLiveLinkTransformStaticData StaticData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkTransformStaticData result;
				if ((result = this._StaticData) == null)
				{
					result = (this._StaticData = new FLiveLinkTransformStaticData(base.NativePtr + (IntPtr)FLiveLinkTransformBlueprintData.__PropertyOffset_StaticData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkTransformStaticData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkTransformBlueprintData.__PropertyOffset_StaticData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170081F6 RID: 33270
		// (get) Token: 0x060214C9 RID: 136393 RVA: 0x003114F8 File Offset: 0x0030F6F8
		// (set) Token: 0x060214CA RID: 136394 RVA: 0x0031153B File Offset: 0x0030F73B
		public FLiveLinkTransformFrameData FrameData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkTransformFrameData result;
				if ((result = this._FrameData) == null)
				{
					result = (this._FrameData = new FLiveLinkTransformFrameData(base.NativePtr + (IntPtr)FLiveLinkTransformBlueprintData.__PropertyOffset_FrameData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkTransformFrameData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkTransformBlueprintData.__PropertyOffset_FrameData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060214CB RID: 136395 RVA: 0x0031155C File Offset: 0x0030F75C
		public FLiveLinkTransformBlueprintData()
		{
		}

		// Token: 0x060214CC RID: 136396 RVA: 0x00311564 File Offset: 0x0030F764
		public FLiveLinkTransformBlueprintData(FLiveLinkTransformStaticData StaticData, FLiveLinkTransformFrameData FrameData)
		{
			this.StaticData = StaticData;
			this.FrameData = FrameData;
		}

		// Token: 0x060214CD RID: 136397 RVA: 0x0031157A File Offset: 0x0030F77A
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTransformBlueprintData.StaticStruct();
		}

		// Token: 0x060214CE RID: 136398 RVA: 0x00311586 File Offset: 0x0030F786
		[NullableContext(2)]
		public FLiveLinkTransformBlueprintData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214CF RID: 136399 RVA: 0x00311590 File Offset: 0x0030F790
		public FLiveLinkTransformBlueprintData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214D0 RID: 136400 RVA: 0x0031159B File Offset: 0x0030F79B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTransformBlueprintData(Pointer, false, true);
		}

		// Token: 0x060214D1 RID: 136401 RVA: 0x003115A5 File Offset: 0x0030F7A5
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTransformBlueprintData(Pointer, MemoryOwner);
		}

		// Token: 0x04011C1D RID: 72733
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTransformBlueprintData";

		// Token: 0x04011C1E RID: 72734
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C1F RID: 72735
		internal static int __PropertyOffset_StaticData;

		// Token: 0x04011C20 RID: 72736
		[Nullable(2)]
		private FLiveLinkTransformStaticData _StaticData;

		// Token: 0x04011C21 RID: 72737
		internal static int __PropertyOffset_FrameData;

		// Token: 0x04011C22 RID: 72738
		[Nullable(2)]
		private FLiveLinkTransformFrameData _FrameData;
	}
}
