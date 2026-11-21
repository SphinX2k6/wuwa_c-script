using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000595 RID: 1429
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KuroSimpleCombatSubsystem")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKuroSimpleCombatSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060081BA RID: 33210 RVA: 0x000BF710 File Offset: 0x000BD910
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSimpleCombatSubsystem._ClassPtr;
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x000BF71C File Offset: 0x000BD91C
		public UKuroSimpleCombatSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroSimpleCombatSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x000BF744 File Offset: 0x000BD944
		[NullableContext(1)]
		public UKuroSimpleCombatSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSimpleCombatSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060081BD RID: 33213 RVA: 0x000BF777 File Offset: 0x000BD977
		// (set) Token: 0x060081BE RID: 33214 RVA: 0x000BF78B File Offset: 0x000BD98B
		public unsafe UKSC_World KscWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSimpleCombatSubsystem.__PropertyOffset_KscWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSimpleCombatSubsystem.__PropertyOffset_KscWorld, value);
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060081BF RID: 33215 RVA: 0x000BF7A0 File Offset: 0x000BD9A0
		// (set) Token: 0x060081C0 RID: 33216 RVA: 0x000BF7B4 File Offset: 0x000BD9B4
		public unsafe UKSC_World OldKscWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSimpleCombatSubsystem.__PropertyOffset_OldKscWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSimpleCombatSubsystem.__PropertyOffset_OldKscWorld, value);
			}
		}

		// Token: 0x060081C1 RID: 33217 RVA: 0x000BF7C9 File Offset: 0x000BD9C9
		public UKSC_World GetKSCWorld()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_World>(UKuroSimpleCombatSubsystem.__GetKSCWorld_Internal(base.NativePtr));
		}

		// Token: 0x060081C2 RID: 33218 RVA: 0x000BF7DB File Offset: 0x000BD9DB
		public void DestroyWorld()
		{
			UKuroSimpleCombatSubsystem.__DestroyWorld_Internal(base.NativePtr);
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x000BF7E8 File Offset: 0x000BD9E8
		public void DestoryWorld()
		{
			UKuroSimpleCombatSubsystem.__DestoryWorld_Internal(base.NativePtr);
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x000BF7F5 File Offset: 0x000BD9F5
		public UKSC_World CreateWorld([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UKSC_World> WorldClass = default(TSubclassOf<UKSC_World>))
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_World>(UKuroSimpleCombatSubsystem.__CreateWorld_Internal(base.NativePtr, WorldClass._NativePtr));
		}

		// Token: 0x060081C5 RID: 33221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKSCWorld_Internal(IntPtr @this);

		// Token: 0x060081C6 RID: 33222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyWorld_Internal(IntPtr @this);

		// Token: 0x060081C7 RID: 33223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestoryWorld_Internal(IntPtr @this);

		// Token: 0x060081C8 RID: 33224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateWorld_Internal(IntPtr @this, IntPtr WorldClass);

		// Token: 0x060081C9 RID: 33225 RVA: 0x000BF80D File Offset: 0x000BDA0D
		static UKuroSimpleCombatSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KuroSimpleCombatSubsystem");
		}

		// Token: 0x060081CA RID: 33226 RVA: 0x000BF81B File Offset: 0x000BDA1B
		protected UKuroSimpleCombatSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400389C RID: 14492
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KuroSimpleCombatSubsystem";

		// Token: 0x0400389D RID: 14493
		private static IntPtr _ClassPtr;

		// Token: 0x0400389E RID: 14494
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400389F RID: 14495
		internal static int __PropertyOffset_KscWorld;

		// Token: 0x040038A0 RID: 14496
		internal static int __PropertyOffset_OldKscWorld;
	}
}
