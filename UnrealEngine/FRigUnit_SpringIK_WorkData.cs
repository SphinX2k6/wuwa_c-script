using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006DC RID: 1756
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SpringIK_WorkData")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRigUnit_SpringIK_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005E3A RID: 24122 RVA: 0x00087381 File Offset: 0x00085581
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SpringIK_WorkData._ScriptStructPtr != 0) ? FRigUnit_SpringIK_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SpringIK_WorkData", ref FRigUnit_SpringIK_WorkData._ScriptStructPtr);
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06005E3B RID: 24123 RVA: 0x000873A8 File Offset: 0x000855A8
		// (set) Token: 0x06005E3C RID: 24124 RVA: 0x000873EB File Offset: 0x000855EB
		public TArray<FCachedRigElement> BoneIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._BoneIndices) == null)
				{
					result = (this._BoneIndices = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_SpringIK_WorkData.__PropertyOffset_BoneIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneIndices.CopyAssign(value);
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06005E3D RID: 24125 RVA: 0x000873FC File Offset: 0x000855FC
		// (set) Token: 0x06005E3E RID: 24126 RVA: 0x0008743F File Offset: 0x0008563F
		public FCachedRigElement CachedPoleVector
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedPoleVector) == null)
				{
					result = (this._CachedPoleVector = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SpringIK_WorkData.__PropertyOffset_CachedPoleVector, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SpringIK_WorkData.__PropertyOffset_CachedPoleVector, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06005E3F RID: 24127 RVA: 0x00087460 File Offset: 0x00085660
		// (set) Token: 0x06005E40 RID: 24128 RVA: 0x000874A3 File Offset: 0x000856A3
		public TArray<FTransform> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRigUnit_SpringIK_WorkData.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06005E41 RID: 24129 RVA: 0x000874B4 File Offset: 0x000856B4
		// (set) Token: 0x06005E42 RID: 24130 RVA: 0x000874F7 File Offset: 0x000856F7
		public FCRSimPointContainer Simulation
		{
			get
			{
				base.FastCheckIsValid();
				FCRSimPointContainer result;
				if ((result = this._Simulation) == null)
				{
					result = (this._Simulation = new FCRSimPointContainer(base.NativePtr + (IntPtr)FRigUnit_SpringIK_WorkData.__PropertyOffset_Simulation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCRSimPointContainer.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SpringIK_WorkData.__PropertyOffset_Simulation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x00087518 File Offset: 0x00085718
		public FRigUnit_SpringIK_WorkData()
		{
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x00087520 File Offset: 0x00085720
		public FRigUnit_SpringIK_WorkData(TArray<FCachedRigElement> BoneIndices, FCachedRigElement CachedPoleVector, TArray<FTransform> Transforms, FCRSimPointContainer Simulation)
		{
			this.BoneIndices = BoneIndices;
			this.CachedPoleVector = CachedPoleVector;
			this.Transforms = Transforms;
			this.Simulation = Simulation;
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x00087545 File Offset: 0x00085745
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SpringIK_WorkData.StaticStruct();
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x00087551 File Offset: 0x00085751
		[NullableContext(2)]
		public FRigUnit_SpringIK_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x0008755B File Offset: 0x0008575B
		public FRigUnit_SpringIK_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x00087566 File Offset: 0x00085766
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SpringIK_WorkData(Pointer, false, true);
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x00087570 File Offset: 0x00085770
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SpringIK_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002C16 RID: 11286
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_SpringIK_WorkData";

		// Token: 0x04002C17 RID: 11287
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C18 RID: 11288
		internal static int __PropertyOffset_BoneIndices;

		// Token: 0x04002C19 RID: 11289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _BoneIndices;

		// Token: 0x04002C1A RID: 11290
		internal static int __PropertyOffset_CachedPoleVector;

		// Token: 0x04002C1B RID: 11291
		[Nullable(2)]
		private FCachedRigElement _CachedPoleVector;

		// Token: 0x04002C1C RID: 11292
		internal static int __PropertyOffset_Transforms;

		// Token: 0x04002C1D RID: 11293
		[Nullable(2)]
		private TArray<FTransform> _Transforms;

		// Token: 0x04002C1E RID: 11294
		internal static int __PropertyOffset_Simulation;

		// Token: 0x04002C1F RID: 11295
		[Nullable(2)]
		private FCRSimPointContainer _Simulation;
	}
}
