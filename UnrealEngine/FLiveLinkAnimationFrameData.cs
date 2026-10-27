using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020021F0 RID: 8688
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkAnimationFrameData")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FLiveLinkAnimationFrameData : FLiveLinkBaseFrameData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602120D RID: 135693 RVA: 0x0030D9C2 File Offset: 0x0030BBC2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkAnimationFrameData._ScriptStructPtr != 0) ? FLiveLinkAnimationFrameData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkAnimationFrameData", ref FLiveLinkAnimationFrameData._ScriptStructPtr);
		}

		// Token: 0x17008161 RID: 33121
		// (get) Token: 0x0602120E RID: 135694 RVA: 0x0030D9E8 File Offset: 0x0030BBE8
		// (set) Token: 0x0602120F RID: 135695 RVA: 0x0030DA2B File Offset: 0x0030BC2B
		public TArray<FTransform> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FLiveLinkAnimationFrameData.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x06021210 RID: 135696 RVA: 0x0030DA39 File Offset: 0x0030BC39
		public FLiveLinkAnimationFrameData()
		{
		}

		// Token: 0x06021211 RID: 135697 RVA: 0x0030DA41 File Offset: 0x0030BC41
		public FLiveLinkAnimationFrameData(TArray<FTransform> Transforms, FLiveLinkWorldTime WorldTime, FLiveLinkMetaData MetaData, TArray<float> PropertyValues)
		{
			this.Transforms = Transforms;
			base.WorldTime = WorldTime;
			base.MetaData = MetaData;
			base.PropertyValues = PropertyValues;
		}

		// Token: 0x06021212 RID: 135698 RVA: 0x0030DA66 File Offset: 0x0030BC66
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkAnimationFrameData.StaticStruct();
		}

		// Token: 0x06021213 RID: 135699 RVA: 0x0030DA72 File Offset: 0x0030BC72
		[NullableContext(2)]
		public FLiveLinkAnimationFrameData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021214 RID: 135700 RVA: 0x0030DA7C File Offset: 0x0030BC7C
		public FLiveLinkAnimationFrameData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021215 RID: 135701 RVA: 0x0030DA87 File Offset: 0x0030BC87
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkAnimationFrameData(Pointer, false, true);
		}

		// Token: 0x06021216 RID: 135702 RVA: 0x0030DA91 File Offset: 0x0030BC91
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkAnimationFrameData(Pointer, MemoryOwner);
		}

		// Token: 0x04011ADB RID: 72411
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkAnimationFrameData";

		// Token: 0x04011ADC RID: 72412
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011ADD RID: 72413
		internal static int __PropertyOffset_Transforms;

		// Token: 0x04011ADE RID: 72414
		[Nullable(2)]
		private TArray<FTransform> _Transforms;
	}
}
