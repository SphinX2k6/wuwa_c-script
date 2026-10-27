using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016F1 RID: 5873
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletCoreSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroBulletCoreSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015334 RID: 86836 RVA: 0x001F295E File Offset: 0x001F0B5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletCoreSubsystem._ClassPtr;
		}

		// Token: 0x06015335 RID: 86837 RVA: 0x001F296C File Offset: 0x001F0B6C
		public UKuroBulletCoreSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletCoreSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015336 RID: 86838 RVA: 0x001F2994 File Offset: 0x001F0B94
		[NullableContext(1)]
		public UKuroBulletCoreSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletCoreSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015337 RID: 86839 RVA: 0x001F29C7 File Offset: 0x001F0BC7
		[NullableContext(2)]
		public UBulletWorld GetBulletWorld()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletWorld>(UKuroBulletCoreSubsystem.__GetBulletWorld_Internal(base.NativePtr));
		}

		// Token: 0x06015338 RID: 86840 RVA: 0x001F29D9 File Offset: 0x001F0BD9
		public void DestroyWorld()
		{
			UKuroBulletCoreSubsystem.__DestroyWorld_Internal(base.NativePtr);
		}

		// Token: 0x06015339 RID: 86841 RVA: 0x001F29E6 File Offset: 0x001F0BE6
		[NullableContext(2)]
		public UBulletWorld CreateWorld()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletWorld>(UKuroBulletCoreSubsystem.__CreateWorld_Internal(base.NativePtr));
		}

		// Token: 0x0601533A RID: 86842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBulletWorld_Internal(IntPtr @this);

		// Token: 0x0601533B RID: 86843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyWorld_Internal(IntPtr @this);

		// Token: 0x0601533C RID: 86844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateWorld_Internal(IntPtr @this);

		// Token: 0x0601533D RID: 86845 RVA: 0x001F29F8 File Offset: 0x001F0BF8
		static UKuroBulletCoreSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletCoreSubsystem");
		}

		// Token: 0x0601533E RID: 86846 RVA: 0x001F2A06 File Offset: 0x001F0C06
		protected UKuroBulletCoreSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B8FE RID: 47358
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletCoreSubsystem";

		// Token: 0x0400B8FF RID: 47359
		private static IntPtr _ClassPtr;

		// Token: 0x0400B900 RID: 47360
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
