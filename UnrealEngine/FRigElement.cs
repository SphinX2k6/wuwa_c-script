using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200051E RID: 1310
	[UnrealObjectPath("/Script/ControlRig.RigElement")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060044B8 RID: 17592 RVA: 0x000665A2 File Offset: 0x000647A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigElement._ScriptStructPtr != 0) ? FRigElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigElement", ref FRigElement._ScriptStructPtr);
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x060044B9 RID: 17593 RVA: 0x000665C6 File Offset: 0x000647C6
		// (set) Token: 0x060044BA RID: 17594 RVA: 0x000665DA File Offset: 0x000647DA
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigElement.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigElement.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x060044BB RID: 17595 RVA: 0x000665EF File Offset: 0x000647EF
		// (set) Token: 0x060044BC RID: 17596 RVA: 0x000665FF File Offset: 0x000647FF
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigElement.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigElement.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x00066610 File Offset: 0x00064810
		public FRigElement()
		{
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x00066618 File Offset: 0x00064818
		public FRigElement(FName Name, int Index)
		{
			this.Name = Name;
			this.Index = Index;
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x0006662E File Offset: 0x0006482E
		protected override IntPtr GetUStructPtr()
		{
			return FRigElement.StaticStruct();
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x0006663A File Offset: 0x0006483A
		[NullableContext(2)]
		public FRigElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x00066644 File Offset: 0x00064844
		public FRigElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x0006664F File Offset: 0x0006484F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigElement(Pointer, false, true);
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x00066659 File Offset: 0x00064859
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigElement(Pointer, MemoryOwner);
		}

		// Token: 0x0400217D RID: 8573
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigElement";

		// Token: 0x0400217E RID: 8574
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400217F RID: 8575
		internal static int __PropertyOffset_Name;

		// Token: 0x04002180 RID: 8576
		internal static int __PropertyOffset_Index;
	}
}
