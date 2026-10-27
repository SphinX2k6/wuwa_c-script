using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C80 RID: 7296
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSceneModifier.KuroSceneModifierComponentBackupEntry")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroSceneModifierComponentBackupEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C537 RID: 116023 RVA: 0x0029BF6E File Offset: 0x0029A16E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSceneModifierComponentBackupEntry._ScriptStructPtr != 0) ? FKuroSceneModifierComponentBackupEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSceneModifier.KuroSceneModifierComponentBackupEntry", ref FKuroSceneModifierComponentBackupEntry._ScriptStructPtr);
		}

		// Token: 0x17007289 RID: 29321
		// (get) Token: 0x0601C538 RID: 116024 RVA: 0x0029BF94 File Offset: 0x0029A194
		// (set) Token: 0x0601C539 RID: 116025 RVA: 0x0029BFD7 File Offset: 0x0029A1D7
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FKuroSceneModifierComponentBackupEntry.__PropertyOffset_Materials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x0601C53A RID: 116026 RVA: 0x0029BFE5 File Offset: 0x0029A1E5
		public FKuroSceneModifierComponentBackupEntry()
		{
		}

		// Token: 0x0601C53B RID: 116027 RVA: 0x0029BFED File Offset: 0x0029A1ED
		public FKuroSceneModifierComponentBackupEntry(TArray<UMaterialInterface> Materials)
		{
			this.Materials = Materials;
		}

		// Token: 0x0601C53C RID: 116028 RVA: 0x0029BFFC File Offset: 0x0029A1FC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSceneModifierComponentBackupEntry.StaticStruct();
		}

		// Token: 0x0601C53D RID: 116029 RVA: 0x0029C008 File Offset: 0x0029A208
		[NullableContext(2)]
		public FKuroSceneModifierComponentBackupEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C53E RID: 116030 RVA: 0x0029C012 File Offset: 0x0029A212
		public FKuroSceneModifierComponentBackupEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C53F RID: 116031 RVA: 0x0029C01D File Offset: 0x0029A21D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSceneModifierComponentBackupEntry(Pointer, false, true);
		}

		// Token: 0x0601C540 RID: 116032 RVA: 0x0029C027 File Offset: 0x0029A227
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSceneModifierComponentBackupEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400F3A5 RID: 62373
		public const string __ObjectPath = "/Script/KuroSceneModifier.KuroSceneModifierComponentBackupEntry";

		// Token: 0x0400F3A6 RID: 62374
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F3A7 RID: 62375
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400F3A8 RID: 62376
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;
	}
}
