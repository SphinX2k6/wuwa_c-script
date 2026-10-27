using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A6 RID: 1702
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_PointSimulation_WorkData")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FRigUnit_PointSimulation_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005AA1 RID: 23201 RVA: 0x0008224C File Offset: 0x0008044C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_PointSimulation_WorkData._ScriptStructPtr != 0) ? FRigUnit_PointSimulation_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_PointSimulation_WorkData", ref FRigUnit_PointSimulation_WorkData._ScriptStructPtr);
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06005AA2 RID: 23202 RVA: 0x00082270 File Offset: 0x00080470
		// (set) Token: 0x06005AA3 RID: 23203 RVA: 0x000822B3 File Offset: 0x000804B3
		public FCRSimPointContainer Simulation
		{
			get
			{
				base.FastCheckIsValid();
				FCRSimPointContainer result;
				if ((result = this._Simulation) == null)
				{
					result = (this._Simulation = new FCRSimPointContainer(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_WorkData.__PropertyOffset_Simulation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCRSimPointContainer.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_PointSimulation_WorkData.__PropertyOffset_Simulation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06005AA4 RID: 23204 RVA: 0x000822D4 File Offset: 0x000804D4
		// (set) Token: 0x06005AA5 RID: 23205 RVA: 0x00082317 File Offset: 0x00080517
		public TArray<FCachedRigElement> BoneIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._BoneIndices) == null)
				{
					result = (this._BoneIndices = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_PointSimulation_WorkData.__PropertyOffset_BoneIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneIndices.CopyAssign(value);
			}
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x00082325 File Offset: 0x00080525
		public FRigUnit_PointSimulation_WorkData()
		{
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x0008232D File Offset: 0x0008052D
		public FRigUnit_PointSimulation_WorkData(FCRSimPointContainer Simulation, TArray<FCachedRigElement> BoneIndices)
		{
			this.Simulation = Simulation;
			this.BoneIndices = BoneIndices;
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x00082343 File Offset: 0x00080543
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_PointSimulation_WorkData.StaticStruct();
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x0008234F File Offset: 0x0008054F
		[NullableContext(2)]
		public FRigUnit_PointSimulation_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x00082359 File Offset: 0x00080559
		public FRigUnit_PointSimulation_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x00082364 File Offset: 0x00080564
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_PointSimulation_WorkData(Pointer, false, true);
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x0008236E File Offset: 0x0008056E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_PointSimulation_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002A71 RID: 10865
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_PointSimulation_WorkData";

		// Token: 0x04002A72 RID: 10866
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A73 RID: 10867
		internal static int __PropertyOffset_Simulation;

		// Token: 0x04002A74 RID: 10868
		[Nullable(2)]
		private FCRSimPointContainer _Simulation;

		// Token: 0x04002A75 RID: 10869
		internal static int __PropertyOffset_BoneIndices;

		// Token: 0x04002A76 RID: 10870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _BoneIndices;
	}
}
