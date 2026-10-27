using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200178A RID: 6026
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainOfflineWindFrame")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FJacobiChainOfflineWindFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015AE5 RID: 88805 RVA: 0x001FDD63 File Offset: 0x001FBF63
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainOfflineWindFrame._ScriptStructPtr != 0) ? FJacobiChainOfflineWindFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainOfflineWindFrame", ref FJacobiChainOfflineWindFrame._ScriptStructPtr);
		}

		// Token: 0x170055B8 RID: 21944
		// (get) Token: 0x06015AE6 RID: 88806 RVA: 0x001FDD88 File Offset: 0x001FBF88
		// (set) Token: 0x06015AE7 RID: 88807 RVA: 0x001FDDCB File Offset: 0x001FBFCB
		public TArray<FVector> ParticleOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._ParticleOffsets) == null)
				{
					result = (this._ParticleOffsets = new TArray<FVector>(base.NativePtr + (IntPtr)FJacobiChainOfflineWindFrame.__PropertyOffset_ParticleOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParticleOffsets.CopyAssign(value);
			}
		}

		// Token: 0x170055B9 RID: 21945
		// (get) Token: 0x06015AE8 RID: 88808 RVA: 0x001FDDDC File Offset: 0x001FBFDC
		// (set) Token: 0x06015AE9 RID: 88809 RVA: 0x001FDE1F File Offset: 0x001FC01F
		public TArray<FQuat> RigidRotationDeltas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._RigidRotationDeltas) == null)
				{
					result = (this._RigidRotationDeltas = new TArray<FQuat>(base.NativePtr + (IntPtr)FJacobiChainOfflineWindFrame.__PropertyOffset_RigidRotationDeltas, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RigidRotationDeltas.CopyAssign(value);
			}
		}

		// Token: 0x06015AEA RID: 88810 RVA: 0x001FDE2D File Offset: 0x001FC02D
		public FJacobiChainOfflineWindFrame()
		{
		}

		// Token: 0x06015AEB RID: 88811 RVA: 0x001FDE35 File Offset: 0x001FC035
		public FJacobiChainOfflineWindFrame(TArray<FVector> ParticleOffsets, TArray<FQuat> RigidRotationDeltas)
		{
			this.ParticleOffsets = ParticleOffsets;
			this.RigidRotationDeltas = RigidRotationDeltas;
		}

		// Token: 0x06015AEC RID: 88812 RVA: 0x001FDE4B File Offset: 0x001FC04B
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainOfflineWindFrame.StaticStruct();
		}

		// Token: 0x06015AED RID: 88813 RVA: 0x001FDE57 File Offset: 0x001FC057
		[NullableContext(2)]
		public FJacobiChainOfflineWindFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015AEE RID: 88814 RVA: 0x001FDE61 File Offset: 0x001FC061
		public FJacobiChainOfflineWindFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015AEF RID: 88815 RVA: 0x001FDE6C File Offset: 0x001FC06C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainOfflineWindFrame(Pointer, false, true);
		}

		// Token: 0x06015AF0 RID: 88816 RVA: 0x001FDE76 File Offset: 0x001FC076
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainOfflineWindFrame(Pointer, MemoryOwner);
		}

		// Token: 0x0400BD62 RID: 48482
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainOfflineWindFrame";

		// Token: 0x0400BD63 RID: 48483
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BD64 RID: 48484
		internal static int __PropertyOffset_ParticleOffsets;

		// Token: 0x0400BD65 RID: 48485
		[Nullable(2)]
		private TArray<FVector> _ParticleOffsets;

		// Token: 0x0400BD66 RID: 48486
		internal static int __PropertyOffset_RigidRotationDeltas;

		// Token: 0x0400BD67 RID: 48487
		[Nullable(2)]
		private TArray<FQuat> _RigidRotationDeltas;
	}
}
