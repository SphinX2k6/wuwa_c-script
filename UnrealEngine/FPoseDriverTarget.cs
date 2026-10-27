using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000337 RID: 823
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.PoseDriverTarget")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FPoseDriverTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002DCB RID: 11723 RVA: 0x00046543 File Offset: 0x00044743
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPoseDriverTarget._ScriptStructPtr != 0) ? FPoseDriverTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.PoseDriverTarget", ref FPoseDriverTarget._ScriptStructPtr);
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002DCC RID: 11724 RVA: 0x00046568 File Offset: 0x00044768
		// (set) Token: 0x06002DCD RID: 11725 RVA: 0x000465AB File Offset: 0x000447AB
		public TArray<FPoseDriverTransform> BoneTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPoseDriverTransform> result;
				if ((result = this._BoneTransforms) == null)
				{
					result = (this._BoneTransforms = new TArray<FPoseDriverTransform>(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_BoneTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneTransforms.CopyAssign(value);
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x000465B9 File Offset: 0x000447B9
		// (set) Token: 0x06002DCF RID: 11727 RVA: 0x000465CD File Offset: 0x000447CD
		public unsafe FRotator TargetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_TargetRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_TargetRotation) = value;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x000465E2 File Offset: 0x000447E2
		// (set) Token: 0x06002DD1 RID: 11729 RVA: 0x000465F2 File Offset: 0x000447F2
		public unsafe float TargetScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_TargetScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_TargetScale) = value;
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x00046603 File Offset: 0x00044803
		// (set) Token: 0x06002DD3 RID: 11731 RVA: 0x00046613 File Offset: 0x00044813
		public unsafe ERBFDistanceMethod DistanceMethod
		{
			get
			{
				return (ERBFDistanceMethod)(*(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_DistanceMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_DistanceMethod) = (byte)value;
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002DD4 RID: 11732 RVA: 0x00046624 File Offset: 0x00044824
		// (set) Token: 0x06002DD5 RID: 11733 RVA: 0x00046634 File Offset: 0x00044834
		public unsafe ERBFFunctionType FunctionType
		{
			get
			{
				return (ERBFFunctionType)(*(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_FunctionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_FunctionType) = (byte)value;
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x00046645 File Offset: 0x00044845
		// (set) Token: 0x06002DD7 RID: 11735 RVA: 0x00046655 File Offset: 0x00044855
		public unsafe bool bApplyCustomCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_bApplyCustomCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_bApplyCustomCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x00046668 File Offset: 0x00044868
		// (set) Token: 0x06002DD9 RID: 11737 RVA: 0x000466AB File Offset: 0x000448AB
		public FRichCurve CustomCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._CustomCurve) == null)
				{
					result = (this._CustomCurve = new FRichCurve(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_CustomCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_CustomCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002DDA RID: 11738 RVA: 0x000466CC File Offset: 0x000448CC
		// (set) Token: 0x06002DDB RID: 11739 RVA: 0x000466E0 File Offset: 0x000448E0
		public unsafe FName DrivenName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_DrivenName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_DrivenName) = value;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x000466F5 File Offset: 0x000448F5
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x00046705 File Offset: 0x00044905
		public unsafe bool bIsHidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_bIsHidden) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseDriverTarget.__PropertyOffset_bIsHidden) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x00046716 File Offset: 0x00044916
		public FPoseDriverTarget()
		{
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x00046720 File Offset: 0x00044920
		public FPoseDriverTarget(TArray<FPoseDriverTransform> BoneTransforms, FRotator TargetRotation, float TargetScale, ERBFDistanceMethod DistanceMethod, ERBFFunctionType FunctionType, bool bApplyCustomCurve, FRichCurve CustomCurve, FName DrivenName, bool bIsHidden)
		{
			this.BoneTransforms = BoneTransforms;
			this.TargetRotation = TargetRotation;
			this.TargetScale = TargetScale;
			this.DistanceMethod = DistanceMethod;
			this.FunctionType = FunctionType;
			this.bApplyCustomCurve = bApplyCustomCurve;
			this.CustomCurve = CustomCurve;
			this.DrivenName = DrivenName;
			this.bIsHidden = bIsHidden;
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x00046778 File Offset: 0x00044978
		protected override IntPtr GetUStructPtr()
		{
			return FPoseDriverTarget.StaticStruct();
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00046784 File Offset: 0x00044984
		[NullableContext(2)]
		public FPoseDriverTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x0004678E File Offset: 0x0004498E
		public FPoseDriverTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00046799 File Offset: 0x00044999
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPoseDriverTarget(Pointer, false, true);
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x000467A3 File Offset: 0x000449A3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPoseDriverTarget(Pointer, MemoryOwner);
		}

		// Token: 0x0400139E RID: 5022
		public const string __ObjectPath = "/Script/AnimGraphRuntime.PoseDriverTarget";

		// Token: 0x0400139F RID: 5023
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013A0 RID: 5024
		internal static int __PropertyOffset_BoneTransforms;

		// Token: 0x040013A1 RID: 5025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPoseDriverTransform> _BoneTransforms;

		// Token: 0x040013A2 RID: 5026
		internal static int __PropertyOffset_TargetRotation;

		// Token: 0x040013A3 RID: 5027
		internal static int __PropertyOffset_TargetScale;

		// Token: 0x040013A4 RID: 5028
		internal static int __PropertyOffset_DistanceMethod;

		// Token: 0x040013A5 RID: 5029
		internal static int __PropertyOffset_FunctionType;

		// Token: 0x040013A6 RID: 5030
		internal static int __PropertyOffset_bApplyCustomCurve;

		// Token: 0x040013A7 RID: 5031
		internal static int __PropertyOffset_CustomCurve;

		// Token: 0x040013A8 RID: 5032
		[Nullable(2)]
		private FRichCurve _CustomCurve;

		// Token: 0x040013A9 RID: 5033
		internal static int __PropertyOffset_DrivenName;

		// Token: 0x040013AA RID: 5034
		internal static int __PropertyOffset_bIsHidden;
	}
}
