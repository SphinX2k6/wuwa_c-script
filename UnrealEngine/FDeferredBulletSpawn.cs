using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016D3 RID: 5843
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.DeferredBulletSpawn")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FDeferredBulletSpawn : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060152A1 RID: 86689 RVA: 0x001F1C29 File Offset: 0x001EFE29
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDeferredBulletSpawn._ScriptStructPtr != 0) ? FDeferredBulletSpawn._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.DeferredBulletSpawn", ref FDeferredBulletSpawn._ScriptStructPtr);
		}

		// Token: 0x170053A5 RID: 21413
		// (get) Token: 0x060152A2 RID: 86690 RVA: 0x001F1C4D File Offset: 0x001EFE4D
		// (set) Token: 0x060152A3 RID: 86691 RVA: 0x001F1C67 File Offset: 0x001EFE67
		[Nullable(2)]
		public unsafe IBulletContext BulletContext
		{
			[NullableContext(2)]
			get
			{
				return (IBulletContext)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)FDeferredBulletSpawn.__PropertyOffset_BulletContext));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)FDeferredBulletSpawn.__PropertyOffset_BulletContext) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x170053A6 RID: 21414
		// (get) Token: 0x060152A4 RID: 86692 RVA: 0x001F1C90 File Offset: 0x001EFE90
		// (set) Token: 0x060152A5 RID: 86693 RVA: 0x001F1CD3 File Offset: 0x001EFED3
		public FBulletSpawnParams SpawnParams
		{
			get
			{
				base.FastCheckIsValid();
				FBulletSpawnParams result;
				if ((result = this._SpawnParams) == null)
				{
					result = (this._SpawnParams = new FBulletSpawnParams(base.NativePtr + (IntPtr)FDeferredBulletSpawn.__PropertyOffset_SpawnParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBulletSpawnParams.StaticStruct(), base.NativePtr + (IntPtr)FDeferredBulletSpawn.__PropertyOffset_SpawnParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060152A6 RID: 86694 RVA: 0x001F1CF4 File Offset: 0x001EFEF4
		public FDeferredBulletSpawn()
		{
		}

		// Token: 0x060152A7 RID: 86695 RVA: 0x001F1CFC File Offset: 0x001EFEFC
		public FDeferredBulletSpawn(IBulletContext BulletContext, FBulletSpawnParams SpawnParams)
		{
			this.BulletContext = BulletContext;
			this.SpawnParams = SpawnParams;
		}

		// Token: 0x060152A8 RID: 86696 RVA: 0x001F1D12 File Offset: 0x001EFF12
		protected override IntPtr GetUStructPtr()
		{
			return FDeferredBulletSpawn.StaticStruct();
		}

		// Token: 0x060152A9 RID: 86697 RVA: 0x001F1D1E File Offset: 0x001EFF1E
		[NullableContext(2)]
		public FDeferredBulletSpawn(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060152AA RID: 86698 RVA: 0x001F1D28 File Offset: 0x001EFF28
		public FDeferredBulletSpawn(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060152AB RID: 86699 RVA: 0x001F1D33 File Offset: 0x001EFF33
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDeferredBulletSpawn(Pointer, false, true);
		}

		// Token: 0x060152AC RID: 86700 RVA: 0x001F1D3D File Offset: 0x001EFF3D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDeferredBulletSpawn(Pointer, MemoryOwner);
		}

		// Token: 0x0400B837 RID: 47159
		public const string __ObjectPath = "/Script/KuroBulletCore.DeferredBulletSpawn";

		// Token: 0x0400B838 RID: 47160
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B839 RID: 47161
		internal static int __PropertyOffset_BulletContext;

		// Token: 0x0400B83A RID: 47162
		internal static int __PropertyOffset_SpawnParams;

		// Token: 0x0400B83B RID: 47163
		[Nullable(2)]
		private FBulletSpawnParams _SpawnParams;
	}
}
