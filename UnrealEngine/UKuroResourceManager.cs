using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001902 RID: 6402
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroResourceManager")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UKuroResourceManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017C1A RID: 97306 RVA: 0x0022CD9D File Offset: 0x0022AF9D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroResourceManager._ClassPtr;
		}

		// Token: 0x06017C1B RID: 97307 RVA: 0x0022CDAC File Offset: 0x0022AFAC
		public UKuroResourceManager() : this(BuiltinUtils.AllocNativeUObject(UKuroResourceManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017C1C RID: 97308 RVA: 0x0022CDD4 File Offset: 0x0022AFD4
		public UKuroResourceManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroResourceManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FA6 RID: 24486
		// (get) Token: 0x06017C1D RID: 97309 RVA: 0x0022CE08 File Offset: 0x0022B008
		// (set) Token: 0x06017C1E RID: 97310 RVA: 0x0022CE41 File Offset: 0x0022B041
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

		// Token: 0x06017C1F RID: 97311 RVA: 0x0022CE62 File Offset: 0x0022B062
		public bool WaitComplete(int HandleId, float Timeout)
		{
			return UKuroResourceManager.__WaitComplete_Internal(base.NativePtr, HandleId, Timeout);
		}

		// Token: 0x06017C20 RID: 97312 RVA: 0x0022CE71 File Offset: 0x0022B071
		public void Release(int HandleId)
		{
			UKuroResourceManager.__Release_Internal(base.NativePtr, HandleId);
		}

		// Token: 0x06017C21 RID: 97313 RVA: 0x0022CE80 File Offset: 0x0022B080
		public unsafe int LoadWithIdByName(in FName Path, int HandleId)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return UKuroResourceManager.__LoadWithIdByName_Internal(base.NativePtr, Path, HandleId);
			}
		}

		// Token: 0x06017C22 RID: 97314 RVA: 0x0022CEA0 File Offset: 0x0022B0A0
		public unsafe int LoadWithIdAndTagByName(in FName Path, int HandleId, FName MemTag)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return UKuroResourceManager.__LoadWithIdAndTagByName_Internal(base.NativePtr, Path, HandleId, MemTag);
			}
		}

		// Token: 0x06017C23 RID: 97315 RVA: 0x0022CEC0 File Offset: 0x0022B0C0
		public unsafe int LoadWithIdAndTag(string Path, int HandleId, FName MemTag)
		{
			FString fstring = FString.AllocTemp(Path);
			int result = UKuroResourceManager.__LoadWithIdAndTag_Internal(base.NativePtr, fstring, HandleId, MemTag);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06017C24 RID: 97316 RVA: 0x0022CEEC File Offset: 0x0022B0EC
		public unsafe int LoadWithId(string Path, int HandleId)
		{
			FString fstring = FString.AllocTemp(Path);
			int result = UKuroResourceManager.__LoadWithId_Internal(base.NativePtr, fstring, HandleId);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06017C25 RID: 97317 RVA: 0x0022CF18 File Offset: 0x0022B118
		public unsafe int LoadAsyncWithIdByName(in FName Path, int HandleId, int Priority)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return UKuroResourceManager.__LoadAsyncWithIdByName_Internal(base.NativePtr, Path, HandleId, Priority);
			}
		}

		// Token: 0x06017C26 RID: 97318 RVA: 0x0022CF38 File Offset: 0x0022B138
		public unsafe int LoadAsyncWithIdAndTagByName(in FName Path, int HandleId, int Priority, FName MemTag)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return UKuroResourceManager.__LoadAsyncWithIdAndTagByName_Internal(base.NativePtr, Path, HandleId, Priority, MemTag);
			}
		}

		// Token: 0x06017C27 RID: 97319 RVA: 0x0022CF5C File Offset: 0x0022B15C
		public unsafe int LoadAsyncWithIdAndTag(string Path, int HandleId, int Priority, FName MemTag)
		{
			FString fstring = FString.AllocTemp(Path);
			int result = UKuroResourceManager.__LoadAsyncWithIdAndTag_Internal(base.NativePtr, fstring, HandleId, Priority, MemTag);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06017C28 RID: 97320 RVA: 0x0022CF8C File Offset: 0x0022B18C
		public unsafe int LoadAsyncWithId(string Path, int HandleId, int Priority)
		{
			FString fstring = FString.AllocTemp(Path);
			int result = UKuroResourceManager.__LoadAsyncWithId_Internal(base.NativePtr, fstring, HandleId, Priority);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06017C29 RID: 97321 RVA: 0x0022CFB8 File Offset: 0x0022B1B8
		[NullableContext(2)]
		public unsafe UObject GetLoadedAssetByName(in FName Path)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroResourceManager.__GetLoadedAssetByName_Internal(base.NativePtr, Path));
			}
		}

		// Token: 0x06017C2A RID: 97322 RVA: 0x0022CFDC File Offset: 0x0022B1DC
		[return: Nullable(2)]
		public unsafe UObject GetLoadedAsset(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroResourceManager.__GetLoadedAsset_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06017C2B RID: 97323 RVA: 0x0022D00B File Offset: 0x0022B20B
		[NullableContext(2)]
		public UObject GetAsset(int HandleId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKuroResourceManager.__GetAsset_Internal(base.NativePtr, HandleId));
		}

		// Token: 0x06017C2C RID: 97324 RVA: 0x0022D01E File Offset: 0x0022B21E
		public void DebugDumpLoadingAssets()
		{
			UKuroResourceManager.__DebugDumpLoadingAssets_Internal(base.NativePtr);
		}

		// Token: 0x06017C2D RID: 97325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WaitComplete_Internal(IntPtr @this, int HandleId, float Timeout);

		// Token: 0x06017C2E RID: 97326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Release_Internal(IntPtr @this, int HandleId);

		// Token: 0x06017C2F RID: 97327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadWithIdByName_Internal(IntPtr @this, in FName Path, int HandleId);

		// Token: 0x06017C30 RID: 97328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadWithIdAndTagByName_Internal(IntPtr @this, in FName Path, int HandleId, FName MemTag);

		// Token: 0x06017C31 RID: 97329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadWithIdAndTag_Internal(IntPtr @this, in FString Path, int HandleId, FName MemTag);

		// Token: 0x06017C32 RID: 97330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadWithId_Internal(IntPtr @this, in FString Path, int HandleId);

		// Token: 0x06017C33 RID: 97331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadAsyncWithIdByName_Internal(IntPtr @this, in FName Path, int HandleId, int Priority);

		// Token: 0x06017C34 RID: 97332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadAsyncWithIdAndTagByName_Internal(IntPtr @this, in FName Path, int HandleId, int Priority, FName MemTag);

		// Token: 0x06017C35 RID: 97333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadAsyncWithIdAndTag_Internal(IntPtr @this, in FString Path, int HandleId, int Priority, FName MemTag);

		// Token: 0x06017C36 RID: 97334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadAsyncWithId_Internal(IntPtr @this, in FString Path, int HandleId, int Priority);

		// Token: 0x06017C37 RID: 97335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLoadedAssetByName_Internal(IntPtr @this, in FName Path);

		// Token: 0x06017C38 RID: 97336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLoadedAsset_Internal(IntPtr @this, in FString Path);

		// Token: 0x06017C39 RID: 97337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAsset_Internal(IntPtr @this, int HandleId);

		// Token: 0x06017C3A RID: 97338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugDumpLoadingAssets_Internal(IntPtr @this);

		// Token: 0x06017C3B RID: 97339 RVA: 0x0022D02B File Offset: 0x0022B22B
		static UKuroResourceManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroResourceManager");
		}

		// Token: 0x06017C3C RID: 97340 RVA: 0x0022D039 File Offset: 0x0022B239
		protected UKuroResourceManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE3A RID: 52794
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroResourceManager";

		// Token: 0x0400CE3B RID: 52795
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE3C RID: 52796
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE3D RID: 52797
		internal static int __PropertyOffset_LoadResourceDelegate;

		// Token: 0x0400CE3E RID: 52798
		[Nullable(2)]
		private FKuroLoadResourceDelegate _LoadResourceDelegate;
	}
}
