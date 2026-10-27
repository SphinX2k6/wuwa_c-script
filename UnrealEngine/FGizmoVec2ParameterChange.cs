using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001569 RID: 5481
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoVec2ParameterChange")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FGizmoVec2ParameterChange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013DA4 RID: 81316 RVA: 0x001D2736 File Offset: 0x001D0936
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGizmoVec2ParameterChange._ScriptStructPtr != 0) ? FGizmoVec2ParameterChange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/InteractiveToolsFramework.GizmoVec2ParameterChange", ref FGizmoVec2ParameterChange._ScriptStructPtr);
		}

		// Token: 0x17004DC8 RID: 19912
		// (get) Token: 0x06013DA5 RID: 81317 RVA: 0x001D275A File Offset: 0x001D095A
		// (set) Token: 0x06013DA6 RID: 81318 RVA: 0x001D276E File Offset: 0x001D096E
		public unsafe FVector2D InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGizmoVec2ParameterChange.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGizmoVec2ParameterChange.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x17004DC9 RID: 19913
		// (get) Token: 0x06013DA7 RID: 81319 RVA: 0x001D2783 File Offset: 0x001D0983
		// (set) Token: 0x06013DA8 RID: 81320 RVA: 0x001D2797 File Offset: 0x001D0997
		public unsafe FVector2D CurrentValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGizmoVec2ParameterChange.__PropertyOffset_CurrentValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGizmoVec2ParameterChange.__PropertyOffset_CurrentValue) = value;
			}
		}

		// Token: 0x06013DA9 RID: 81321 RVA: 0x001D27AC File Offset: 0x001D09AC
		public FGizmoVec2ParameterChange()
		{
		}

		// Token: 0x06013DAA RID: 81322 RVA: 0x001D27B4 File Offset: 0x001D09B4
		public FGizmoVec2ParameterChange(FVector2D InitialValue, FVector2D CurrentValue)
		{
			this.InitialValue = InitialValue;
			this.CurrentValue = CurrentValue;
		}

		// Token: 0x06013DAB RID: 81323 RVA: 0x001D27CA File Offset: 0x001D09CA
		protected override IntPtr GetUStructPtr()
		{
			return FGizmoVec2ParameterChange.StaticStruct();
		}

		// Token: 0x06013DAC RID: 81324 RVA: 0x001D27D6 File Offset: 0x001D09D6
		[NullableContext(2)]
		public FGizmoVec2ParameterChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013DAD RID: 81325 RVA: 0x001D27E0 File Offset: 0x001D09E0
		public FGizmoVec2ParameterChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013DAE RID: 81326 RVA: 0x001D27EB File Offset: 0x001D09EB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGizmoVec2ParameterChange(Pointer, false, true);
		}

		// Token: 0x06013DAF RID: 81327 RVA: 0x001D27F5 File Offset: 0x001D09F5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGizmoVec2ParameterChange(Pointer, MemoryOwner);
		}

		// Token: 0x0400ABDA RID: 43994
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoVec2ParameterChange";

		// Token: 0x0400ABDB RID: 43995
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ABDC RID: 43996
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x0400ABDD RID: 43997
		internal static int __PropertyOffset_CurrentValue;
	}
}
