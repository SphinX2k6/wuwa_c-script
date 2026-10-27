using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ED5 RID: 3797
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.NavDataLayerActivation")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNavDataLayerActivation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CDB8 RID: 52664 RVA: 0x0012BF00 File Offset: 0x0012A100
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavDataLayerActivation._ScriptStructPtr != 0) ? FNavDataLayerActivation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NavDataLayerActivation", ref FNavDataLayerActivation._ScriptStructPtr);
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x0600CDB9 RID: 52665 RVA: 0x0012BF24 File Offset: 0x0012A124
		// (set) Token: 0x0600CDBA RID: 52666 RVA: 0x0012BF67 File Offset: 0x0012A167
		public TArray<FMapNavMeshDataLayerInfo> DataLayerInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMapNavMeshDataLayerInfo> result;
				if ((result = this._DataLayerInfos) == null)
				{
					result = (this._DataLayerInfos = new TArray<FMapNavMeshDataLayerInfo>(base.NativePtr + (IntPtr)FNavDataLayerActivation.__PropertyOffset_DataLayerInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayerInfos.CopyAssign(value);
			}
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x0600CDBB RID: 52667 RVA: 0x0012BF75 File Offset: 0x0012A175
		// (set) Token: 0x0600CDBC RID: 52668 RVA: 0x0012BF85 File Offset: 0x0012A185
		public unsafe uint Hash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavDataLayerActivation.__PropertyOffset_Hash);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavDataLayerActivation.__PropertyOffset_Hash) = (int)value;
			}
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x0600CDBD RID: 52669 RVA: 0x0012BF96 File Offset: 0x0012A196
		// (set) Token: 0x0600CDBE RID: 52670 RVA: 0x0012BFA6 File Offset: 0x0012A1A6
		public unsafe uint DataLayerSetId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavDataLayerActivation.__PropertyOffset_DataLayerSetId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavDataLayerActivation.__PropertyOffset_DataLayerSetId) = (int)value;
			}
		}

		// Token: 0x0600CDBF RID: 52671 RVA: 0x0012BFB7 File Offset: 0x0012A1B7
		public FNavDataLayerActivation()
		{
		}

		// Token: 0x0600CDC0 RID: 52672 RVA: 0x0012BFBF File Offset: 0x0012A1BF
		public FNavDataLayerActivation(TArray<FMapNavMeshDataLayerInfo> DataLayerInfos, uint Hash, uint DataLayerSetId)
		{
			this.DataLayerInfos = DataLayerInfos;
			this.Hash = Hash;
			this.DataLayerSetId = DataLayerSetId;
		}

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x0012BFDC File Offset: 0x0012A1DC
		protected override IntPtr GetUStructPtr()
		{
			return FNavDataLayerActivation.StaticStruct();
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x0012BFE8 File Offset: 0x0012A1E8
		[NullableContext(2)]
		public FNavDataLayerActivation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CDC3 RID: 52675 RVA: 0x0012BFF2 File Offset: 0x0012A1F2
		public FNavDataLayerActivation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CDC4 RID: 52676 RVA: 0x0012BFFD File Offset: 0x0012A1FD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavDataLayerActivation(Pointer, false, true);
		}

		// Token: 0x0600CDC5 RID: 52677 RVA: 0x0012C007 File Offset: 0x0012A207
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavDataLayerActivation(Pointer, MemoryOwner);
		}

		// Token: 0x04006ED6 RID: 28374
		public const string __ObjectPath = "/Script/Engine.NavDataLayerActivation";

		// Token: 0x04006ED7 RID: 28375
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006ED8 RID: 28376
		internal static int __PropertyOffset_DataLayerInfos;

		// Token: 0x04006ED9 RID: 28377
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMapNavMeshDataLayerInfo> _DataLayerInfos;

		// Token: 0x04006EDA RID: 28378
		internal static int __PropertyOffset_Hash;

		// Token: 0x04006EDB RID: 28379
		internal static int __PropertyOffset_DataLayerSetId;
	}
}
