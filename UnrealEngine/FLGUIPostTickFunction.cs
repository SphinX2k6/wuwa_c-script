using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020AD RID: 8365
	[UnrealObjectPath("/Script/LGUI.LGUIPostTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLGUIPostTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F87C RID: 129148 RVA: 0x002EDF74 File Offset: 0x002EC174
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIPostTickFunction._ScriptStructPtr != 0) ? FLGUIPostTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIPostTickFunction", ref FLGUIPostTickFunction._ScriptStructPtr);
		}

		// Token: 0x0601F87D RID: 129149 RVA: 0x002EDF98 File Offset: 0x002EC198
		public FLGUIPostTickFunction()
		{
		}

		// Token: 0x0601F87E RID: 129150 RVA: 0x002EDFA0 File Offset: 0x002EC1A0
		public FLGUIPostTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x0601F87F RID: 129151 RVA: 0x002EDFDD File Offset: 0x002EC1DD
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIPostTickFunction.StaticStruct();
		}

		// Token: 0x0601F880 RID: 129152 RVA: 0x002EDFE9 File Offset: 0x002EC1E9
		[NullableContext(2)]
		public FLGUIPostTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F881 RID: 129153 RVA: 0x002EDFF3 File Offset: 0x002EC1F3
		public FLGUIPostTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F882 RID: 129154 RVA: 0x002EDFFE File Offset: 0x002EC1FE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIPostTickFunction(Pointer, false, true);
		}

		// Token: 0x0601F883 RID: 129155 RVA: 0x002EE008 File Offset: 0x002EC208
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIPostTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04011054 RID: 69716
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPostTickFunction";

		// Token: 0x04011055 RID: 69717
		private static IntPtr _ScriptStructPtr;
	}
}
