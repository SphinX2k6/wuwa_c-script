using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001665 RID: 5733
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroIKRequest")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroIKRequest : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014C41 RID: 85057 RVA: 0x001E8A04 File Offset: 0x001E6C04
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroIKRequest._ScriptStructPtr != 0) ? FKuroIKRequest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroIKRequest", ref FKuroIKRequest._ScriptStructPtr);
		}

		// Token: 0x17005222 RID: 21026
		// (get) Token: 0x06014C42 RID: 85058 RVA: 0x001E8A28 File Offset: 0x001E6C28
		// (set) Token: 0x06014C43 RID: 85059 RVA: 0x001E8A38 File Offset: 0x001E6C38
		public unsafe EKuroIKSolverType SolverType
		{
			get
			{
				return (EKuroIKSolverType)(*(base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_SolverType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_SolverType) = (byte)value;
			}
		}

		// Token: 0x17005223 RID: 21027
		// (get) Token: 0x06014C44 RID: 85060 RVA: 0x001E8A4C File Offset: 0x001E6C4C
		// (set) Token: 0x06014C45 RID: 85061 RVA: 0x001E8A8F File Offset: 0x001E6C8F
		public FBoneReference EndBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._EndBone) == null)
				{
					result = (this._EndBone = new FBoneReference(base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_EndBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_EndBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005224 RID: 21028
		// (get) Token: 0x06014C46 RID: 85062 RVA: 0x001E8AB0 File Offset: 0x001E6CB0
		// (set) Token: 0x06014C47 RID: 85063 RVA: 0x001E8AF3 File Offset: 0x001E6CF3
		public FBoneReference RootBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._RootBone) == null)
				{
					result = (this._RootBone = new FBoneReference(base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_RootBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_RootBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005225 RID: 21029
		// (get) Token: 0x06014C48 RID: 85064 RVA: 0x001E8B14 File Offset: 0x001E6D14
		// (set) Token: 0x06014C49 RID: 85065 RVA: 0x001E8B57 File Offset: 0x001E6D57
		public TArray<FKuroIKRotationConstraint> Constraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroIKRotationConstraint> result;
				if ((result = this._Constraints) == null)
				{
					result = (this._Constraints = new TArray<FKuroIKRotationConstraint>(base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_Constraints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Constraints.CopyAssign(value);
			}
		}

		// Token: 0x17005226 RID: 21030
		// (get) Token: 0x06014C4A RID: 85066 RVA: 0x001E8B65 File Offset: 0x001E6D65
		// (set) Token: 0x06014C4B RID: 85067 RVA: 0x001E8B75 File Offset: 0x001E6D75
		public unsafe float Tolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_Tolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_Tolerance) = value;
			}
		}

		// Token: 0x17005227 RID: 21031
		// (get) Token: 0x06014C4C RID: 85068 RVA: 0x001E8B86 File Offset: 0x001E6D86
		// (set) Token: 0x06014C4D RID: 85069 RVA: 0x001E8B96 File Offset: 0x001E6D96
		public unsafe int MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_MaxIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroIKRequest.__PropertyOffset_MaxIterations) = value;
			}
		}

		// Token: 0x06014C4E RID: 85070 RVA: 0x001E8BA7 File Offset: 0x001E6DA7
		public FKuroIKRequest()
		{
		}

		// Token: 0x06014C4F RID: 85071 RVA: 0x001E8BAF File Offset: 0x001E6DAF
		public FKuroIKRequest(EKuroIKSolverType SolverType, FBoneReference EndBone, FBoneReference RootBone, TArray<FKuroIKRotationConstraint> Constraints, float Tolerance, int MaxIterations)
		{
			this.SolverType = SolverType;
			this.EndBone = EndBone;
			this.RootBone = RootBone;
			this.Constraints = Constraints;
			this.Tolerance = Tolerance;
			this.MaxIterations = MaxIterations;
		}

		// Token: 0x06014C50 RID: 85072 RVA: 0x001E8BE4 File Offset: 0x001E6DE4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroIKRequest.StaticStruct();
		}

		// Token: 0x06014C51 RID: 85073 RVA: 0x001E8BF0 File Offset: 0x001E6DF0
		[NullableContext(2)]
		public FKuroIKRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014C52 RID: 85074 RVA: 0x001E8BFA File Offset: 0x001E6DFA
		public FKuroIKRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014C53 RID: 85075 RVA: 0x001E8C05 File Offset: 0x001E6E05
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroIKRequest(Pointer, false, true);
		}

		// Token: 0x06014C54 RID: 85076 RVA: 0x001E8C0F File Offset: 0x001E6E0F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroIKRequest(Pointer, MemoryOwner);
		}

		// Token: 0x0400B528 RID: 46376
		public const string __ObjectPath = "/Script/KuroAnim.KuroIKRequest";

		// Token: 0x0400B529 RID: 46377
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B52A RID: 46378
		internal static int __PropertyOffset_SolverType;

		// Token: 0x0400B52B RID: 46379
		internal static int __PropertyOffset_EndBone;

		// Token: 0x0400B52C RID: 46380
		[Nullable(2)]
		private FBoneReference _EndBone;

		// Token: 0x0400B52D RID: 46381
		internal static int __PropertyOffset_RootBone;

		// Token: 0x0400B52E RID: 46382
		[Nullable(2)]
		private FBoneReference _RootBone;

		// Token: 0x0400B52F RID: 46383
		internal static int __PropertyOffset_Constraints;

		// Token: 0x0400B530 RID: 46384
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroIKRotationConstraint> _Constraints;

		// Token: 0x0400B531 RID: 46385
		internal static int __PropertyOffset_Tolerance;

		// Token: 0x0400B532 RID: 46386
		internal static int __PropertyOffset_MaxIterations;
	}
}
