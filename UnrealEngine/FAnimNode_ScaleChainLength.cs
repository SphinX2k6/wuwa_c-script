using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002FB RID: 763
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_ScaleChainLength")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FAnimNode_ScaleChainLength : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002BAD RID: 11181 RVA: 0x00042A28 File Offset: 0x00040C28
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ScaleChainLength._ScriptStructPtr != 0) ? FAnimNode_ScaleChainLength._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_ScaleChainLength", ref FAnimNode_ScaleChainLength._ScriptStructPtr);
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x00042A4C File Offset: 0x00040C4C
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x00042A8F File Offset: 0x00040C8F
		public FPoseLink InputPose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._InputPose) == null)
				{
					result = (this._InputPose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_InputPose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_InputPose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x00042AB0 File Offset: 0x00040CB0
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x00042AC0 File Offset: 0x00040CC0
		public unsafe float DefaultChainLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_DefaultChainLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_DefaultChainLength) = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x00042AD4 File Offset: 0x00040CD4
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x00042B17 File Offset: 0x00040D17
		public FBoneReference ChainStartBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._ChainStartBone) == null)
				{
					result = (this._ChainStartBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_ChainStartBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_ChainStartBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x00042B38 File Offset: 0x00040D38
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x00042B7B File Offset: 0x00040D7B
		public FBoneReference ChainEndBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._ChainEndBone) == null)
				{
					result = (this._ChainEndBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_ChainEndBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_ChainEndBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x00042B9C File Offset: 0x00040D9C
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x00042BB0 File Offset: 0x00040DB0
		public unsafe FVector TargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_TargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_TargetLocation) = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x00042BC5 File Offset: 0x00040DC5
		// (set) Token: 0x06002BB9 RID: 11193 RVA: 0x00042BD5 File Offset: 0x00040DD5
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x00042BE8 File Offset: 0x00040DE8
		// (set) Token: 0x06002BBB RID: 11195 RVA: 0x00042C2B File Offset: 0x00040E2B
		public FInputScaleBias AlphaScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBias result;
				if ((result = this._AlphaScaleBias) == null)
				{
					result = (this._AlphaScaleBias = new FInputScaleBias(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_AlphaScaleBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBias.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_AlphaScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x00042C4C File Offset: 0x00040E4C
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x00042C5C File Offset: 0x00040E5C
		public unsafe EScaleChainInitialLength ChainInitialLength
		{
			get
			{
				return (EScaleChainInitialLength)(*(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_ChainInitialLength));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ScaleChainLength.__PropertyOffset_ChainInitialLength) = (byte)value;
			}
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x00042C6D File Offset: 0x00040E6D
		public FAnimNode_ScaleChainLength()
		{
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x00042C78 File Offset: 0x00040E78
		public FAnimNode_ScaleChainLength(FPoseLink InputPose, float DefaultChainLength, FBoneReference ChainStartBone, FBoneReference ChainEndBone, FVector TargetLocation, float Alpha, FInputScaleBias AlphaScaleBias, EScaleChainInitialLength ChainInitialLength)
		{
			this.InputPose = InputPose;
			this.DefaultChainLength = DefaultChainLength;
			this.ChainStartBone = ChainStartBone;
			this.ChainEndBone = ChainEndBone;
			this.TargetLocation = TargetLocation;
			this.Alpha = Alpha;
			this.AlphaScaleBias = AlphaScaleBias;
			this.ChainInitialLength = ChainInitialLength;
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x00042CC8 File Offset: 0x00040EC8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ScaleChainLength.StaticStruct();
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x00042CD4 File Offset: 0x00040ED4
		[NullableContext(2)]
		public FAnimNode_ScaleChainLength(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x00042CDE File Offset: 0x00040EDE
		public FAnimNode_ScaleChainLength(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x00042CE9 File Offset: 0x00040EE9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ScaleChainLength(Pointer, false, true);
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00042CF3 File Offset: 0x00040EF3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ScaleChainLength(Pointer, MemoryOwner);
		}

		// Token: 0x040011CF RID: 4559
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_ScaleChainLength";

		// Token: 0x040011D0 RID: 4560
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040011D1 RID: 4561
		internal static int __PropertyOffset_InputPose;

		// Token: 0x040011D2 RID: 4562
		[Nullable(2)]
		private FPoseLink _InputPose;

		// Token: 0x040011D3 RID: 4563
		internal static int __PropertyOffset_DefaultChainLength;

		// Token: 0x040011D4 RID: 4564
		internal static int __PropertyOffset_ChainStartBone;

		// Token: 0x040011D5 RID: 4565
		[Nullable(2)]
		private FBoneReference _ChainStartBone;

		// Token: 0x040011D6 RID: 4566
		internal static int __PropertyOffset_ChainEndBone;

		// Token: 0x040011D7 RID: 4567
		[Nullable(2)]
		private FBoneReference _ChainEndBone;

		// Token: 0x040011D8 RID: 4568
		internal static int __PropertyOffset_TargetLocation;

		// Token: 0x040011D9 RID: 4569
		internal static int __PropertyOffset_Alpha;

		// Token: 0x040011DA RID: 4570
		internal static int __PropertyOffset_AlphaScaleBias;

		// Token: 0x040011DB RID: 4571
		[Nullable(2)]
		private FInputScaleBias _AlphaScaleBias;

		// Token: 0x040011DC RID: 4572
		internal static int __PropertyOffset_ChainInitialLength;
	}
}
