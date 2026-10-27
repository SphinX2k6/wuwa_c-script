using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001557 RID: 5463
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoFloatParameterChange")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FGizmoFloatParameterChange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013CDE RID: 81118 RVA: 0x001D149A File Offset: 0x001CF69A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGizmoFloatParameterChange._ScriptStructPtr != 0) ? FGizmoFloatParameterChange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/InteractiveToolsFramework.GizmoFloatParameterChange", ref FGizmoFloatParameterChange._ScriptStructPtr);
		}

		// Token: 0x17004D94 RID: 19860
		// (get) Token: 0x06013CDF RID: 81119 RVA: 0x001D14BE File Offset: 0x001CF6BE
		// (set) Token: 0x06013CE0 RID: 81120 RVA: 0x001D14CE File Offset: 0x001CF6CE
		public unsafe float InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGizmoFloatParameterChange.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGizmoFloatParameterChange.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x17004D95 RID: 19861
		// (get) Token: 0x06013CE1 RID: 81121 RVA: 0x001D14DF File Offset: 0x001CF6DF
		// (set) Token: 0x06013CE2 RID: 81122 RVA: 0x001D14EF File Offset: 0x001CF6EF
		public unsafe float CurrentValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGizmoFloatParameterChange.__PropertyOffset_CurrentValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGizmoFloatParameterChange.__PropertyOffset_CurrentValue) = value;
			}
		}

		// Token: 0x06013CE3 RID: 81123 RVA: 0x001D1500 File Offset: 0x001CF700
		public FGizmoFloatParameterChange()
		{
		}

		// Token: 0x06013CE4 RID: 81124 RVA: 0x001D1508 File Offset: 0x001CF708
		public FGizmoFloatParameterChange(float InitialValue, float CurrentValue)
		{
			this.InitialValue = InitialValue;
			this.CurrentValue = CurrentValue;
		}

		// Token: 0x06013CE5 RID: 81125 RVA: 0x001D151E File Offset: 0x001CF71E
		protected override IntPtr GetUStructPtr()
		{
			return FGizmoFloatParameterChange.StaticStruct();
		}

		// Token: 0x06013CE6 RID: 81126 RVA: 0x001D152A File Offset: 0x001CF72A
		[NullableContext(2)]
		public FGizmoFloatParameterChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013CE7 RID: 81127 RVA: 0x001D1534 File Offset: 0x001CF734
		public FGizmoFloatParameterChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013CE8 RID: 81128 RVA: 0x001D153F File Offset: 0x001CF73F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGizmoFloatParameterChange(Pointer, false, true);
		}

		// Token: 0x06013CE9 RID: 81129 RVA: 0x001D1549 File Offset: 0x001CF749
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGizmoFloatParameterChange(Pointer, MemoryOwner);
		}

		// Token: 0x0400AB6D RID: 43885
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoFloatParameterChange";

		// Token: 0x0400AB6E RID: 43886
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AB6F RID: 43887
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x0400AB70 RID: 43888
		internal static int __PropertyOffset_CurrentValue;
	}
}
