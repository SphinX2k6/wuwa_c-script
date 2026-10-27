using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022BE RID: 8894
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendActorProcessingItem")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FMeshBlendActorProcessingItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021C94 RID: 138388 RVA: 0x0031F2BF File Offset: 0x0031D4BF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshBlendActorProcessingItem._ScriptStructPtr != 0) ? FMeshBlendActorProcessingItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.MeshBlendActorProcessingItem", ref FMeshBlendActorProcessingItem._ScriptStructPtr);
		}

		// Token: 0x1700830C RID: 33548
		// (get) Token: 0x06021C95 RID: 138389 RVA: 0x0031F2E3 File Offset: 0x0031D4E3
		// (set) Token: 0x06021C96 RID: 138390 RVA: 0x0031F2F3 File Offset: 0x0031D4F3
		public unsafe bool bReset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBlendActorProcessingItem.__PropertyOffset_bReset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBlendActorProcessingItem.__PropertyOffset_bReset) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700830D RID: 33549
		// (get) Token: 0x06021C97 RID: 138391 RVA: 0x0031F304 File Offset: 0x0031D504
		// (set) Token: 0x06021C98 RID: 138392 RVA: 0x0031F314 File Offset: 0x0031D514
		public unsafe bool bSoftReset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBlendActorProcessingItem.__PropertyOffset_bSoftReset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBlendActorProcessingItem.__PropertyOffset_bSoftReset) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700830E RID: 33550
		// (get) Token: 0x06021C99 RID: 138393 RVA: 0x0031F325 File Offset: 0x0031D525
		// (set) Token: 0x06021C9A RID: 138394 RVA: 0x0031F335 File Offset: 0x0031D535
		public unsafe bool bRefresh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBlendActorProcessingItem.__PropertyOffset_bRefresh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBlendActorProcessingItem.__PropertyOffset_bRefresh) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021C9B RID: 138395 RVA: 0x0031F346 File Offset: 0x0031D546
		public FMeshBlendActorProcessingItem()
		{
		}

		// Token: 0x06021C9C RID: 138396 RVA: 0x0031F34E File Offset: 0x0031D54E
		public FMeshBlendActorProcessingItem(bool bReset, bool bSoftReset, bool bRefresh)
		{
			this.bReset = bReset;
			this.bSoftReset = bSoftReset;
			this.bRefresh = bRefresh;
		}

		// Token: 0x06021C9D RID: 138397 RVA: 0x0031F36B File Offset: 0x0031D56B
		protected override IntPtr GetUStructPtr()
		{
			return FMeshBlendActorProcessingItem.StaticStruct();
		}

		// Token: 0x06021C9E RID: 138398 RVA: 0x0031F377 File Offset: 0x0031D577
		[NullableContext(2)]
		public FMeshBlendActorProcessingItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021C9F RID: 138399 RVA: 0x0031F381 File Offset: 0x0031D581
		public FMeshBlendActorProcessingItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021CA0 RID: 138400 RVA: 0x0031F38C File Offset: 0x0031D58C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshBlendActorProcessingItem(Pointer, false, true);
		}

		// Token: 0x06021CA1 RID: 138401 RVA: 0x0031F396 File Offset: 0x0031D596
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshBlendActorProcessingItem(Pointer, MemoryOwner);
		}

		// Token: 0x04012075 RID: 73845
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MeshBlend.MeshBlendActorProcessingItem";

		// Token: 0x04012076 RID: 73846
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012077 RID: 73847
		internal static int __PropertyOffset_bReset;

		// Token: 0x04012078 RID: 73848
		internal static int __PropertyOffset_bSoftReset;

		// Token: 0x04012079 RID: 73849
		internal static int __PropertyOffset_bRefresh;
	}
}
