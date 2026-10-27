using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E61 RID: 7777
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KuroSimpleCombatSubsystem")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKuroSimpleCombatSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DA3E RID: 121406 RVA: 0x002BC2F8 File Offset: 0x002BA4F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSimpleCombatSubsystem._ClassPtr;
		}

		// Token: 0x0601DA3F RID: 121407 RVA: 0x002BC304 File Offset: 0x002BA504
		public UKuroSimpleCombatSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroSimpleCombatSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DA40 RID: 121408 RVA: 0x002BC32C File Offset: 0x002BA52C
		[NullableContext(1)]
		public UKuroSimpleCombatSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSimpleCombatSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007767 RID: 30567
		// (get) Token: 0x0601DA41 RID: 121409 RVA: 0x002BC35F File Offset: 0x002BA55F
		// (set) Token: 0x0601DA42 RID: 121410 RVA: 0x002BC373 File Offset: 0x002BA573
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

		// Token: 0x17007768 RID: 30568
		// (get) Token: 0x0601DA43 RID: 121411 RVA: 0x002BC388 File Offset: 0x002BA588
		// (set) Token: 0x0601DA44 RID: 121412 RVA: 0x002BC39C File Offset: 0x002BA59C
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

		// Token: 0x0601DA45 RID: 121413 RVA: 0x002BC3B1 File Offset: 0x002BA5B1
		public UKSC_World GetKSCWorld()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_World>(UKuroSimpleCombatSubsystem.__GetKSCWorld_Internal(base.NativePtr));
		}

		// Token: 0x0601DA46 RID: 121414 RVA: 0x002BC3C3 File Offset: 0x002BA5C3
		public void DestroyWorld()
		{
			UKuroSimpleCombatSubsystem.__DestroyWorld_Internal(base.NativePtr);
		}

		// Token: 0x0601DA47 RID: 121415 RVA: 0x002BC3D0 File Offset: 0x002BA5D0
		public void DestoryWorld()
		{
			UKuroSimpleCombatSubsystem.__DestoryWorld_Internal(base.NativePtr);
		}

		// Token: 0x0601DA48 RID: 121416 RVA: 0x002BC3DD File Offset: 0x002BA5DD
		public UKSC_World CreateWorld([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UKSC_World> WorldClass = default(TSubclassOf<UKSC_World>))
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_World>(UKuroSimpleCombatSubsystem.__CreateWorld_Internal(base.NativePtr, WorldClass._NativePtr));
		}

		// Token: 0x0601DA49 RID: 121417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKSCWorld_Internal(IntPtr @this);

		// Token: 0x0601DA4A RID: 121418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyWorld_Internal(IntPtr @this);

		// Token: 0x0601DA4B RID: 121419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestoryWorld_Internal(IntPtr @this);

		// Token: 0x0601DA4C RID: 121420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateWorld_Internal(IntPtr @this, IntPtr WorldClass);

		// Token: 0x0601DA4D RID: 121421 RVA: 0x002BC3F5 File Offset: 0x002BA5F5
		static UKuroSimpleCombatSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KuroSimpleCombatSubsystem");
		}

		// Token: 0x0601DA4E RID: 121422 RVA: 0x002BC403 File Offset: 0x002BA603
		protected UKuroSimpleCombatSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010100 RID: 65792
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KuroSimpleCombatSubsystem";

		// Token: 0x04010101 RID: 65793
		private static IntPtr _ClassPtr;

		// Token: 0x04010102 RID: 65794
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010103 RID: 65795
		internal static int __PropertyOffset_KscWorld;

		// Token: 0x04010104 RID: 65796
		internal static int __PropertyOffset_OldKscWorld;
	}
}
