using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003FC RID: 1020
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroResourceManager")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UKuroResourceManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600640F RID: 25615 RVA: 0x0008EED3 File Offset: 0x0008D0D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroResourceManager._ClassPtr;
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x0008EEE0 File Offset: 0x0008D0E0
		public UKuroResourceManager() : this(BuiltinUtils.AllocNativeUObject(UKuroResourceManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x0008EF08 File Offset: 0x0008D108
		public UKuroResourceManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroResourceManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06006412 RID: 25618 RVA: 0x0008EF3C File Offset: 0x0008D13C
		// (set) Token: 0x06006413 RID: 25619 RVA: 0x0008EF75 File Offset: 0x0008D175
		public FKuroLoadResourceDelegate LoadResourceDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroLoadResourceDelegate result;
				if ((result = this._LoadResourceDelegate) == null)
				{
					result = (this._LoadResourceDelegate = new FKuroLoadResourceDelegate(base.NativePtr + (IntPtr)UKuroResourceManager.__PropertyOffset_LoadResourceDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroResourceManager.__PropertyOffset_LoadResourceDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x0008EF96 File Offset: 0x0008D196
		public bool WaitComplete(int HandleId, float Timeout)
		{
			return UKuroResourceManager.__WaitComplete_Internal(base.NativePtr, HandleId, Timeout);
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x0008EFA5 File Offset: 0x0008D1A5
		public void Release(int HandleId)
		{
			UKuroResourceManager.__Release_Internal(base.NativePtr, HandleId);
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x0008EFB4 File Offset: 0x0008D1B4
		public unsafe int LoadWithIdByName(in FName Path, int HandleId)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return UKuroResourceManager.__LoadWithIdByName_Internal(base.NativePtr, Path, HandleId);
			}
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x0008EFD4 File Offset: 0x0008D1D4
		public unsafe int LoadWithIdAndTagByName(in FName Path, int HandleId, FName MemTag)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return UKuroResourceManager.__LoadWithIdAndTagByName_Internal(base.NativePtr, Path, HandleId, MemTag);
			}
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x0008EFF4 File Offset: 0x0008D1F4
		public unsafe int LoadWithIdAndTag(string Path, int HandleId, FName MemTag)
		{
			FString fstring = FString.AllocTemp(Path);
			int result = UKuroResourceManager.__LoadWithIdAndTag_Internal(base.NativePtr, fstring, HandleId, MemTag);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x0008F020 File Offset: 0x0008D220
		public unsafe int LoadWithId(string Path, int HandleId)
		{
			FString fstring = FString.AllocTemp(Path);
			int result = UKuroResourceManager.__LoadWithId_Internal(base.NativePtr, fstring, HandleId);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x0008F04C File Offset: 0x0008D24C
		public unsafe int LoadAsyncWithIdByName(in FName Path, int HandleId, int Priority)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return UKuroResourceManager.__LoadAsyncWithIdByName_Internal(base.NativePtr, Path, HandleId, Priority);
			}
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x0008F06C File Offset: 0x0008D26C
		public unsafe int LoadAsyncWithIdAndTagByName(in FName Path, int HandleId, int Priority, FName MemTag)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return UKuroResourceManager.__LoadAsyncWithIdAndTagByName_Internal(base.NativePtr, Path, HandleId, Priority, MemTag);
			}
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x0008F090 File Offset: 0x0008D290
		public unsafe int LoadAsyncWithIdAndTag(string Path, int HandleId, int Priority, FName MemTag)
		{
			FString fstring = FString.AllocTemp(Path);
			int result = UKuroResourceManager.__LoadAsyncWithIdAndTag_Internal(base.NativePtr, fstring, HandleId, Priority, MemTag);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x0008F0C0 File Offset: 0x0008D2C0
		public unsafe int LoadAsyncWithId(string Path, int HandleId, int Priority)
		{
			FString fstring = FString.AllocTemp(Path);
			int result = UKuroResourceManager.__LoadAsyncWithId_Internal(base.NativePtr, fstring, HandleId, Priority);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x0008F0EC File Offset: 0x0008D2EC
		[NullableContext(2)]
		public unsafe UObject GetLoadedAssetByName(in FName Path)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroResourceManager.__GetLoadedAssetByName_Internal(base.NativePtr, Path));
			}
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x0008F110 File Offset: 0x0008D310
		[return: Nullable(2)]
		public unsafe UObject GetLoadedAsset(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroResourceManager.__GetLoadedAsset_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x0008F13F File Offset: 0x0008D33F
		[NullableContext(2)]
		public UObject GetAsset(int HandleId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroResourceManager.__GetAsset_Internal(base.NativePtr, HandleId));
		}

		// Token: 0x06006421 RID: 25633 RVA: 0x0008F152 File Offset: 0x0008D352
		public void DebugDumpLoadingAssets()
		{
			UKuroResourceManager.__DebugDumpLoadingAssets_Internal(base.NativePtr);
		}

		// Token: 0x06006422 RID: 25634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WaitComplete_Internal(IntPtr @this, int HandleId, float Timeout);

		// Token: 0x06006423 RID: 25635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Release_Internal(IntPtr @this, int HandleId);

		// Token: 0x06006424 RID: 25636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadWithIdByName_Internal(IntPtr @this, in FName Path, int HandleId);

		// Token: 0x06006425 RID: 25637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadWithIdAndTagByName_Internal(IntPtr @this, in FName Path, int HandleId, FName MemTag);

		// Token: 0x06006426 RID: 25638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadWithIdAndTag_Internal(IntPtr @this, in FString Path, int HandleId, FName MemTag);

		// Token: 0x06006427 RID: 25639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadWithId_Internal(IntPtr @this, in FString Path, int HandleId);

		// Token: 0x06006428 RID: 25640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadAsyncWithIdByName_Internal(IntPtr @this, in FName Path, int HandleId, int Priority);

		// Token: 0x06006429 RID: 25641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadAsyncWithIdAndTagByName_Internal(IntPtr @this, in FName Path, int HandleId, int Priority, FName MemTag);

		// Token: 0x0600642A RID: 25642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadAsyncWithIdAndTag_Internal(IntPtr @this, in FString Path, int HandleId, int Priority, FName MemTag);

		// Token: 0x0600642B RID: 25643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadAsyncWithId_Internal(IntPtr @this, in FString Path, int HandleId, int Priority);

		// Token: 0x0600642C RID: 25644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLoadedAssetByName_Internal(IntPtr @this, in FName Path);

		// Token: 0x0600642D RID: 25645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLoadedAsset_Internal(IntPtr @this, in FString Path);

		// Token: 0x0600642E RID: 25646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAsset_Internal(IntPtr @this, int HandleId);

		// Token: 0x0600642F RID: 25647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugDumpLoadingAssets_Internal(IntPtr @this);

		// Token: 0x06006430 RID: 25648 RVA: 0x0008F15F File Offset: 0x0008D35F
		static UKuroResourceManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroResourceManager");
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x0008F16D File Offset: 0x0008D36D
		protected UKuroResourceManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A40 RID: 10816
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroResourceManager";

		// Token: 0x04002A41 RID: 10817
		private static IntPtr _ClassPtr;

		// Token: 0x04002A42 RID: 10818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002A43 RID: 10819
		internal static int __PropertyOffset_LoadResourceDelegate;

		// Token: 0x04002A44 RID: 10820
		[Nullable(2)]
		private FKuroLoadResourceDelegate _LoadResourceDelegate;
	}
}
