using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002144 RID: 8516
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDynamicSpriteAtlasMgr")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class UUIDynamicSpriteAtlasMgr : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602012F RID: 131375 RVA: 0x002FB287 File Offset: 0x002F9487
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDynamicSpriteAtlasMgr._ClassPtr;
		}

		// Token: 0x06020130 RID: 131376 RVA: 0x002FB294 File Offset: 0x002F9494
		public UUIDynamicSpriteAtlasMgr() : this(BuiltinUtils.AllocNativeUObject(UUIDynamicSpriteAtlasMgr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020131 RID: 131377 RVA: 0x002FB2BC File Offset: 0x002F94BC
		public UUIDynamicSpriteAtlasMgr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDynamicSpriteAtlasMgr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DF8 RID: 32248
		// (get) Token: 0x06020132 RID: 131378 RVA: 0x002FB2F0 File Offset: 0x002F94F0
		// (set) Token: 0x06020133 RID: 131379 RVA: 0x002FB329 File Offset: 0x002F9529
		public TMap<FSoftObjectPath, FSpriteCollection> PathSpriteMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, FSpriteCollection> result;
				if ((result = this._PathSpriteMap) == null)
				{
					result = (this._PathSpriteMap = new TMap<FSoftObjectPath, FSpriteCollection>(base.NativePtr + (IntPtr)UUIDynamicSpriteAtlasMgr.__PropertyOffset_PathSpriteMap, this));
				}
				return result;
			}
			set
			{
				this.PathSpriteMap.CopyAssign(value);
			}
		}

		// Token: 0x17007DF9 RID: 32249
		// (get) Token: 0x06020134 RID: 131380 RVA: 0x002FB338 File Offset: 0x002F9538
		// (set) Token: 0x06020135 RID: 131381 RVA: 0x002FB371 File Offset: 0x002F9571
		public TMap<FSoftObjectPath, FIntPoint> DiffSrcPositions
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, FIntPoint> result;
				if ((result = this._DiffSrcPositions) == null)
				{
					result = (this._DiffSrcPositions = new TMap<FSoftObjectPath, FIntPoint>(base.NativePtr + (IntPtr)UUIDynamicSpriteAtlasMgr.__PropertyOffset_DiffSrcPositions, this));
				}
				return result;
			}
			set
			{
				this.DiffSrcPositions.CopyAssign(value);
			}
		}

		// Token: 0x17007DFA RID: 32250
		// (get) Token: 0x06020136 RID: 131382 RVA: 0x002FB380 File Offset: 0x002F9580
		// (set) Token: 0x06020137 RID: 131383 RVA: 0x002FB3B9 File Offset: 0x002F95B9
		public TMap<FSoftObjectPath, UUIDynSpriteData> SpriteDatas
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, UUIDynSpriteData> result;
				if ((result = this._SpriteDatas) == null)
				{
					result = (this._SpriteDatas = new TMap<FSoftObjectPath, UUIDynSpriteData>(base.NativePtr + (IntPtr)UUIDynamicSpriteAtlasMgr.__PropertyOffset_SpriteDatas, this));
				}
				return result;
			}
			set
			{
				this.SpriteDatas.CopyAssign(value);
			}
		}

		// Token: 0x17007DFB RID: 32251
		// (get) Token: 0x06020138 RID: 131384 RVA: 0x002FB3C8 File Offset: 0x002F95C8
		// (set) Token: 0x06020139 RID: 131385 RVA: 0x002FB401 File Offset: 0x002F9601
		public TArray<UUIDynSpriteData> SpritePool
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUIDynSpriteData> result;
				if ((result = this._SpritePool) == null)
				{
					result = (this._SpritePool = new TArray<UUIDynSpriteData>(base.NativePtr + (IntPtr)UUIDynamicSpriteAtlasMgr.__PropertyOffset_SpritePool, this));
				}
				return result;
			}
			set
			{
				this.SpritePool.CopyAssign(value);
			}
		}

		// Token: 0x17007DFC RID: 32252
		// (get) Token: 0x0602013A RID: 131386 RVA: 0x002FB410 File Offset: 0x002F9610
		// (set) Token: 0x0602013B RID: 131387 RVA: 0x002FB449 File Offset: 0x002F9649
		public TMap<UUISpriteBase, UUIDynSpriteDataProxy> SpriteToDynSpriteProxy
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UUISpriteBase, UUIDynSpriteDataProxy> result;
				if ((result = this._SpriteToDynSpriteProxy) == null)
				{
					result = (this._SpriteToDynSpriteProxy = new TMap<UUISpriteBase, UUIDynSpriteDataProxy>(base.NativePtr + (IntPtr)UUIDynamicSpriteAtlasMgr.__PropertyOffset_SpriteToDynSpriteProxy, this));
				}
				return result;
			}
			set
			{
				this.SpriteToDynSpriteProxy.CopyAssign(value);
			}
		}

		// Token: 0x0602013C RID: 131388 RVA: 0x002FB457 File Offset: 0x002F9657
		public void TestRebuildAtlas()
		{
			UUIDynamicSpriteAtlasMgr.__TestRebuildAtlas_Internal(base.NativePtr);
		}

		// Token: 0x0602013D RID: 131389 RVA: 0x002FB464 File Offset: 0x002F9664
		public void OnDynamicAtlasSlotBuilt([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FDynamicAtlasSlotManagedHandle> Handles)
		{
			UUIDynamicSpriteAtlasMgr.__OnDynamicAtlasSlotBuilt_Internal(base.NativePtr, (Handles ?? new TArray<FDynamicAtlasSlotManagedHandle>()).NativePtr);
		}

		// Token: 0x0602013E RID: 131390 RVA: 0x002FB481 File Offset: 0x002F9681
		[NullableContext(2)]
		public void OnDynamicAtlasExpandCallback(in FTextureExpandParam TextureExpandParam)
		{
			UUIDynamicSpriteAtlasMgr.__OnDynamicAtlasExpandCallback_Internal(base.NativePtr, (TextureExpandParam ?? new FTextureExpandParam()).NativePtr);
		}

		// Token: 0x0602013F RID: 131391 RVA: 0x002FB4A0 File Offset: 0x002F96A0
		[return: Nullable(2)]
		public unsafe UUIDynSpriteData GetSpriteData(string SpritePath)
		{
			FString fstring = FString.AllocTemp(SpritePath);
			UUIDynSpriteData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIDynSpriteData>(UUIDynamicSpriteAtlasMgr.__GetSpriteData_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06020140 RID: 131392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestRebuildAtlas_Internal(IntPtr @this);

		// Token: 0x06020141 RID: 131393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDynamicAtlasSlotBuilt_Internal(IntPtr @this, IntPtr Handles);

		// Token: 0x06020142 RID: 131394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDynamicAtlasExpandCallback_Internal(IntPtr @this, IntPtr TextureExpandParam);

		// Token: 0x06020143 RID: 131395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpriteData_Internal(IntPtr @this, in FString SpritePath);

		// Token: 0x06020144 RID: 131396 RVA: 0x002FB4CF File Offset: 0x002F96CF
		static UUIDynamicSpriteAtlasMgr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynamicSpriteAtlasMgr");
		}

		// Token: 0x06020145 RID: 131397 RVA: 0x002FB4DD File Offset: 0x002F96DD
		protected UUIDynamicSpriteAtlasMgr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401143C RID: 70716
		public new const string __ObjectPath = "/Script/LGUI.UIDynamicSpriteAtlasMgr";

		// Token: 0x0401143D RID: 70717
		private static IntPtr _ClassPtr;

		// Token: 0x0401143E RID: 70718
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401143F RID: 70719
		internal static int __PropertyOffset_PathSpriteMap;

		// Token: 0x04011440 RID: 70720
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, FSpriteCollection> _PathSpriteMap;

		// Token: 0x04011441 RID: 70721
		internal static int __PropertyOffset_DiffSrcPositions;

		// Token: 0x04011442 RID: 70722
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftObjectPath, FIntPoint> _DiffSrcPositions;

		// Token: 0x04011443 RID: 70723
		internal static int __PropertyOffset_SpriteDatas;

		// Token: 0x04011444 RID: 70724
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, UUIDynSpriteData> _SpriteDatas;

		// Token: 0x04011445 RID: 70725
		internal static int __PropertyOffset_SpritePool;

		// Token: 0x04011446 RID: 70726
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIDynSpriteData> _SpritePool;

		// Token: 0x04011447 RID: 70727
		internal static int __PropertyOffset_SpriteToDynSpriteProxy;

		// Token: 0x04011448 RID: 70728
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UUISpriteBase, UUIDynSpriteDataProxy> _SpriteToDynSpriteProxy;
	}
}
