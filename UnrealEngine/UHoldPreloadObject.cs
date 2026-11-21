using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C7 RID: 1479
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.HoldPreloadObject")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UHoldPreloadObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008390 RID: 33680 RVA: 0x000C2D60 File Offset: 0x000C0F60
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoldPreloadObject._ClassPtr;
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x000C2D6C File Offset: 0x000C0F6C
		public UHoldPreloadObject() : this(BuiltinUtils.AllocNativeUObject(UHoldPreloadObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x000C2D94 File Offset: 0x000C0F94
		public UHoldPreloadObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoldPreloadObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06008393 RID: 33683 RVA: 0x000C2DC8 File Offset: 0x000C0FC8
		// (set) Token: 0x06008394 RID: 33684 RVA: 0x000C2E01 File Offset: 0x000C1001
		public TArray<UObject> CommonAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._CommonAssets) == null)
				{
					result = (this._CommonAssets = new TArray<UObject>(base.NativePtr + (IntPtr)UHoldPreloadObject.__PropertyOffset_CommonAssets, this));
				}
				return result;
			}
			set
			{
				this.CommonAssets.CopyAssign(value);
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06008395 RID: 33685 RVA: 0x000C2E10 File Offset: 0x000C1010
		// (set) Token: 0x06008396 RID: 33686 RVA: 0x000C2E49 File Offset: 0x000C1049
		public TMap<int, FPreloadObjectCollection> EntityAssetMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FPreloadObjectCollection> result;
				if ((result = this._EntityAssetMap) == null)
				{
					result = (this._EntityAssetMap = new TMap<int, FPreloadObjectCollection>(base.NativePtr + (IntPtr)UHoldPreloadObject.__PropertyOffset_EntityAssetMap, this));
				}
				return result;
			}
			set
			{
				this.EntityAssetMap.CopyAssign(value);
			}
		}

		// Token: 0x06008397 RID: 33687 RVA: 0x000C2E57 File Offset: 0x000C1057
		public bool RemoveEntityAssets(int EntityId)
		{
			return UHoldPreloadObject.__RemoveEntityAssets_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x06008398 RID: 33688 RVA: 0x000C2E65 File Offset: 0x000C1065
		public bool GetEntityAssetArray(int EntityId, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> OutAssets)
		{
			return UHoldPreloadObject.__GetEntityAssetArray_Internal(base.NativePtr, EntityId, (OutAssets ?? new TArray<UObject>()).NativePtr);
		}

		// Token: 0x06008399 RID: 33689 RVA: 0x000C2E83 File Offset: 0x000C1083
		public TArray<UObject> GetCommonAssetArray()
		{
			return new TArray<UObject>(UHoldPreloadObject.__GetCommonAssetArray_Internal(base.NativePtr), null);
		}

		// Token: 0x0600839A RID: 33690 RVA: 0x000C2E96 File Offset: 0x000C1096
		public void ClearEntityAssetMap()
		{
			UHoldPreloadObject.__ClearEntityAssetMap_Internal(base.NativePtr);
		}

		// Token: 0x0600839B RID: 33691 RVA: 0x000C2EA3 File Offset: 0x000C10A3
		public void ClearCommonAsset()
		{
			UHoldPreloadObject.__ClearCommonAsset_Internal(base.NativePtr);
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x000C2EB0 File Offset: 0x000C10B0
		public void Clear()
		{
			UHoldPreloadObject.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x0600839D RID: 33693 RVA: 0x000C2EBD File Offset: 0x000C10BD
		[NullableContext(2)]
		public bool AddEntityAsset(int EntityId, UObject InObject)
		{
			return UHoldPreloadObject.__AddEntityAsset_Internal(base.NativePtr, EntityId, (InObject != null) ? InObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600839E RID: 33694 RVA: 0x000C2EDB File Offset: 0x000C10DB
		[NullableContext(2)]
		public void AddCommonAsset(UObject InObject)
		{
			UHoldPreloadObject.__AddCommonAsset_Internal(base.NativePtr, (InObject != null) ? InObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600839F RID: 33695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveEntityAssets_Internal(IntPtr @this, int EntityId);

		// Token: 0x060083A0 RID: 33696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEntityAssetArray_Internal(IntPtr @this, int EntityId, IntPtr OutAssets);

		// Token: 0x060083A1 RID: 33697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCommonAssetArray_Internal(IntPtr @this);

		// Token: 0x060083A2 RID: 33698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearEntityAssetMap_Internal(IntPtr @this);

		// Token: 0x060083A3 RID: 33699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCommonAsset_Internal(IntPtr @this);

		// Token: 0x060083A4 RID: 33700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x060083A5 RID: 33701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddEntityAsset_Internal(IntPtr @this, int EntityId, IntPtr InObject);

		// Token: 0x060083A6 RID: 33702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCommonAsset_Internal(IntPtr @this, IntPtr InObject);

		// Token: 0x060083A7 RID: 33703 RVA: 0x000C2EF8 File Offset: 0x000C10F8
		static UHoldPreloadObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.HoldPreloadObject");
		}

		// Token: 0x060083A8 RID: 33704 RVA: 0x000C2F06 File Offset: 0x000C1106
		protected UHoldPreloadObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003972 RID: 14706
		public new const string __ObjectPath = "/Script/KuroUtility.HoldPreloadObject";

		// Token: 0x04003973 RID: 14707
		private static IntPtr _ClassPtr;

		// Token: 0x04003974 RID: 14708
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003975 RID: 14709
		internal static int __PropertyOffset_CommonAssets;

		// Token: 0x04003976 RID: 14710
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _CommonAssets;

		// Token: 0x04003977 RID: 14711
		internal static int __PropertyOffset_EntityAssetMap;

		// Token: 0x04003978 RID: 14712
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FPreloadObjectCollection> _EntityAssetMap;
	}
}
