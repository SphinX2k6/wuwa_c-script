using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006FC RID: 1788
	[UnrealObjectPath("/Script/ControlRig.RigUnit_VisualDebugTransform")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_VisualDebugTransform : FRigUnit_DebugBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060060BE RID: 24766 RVA: 0x0008AC29 File Offset: 0x00088E29
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_VisualDebugTransform._ScriptStructPtr != 0) ? FRigUnit_VisualDebugTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_VisualDebugTransform", ref FRigUnit_VisualDebugTransform._ScriptStructPtr);
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x060060BF RID: 24767 RVA: 0x0008AC4D File Offset: 0x00088E4D
		// (set) Token: 0x060060C0 RID: 24768 RVA: 0x0008AC61 File Offset: 0x00088E61
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransform.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransform.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x060060C1 RID: 24769 RVA: 0x0008AC76 File Offset: 0x00088E76
		// (set) Token: 0x060060C2 RID: 24770 RVA: 0x0008AC86 File Offset: 0x00088E86
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransform.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransform.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x060060C3 RID: 24771 RVA: 0x0008AC97 File Offset: 0x00088E97
		// (set) Token: 0x060060C4 RID: 24772 RVA: 0x0008ACA7 File Offset: 0x00088EA7
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransform.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransform.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x060060C5 RID: 24773 RVA: 0x0008ACB8 File Offset: 0x00088EB8
		// (set) Token: 0x060060C6 RID: 24774 RVA: 0x0008ACC8 File Offset: 0x00088EC8
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransform.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransform.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x060060C7 RID: 24775 RVA: 0x0008ACD9 File Offset: 0x00088ED9
		// (set) Token: 0x060060C8 RID: 24776 RVA: 0x0008ACED File Offset: 0x00088EED
		public unsafe FName BoneSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransform.__PropertyOffset_BoneSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransform.__PropertyOffset_BoneSpace) = value;
			}
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x0008AD02 File Offset: 0x00088F02
		public FRigUnit_VisualDebugTransform()
		{
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x0008AD0A File Offset: 0x00088F0A
		public FRigUnit_VisualDebugTransform(FTransform Value, bool bEnabled, float Thickness, float Scale, FName BoneSpace)
		{
			this.Value = Value;
			this.bEnabled = bEnabled;
			this.Thickness = Thickness;
			this.Scale = Scale;
			this.BoneSpace = BoneSpace;
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x0008AD37 File Offset: 0x00088F37
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_VisualDebugTransform.StaticStruct();
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x0008AD43 File Offset: 0x00088F43
		[NullableContext(2)]
		public FRigUnit_VisualDebugTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x0008AD4D File Offset: 0x00088F4D
		public FRigUnit_VisualDebugTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x0008AD58 File Offset: 0x00088F58
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_VisualDebugTransform(Pointer, false, true);
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x0008AD62 File Offset: 0x00088F62
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_VisualDebugTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002D40 RID: 11584
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_VisualDebugTransform";

		// Token: 0x04002D41 RID: 11585
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D42 RID: 11586
		internal static int __PropertyOffset_Value;

		// Token: 0x04002D43 RID: 11587
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002D44 RID: 11588
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002D45 RID: 11589
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002D46 RID: 11590
		internal static int __PropertyOffset_BoneSpace;
	}
}
