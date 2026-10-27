using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001112 RID: 4370
	[UnrealObjectPath("/Script/Engine.SkinWeightProfileManagerTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSkinWeightProfileManagerTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FE52 RID: 65106 RVA: 0x001775D5 File Offset: 0x001757D5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkinWeightProfileManagerTickFunction._ScriptStructPtr != 0) ? FSkinWeightProfileManagerTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkinWeightProfileManagerTickFunction", ref FSkinWeightProfileManagerTickFunction._ScriptStructPtr);
		}

		// Token: 0x0600FE53 RID: 65107 RVA: 0x001775F9 File Offset: 0x001757F9
		public FSkinWeightProfileManagerTickFunction()
		{
		}

		// Token: 0x0600FE54 RID: 65108 RVA: 0x00177601 File Offset: 0x00175801
		public FSkinWeightProfileManagerTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x0600FE55 RID: 65109 RVA: 0x0017763E File Offset: 0x0017583E
		protected override IntPtr GetUStructPtr()
		{
			return FSkinWeightProfileManagerTickFunction.StaticStruct();
		}

		// Token: 0x0600FE56 RID: 65110 RVA: 0x0017764A File Offset: 0x0017584A
		[NullableContext(2)]
		public FSkinWeightProfileManagerTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FE57 RID: 65111 RVA: 0x00177654 File Offset: 0x00175854
		public FSkinWeightProfileManagerTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FE58 RID: 65112 RVA: 0x0017765F File Offset: 0x0017585F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkinWeightProfileManagerTickFunction(Pointer, false, true);
		}

		// Token: 0x0600FE59 RID: 65113 RVA: 0x00177669 File Offset: 0x00175869
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkinWeightProfileManagerTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04008900 RID: 35072
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkinWeightProfileManagerTickFunction";

		// Token: 0x04008901 RID: 35073
		private static IntPtr _ScriptStructPtr;
	}
}
