using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027EC RID: 10220
	[UnrealObjectPath("/Script/SlateCore.CaptureLostEvent")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FCaptureLostEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602617E RID: 156030 RVA: 0x0039C810 File Offset: 0x0039AA10
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCaptureLostEvent._ScriptStructPtr != 0) ? FCaptureLostEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.CaptureLostEvent", ref FCaptureLostEvent._ScriptStructPtr);
		}

		// Token: 0x0602617F RID: 156031 RVA: 0x0039C834 File Offset: 0x0039AA34
		public FCaptureLostEvent()
		{
		}

		// Token: 0x06026180 RID: 156032 RVA: 0x0039C83C File Offset: 0x0039AA3C
		protected override IntPtr GetUStructPtr()
		{
			return FCaptureLostEvent.StaticStruct();
		}

		// Token: 0x06026181 RID: 156033 RVA: 0x0039C848 File Offset: 0x0039AA48
		[NullableContext(2)]
		public FCaptureLostEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026182 RID: 156034 RVA: 0x0039C852 File Offset: 0x0039AA52
		public FCaptureLostEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026183 RID: 156035 RVA: 0x0039C85D File Offset: 0x0039AA5D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCaptureLostEvent(Pointer, false, true);
		}

		// Token: 0x06026184 RID: 156036 RVA: 0x0039C867 File Offset: 0x0039AA67
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCaptureLostEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04014CE6 RID: 85222
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.CaptureLostEvent";

		// Token: 0x04014CE7 RID: 85223
		private static IntPtr _ScriptStructPtr;
	}
}
