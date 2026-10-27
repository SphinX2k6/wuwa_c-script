using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022BC RID: 8892
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendActorCheckAgainItem")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMeshBlendActorCheckAgainItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021C7C RID: 138364 RVA: 0x0031F10A File Offset: 0x0031D30A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshBlendActorCheckAgainItem._ScriptStructPtr != 0) ? FMeshBlendActorCheckAgainItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.MeshBlendActorCheckAgainItem", ref FMeshBlendActorCheckAgainItem._ScriptStructPtr);
		}

		// Token: 0x17008308 RID: 33544
		// (get) Token: 0x06021C7D RID: 138365 RVA: 0x0031F12E File Offset: 0x0031D32E
		// (set) Token: 0x06021C7E RID: 138366 RVA: 0x0031F13E File Offset: 0x0031D33E
		public unsafe float StopCheckingAfter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBlendActorCheckAgainItem.__PropertyOffset_StopCheckingAfter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBlendActorCheckAgainItem.__PropertyOffset_StopCheckingAfter) = value;
			}
		}

		// Token: 0x17008309 RID: 33545
		// (get) Token: 0x06021C7F RID: 138367 RVA: 0x0031F14F File Offset: 0x0031D34F
		// (set) Token: 0x06021C80 RID: 138368 RVA: 0x0031F15F File Offset: 0x0031D35F
		public unsafe bool HasBeenCheckedOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBlendActorCheckAgainItem.__PropertyOffset_HasBeenCheckedOnce) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBlendActorCheckAgainItem.__PropertyOffset_HasBeenCheckedOnce) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021C81 RID: 138369 RVA: 0x0031F170 File Offset: 0x0031D370
		public FMeshBlendActorCheckAgainItem()
		{
		}

		// Token: 0x06021C82 RID: 138370 RVA: 0x0031F178 File Offset: 0x0031D378
		public FMeshBlendActorCheckAgainItem(float StopCheckingAfter, bool HasBeenCheckedOnce)
		{
			this.StopCheckingAfter = StopCheckingAfter;
			this.HasBeenCheckedOnce = HasBeenCheckedOnce;
		}

		// Token: 0x06021C83 RID: 138371 RVA: 0x0031F18E File Offset: 0x0031D38E
		protected override IntPtr GetUStructPtr()
		{
			return FMeshBlendActorCheckAgainItem.StaticStruct();
		}

		// Token: 0x06021C84 RID: 138372 RVA: 0x0031F19A File Offset: 0x0031D39A
		[NullableContext(2)]
		public FMeshBlendActorCheckAgainItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021C85 RID: 138373 RVA: 0x0031F1A4 File Offset: 0x0031D3A4
		public FMeshBlendActorCheckAgainItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021C86 RID: 138374 RVA: 0x0031F1AF File Offset: 0x0031D3AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshBlendActorCheckAgainItem(Pointer, false, true);
		}

		// Token: 0x06021C87 RID: 138375 RVA: 0x0031F1B9 File Offset: 0x0031D3B9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshBlendActorCheckAgainItem(Pointer, MemoryOwner);
		}

		// Token: 0x0401206C RID: 73836
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MeshBlend.MeshBlendActorCheckAgainItem";

		// Token: 0x0401206D RID: 73837
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401206E RID: 73838
		internal static int __PropertyOffset_StopCheckingAfter;

		// Token: 0x0401206F RID: 73839
		internal static int __PropertyOffset_HasBeenCheckedOnce;
	}
}
