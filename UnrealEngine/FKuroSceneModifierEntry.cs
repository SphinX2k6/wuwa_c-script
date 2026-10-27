using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C82 RID: 7298
	[UnrealObjectPath("/Script/KuroSceneModifier.KuroSceneModifierEntry")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FKuroSceneModifierEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C54B RID: 116043 RVA: 0x0029C0C8 File Offset: 0x0029A2C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSceneModifierEntry._ScriptStructPtr != 0) ? FKuroSceneModifierEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSceneModifier.KuroSceneModifierEntry", ref FKuroSceneModifierEntry._ScriptStructPtr);
		}

		// Token: 0x1700728B RID: 29323
		// (get) Token: 0x0601C54C RID: 116044 RVA: 0x0029C0EC File Offset: 0x0029A2EC
		// (set) Token: 0x0601C54D RID: 116045 RVA: 0x0029C12F File Offset: 0x0029A32F
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TWeakObjectPtr<UStaticMeshComponent>, FKuroSceneModifierComponentBackupEntry> BackupComponents
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TWeakObjectPtr<UStaticMeshComponent>, FKuroSceneModifierComponentBackupEntry> result;
				if ((result = this._BackupComponents) == null)
				{
					result = (this._BackupComponents = new TMap<TWeakObjectPtr<UStaticMeshComponent>, FKuroSceneModifierComponentBackupEntry>(base.NativePtr + (IntPtr)FKuroSceneModifierEntry.__PropertyOffset_BackupComponents, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.BackupComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601C54E RID: 116046 RVA: 0x0029C13D File Offset: 0x0029A33D
		public FKuroSceneModifierEntry()
		{
		}

		// Token: 0x0601C54F RID: 116047 RVA: 0x0029C145 File Offset: 0x0029A345
		public FKuroSceneModifierEntry([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TWeakObjectPtr<UStaticMeshComponent>, FKuroSceneModifierComponentBackupEntry> BackupComponents)
		{
			this.BackupComponents = BackupComponents;
		}

		// Token: 0x0601C550 RID: 116048 RVA: 0x0029C154 File Offset: 0x0029A354
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSceneModifierEntry.StaticStruct();
		}

		// Token: 0x0601C551 RID: 116049 RVA: 0x0029C160 File Offset: 0x0029A360
		[NullableContext(2)]
		public FKuroSceneModifierEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C552 RID: 116050 RVA: 0x0029C16A File Offset: 0x0029A36A
		public FKuroSceneModifierEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C553 RID: 116051 RVA: 0x0029C175 File Offset: 0x0029A375
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSceneModifierEntry(Pointer, false, true);
		}

		// Token: 0x0601C554 RID: 116052 RVA: 0x0029C17F File Offset: 0x0029A37F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSceneModifierEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400F3AC RID: 62380
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSceneModifier.KuroSceneModifierEntry";

		// Token: 0x0400F3AD RID: 62381
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F3AE RID: 62382
		internal static int __PropertyOffset_BackupComponents;

		// Token: 0x0400F3AF RID: 62383
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TWeakObjectPtr<UStaticMeshComponent>, FKuroSceneModifierComponentBackupEntry> _BackupComponents;
	}
}
