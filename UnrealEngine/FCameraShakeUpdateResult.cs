using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000917 RID: 2327
	[UnrealObjectPath("/Script/Engine.CameraShakeUpdateResult")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCameraShakeUpdateResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600800D RID: 32781 RVA: 0x000B7707 File Offset: 0x000B5907
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraShakeUpdateResult._ScriptStructPtr != 0) ? FCameraShakeUpdateResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CameraShakeUpdateResult", ref FCameraShakeUpdateResult._ScriptStructPtr);
		}

		// Token: 0x0600800E RID: 32782 RVA: 0x000B772B File Offset: 0x000B592B
		public FCameraShakeUpdateResult()
		{
		}

		// Token: 0x0600800F RID: 32783 RVA: 0x000B7733 File Offset: 0x000B5933
		protected override IntPtr GetUStructPtr()
		{
			return FCameraShakeUpdateResult.StaticStruct();
		}

		// Token: 0x06008010 RID: 32784 RVA: 0x000B773F File Offset: 0x000B593F
		[NullableContext(2)]
		public FCameraShakeUpdateResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008011 RID: 32785 RVA: 0x000B7749 File Offset: 0x000B5949
		public FCameraShakeUpdateResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008012 RID: 32786 RVA: 0x000B7754 File Offset: 0x000B5954
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraShakeUpdateResult(Pointer, false, true);
		}

		// Token: 0x06008013 RID: 32787 RVA: 0x000B775E File Offset: 0x000B595E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraShakeUpdateResult(Pointer, MemoryOwner);
		}

		// Token: 0x04003D5D RID: 15709
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CameraShakeUpdateResult";

		// Token: 0x04003D5E RID: 15710
		private static IntPtr _ScriptStructPtr;
	}
}
