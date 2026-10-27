using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000556 RID: 1366
	[UnrealObjectPath("/Script/ControlRig.RigUnit_BoneHarmonics_BoneTarget")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_BoneHarmonics_BoneTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600484B RID: 18507 RVA: 0x0006B338 File Offset: 0x00069538
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_BoneHarmonics_BoneTarget._ScriptStructPtr != 0) ? FRigUnit_BoneHarmonics_BoneTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_BoneHarmonics_BoneTarget", ref FRigUnit_BoneHarmonics_BoneTarget._ScriptStructPtr);
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x0600484C RID: 18508 RVA: 0x0006B35C File Offset: 0x0006955C
		// (set) Token: 0x0600484D RID: 18509 RVA: 0x0006B370 File Offset: 0x00069570
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics_BoneTarget.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics_BoneTarget.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x0600484E RID: 18510 RVA: 0x0006B385 File Offset: 0x00069585
		// (set) Token: 0x0600484F RID: 18511 RVA: 0x0006B395 File Offset: 0x00069595
		public unsafe float Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics_BoneTarget.__PropertyOffset_Ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneHarmonics_BoneTarget.__PropertyOffset_Ratio) = value;
			}
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x0006B3A6 File Offset: 0x000695A6
		public FRigUnit_BoneHarmonics_BoneTarget()
		{
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x0006B3AE File Offset: 0x000695AE
		public FRigUnit_BoneHarmonics_BoneTarget(FName Bone, float Ratio)
		{
			this.Bone = Bone;
			this.Ratio = Ratio;
		}

		// Token: 0x06004852 RID: 18514 RVA: 0x0006B3C4 File Offset: 0x000695C4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_BoneHarmonics_BoneTarget.StaticStruct();
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x0006B3D0 File Offset: 0x000695D0
		[NullableContext(2)]
		public FRigUnit_BoneHarmonics_BoneTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x0006B3DA File Offset: 0x000695DA
		public FRigUnit_BoneHarmonics_BoneTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x0006B3E5 File Offset: 0x000695E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_BoneHarmonics_BoneTarget(Pointer, false, true);
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x0006B3EF File Offset: 0x000695EF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_BoneHarmonics_BoneTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04002314 RID: 8980
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_BoneHarmonics_BoneTarget";

		// Token: 0x04002315 RID: 8981
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002316 RID: 8982
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002317 RID: 8983
		internal static int __PropertyOffset_Ratio;
	}
}
