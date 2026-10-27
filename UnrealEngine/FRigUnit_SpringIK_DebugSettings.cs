using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006DB RID: 1755
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SpringIK_DebugSettings")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRigUnit_SpringIK_DebugSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005E2A RID: 24106 RVA: 0x00087268 File Offset: 0x00085468
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SpringIK_DebugSettings._ScriptStructPtr != 0) ? FRigUnit_SpringIK_DebugSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SpringIK_DebugSettings", ref FRigUnit_SpringIK_DebugSettings._ScriptStructPtr);
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06005E2B RID: 24107 RVA: 0x0008728C File Offset: 0x0008548C
		// (set) Token: 0x06005E2C RID: 24108 RVA: 0x0008729C File Offset: 0x0008549C
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK_DebugSettings.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK_DebugSettings.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06005E2D RID: 24109 RVA: 0x000872AD File Offset: 0x000854AD
		// (set) Token: 0x06005E2E RID: 24110 RVA: 0x000872BD File Offset: 0x000854BD
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK_DebugSettings.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK_DebugSettings.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06005E2F RID: 24111 RVA: 0x000872CE File Offset: 0x000854CE
		// (set) Token: 0x06005E30 RID: 24112 RVA: 0x000872E2 File Offset: 0x000854E2
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK_DebugSettings.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK_DebugSettings.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06005E31 RID: 24113 RVA: 0x000872F7 File Offset: 0x000854F7
		// (set) Token: 0x06005E32 RID: 24114 RVA: 0x0008730B File Offset: 0x0008550B
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK_DebugSettings.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK_DebugSettings.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x00087320 File Offset: 0x00085520
		public FRigUnit_SpringIK_DebugSettings()
		{
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x00087328 File Offset: 0x00085528
		public FRigUnit_SpringIK_DebugSettings(bool bEnabled, float Scale, FLinearColor Color, FTransform WorldOffset)
		{
			this.bEnabled = bEnabled;
			this.Scale = Scale;
			this.Color = Color;
			this.WorldOffset = WorldOffset;
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x0008734D File Offset: 0x0008554D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SpringIK_DebugSettings.StaticStruct();
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x00087359 File Offset: 0x00085559
		[NullableContext(2)]
		public FRigUnit_SpringIK_DebugSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00087363 File Offset: 0x00085563
		public FRigUnit_SpringIK_DebugSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x0008736E File Offset: 0x0008556E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SpringIK_DebugSettings(Pointer, false, true);
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x00087378 File Offset: 0x00085578
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SpringIK_DebugSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04002C10 RID: 11280
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_SpringIK_DebugSettings";

		// Token: 0x04002C11 RID: 11281
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C12 RID: 11282
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002C13 RID: 11283
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002C14 RID: 11284
		internal static int __PropertyOffset_Color;

		// Token: 0x04002C15 RID: 11285
		internal static int __PropertyOffset_WorldOffset;
	}
}
