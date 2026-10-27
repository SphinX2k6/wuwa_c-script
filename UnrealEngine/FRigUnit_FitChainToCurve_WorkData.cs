using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005AC RID: 1452
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_FitChainToCurve_WorkData")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FRigUnit_FitChainToCurve_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004E2D RID: 20013 RVA: 0x00073792 File Offset: 0x00071992
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_FitChainToCurve_WorkData._ScriptStructPtr != 0) ? FRigUnit_FitChainToCurve_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_FitChainToCurve_WorkData", ref FRigUnit_FitChainToCurve_WorkData._ScriptStructPtr);
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x000737B6 File Offset: 0x000719B6
		// (set) Token: 0x06004E2F RID: 20015 RVA: 0x000737C6 File Offset: 0x000719C6
		public unsafe float ChainLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_ChainLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_ChainLength) = value;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06004E30 RID: 20016 RVA: 0x000737D8 File Offset: 0x000719D8
		// (set) Token: 0x06004E31 RID: 20017 RVA: 0x0007381B File Offset: 0x00071A1B
		public TArray<FVector> ItemPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._ItemPositions) == null)
				{
					result = (this._ItemPositions = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_ItemPositions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemPositions.CopyAssign(value);
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06004E32 RID: 20018 RVA: 0x0007382C File Offset: 0x00071A2C
		// (set) Token: 0x06004E33 RID: 20019 RVA: 0x0007386F File Offset: 0x00071A6F
		public TArray<float> ItemSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ItemSegments) == null)
				{
					result = (this._ItemSegments = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_ItemSegments, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemSegments.CopyAssign(value);
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06004E34 RID: 20020 RVA: 0x00073880 File Offset: 0x00071A80
		// (set) Token: 0x06004E35 RID: 20021 RVA: 0x000738C3 File Offset: 0x00071AC3
		public TArray<FVector> CurvePositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._CurvePositions) == null)
				{
					result = (this._CurvePositions = new TArray<FVector>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_CurvePositions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CurvePositions.CopyAssign(value);
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06004E36 RID: 20022 RVA: 0x000738D4 File Offset: 0x00071AD4
		// (set) Token: 0x06004E37 RID: 20023 RVA: 0x00073917 File Offset: 0x00071B17
		public TArray<float> CurveSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CurveSegments) == null)
				{
					result = (this._CurveSegments = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_CurveSegments, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CurveSegments.CopyAssign(value);
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06004E38 RID: 20024 RVA: 0x00073928 File Offset: 0x00071B28
		// (set) Token: 0x06004E39 RID: 20025 RVA: 0x0007396B File Offset: 0x00071B6B
		public TArray<FCachedRigElement> CachedItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedItems) == null)
				{
					result = (this._CachedItems = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_CachedItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedItems.CopyAssign(value);
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06004E3A RID: 20026 RVA: 0x0007397C File Offset: 0x00071B7C
		// (set) Token: 0x06004E3B RID: 20027 RVA: 0x000739BF File Offset: 0x00071BBF
		public TArray<int> ItemRotationA
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ItemRotationA) == null)
				{
					result = (this._ItemRotationA = new TArray<int>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_ItemRotationA, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemRotationA.CopyAssign(value);
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x000739D0 File Offset: 0x00071BD0
		// (set) Token: 0x06004E3D RID: 20029 RVA: 0x00073A13 File Offset: 0x00071C13
		public TArray<int> ItemRotationB
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ItemRotationB) == null)
				{
					result = (this._ItemRotationB = new TArray<int>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_ItemRotationB, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemRotationB.CopyAssign(value);
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06004E3E RID: 20030 RVA: 0x00073A24 File Offset: 0x00071C24
		// (set) Token: 0x06004E3F RID: 20031 RVA: 0x00073A67 File Offset: 0x00071C67
		public TArray<float> ItemRotationT
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ItemRotationT) == null)
				{
					result = (this._ItemRotationT = new TArray<float>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_ItemRotationT, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemRotationT.CopyAssign(value);
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06004E40 RID: 20032 RVA: 0x00073A78 File Offset: 0x00071C78
		// (set) Token: 0x06004E41 RID: 20033 RVA: 0x00073ABB File Offset: 0x00071CBB
		public TArray<FTransform> ItemLocalTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._ItemLocalTransforms) == null)
				{
					result = (this._ItemLocalTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_WorkData.__PropertyOffset_ItemLocalTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ItemLocalTransforms.CopyAssign(value);
			}
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x00073AC9 File Offset: 0x00071CC9
		public FRigUnit_FitChainToCurve_WorkData()
		{
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x00073AD4 File Offset: 0x00071CD4
		public FRigUnit_FitChainToCurve_WorkData(float ChainLength, TArray<FVector> ItemPositions, TArray<float> ItemSegments, TArray<FVector> CurvePositions, TArray<float> CurveSegments, TArray<FCachedRigElement> CachedItems, TArray<int> ItemRotationA, TArray<int> ItemRotationB, TArray<float> ItemRotationT, TArray<FTransform> ItemLocalTransforms)
		{
			this.ChainLength = ChainLength;
			this.ItemPositions = ItemPositions;
			this.ItemSegments = ItemSegments;
			this.CurvePositions = CurvePositions;
			this.CurveSegments = CurveSegments;
			this.CachedItems = CachedItems;
			this.ItemRotationA = ItemRotationA;
			this.ItemRotationB = ItemRotationB;
			this.ItemRotationT = ItemRotationT;
			this.ItemLocalTransforms = ItemLocalTransforms;
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x00073B34 File Offset: 0x00071D34
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_FitChainToCurve_WorkData.StaticStruct();
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x00073B40 File Offset: 0x00071D40
		[NullableContext(2)]
		public FRigUnit_FitChainToCurve_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x00073B4A File Offset: 0x00071D4A
		public FRigUnit_FitChainToCurve_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x00073B55 File Offset: 0x00071D55
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_FitChainToCurve_WorkData(Pointer, false, true);
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x00073B5F File Offset: 0x00071D5F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_FitChainToCurve_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x040025C2 RID: 9666
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_FitChainToCurve_WorkData";

		// Token: 0x040025C3 RID: 9667
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040025C4 RID: 9668
		internal static int __PropertyOffset_ChainLength;

		// Token: 0x040025C5 RID: 9669
		internal static int __PropertyOffset_ItemPositions;

		// Token: 0x040025C6 RID: 9670
		[Nullable(2)]
		private TArray<FVector> _ItemPositions;

		// Token: 0x040025C7 RID: 9671
		internal static int __PropertyOffset_ItemSegments;

		// Token: 0x040025C8 RID: 9672
		[Nullable(2)]
		private TArray<float> _ItemSegments;

		// Token: 0x040025C9 RID: 9673
		internal static int __PropertyOffset_CurvePositions;

		// Token: 0x040025CA RID: 9674
		[Nullable(2)]
		private TArray<FVector> _CurvePositions;

		// Token: 0x040025CB RID: 9675
		internal static int __PropertyOffset_CurveSegments;

		// Token: 0x040025CC RID: 9676
		[Nullable(2)]
		private TArray<float> _CurveSegments;

		// Token: 0x040025CD RID: 9677
		internal static int __PropertyOffset_CachedItems;

		// Token: 0x040025CE RID: 9678
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedItems;

		// Token: 0x040025CF RID: 9679
		internal static int __PropertyOffset_ItemRotationA;

		// Token: 0x040025D0 RID: 9680
		[Nullable(2)]
		private TArray<int> _ItemRotationA;

		// Token: 0x040025D1 RID: 9681
		internal static int __PropertyOffset_ItemRotationB;

		// Token: 0x040025D2 RID: 9682
		[Nullable(2)]
		private TArray<int> _ItemRotationB;

		// Token: 0x040025D3 RID: 9683
		internal static int __PropertyOffset_ItemRotationT;

		// Token: 0x040025D4 RID: 9684
		[Nullable(2)]
		private TArray<float> _ItemRotationT;

		// Token: 0x040025D5 RID: 9685
		internal static int __PropertyOffset_ItemLocalTransforms;

		// Token: 0x040025D6 RID: 9686
		[Nullable(2)]
		private TArray<FTransform> _ItemLocalTransforms;
	}
}
