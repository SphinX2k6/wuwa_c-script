using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005EE RID: 1518
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.LoadMapNotify")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class ULoadMapNotify : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008727 RID: 34599 RVA: 0x000CABD9 File Offset: 0x000C8DD9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULoadMapNotify._ClassPtr;
		}

		// Token: 0x06008728 RID: 34600 RVA: 0x000CABE8 File Offset: 0x000C8DE8
		public ULoadMapNotify() : this(BuiltinUtils.AllocNativeUObject(ULoadMapNotify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x000CAC10 File Offset: 0x000C8E10
		[NullableContext(1)]
		public ULoadMapNotify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULoadMapNotify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600872A RID: 34602 RVA: 0x000CAC44 File Offset: 0x000C8E44
		public unsafe int UnloadStreamLevel(in FName Path, bool bShouldBlockOnLoad)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return ULoadMapNotify.__UnloadStreamLevel_Internal(base.NativePtr, Path, bShouldBlockOnLoad);
			}
		}

		// Token: 0x0600872B RID: 34603 RVA: 0x000CAC63 File Offset: 0x000C8E63
		public void OnUnLoadStreamLevel(int LinkID)
		{
			ULoadMapNotify.__OnUnLoadStreamLevel_Internal(base.NativePtr, LinkID);
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x000CAC71 File Offset: 0x000C8E71
		public void OnLoadStreamLevel(int LinkID)
		{
			ULoadMapNotify.__OnLoadStreamLevel_Internal(base.NativePtr, LinkID);
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x000CAC80 File Offset: 0x000C8E80
		public unsafe int LoadStreamLevel(in FName Path, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return ULoadMapNotify.__LoadStreamLevel_Internal(base.NativePtr, Path, bMakeVisibleAfterLoad, bShouldBlockOnLoad);
			}
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x000CACA0 File Offset: 0x000C8EA0
		public void Clear()
		{
			ULoadMapNotify.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x000CACAD File Offset: 0x000C8EAD
		public void BindUnLoadStreamLevel(FUnLoadStreamLevelDelegate UnLoadStreamLevelHandler)
		{
			ULoadMapNotify.__BindUnLoadStreamLevel_Internal(base.NativePtr, (UnLoadStreamLevelHandler != null) ? UnLoadStreamLevelHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x000CACC7 File Offset: 0x000C8EC7
		public void BindLoadStreamLevel(FLoadStreamLevelDelegate LoadStreamLevelHandler)
		{
			ULoadMapNotify.__BindLoadStreamLevel_Internal(base.NativePtr, (LoadStreamLevelHandler != null) ? LoadStreamLevelHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x000CACE1 File Offset: 0x000C8EE1
		public void BindEndLoadTransitionMap(FEndLoadTransitionMapDelegate EndLoadTransitionMapHandler)
		{
			ULoadMapNotify.__BindEndLoadTransitionMap_Internal(base.NativePtr, (EndLoadTransitionMapHandler != null) ? EndLoadTransitionMapHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x000CACFB File Offset: 0x000C8EFB
		public void BindEndLoadMap(FEndLoadMapDelegate EndLoadMapHandler)
		{
			ULoadMapNotify.__BindEndLoadMap_Internal(base.NativePtr, (EndLoadMapHandler != null) ? EndLoadMapHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x000CAD15 File Offset: 0x000C8F15
		public void BindBeginTravelLoadMap(FBeginTravelLoadMapDelegate BeginTravelLoadMapHandler)
		{
			ULoadMapNotify.__BindBeginTravelLoadMap_Internal(base.NativePtr, (BeginTravelLoadMapHandler != null) ? BeginTravelLoadMapHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x000CAD2F File Offset: 0x000C8F2F
		public void BindBeginLoadMap(FBeginLoadMapDelegate BeginLoadMapHandler)
		{
			ULoadMapNotify.__BindBeginLoadMap_Internal(base.NativePtr, (BeginLoadMapHandler != null) ? BeginLoadMapHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06008735 RID: 34613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __UnloadStreamLevel_Internal(IntPtr @this, in FName Path, bool bShouldBlockOnLoad);

		// Token: 0x06008736 RID: 34614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUnLoadStreamLevel_Internal(IntPtr @this, int LinkID);

		// Token: 0x06008737 RID: 34615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLoadStreamLevel_Internal(IntPtr @this, int LinkID);

		// Token: 0x06008738 RID: 34616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadStreamLevel_Internal(IntPtr @this, in FName Path, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad);

		// Token: 0x06008739 RID: 34617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x0600873A RID: 34618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindUnLoadStreamLevel_Internal(IntPtr @this, IntPtr UnLoadStreamLevelHandler);

		// Token: 0x0600873B RID: 34619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindLoadStreamLevel_Internal(IntPtr @this, IntPtr LoadStreamLevelHandler);

		// Token: 0x0600873C RID: 34620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindEndLoadTransitionMap_Internal(IntPtr @this, IntPtr EndLoadTransitionMapHandler);

		// Token: 0x0600873D RID: 34621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindEndLoadMap_Internal(IntPtr @this, IntPtr EndLoadMapHandler);

		// Token: 0x0600873E RID: 34622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindBeginTravelLoadMap_Internal(IntPtr @this, IntPtr BeginTravelLoadMapHandler);

		// Token: 0x0600873F RID: 34623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindBeginLoadMap_Internal(IntPtr @this, IntPtr BeginLoadMapHandler);

		// Token: 0x06008740 RID: 34624 RVA: 0x000CAD49 File Offset: 0x000C8F49
		static ULoadMapNotify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.LoadMapNotify");
		}

		// Token: 0x06008741 RID: 34625 RVA: 0x000CAD57 File Offset: 0x000C8F57
		protected ULoadMapNotify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003AD5 RID: 15061
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.LoadMapNotify";

		// Token: 0x04003AD6 RID: 15062
		private static IntPtr _ClassPtr;

		// Token: 0x04003AD7 RID: 15063
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
