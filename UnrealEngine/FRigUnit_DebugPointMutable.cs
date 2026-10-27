using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200058C RID: 1420
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugPointMutable")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FRigUnit_DebugPointMutable : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004BE1 RID: 19425 RVA: 0x000705F0 File Offset: 0x0006E7F0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugPointMutable._ScriptStructPtr != 0) ? FRigUnit_DebugPointMutable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugPointMutable", ref FRigUnit_DebugPointMutable._ScriptStructPtr);
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06004BE2 RID: 19426 RVA: 0x00070614 File Offset: 0x0006E814
		// (set) Token: 0x06004BE3 RID: 19427 RVA: 0x00070628 File Offset: 0x0006E828
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06004BE4 RID: 19428 RVA: 0x0007063D File Offset: 0x0006E83D
		// (set) Token: 0x06004BE5 RID: 19429 RVA: 0x0007064D File Offset: 0x0006E84D
		public unsafe ERigUnitDebugPointMode Mode
		{
			get
			{
				return (ERigUnitDebugPointMode)(*(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x0007065E File Offset: 0x0006E85E
		// (set) Token: 0x06004BE7 RID: 19431 RVA: 0x00070672 File Offset: 0x0006E872
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x00070687 File Offset: 0x0006E887
		// (set) Token: 0x06004BE9 RID: 19433 RVA: 0x00070697 File Offset: 0x0006E897
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06004BEA RID: 19434 RVA: 0x000706A8 File Offset: 0x0006E8A8
		// (set) Token: 0x06004BEB RID: 19435 RVA: 0x000706B8 File Offset: 0x0006E8B8
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06004BEC RID: 19436 RVA: 0x000706C9 File Offset: 0x0006E8C9
		// (set) Token: 0x06004BED RID: 19437 RVA: 0x000706DD File Offset: 0x0006E8DD
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06004BEE RID: 19438 RVA: 0x000706F2 File Offset: 0x0006E8F2
		// (set) Token: 0x06004BEF RID: 19439 RVA: 0x00070706 File Offset: 0x0006E906
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x0007071B File Offset: 0x0006E91B
		// (set) Token: 0x06004BF1 RID: 19441 RVA: 0x0007072B File Offset: 0x0006E92B
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPointMutable.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x0007073C File Offset: 0x0006E93C
		public FRigUnit_DebugPointMutable()
		{
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x00070744 File Offset: 0x0006E944
		[NullableContext(1)]
		public FRigUnit_DebugPointMutable(FVector Vector, ERigUnitDebugPointMode Mode, FLinearColor Color, float Scale, float Thickness, FName Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
		{
			this.Vector = Vector;
			this.Mode = Mode;
			this.Color = Color;
			this.Scale = Scale;
			this.Thickness = Thickness;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x0007079C File Offset: 0x0006E99C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugPointMutable.StaticStruct();
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x000707A8 File Offset: 0x0006E9A8
		[NullableContext(2)]
		public FRigUnit_DebugPointMutable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x000707B2 File Offset: 0x0006E9B2
		public FRigUnit_DebugPointMutable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x000707BD File Offset: 0x0006E9BD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugPointMutable(Pointer, false, true);
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x000707C7 File Offset: 0x0006E9C7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugPointMutable(Pointer, MemoryOwner);
		}

		// Token: 0x040024BE RID: 9406
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugPointMutable";

		// Token: 0x040024BF RID: 9407
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040024C0 RID: 9408
		internal static int __PropertyOffset_Vector;

		// Token: 0x040024C1 RID: 9409
		internal static int __PropertyOffset_Mode;

		// Token: 0x040024C2 RID: 9410
		internal static int __PropertyOffset_Color;

		// Token: 0x040024C3 RID: 9411
		internal static int __PropertyOffset_Scale;

		// Token: 0x040024C4 RID: 9412
		internal static int __PropertyOffset_Thickness;

		// Token: 0x040024C5 RID: 9413
		internal static int __PropertyOffset_Space;

		// Token: 0x040024C6 RID: 9414
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x040024C7 RID: 9415
		internal static int __PropertyOffset_bEnabled;
	}
}
