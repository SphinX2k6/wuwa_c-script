using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013AD RID: 5037
	[UnrealObjectPath("/Script/GameplayAbilities.PreallocationInfo")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FPreallocationInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060127B4 RID: 75700 RVA: 0x001B2BB2 File Offset: 0x001B0DB2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPreallocationInfo._ScriptStructPtr != 0) ? FPreallocationInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.PreallocationInfo", ref FPreallocationInfo._ScriptStructPtr);
		}

		// Token: 0x170047F7 RID: 18423
		// (get) Token: 0x060127B5 RID: 75701 RVA: 0x001B2BD8 File Offset: 0x001B0DD8
		// (set) Token: 0x060127B6 RID: 75702 RVA: 0x001B2C1B File Offset: 0x001B0E1B
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<AGameplayCueNotify_Actor>> ClassesNeedingPreallocation
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<AGameplayCueNotify_Actor>> result;
				if ((result = this._ClassesNeedingPreallocation) == null)
				{
					result = (this._ClassesNeedingPreallocation = new TArray<TSubclassOf<AGameplayCueNotify_Actor>>(base.NativePtr + (IntPtr)FPreallocationInfo.__PropertyOffset_ClassesNeedingPreallocation, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ClassesNeedingPreallocation.CopyAssign(value);
			}
		}

		// Token: 0x060127B7 RID: 75703 RVA: 0x001B2C29 File Offset: 0x001B0E29
		public FPreallocationInfo()
		{
		}

		// Token: 0x060127B8 RID: 75704 RVA: 0x001B2C31 File Offset: 0x001B0E31
		public FPreallocationInfo([Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TSubclassOf<AGameplayCueNotify_Actor>> ClassesNeedingPreallocation)
		{
			this.ClassesNeedingPreallocation = ClassesNeedingPreallocation;
		}

		// Token: 0x060127B9 RID: 75705 RVA: 0x001B2C40 File Offset: 0x001B0E40
		protected override IntPtr GetUStructPtr()
		{
			return FPreallocationInfo.StaticStruct();
		}

		// Token: 0x060127BA RID: 75706 RVA: 0x001B2C4C File Offset: 0x001B0E4C
		[NullableContext(2)]
		public FPreallocationInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060127BB RID: 75707 RVA: 0x001B2C56 File Offset: 0x001B0E56
		public FPreallocationInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060127BC RID: 75708 RVA: 0x001B2C61 File Offset: 0x001B0E61
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPreallocationInfo(Pointer, false, true);
		}

		// Token: 0x060127BD RID: 75709 RVA: 0x001B2C6B File Offset: 0x001B0E6B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPreallocationInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009E3D RID: 40509
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.PreallocationInfo";

		// Token: 0x04009E3E RID: 40510
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E3F RID: 40511
		internal static int __PropertyOffset_ClassesNeedingPreallocation;

		// Token: 0x04009E40 RID: 40512
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<AGameplayCueNotify_Actor>> _ClassesNeedingPreallocation;
	}
}
