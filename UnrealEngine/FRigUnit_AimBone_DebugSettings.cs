using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000541 RID: 1345
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AimBone_DebugSettings")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_AimBone_DebugSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060046CA RID: 18122 RVA: 0x000691D8 File Offset: 0x000673D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AimBone_DebugSettings._ScriptStructPtr != 0) ? FRigUnit_AimBone_DebugSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AimBone_DebugSettings", ref FRigUnit_AimBone_DebugSettings._ScriptStructPtr);
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x060046CB RID: 18123 RVA: 0x000691FC File Offset: 0x000673FC
		// (set) Token: 0x060046CC RID: 18124 RVA: 0x0006920C File Offset: 0x0006740C
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBone_DebugSettings.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone_DebugSettings.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x0006921D File Offset: 0x0006741D
		// (set) Token: 0x060046CE RID: 18126 RVA: 0x0006922D File Offset: 0x0006742D
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBone_DebugSettings.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone_DebugSettings.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x0006923E File Offset: 0x0006743E
		// (set) Token: 0x060046D0 RID: 18128 RVA: 0x00069252 File Offset: 0x00067452
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBone_DebugSettings.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone_DebugSettings.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x00069267 File Offset: 0x00067467
		public FRigUnit_AimBone_DebugSettings()
		{
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x0006926F File Offset: 0x0006746F
		public FRigUnit_AimBone_DebugSettings(bool bEnabled, float Scale, FTransform WorldOffset)
		{
			this.bEnabled = bEnabled;
			this.Scale = Scale;
			this.WorldOffset = WorldOffset;
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x0006928C File Offset: 0x0006748C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AimBone_DebugSettings.StaticStruct();
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x00069298 File Offset: 0x00067498
		[NullableContext(2)]
		public FRigUnit_AimBone_DebugSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x000692A2 File Offset: 0x000674A2
		public FRigUnit_AimBone_DebugSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x000692AD File Offset: 0x000674AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AimBone_DebugSettings(Pointer, false, true);
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x000692B7 File Offset: 0x000674B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AimBone_DebugSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04002264 RID: 8804
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_AimBone_DebugSettings";

		// Token: 0x04002265 RID: 8805
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002266 RID: 8806
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002267 RID: 8807
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002268 RID: 8808
		internal static int __PropertyOffset_WorldOffset;
	}
}
