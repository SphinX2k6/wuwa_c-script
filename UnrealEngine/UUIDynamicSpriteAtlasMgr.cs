using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F6 RID: 1782
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDynamicSpriteAtlasMgr")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class UUIDynamicSpriteAtlasMgr : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600976B RID: 38763 RVA: 0x000E46CC File Offset: 0x000E28CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDynamicSpriteAtlasMgr._ClassPtr;
		}

		// Token: 0x0600976C RID: 38764 RVA: 0x000E46D8 File Offset: 0x000E28D8
		public UUIDynamicSpriteAtlasMgr() : this(BuiltinUtils.AllocNativeUObject(UUIDynamicSpriteAtlasMgr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600976D RID: 38765 RVA: 0x000E4700 File Offset: 0x000E2900
		public UUIDynamicSpriteAtlasMgr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDynamicSpriteAtlasMgr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x0600976E RID: 38766 RVA: 0x000E4734 File Offset: 0x000E2934
		// (set) Token: 0x0600976F RID: 38767 RVA: 0x000E476D File Offset: 0x000E296D
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

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06009770 RID: 38768 RVA: 0x000E477C File Offset: 0x000E297C
		// (set) Token: 0x06009771 RID: 38769 RVA: 0x000E47B5 File Offset: 0x000E29B5
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

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06009772 RID: 38770 RVA: 0x000E47C4 File Offset: 0x000E29C4
		// (set) Token: 0x06009773 RID: 38771 RVA: 0x000E47FD File Offset: 0x000E29FD
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

		// Token: 0x06009774 RID: 38772 RVA: 0x000E480B File Offset: 0x000E2A0B
		public void TestRebuildAtlas()
		{
			UUIDynamicSpriteAtlasMgr.__TestRebuildAtlas_Internal(base.NativePtr);
		}

		// Token: 0x06009775 RID: 38773 RVA: 0x000E4818 File Offset: 0x000E2A18
		[return: Nullable(2)]
		public unsafe UUIDynSpriteData GetSpriteData(string SpritePath)
		{
			FString fstring = FString.AllocTemp(SpritePath);
			UUIDynSpriteData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIDynSpriteData>(UUIDynamicSpriteAtlasMgr.__GetSpriteData_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06009776 RID: 38774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestRebuildAtlas_Internal(IntPtr @this);

		// Token: 0x06009777 RID: 38775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpriteData_Internal(IntPtr @this, in FString SpritePath);

		// Token: 0x06009778 RID: 38776 RVA: 0x000E4847 File Offset: 0x000E2A47
		static UUIDynamicSpriteAtlasMgr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynamicSpriteAtlasMgr");
		}

		// Token: 0x06009779 RID: 38777 RVA: 0x000E4855 File Offset: 0x000E2A55
		protected UUIDynamicSpriteAtlasMgr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041E1 RID: 16865
		public new const string __ObjectPath = "/Script/LGUI.UIDynamicSpriteAtlasMgr";

		// Token: 0x040041E2 RID: 16866
		private static IntPtr _ClassPtr;

		// Token: 0x040041E3 RID: 16867
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041E4 RID: 16868
		internal static int __PropertyOffset_DiffSrcPositions;

		// Token: 0x040041E5 RID: 16869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftObjectPath, FIntPoint> _DiffSrcPositions;

		// Token: 0x040041E6 RID: 16870
		internal static int __PropertyOffset_SpriteDatas;

		// Token: 0x040041E7 RID: 16871
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, UUIDynSpriteData> _SpriteDatas;

		// Token: 0x040041E8 RID: 16872
		internal static int __PropertyOffset_SpritePool;

		// Token: 0x040041E9 RID: 16873
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIDynSpriteData> _SpritePool;
	}
}
