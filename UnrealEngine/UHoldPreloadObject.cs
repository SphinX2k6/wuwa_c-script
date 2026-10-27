using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EA4 RID: 7844
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.HoldPreloadObject")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UHoldPreloadObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DC8F RID: 121999 RVA: 0x002C0594 File Offset: 0x002BE794
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoldPreloadObject._ClassPtr;
		}

		// Token: 0x0601DC90 RID: 122000 RVA: 0x002C05A0 File Offset: 0x002BE7A0
		public UHoldPreloadObject() : this(BuiltinUtils.AllocNativeUObject(UHoldPreloadObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DC91 RID: 122001 RVA: 0x002C05C8 File Offset: 0x002BE7C8
		public UHoldPreloadObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoldPreloadObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700778B RID: 30603
		// (get) Token: 0x0601DC92 RID: 122002 RVA: 0x002C05FC File Offset: 0x002BE7FC
		// (set) Token: 0x0601DC93 RID: 122003 RVA: 0x002C0635 File Offset: 0x002BE835
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

		// Token: 0x1700778C RID: 30604
		// (get) Token: 0x0601DC94 RID: 122004 RVA: 0x002C0644 File Offset: 0x002BE844
		// (set) Token: 0x0601DC95 RID: 122005 RVA: 0x002C067D File Offset: 0x002BE87D
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

		// Token: 0x0601DC96 RID: 122006 RVA: 0x002C068B File Offset: 0x002BE88B
		public bool RemoveEntityAssets(int EntityId)
		{
			return UHoldPreloadObject.__RemoveEntityAssets_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x0601DC97 RID: 122007 RVA: 0x002C0699 File Offset: 0x002BE899
		public bool GetEntityAssetArray(int EntityId, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> OutAssets)
		{
			return UHoldPreloadObject.__GetEntityAssetArray_Internal(base.NativePtr, EntityId, (OutAssets ?? new TArray<UObject>()).NativePtr);
		}

		// Token: 0x0601DC98 RID: 122008 RVA: 0x002C06B7 File Offset: 0x002BE8B7
		public TArray<UObject> GetCommonAssetArray()
		{
			return new TArray<UObject>(UHoldPreloadObject.__GetCommonAssetArray_Internal(base.NativePtr), null);
		}

		// Token: 0x0601DC99 RID: 122009 RVA: 0x002C06CA File Offset: 0x002BE8CA
		public void ClearEntityAssetMap()
		{
			UHoldPreloadObject.__ClearEntityAssetMap_Internal(base.NativePtr);
		}

		// Token: 0x0601DC9A RID: 122010 RVA: 0x002C06D7 File Offset: 0x002BE8D7
		public void ClearCommonAsset()
		{
			UHoldPreloadObject.__ClearCommonAsset_Internal(base.NativePtr);
		}

		// Token: 0x0601DC9B RID: 122011 RVA: 0x002C06E4 File Offset: 0x002BE8E4
		public void Clear()
		{
			UHoldPreloadObject.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x0601DC9C RID: 122012 RVA: 0x002C06F1 File Offset: 0x002BE8F1
		[NullableContext(2)]
		public bool AddEntityAsset(int EntityId, UObject InObject)
		{
			return UHoldPreloadObject.__AddEntityAsset_Internal(base.NativePtr, EntityId, (InObject != null) ? InObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DC9D RID: 122013 RVA: 0x002C070F File Offset: 0x002BE90F
		[NullableContext(2)]
		public void AddCommonAsset(UObject InObject)
		{
			UHoldPreloadObject.__AddCommonAsset_Internal(base.NativePtr, (InObject != null) ? InObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DC9E RID: 122014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveEntityAssets_Internal(IntPtr @this, int EntityId);

		// Token: 0x0601DC9F RID: 122015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEntityAssetArray_Internal(IntPtr @this, int EntityId, IntPtr OutAssets);

		// Token: 0x0601DCA0 RID: 122016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCommonAssetArray_Internal(IntPtr @this);

		// Token: 0x0601DCA1 RID: 122017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearEntityAssetMap_Internal(IntPtr @this);

		// Token: 0x0601DCA2 RID: 122018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCommonAsset_Internal(IntPtr @this);

		// Token: 0x0601DCA3 RID: 122019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x0601DCA4 RID: 122020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddEntityAsset_Internal(IntPtr @this, int EntityId, IntPtr InObject);

		// Token: 0x0601DCA5 RID: 122021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddCommonAsset_Internal(IntPtr @this, IntPtr InObject);

		// Token: 0x0601DCA6 RID: 122022 RVA: 0x002C072C File Offset: 0x002BE92C
		static UHoldPreloadObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.HoldPreloadObject");
		}

		// Token: 0x0601DCA7 RID: 122023 RVA: 0x002C073A File Offset: 0x002BE93A
		protected UHoldPreloadObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401023B RID: 66107
		public new const string __ObjectPath = "/Script/KuroUtility.HoldPreloadObject";

		// Token: 0x0401023C RID: 66108
		private static IntPtr _ClassPtr;

		// Token: 0x0401023D RID: 66109
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401023E RID: 66110
		internal static int __PropertyOffset_CommonAssets;

		// Token: 0x0401023F RID: 66111
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _CommonAssets;

		// Token: 0x04010240 RID: 66112
		internal static int __PropertyOffset_EntityAssetMap;

		// Token: 0x04010241 RID: 66113
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FPreloadObjectCollection> _EntityAssetMap;
	}
}
