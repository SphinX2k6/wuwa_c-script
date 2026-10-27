using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000694 RID: 1684
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MultiFABRIK")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_MultiFABRIK : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600597F RID: 22911 RVA: 0x00080A1C File Offset: 0x0007EC1C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MultiFABRIK._ScriptStructPtr != 0) ? FRigUnit_MultiFABRIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MultiFABRIK", ref FRigUnit_MultiFABRIK._ScriptStructPtr);
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06005980 RID: 22912 RVA: 0x00080A40 File Offset: 0x0007EC40
		// (set) Token: 0x06005981 RID: 22913 RVA: 0x00080A54 File Offset: 0x0007EC54
		public unsafe FName RootBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_RootBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_RootBone) = value;
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06005982 RID: 22914 RVA: 0x00080A6C File Offset: 0x0007EC6C
		// (set) Token: 0x06005983 RID: 22915 RVA: 0x00080AAF File Offset: 0x0007ECAF
		public TArray<FRigUnit_MultiFABRIK_EndEffector> Effectors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_MultiFABRIK_EndEffector> result;
				if ((result = this._Effectors) == null)
				{
					result = (this._Effectors = new TArray<FRigUnit_MultiFABRIK_EndEffector>(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_Effectors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Effectors.CopyAssign(value);
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06005984 RID: 22916 RVA: 0x00080ABD File Offset: 0x0007ECBD
		// (set) Token: 0x06005985 RID: 22917 RVA: 0x00080ACD File Offset: 0x0007ECCD
		public unsafe float Precision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_Precision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_Precision) = value;
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06005986 RID: 22918 RVA: 0x00080ADE File Offset: 0x0007ECDE
		// (set) Token: 0x06005987 RID: 22919 RVA: 0x00080AEE File Offset: 0x0007ECEE
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06005988 RID: 22920 RVA: 0x00080AFF File Offset: 0x0007ECFF
		// (set) Token: 0x06005989 RID: 22921 RVA: 0x00080B0F File Offset: 0x0007ED0F
		public unsafe int MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_MaxIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_MaxIterations) = value;
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x0600598A RID: 22922 RVA: 0x00080B20 File Offset: 0x0007ED20
		// (set) Token: 0x0600598B RID: 22923 RVA: 0x00080B63 File Offset: 0x0007ED63
		public FRigUnit_MultiFABRIK_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_MultiFABRIK_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_MultiFABRIK_WorkData(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_MultiFABRIK_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x00080B84 File Offset: 0x0007ED84
		public FRigUnit_MultiFABRIK()
		{
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x00080B8C File Offset: 0x0007ED8C
		public FRigUnit_MultiFABRIK(FName RootBone, TArray<FRigUnit_MultiFABRIK_EndEffector> Effectors, float Precision, bool bPropagateToChildren, int MaxIterations, FRigUnit_MultiFABRIK_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.RootBone = RootBone;
			this.Effectors = Effectors;
			this.Precision = Precision;
			this.bPropagateToChildren = bPropagateToChildren;
			this.MaxIterations = MaxIterations;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x00080BC9 File Offset: 0x0007EDC9
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MultiFABRIK.StaticStruct();
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x00080BD5 File Offset: 0x0007EDD5
		[NullableContext(2)]
		public FRigUnit_MultiFABRIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x00080BDF File Offset: 0x0007EDDF
		public FRigUnit_MultiFABRIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x00080BEA File Offset: 0x0007EDEA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MultiFABRIK(Pointer, false, true);
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x00080BF4 File Offset: 0x0007EDF4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MultiFABRIK(Pointer, MemoryOwner);
		}

		// Token: 0x040029F3 RID: 10739
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MultiFABRIK";

		// Token: 0x040029F4 RID: 10740
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029F5 RID: 10741
		internal static int __PropertyOffset_RootBone;

		// Token: 0x040029F6 RID: 10742
		internal static int __PropertyOffset_Effectors;

		// Token: 0x040029F7 RID: 10743
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_MultiFABRIK_EndEffector> _Effectors;

		// Token: 0x040029F8 RID: 10744
		internal static int __PropertyOffset_Precision;

		// Token: 0x040029F9 RID: 10745
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x040029FA RID: 10746
		internal static int __PropertyOffset_MaxIterations;

		// Token: 0x040029FB RID: 10747
		internal static int __PropertyOffset_WorkData;

		// Token: 0x040029FC RID: 10748
		[Nullable(2)]
		private FRigUnit_MultiFABRIK_WorkData _WorkData;
	}
}
