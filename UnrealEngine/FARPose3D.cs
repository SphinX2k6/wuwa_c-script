using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BB RID: 955
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARPose3D")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FARPose3D : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060034F5 RID: 13557 RVA: 0x00050D12 File Offset: 0x0004EF12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARPose3D._ScriptStructPtr != 0) ? FARPose3D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARPose3D", ref FARPose3D._ScriptStructPtr);
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x00050D38 File Offset: 0x0004EF38
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x00050D7B File Offset: 0x0004EF7B
		public FARSkeletonDefinition SkeletonDefinition
		{
			get
			{
				base.FastCheckIsValid();
				FARSkeletonDefinition result;
				if ((result = this._SkeletonDefinition) == null)
				{
					result = (this._SkeletonDefinition = new FARSkeletonDefinition(base.NativePtr + (IntPtr)FARPose3D.__PropertyOffset_SkeletonDefinition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARSkeletonDefinition.StaticStruct(), base.NativePtr + (IntPtr)FARPose3D.__PropertyOffset_SkeletonDefinition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x00050D9C File Offset: 0x0004EF9C
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x00050DDF File Offset: 0x0004EFDF
		public TArray<FTransform> JointTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._JointTransforms) == null)
				{
					result = (this._JointTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FARPose3D.__PropertyOffset_JointTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.JointTransforms.CopyAssign(value);
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x00050DF0 File Offset: 0x0004EFF0
		// (set) Token: 0x060034FB RID: 13563 RVA: 0x00050E33 File Offset: 0x0004F033
		public TArray<bool> IsJointTracked
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._IsJointTracked) == null)
				{
					result = (this._IsJointTracked = new TArray<bool>(base.NativePtr + (IntPtr)FARPose3D.__PropertyOffset_IsJointTracked, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IsJointTracked.CopyAssign(value);
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x00050E41 File Offset: 0x0004F041
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x00050E51 File Offset: 0x0004F051
		public unsafe EARJointTransformSpace JointTransformSpace
		{
			get
			{
				return (EARJointTransformSpace)(*(base.NativePtr + (IntPtr)FARPose3D.__PropertyOffset_JointTransformSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARPose3D.__PropertyOffset_JointTransformSpace) = (byte)value;
			}
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x00050E62 File Offset: 0x0004F062
		public FARPose3D()
		{
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00050E6A File Offset: 0x0004F06A
		public FARPose3D(FARSkeletonDefinition SkeletonDefinition, TArray<FTransform> JointTransforms, TArray<bool> IsJointTracked, EARJointTransformSpace JointTransformSpace)
		{
			this.SkeletonDefinition = SkeletonDefinition;
			this.JointTransforms = JointTransforms;
			this.IsJointTracked = IsJointTracked;
			this.JointTransformSpace = JointTransformSpace;
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00050E8F File Offset: 0x0004F08F
		protected override IntPtr GetUStructPtr()
		{
			return FARPose3D.StaticStruct();
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x00050E9B File Offset: 0x0004F09B
		[NullableContext(2)]
		public FARPose3D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x00050EA5 File Offset: 0x0004F0A5
		public FARPose3D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00050EB0 File Offset: 0x0004F0B0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARPose3D(Pointer, false, true);
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x00050EBA File Offset: 0x0004F0BA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARPose3D(Pointer, MemoryOwner);
		}

		// Token: 0x040016F6 RID: 5878
		public const string __ObjectPath = "/Script/AugmentedReality.ARPose3D";

		// Token: 0x040016F7 RID: 5879
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040016F8 RID: 5880
		internal static int __PropertyOffset_SkeletonDefinition;

		// Token: 0x040016F9 RID: 5881
		[Nullable(2)]
		private FARSkeletonDefinition _SkeletonDefinition;

		// Token: 0x040016FA RID: 5882
		internal static int __PropertyOffset_JointTransforms;

		// Token: 0x040016FB RID: 5883
		[Nullable(2)]
		private TArray<FTransform> _JointTransforms;

		// Token: 0x040016FC RID: 5884
		internal static int __PropertyOffset_IsJointTracked;

		// Token: 0x040016FD RID: 5885
		[Nullable(2)]
		private TArray<bool> _IsJointTracked;

		// Token: 0x040016FE RID: 5886
		internal static int __PropertyOffset_JointTransformSpace;
	}
}
