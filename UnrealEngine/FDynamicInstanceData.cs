using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200180E RID: 6158
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.DynamicInstanceData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FDynamicInstanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016C91 RID: 93329 RVA: 0x00214003 File Offset: 0x00212203
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDynamicInstanceData._ScriptStructPtr != 0) ? FDynamicInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroDynamicMeshBatch.DynamicInstanceData", ref FDynamicInstanceData._ScriptStructPtr);
		}

		// Token: 0x17005C0B RID: 23563
		// (get) Token: 0x06016C92 RID: 93330 RVA: 0x00214028 File Offset: 0x00212228
		// (set) Token: 0x06016C93 RID: 93331 RVA: 0x0021406B File Offset: 0x0021226B
		public FBatchKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FBatchKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FBatchKey(base.NativePtr + (IntPtr)FDynamicInstanceData.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBatchKey.StaticStruct(), base.NativePtr + (IntPtr)FDynamicInstanceData.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005C0C RID: 23564
		// (get) Token: 0x06016C94 RID: 93332 RVA: 0x0021408C File Offset: 0x0021228C
		// (set) Token: 0x06016C95 RID: 93333 RVA: 0x0021409C File Offset: 0x0021229C
		public unsafe bool bAttachedToBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDynamicInstanceData.__PropertyOffset_bAttachedToBone) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDynamicInstanceData.__PropertyOffset_bAttachedToBone) = (value ? 1 : 0);
			}
		}

		// Token: 0x06016C96 RID: 93334 RVA: 0x002140AD File Offset: 0x002122AD
		public FDynamicInstanceData()
		{
		}

		// Token: 0x06016C97 RID: 93335 RVA: 0x002140B5 File Offset: 0x002122B5
		public FDynamicInstanceData(FBatchKey Key, bool bAttachedToBone)
		{
			this.Key = Key;
			this.bAttachedToBone = bAttachedToBone;
		}

		// Token: 0x06016C98 RID: 93336 RVA: 0x002140CB File Offset: 0x002122CB
		protected override IntPtr GetUStructPtr()
		{
			return FDynamicInstanceData.StaticStruct();
		}

		// Token: 0x06016C99 RID: 93337 RVA: 0x002140D7 File Offset: 0x002122D7
		[NullableContext(2)]
		public FDynamicInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016C9A RID: 93338 RVA: 0x002140E1 File Offset: 0x002122E1
		public FDynamicInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016C9B RID: 93339 RVA: 0x002140EC File Offset: 0x002122EC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDynamicInstanceData(Pointer, false, true);
		}

		// Token: 0x06016C9C RID: 93340 RVA: 0x002140F6 File Offset: 0x002122F6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDynamicInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x0400C5CD RID: 50637
		public const string __ObjectPath = "/Script/KuroDynamicMeshBatch.DynamicInstanceData";

		// Token: 0x0400C5CE RID: 50638
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C5CF RID: 50639
		internal static int __PropertyOffset_Key;

		// Token: 0x0400C5D0 RID: 50640
		[Nullable(2)]
		private FBatchKey _Key;

		// Token: 0x0400C5D1 RID: 50641
		internal static int __PropertyOffset_bAttachedToBone;
	}
}
