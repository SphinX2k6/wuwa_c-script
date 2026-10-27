using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D1B RID: 3355
	[UnrealObjectPath("/Script/Engine.LatentActionManager")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FLatentActionManager : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B3E4 RID: 46052 RVA: 0x001008E5 File Offset: 0x000FEAE5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLatentActionManager._ScriptStructPtr != 0) ? FLatentActionManager._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LatentActionManager", ref FLatentActionManager._ScriptStructPtr);
		}

		// Token: 0x0600B3E5 RID: 46053 RVA: 0x00100909 File Offset: 0x000FEB09
		public FLatentActionManager()
		{
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x00100911 File Offset: 0x000FEB11
		protected override IntPtr GetUStructPtr()
		{
			return FLatentActionManager.StaticStruct();
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x0010091D File Offset: 0x000FEB1D
		[NullableContext(2)]
		public FLatentActionManager(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x00100927 File Offset: 0x000FEB27
		public FLatentActionManager(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B3E9 RID: 46057 RVA: 0x00100932 File Offset: 0x000FEB32
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLatentActionManager(Pointer, false, true);
		}

		// Token: 0x0600B3EA RID: 46058 RVA: 0x0010093C File Offset: 0x000FEB3C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLatentActionManager(Pointer, MemoryOwner);
		}

		// Token: 0x04005E8F RID: 24207
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LatentActionManager";

		// Token: 0x04005E90 RID: 24208
		private static IntPtr _ScriptStructPtr;
	}
}
