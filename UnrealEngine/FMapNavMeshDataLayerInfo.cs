using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D6F RID: 3439
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.MapNavMeshDataLayerInfo")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMapNavMeshDataLayerInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B9B5 RID: 47541 RVA: 0x0010834F File Offset: 0x0010654F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMapNavMeshDataLayerInfo._ScriptStructPtr != 0) ? FMapNavMeshDataLayerInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MapNavMeshDataLayerInfo", ref FMapNavMeshDataLayerInfo._ScriptStructPtr);
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x0600B9B6 RID: 47542 RVA: 0x00108373 File Offset: 0x00106573
		// (set) Token: 0x0600B9B7 RID: 47543 RVA: 0x00108387 File Offset: 0x00106587
		public unsafe FName DataLayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMapNavMeshDataLayerInfo.__PropertyOffset_DataLayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMapNavMeshDataLayerInfo.__PropertyOffset_DataLayerName) = value;
			}
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x0600B9B8 RID: 47544 RVA: 0x0010839C File Offset: 0x0010659C
		// (set) Token: 0x0600B9B9 RID: 47545 RVA: 0x001083B0 File Offset: 0x001065B0
		public unsafe FName DataLayerLabel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMapNavMeshDataLayerInfo.__PropertyOffset_DataLayerLabel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMapNavMeshDataLayerInfo.__PropertyOffset_DataLayerLabel) = value;
			}
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x0600B9BA RID: 47546 RVA: 0x001083C5 File Offset: 0x001065C5
		// (set) Token: 0x0600B9BB RID: 47547 RVA: 0x001083D5 File Offset: 0x001065D5
		public unsafe bool bActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMapNavMeshDataLayerInfo.__PropertyOffset_bActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMapNavMeshDataLayerInfo.__PropertyOffset_bActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x0600B9BC RID: 47548 RVA: 0x001083E6 File Offset: 0x001065E6
		// (set) Token: 0x0600B9BD RID: 47549 RVA: 0x001083F6 File Offset: 0x001065F6
		public unsafe bool bEnableTileVariant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMapNavMeshDataLayerInfo.__PropertyOffset_bEnableTileVariant) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMapNavMeshDataLayerInfo.__PropertyOffset_bEnableTileVariant) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x0600B9BE RID: 47550 RVA: 0x00108407 File Offset: 0x00106607
		// (set) Token: 0x0600B9BF RID: 47551 RVA: 0x00108417 File Offset: 0x00106617
		public unsafe uint DataLayerId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMapNavMeshDataLayerInfo.__PropertyOffset_DataLayerId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMapNavMeshDataLayerInfo.__PropertyOffset_DataLayerId) = (int)value;
			}
		}

		// Token: 0x0600B9C0 RID: 47552 RVA: 0x00108428 File Offset: 0x00106628
		public FMapNavMeshDataLayerInfo()
		{
		}

		// Token: 0x0600B9C1 RID: 47553 RVA: 0x00108430 File Offset: 0x00106630
		public FMapNavMeshDataLayerInfo(FName DataLayerName, FName DataLayerLabel, bool bActive, bool bEnableTileVariant, uint DataLayerId)
		{
			this.DataLayerName = DataLayerName;
			this.DataLayerLabel = DataLayerLabel;
			this.bActive = bActive;
			this.bEnableTileVariant = bEnableTileVariant;
			this.DataLayerId = DataLayerId;
		}

		// Token: 0x0600B9C2 RID: 47554 RVA: 0x0010845D File Offset: 0x0010665D
		protected override IntPtr GetUStructPtr()
		{
			return FMapNavMeshDataLayerInfo.StaticStruct();
		}

		// Token: 0x0600B9C3 RID: 47555 RVA: 0x00108469 File Offset: 0x00106669
		[NullableContext(2)]
		public FMapNavMeshDataLayerInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B9C4 RID: 47556 RVA: 0x00108473 File Offset: 0x00106673
		public FMapNavMeshDataLayerInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B9C5 RID: 47557 RVA: 0x0010847E File Offset: 0x0010667E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMapNavMeshDataLayerInfo(Pointer, false, true);
		}

		// Token: 0x0600B9C6 RID: 47558 RVA: 0x00108488 File Offset: 0x00106688
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMapNavMeshDataLayerInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400614B RID: 24907
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MapNavMeshDataLayerInfo";

		// Token: 0x0400614C RID: 24908
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400614D RID: 24909
		internal static int __PropertyOffset_DataLayerName;

		// Token: 0x0400614E RID: 24910
		internal static int __PropertyOffset_DataLayerLabel;

		// Token: 0x0400614F RID: 24911
		internal static int __PropertyOffset_bActive;

		// Token: 0x04006150 RID: 24912
		internal static int __PropertyOffset_bEnableTileVariant;

		// Token: 0x04006151 RID: 24913
		internal static int __PropertyOffset_DataLayerId;
	}
}
