using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EDD RID: 7901
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.LoadMapNotify")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class ULoadMapNotify : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E0B7 RID: 123063 RVA: 0x002C966E File Offset: 0x002C786E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULoadMapNotify._ClassPtr;
		}

		// Token: 0x0601E0B8 RID: 123064 RVA: 0x002C967C File Offset: 0x002C787C
		public ULoadMapNotify() : this(BuiltinUtils.AllocNativeUObject(ULoadMapNotify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E0B9 RID: 123065 RVA: 0x002C96A4 File Offset: 0x002C78A4
		[NullableContext(1)]
		public ULoadMapNotify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULoadMapNotify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E0BA RID: 123066 RVA: 0x002C96D8 File Offset: 0x002C78D8
		public unsafe int UnloadStreamLevel(in FName Path, bool bShouldBlockOnLoad)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return ULoadMapNotify.__UnloadStreamLevel_Internal(base.NativePtr, Path, bShouldBlockOnLoad);
			}
		}

		// Token: 0x0601E0BB RID: 123067 RVA: 0x002C96F7 File Offset: 0x002C78F7
		public void OnUnLoadStreamLevel(int LinkID)
		{
			ULoadMapNotify.__OnUnLoadStreamLevel_Internal(base.NativePtr, LinkID);
		}

		// Token: 0x0601E0BC RID: 123068 RVA: 0x002C9705 File Offset: 0x002C7905
		public void OnLoadStreamLevel(int LinkID)
		{
			ULoadMapNotify.__OnLoadStreamLevel_Internal(base.NativePtr, LinkID);
		}

		// Token: 0x0601E0BD RID: 123069 RVA: 0x002C9714 File Offset: 0x002C7914
		public unsafe int LoadStreamLevel(in FName Path, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad)
		{
			fixed (FName* ptr = &Path)
			{
				void* ptr2 = (void*)ptr;
				return ULoadMapNotify.__LoadStreamLevel_Internal(base.NativePtr, Path, bMakeVisibleAfterLoad, bShouldBlockOnLoad);
			}
		}

		// Token: 0x0601E0BE RID: 123070 RVA: 0x002C9734 File Offset: 0x002C7934
		public void Clear()
		{
			ULoadMapNotify.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x0601E0BF RID: 123071 RVA: 0x002C9741 File Offset: 0x002C7941
		public void BindUnLoadStreamLevel(FUnLoadStreamLevelDelegate UnLoadStreamLevelHandler)
		{
			ULoadMapNotify.__BindUnLoadStreamLevel_Internal(base.NativePtr, (UnLoadStreamLevelHandler != null) ? UnLoadStreamLevelHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601E0C0 RID: 123072 RVA: 0x002C975B File Offset: 0x002C795B
		public void BindLoadStreamLevel(FLoadStreamLevelDelegate LoadStreamLevelHandler)
		{
			ULoadMapNotify.__BindLoadStreamLevel_Internal(base.NativePtr, (LoadStreamLevelHandler != null) ? LoadStreamLevelHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601E0C1 RID: 123073 RVA: 0x002C9775 File Offset: 0x002C7975
		public void BindEndLoadTransitionMap(FEndLoadTransitionMapDelegate EndLoadTransitionMapHandler)
		{
			ULoadMapNotify.__BindEndLoadTransitionMap_Internal(base.NativePtr, (EndLoadTransitionMapHandler != null) ? EndLoadTransitionMapHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601E0C2 RID: 123074 RVA: 0x002C978F File Offset: 0x002C798F
		public void BindEndLoadMap(FEndLoadMapDelegate EndLoadMapHandler)
		{
			ULoadMapNotify.__BindEndLoadMap_Internal(base.NativePtr, (EndLoadMapHandler != null) ? EndLoadMapHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601E0C3 RID: 123075 RVA: 0x002C97A9 File Offset: 0x002C79A9
		public void BindBeginTravelLoadMap(FBeginTravelLoadMapDelegate BeginTravelLoadMapHandler)
		{
			ULoadMapNotify.__BindBeginTravelLoadMap_Internal(base.NativePtr, (BeginTravelLoadMapHandler != null) ? BeginTravelLoadMapHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601E0C4 RID: 123076 RVA: 0x002C97C3 File Offset: 0x002C79C3
		public void BindBeginLoadMap(FBeginLoadMapDelegate BeginLoadMapHandler)
		{
			ULoadMapNotify.__BindBeginLoadMap_Internal(base.NativePtr, (BeginLoadMapHandler != null) ? BeginLoadMapHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601E0C5 RID: 123077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __UnloadStreamLevel_Internal(IntPtr @this, in FName Path, bool bShouldBlockOnLoad);

		// Token: 0x0601E0C6 RID: 123078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUnLoadStreamLevel_Internal(IntPtr @this, int LinkID);

		// Token: 0x0601E0C7 RID: 123079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLoadStreamLevel_Internal(IntPtr @this, int LinkID);

		// Token: 0x0601E0C8 RID: 123080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __LoadStreamLevel_Internal(IntPtr @this, in FName Path, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad);

		// Token: 0x0601E0C9 RID: 123081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x0601E0CA RID: 123082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindUnLoadStreamLevel_Internal(IntPtr @this, IntPtr UnLoadStreamLevelHandler);

		// Token: 0x0601E0CB RID: 123083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindLoadStreamLevel_Internal(IntPtr @this, IntPtr LoadStreamLevelHandler);

		// Token: 0x0601E0CC RID: 123084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindEndLoadTransitionMap_Internal(IntPtr @this, IntPtr EndLoadTransitionMapHandler);

		// Token: 0x0601E0CD RID: 123085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindEndLoadMap_Internal(IntPtr @this, IntPtr EndLoadMapHandler);

		// Token: 0x0601E0CE RID: 123086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindBeginTravelLoadMap_Internal(IntPtr @this, IntPtr BeginTravelLoadMapHandler);

		// Token: 0x0601E0CF RID: 123087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindBeginLoadMap_Internal(IntPtr @this, IntPtr BeginLoadMapHandler);

		// Token: 0x0601E0D0 RID: 123088 RVA: 0x002C97DD File Offset: 0x002C79DD
		static ULoadMapNotify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.LoadMapNotify");
		}

		// Token: 0x0601E0D1 RID: 123089 RVA: 0x002C97EB File Offset: 0x002C79EB
		protected ULoadMapNotify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103F1 RID: 66545
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.LoadMapNotify";

		// Token: 0x040103F2 RID: 66546
		private static IntPtr _ClassPtr;

		// Token: 0x040103F3 RID: 66547
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
