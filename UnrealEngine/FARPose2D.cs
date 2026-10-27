using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BA RID: 954
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARPose2D")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FARPose2D : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060034E7 RID: 13543 RVA: 0x00050B89 File Offset: 0x0004ED89
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARPose2D._ScriptStructPtr != 0) ? FARPose2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARPose2D", ref FARPose2D._ScriptStructPtr);
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060034E8 RID: 13544 RVA: 0x00050BB0 File Offset: 0x0004EDB0
		// (set) Token: 0x060034E9 RID: 13545 RVA: 0x00050BF3 File Offset: 0x0004EDF3
		public FARSkeletonDefinition SkeletonDefinition
		{
			get
			{
				base.FastCheckIsValid();
				FARSkeletonDefinition result;
				if ((result = this._SkeletonDefinition) == null)
				{
					result = (this._SkeletonDefinition = new FARSkeletonDefinition(base.NativePtr + (IntPtr)FARPose2D.__PropertyOffset_SkeletonDefinition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARSkeletonDefinition.StaticStruct(), base.NativePtr + (IntPtr)FARPose2D.__PropertyOffset_SkeletonDefinition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x00050C14 File Offset: 0x0004EE14
		// (set) Token: 0x060034EB RID: 13547 RVA: 0x00050C57 File Offset: 0x0004EE57
		public TArray<FVector2D> JointLocations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._JointLocations) == null)
				{
					result = (this._JointLocations = new TArray<FVector2D>(base.NativePtr + (IntPtr)FARPose2D.__PropertyOffset_JointLocations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.JointLocations.CopyAssign(value);
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x00050C68 File Offset: 0x0004EE68
		// (set) Token: 0x060034ED RID: 13549 RVA: 0x00050CAB File Offset: 0x0004EEAB
		public TArray<bool> IsJointTracked
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._IsJointTracked) == null)
				{
					result = (this._IsJointTracked = new TArray<bool>(base.NativePtr + (IntPtr)FARPose2D.__PropertyOffset_IsJointTracked, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IsJointTracked.CopyAssign(value);
			}
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x00050CB9 File Offset: 0x0004EEB9
		public FARPose2D()
		{
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x00050CC1 File Offset: 0x0004EEC1
		public FARPose2D(FARSkeletonDefinition SkeletonDefinition, TArray<FVector2D> JointLocations, TArray<bool> IsJointTracked)
		{
			this.SkeletonDefinition = SkeletonDefinition;
			this.JointLocations = JointLocations;
			this.IsJointTracked = IsJointTracked;
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x00050CDE File Offset: 0x0004EEDE
		protected override IntPtr GetUStructPtr()
		{
			return FARPose2D.StaticStruct();
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00050CEA File Offset: 0x0004EEEA
		[NullableContext(2)]
		public FARPose2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x00050CF4 File Offset: 0x0004EEF4
		public FARPose2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x00050CFF File Offset: 0x0004EEFF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARPose2D(Pointer, false, true);
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00050D09 File Offset: 0x0004EF09
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARPose2D(Pointer, MemoryOwner);
		}

		// Token: 0x040016EE RID: 5870
		public const string __ObjectPath = "/Script/AugmentedReality.ARPose2D";

		// Token: 0x040016EF RID: 5871
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040016F0 RID: 5872
		internal static int __PropertyOffset_SkeletonDefinition;

		// Token: 0x040016F1 RID: 5873
		[Nullable(2)]
		private FARSkeletonDefinition _SkeletonDefinition;

		// Token: 0x040016F2 RID: 5874
		internal static int __PropertyOffset_JointLocations;

		// Token: 0x040016F3 RID: 5875
		[Nullable(2)]
		private TArray<FVector2D> _JointLocations;

		// Token: 0x040016F4 RID: 5876
		internal static int __PropertyOffset_IsJointTracked;

		// Token: 0x040016F5 RID: 5877
		[Nullable(2)]
		private TArray<bool> _IsJointTracked;
	}
}
