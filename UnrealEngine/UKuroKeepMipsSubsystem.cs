using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B2C RID: 6956
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroKeepMipsSubsystem")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UKuroKeepMipsSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A402 RID: 107522 RVA: 0x0026BD38 File Offset: 0x00269F38
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroKeepMipsSubsystem._ClassPtr;
		}

		// Token: 0x0601A403 RID: 107523 RVA: 0x0026BD44 File Offset: 0x00269F44
		public UKuroKeepMipsSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroKeepMipsSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A404 RID: 107524 RVA: 0x0026BD6C File Offset: 0x00269F6C
		[NullableContext(1)]
		public UKuroKeepMipsSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroKeepMipsSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A405 RID: 107525 RVA: 0x0026BD9F File Offset: 0x00269F9F
		public int RequestKeepMips(int TextureKeepMips, int MeshKeepMips = -1, float DurationSeconds = 1f, int RequestId = 0)
		{
			return UKuroKeepMipsSubsystem.__RequestKeepMips_Internal(base.NativePtr, TextureKeepMips, MeshKeepMips, DurationSeconds, RequestId);
		}

		// Token: 0x0601A406 RID: 107526 RVA: 0x0026BDB1 File Offset: 0x00269FB1
		public bool RenewKeepMips(int RequestId, float DurationSeconds = 1f)
		{
			return UKuroKeepMipsSubsystem.__RenewKeepMips_Internal(base.NativePtr, RequestId, DurationSeconds);
		}

		// Token: 0x0601A407 RID: 107527 RVA: 0x0026BDC0 File Offset: 0x00269FC0
		public bool ReleaseKeepMips(int RequestId)
		{
			return UKuroKeepMipsSubsystem.__ReleaseKeepMips_Internal(base.NativePtr, RequestId);
		}

		// Token: 0x0601A408 RID: 107528 RVA: 0x0026BDCE File Offset: 0x00269FCE
		public bool IsActive()
		{
			return UKuroKeepMipsSubsystem.__IsActive_Internal(base.NativePtr);
		}

		// Token: 0x0601A409 RID: 107529 RVA: 0x0026BDDB File Offset: 0x00269FDB
		[NullableContext(2)]
		public static UKuroKeepMipsSubsystem GetForWorld(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroKeepMipsSubsystem>(UKuroKeepMipsSubsystem.__GetForWorld_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601A40A RID: 107530 RVA: 0x0026BDF7 File Offset: 0x00269FF7
		public int GetCurrentMeshKeepMips()
		{
			return UKuroKeepMipsSubsystem.__GetCurrentMeshKeepMips_Internal(base.NativePtr);
		}

		// Token: 0x0601A40B RID: 107531 RVA: 0x0026BE04 File Offset: 0x0026A004
		public int GetCurrentKeepMips()
		{
			return UKuroKeepMipsSubsystem.__GetCurrentKeepMips_Internal(base.NativePtr);
		}

		// Token: 0x0601A40C RID: 107532 RVA: 0x0026BE11 File Offset: 0x0026A011
		[NullableContext(2)]
		public static UKuroKeepMipsSubsystem Get(UGameInstance GameInstance)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroKeepMipsSubsystem>(UKuroKeepMipsSubsystem.__Get_Internal((GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601A40D RID: 107533 RVA: 0x0026BE2D File Offset: 0x0026A02D
		public void ForceRestore()
		{
			UKuroKeepMipsSubsystem.__ForceRestore_Internal(base.NativePtr);
		}

		// Token: 0x0601A40E RID: 107534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __RequestKeepMips_Internal(IntPtr @this, int TextureKeepMips, int MeshKeepMips, float DurationSeconds, int RequestId);

		// Token: 0x0601A40F RID: 107535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RenewKeepMips_Internal(IntPtr @this, int RequestId, float DurationSeconds);

		// Token: 0x0601A410 RID: 107536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReleaseKeepMips_Internal(IntPtr @this, int RequestId);

		// Token: 0x0601A411 RID: 107537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActive_Internal(IntPtr @this);

		// Token: 0x0601A412 RID: 107538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetForWorld_Internal(IntPtr WorldContextObject);

		// Token: 0x0601A413 RID: 107539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCurrentMeshKeepMips_Internal(IntPtr @this);

		// Token: 0x0601A414 RID: 107540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCurrentKeepMips_Internal(IntPtr @this);

		// Token: 0x0601A415 RID: 107541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Get_Internal(IntPtr GameInstance);

		// Token: 0x0601A416 RID: 107542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceRestore_Internal(IntPtr @this);

		// Token: 0x0601A417 RID: 107543 RVA: 0x0026BE3A File Offset: 0x0026A03A
		static UKuroKeepMipsSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroKeepMipsSubsystem");
		}

		// Token: 0x0601A418 RID: 107544 RVA: 0x0026BE48 File Offset: 0x0026A048
		protected UKuroKeepMipsSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E3FB RID: 58363
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroKeepMipsSubsystem";

		// Token: 0x0400E3FC RID: 58364
		private static IntPtr _ClassPtr;

		// Token: 0x0400E3FD RID: 58365
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
