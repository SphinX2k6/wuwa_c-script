using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200297C RID: 10620
	[UnrealObjectPath("/Script/UMG.InvalidationBox")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UInvalidationBox : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060274A4 RID: 160932 RVA: 0x003BE9A3 File Offset: 0x003BCBA3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInvalidationBox._ClassPtr;
		}

		// Token: 0x060274A5 RID: 160933 RVA: 0x003BE9B0 File Offset: 0x003BCBB0
		public UInvalidationBox() : this(BuiltinUtils.AllocNativeUObject(UInvalidationBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060274A6 RID: 160934 RVA: 0x003BE9D8 File Offset: 0x003BCBD8
		[NullableContext(1)]
		public UInvalidationBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInvalidationBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700970A RID: 38666
		// (get) Token: 0x060274A7 RID: 160935 RVA: 0x003BEA0B File Offset: 0x003BCC0B
		// (set) Token: 0x060274A8 RID: 160936 RVA: 0x003BEA1B File Offset: 0x003BCC1B
		public unsafe bool bCanCache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInvalidationBox.__PropertyOffset_bCanCache) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInvalidationBox.__PropertyOffset_bCanCache) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700970B RID: 38667
		// (get) Token: 0x060274A9 RID: 160937 RVA: 0x003BEA2C File Offset: 0x003BCC2C
		// (set) Token: 0x060274AA RID: 160938 RVA: 0x003BEA3C File Offset: 0x003BCC3C
		public unsafe bool CacheRelativeTransforms_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInvalidationBox.__PropertyOffset_CacheRelativeTransforms_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInvalidationBox.__PropertyOffset_CacheRelativeTransforms_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x060274AB RID: 160939 RVA: 0x003BEA4D File Offset: 0x003BCC4D
		public void SetCanCache(bool CanCache)
		{
			UInvalidationBox.__SetCanCache_Internal(base.NativePtr, CanCache);
		}

		// Token: 0x060274AC RID: 160940 RVA: 0x003BEA5B File Offset: 0x003BCC5B
		public void InvalidateCache()
		{
			UInvalidationBox.__InvalidateCache_Internal(base.NativePtr);
		}

		// Token: 0x060274AD RID: 160941 RVA: 0x003BEA68 File Offset: 0x003BCC68
		public bool GetCanCache()
		{
			return UInvalidationBox.__GetCanCache_Internal(base.NativePtr);
		}

		// Token: 0x060274AE RID: 160942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanCache_Internal(IntPtr @this, bool CanCache);

		// Token: 0x060274AF RID: 160943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvalidateCache_Internal(IntPtr @this);

		// Token: 0x060274B0 RID: 160944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCanCache_Internal(IntPtr @this);

		// Token: 0x060274B1 RID: 160945 RVA: 0x003BEA75 File Offset: 0x003BCC75
		static UInvalidationBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.InvalidationBox");
		}

		// Token: 0x060274B2 RID: 160946 RVA: 0x003BEA83 File Offset: 0x003BCC83
		protected UInvalidationBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401594E RID: 88398
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.InvalidationBox";

		// Token: 0x0401594F RID: 88399
		private static IntPtr _ClassPtr;

		// Token: 0x04015950 RID: 88400
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015951 RID: 88401
		internal static int __PropertyOffset_bCanCache;

		// Token: 0x04015952 RID: 88402
		internal static int __PropertyOffset_CacheRelativeTransforms_DEPRECATED;
	}
}
