using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200058E RID: 1422
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Player")]
	[UnrealStructLayout(1656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1656)]
	public class AKSC_Shape2D_Entity_Player : AKSC_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060080AC RID: 32940 RVA: 0x000BE0E6 File Offset: 0x000BC2E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity_Player._ClassPtr;
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x000BE0F4 File Offset: 0x000BC2F4
		public AKSC_Shape2D_Entity_Player() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Player.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x000BE11C File Offset: 0x000BC31C
		[NullableContext(1)]
		public AKSC_Shape2D_Entity_Player(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Player.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x060080AF RID: 32943 RVA: 0x000BE14F File Offset: 0x000BC34F
		// (set) Token: 0x060080B0 RID: 32944 RVA: 0x000BE15F File Offset: 0x000BC35F
		public unsafe bool IsPlayerAlive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Player.__PropertyOffset_IsPlayerAlive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Player.__PropertyOffset_IsPlayerAlive) = (value ? 1 : 0);
			}
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x000BE170 File Offset: 0x000BC370
		public void UseSkill(int SkillIndex)
		{
			AKSC_Shape2D_Entity_Player.__UseSkill_Internal(base.NativePtr, SkillIndex);
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x000BE17E File Offset: 0x000BC37E
		public void SetIsEnable(bool InIsEnable)
		{
			AKSC_Shape2D_Entity_Player.__SetIsEnable_Internal(base.NativePtr, InIsEnable);
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x000BE18C File Offset: 0x000BC38C
		public unsafe void SetEntityTransformDebug(in FTransform Transform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			AKSC_Shape2D_Entity_Player.__SetEntityTransformDebug_Internal(base.NativePtr, ptr);
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x000BE1C1 File Offset: 0x000BC3C1
		public void OnLifeChange(EKSC_AttrType AttrType, int Value)
		{
			AKSC_Shape2D_Entity_Player.__OnLifeChange_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x000BE1D0 File Offset: 0x000BC3D0
		public bool GetIsEnable()
		{
			return AKSC_Shape2D_Entity_Player.__GetIsEnable_Internal(base.NativePtr);
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x000BE1DD File Offset: 0x000BC3DD
		[NullableContext(2)]
		public void AssignPlayerStateChange(in FOnPlayerStateChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnPlayerStateChange fonPlayerStateChange = InDelegate;
			AKSC_Shape2D_Entity_Player.__AssignPlayerStateChange_Internal(nativePtr, (fonPlayerStateChange != null) ? fonPlayerStateChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060080B7 RID: 32951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UseSkill_Internal(IntPtr @this, int SkillIndex);

		// Token: 0x060080B8 RID: 32952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsEnable_Internal(IntPtr @this, bool InIsEnable);

		// Token: 0x060080B9 RID: 32953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEntityTransformDebug_Internal(IntPtr @this, in FTransform Transform);

		// Token: 0x060080BA RID: 32954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLifeChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x060080BB RID: 32955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsEnable_Internal(IntPtr @this);

		// Token: 0x060080BC RID: 32956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignPlayerStateChange_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060080BD RID: 32957 RVA: 0x000BE1F9 File Offset: 0x000BC3F9
		static AKSC_Shape2D_Entity_Player()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Player");
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x000BE207 File Offset: 0x000BC407
		protected AKSC_Shape2D_Entity_Player(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003832 RID: 14386
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Player";

		// Token: 0x04003833 RID: 14387
		private static IntPtr _ClassPtr;

		// Token: 0x04003834 RID: 14388
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003835 RID: 14389
		internal static int __PropertyOffset_IsPlayerAlive;
	}
}
