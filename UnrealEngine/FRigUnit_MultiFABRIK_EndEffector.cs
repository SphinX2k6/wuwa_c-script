using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000695 RID: 1685
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MultiFABRIK_EndEffector")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MultiFABRIK_EndEffector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005993 RID: 22931 RVA: 0x00080BFD File Offset: 0x0007EDFD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MultiFABRIK_EndEffector._ScriptStructPtr != 0) ? FRigUnit_MultiFABRIK_EndEffector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MultiFABRIK_EndEffector", ref FRigUnit_MultiFABRIK_EndEffector._ScriptStructPtr);
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06005994 RID: 22932 RVA: 0x00080C21 File Offset: 0x0007EE21
		// (set) Token: 0x06005995 RID: 22933 RVA: 0x00080C35 File Offset: 0x0007EE35
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK_EndEffector.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK_EndEffector.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06005996 RID: 22934 RVA: 0x00080C4A File Offset: 0x0007EE4A
		// (set) Token: 0x06005997 RID: 22935 RVA: 0x00080C5E File Offset: 0x0007EE5E
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK_EndEffector.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MultiFABRIK_EndEffector.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x06005998 RID: 22936 RVA: 0x00080C73 File Offset: 0x0007EE73
		public FRigUnit_MultiFABRIK_EndEffector()
		{
		}

		// Token: 0x06005999 RID: 22937 RVA: 0x00080C7B File Offset: 0x0007EE7B
		public FRigUnit_MultiFABRIK_EndEffector(FName Bone, FVector Location)
		{
			this.Bone = Bone;
			this.Location = Location;
		}

		// Token: 0x0600599A RID: 22938 RVA: 0x00080C91 File Offset: 0x0007EE91
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MultiFABRIK_EndEffector.StaticStruct();
		}

		// Token: 0x0600599B RID: 22939 RVA: 0x00080C9D File Offset: 0x0007EE9D
		[NullableContext(2)]
		public FRigUnit_MultiFABRIK_EndEffector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600599C RID: 22940 RVA: 0x00080CA7 File Offset: 0x0007EEA7
		public FRigUnit_MultiFABRIK_EndEffector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x00080CB2 File Offset: 0x0007EEB2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MultiFABRIK_EndEffector(Pointer, false, true);
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x00080CBC File Offset: 0x0007EEBC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MultiFABRIK_EndEffector(Pointer, MemoryOwner);
		}

		// Token: 0x040029FD RID: 10749
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_MultiFABRIK_EndEffector";

		// Token: 0x040029FE RID: 10750
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029FF RID: 10751
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002A00 RID: 10752
		internal static int __PropertyOffset_Location;
	}
}
