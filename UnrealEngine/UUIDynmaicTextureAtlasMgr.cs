using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002145 RID: 8517
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDynmaicTextureAtlasMgr")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UUIDynmaicTextureAtlasMgr : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020146 RID: 131398 RVA: 0x002FB4E6 File Offset: 0x002F96E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDynmaicTextureAtlasMgr._ClassPtr;
		}

		// Token: 0x06020147 RID: 131399 RVA: 0x002FB4F4 File Offset: 0x002F96F4
		public UUIDynmaicTextureAtlasMgr() : this(BuiltinUtils.AllocNativeUObject(UUIDynmaicTextureAtlasMgr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020148 RID: 131400 RVA: 0x002FB51C File Offset: 0x002F971C
		public UUIDynmaicTextureAtlasMgr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDynmaicTextureAtlasMgr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DFD RID: 32253
		// (get) Token: 0x06020149 RID: 131401 RVA: 0x002FB550 File Offset: 0x002F9750
		// (set) Token: 0x0602014A RID: 131402 RVA: 0x002FB589 File Offset: 0x002F9789
		public TMap<FSoftObjectPath, FRenderableCollection> PathRenderableMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, FRenderableCollection> result;
				if ((result = this._PathRenderableMap) == null)
				{
					result = (this._PathRenderableMap = new TMap<FSoftObjectPath, FRenderableCollection>(base.NativePtr + (IntPtr)UUIDynmaicTextureAtlasMgr.__PropertyOffset_PathRenderableMap, this));
				}
				return result;
			}
			set
			{
				this.PathRenderableMap.CopyAssign(value);
			}
		}

		// Token: 0x17007DFE RID: 32254
		// (get) Token: 0x0602014B RID: 131403 RVA: 0x002FB598 File Offset: 0x002F9798
		// (set) Token: 0x0602014C RID: 131404 RVA: 0x002FB5D1 File Offset: 0x002F97D1
		public TMap<FSoftObjectPath, FRenderableCollection> FailInsertRenderableMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, FRenderableCollection> result;
				if ((result = this._FailInsertRenderableMap) == null)
				{
					result = (this._FailInsertRenderableMap = new TMap<FSoftObjectPath, FRenderableCollection>(base.NativePtr + (IntPtr)UUIDynmaicTextureAtlasMgr.__PropertyOffset_FailInsertRenderableMap, this));
				}
				return result;
			}
			set
			{
				this.FailInsertRenderableMap.CopyAssign(value);
			}
		}

		// Token: 0x17007DFF RID: 32255
		// (get) Token: 0x0602014D RID: 131405 RVA: 0x002FB5E0 File Offset: 0x002F97E0
		// (set) Token: 0x0602014E RID: 131406 RVA: 0x002FB619 File Offset: 0x002F9819
		public TMap<int, FLoadingPathRenderableMap> BatchLoadingPathRenderableMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FLoadingPathRenderableMap> result;
				if ((result = this._BatchLoadingPathRenderableMap) == null)
				{
					result = (this._BatchLoadingPathRenderableMap = new TMap<int, FLoadingPathRenderableMap>(base.NativePtr + (IntPtr)UUIDynmaicTextureAtlasMgr.__PropertyOffset_BatchLoadingPathRenderableMap, this));
				}
				return result;
			}
			set
			{
				this.BatchLoadingPathRenderableMap.CopyAssign(value);
			}
		}

		// Token: 0x0602014F RID: 131407 RVA: 0x002FB627 File Offset: 0x002F9827
		[NullableContext(2)]
		public void OnDynamicAtlasExpandCallback(in FTextureExpandParam TextureExpandParam)
		{
			UUIDynmaicTextureAtlasMgr.__OnDynamicAtlasExpandCallback_Internal(base.NativePtr, (TextureExpandParam ?? new FTextureExpandParam()).NativePtr);
		}

		// Token: 0x06020150 RID: 131408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDynamicAtlasExpandCallback_Internal(IntPtr @this, IntPtr TextureExpandParam);

		// Token: 0x06020151 RID: 131409 RVA: 0x002FB644 File Offset: 0x002F9844
		static UUIDynmaicTextureAtlasMgr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynmaicTextureAtlasMgr");
		}

		// Token: 0x06020152 RID: 131410 RVA: 0x002FB652 File Offset: 0x002F9852
		protected UUIDynmaicTextureAtlasMgr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011449 RID: 70729
		public new const string __ObjectPath = "/Script/LGUI.UIDynmaicTextureAtlasMgr";

		// Token: 0x0401144A RID: 70730
		private static IntPtr _ClassPtr;

		// Token: 0x0401144B RID: 70731
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401144C RID: 70732
		internal static int __PropertyOffset_PathRenderableMap;

		// Token: 0x0401144D RID: 70733
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, FRenderableCollection> _PathRenderableMap;

		// Token: 0x0401144E RID: 70734
		internal static int __PropertyOffset_FailInsertRenderableMap;

		// Token: 0x0401144F RID: 70735
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, FRenderableCollection> _FailInsertRenderableMap;

		// Token: 0x04011450 RID: 70736
		internal static int __PropertyOffset_BatchLoadingPathRenderableMap;

		// Token: 0x04011451 RID: 70737
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FLoadingPathRenderableMap> _BatchLoadingPathRenderableMap;
	}
}
