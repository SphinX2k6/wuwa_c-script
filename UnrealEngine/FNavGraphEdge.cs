using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002488 RID: 9352
	[UnrealObjectPath("/Script/NavigationSystem.NavGraphEdge")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNavGraphEdge : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022F9C RID: 143260 RVA: 0x0033B5B5 File Offset: 0x003397B5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavGraphEdge._ScriptStructPtr != 0) ? FNavGraphEdge._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.NavGraphEdge", ref FNavGraphEdge._ScriptStructPtr);
		}

		// Token: 0x06022F9D RID: 143261 RVA: 0x0033B5D9 File Offset: 0x003397D9
		public FNavGraphEdge()
		{
		}

		// Token: 0x06022F9E RID: 143262 RVA: 0x0033B5E1 File Offset: 0x003397E1
		protected override IntPtr GetUStructPtr()
		{
			return FNavGraphEdge.StaticStruct();
		}

		// Token: 0x06022F9F RID: 143263 RVA: 0x0033B5ED File Offset: 0x003397ED
		[NullableContext(2)]
		public FNavGraphEdge(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022FA0 RID: 143264 RVA: 0x0033B5F7 File Offset: 0x003397F7
		public FNavGraphEdge(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022FA1 RID: 143265 RVA: 0x0033B602 File Offset: 0x00339802
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavGraphEdge(Pointer, false, true);
		}

		// Token: 0x06022FA2 RID: 143266 RVA: 0x0033B60C File Offset: 0x0033980C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavGraphEdge(Pointer, MemoryOwner);
		}

		// Token: 0x04012AD4 RID: 76500
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.NavGraphEdge";

		// Token: 0x04012AD5 RID: 76501
		private static IntPtr _ScriptStructPtr;
	}
}
