using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E38 RID: 7736
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Player")]
	[UnrealStructLayout(1656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1656)]
	public class AKSC_Shape2D_Entity_Player : AKSC_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D78F RID: 120719 RVA: 0x002B85F2 File Offset: 0x002B67F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity_Player._ClassPtr;
		}

		// Token: 0x0601D790 RID: 120720 RVA: 0x002B8600 File Offset: 0x002B6800
		public AKSC_Shape2D_Entity_Player() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Player.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D791 RID: 120721 RVA: 0x002B8628 File Offset: 0x002B6828
		[NullableContext(1)]
		public AKSC_Shape2D_Entity_Player(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Player.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076C8 RID: 30408
		// (get) Token: 0x0601D792 RID: 120722 RVA: 0x002B865B File Offset: 0x002B685B
		// (set) Token: 0x0601D793 RID: 120723 RVA: 0x002B866B File Offset: 0x002B686B
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

		// Token: 0x0601D794 RID: 120724 RVA: 0x002B867C File Offset: 0x002B687C
		public void UseSkill(int SkillIndex)
		{
			AKSC_Shape2D_Entity_Player.__UseSkill_Internal(base.NativePtr, SkillIndex);
		}

		// Token: 0x0601D795 RID: 120725 RVA: 0x002B868A File Offset: 0x002B688A
		public void SetIsEnable(bool InIsEnable)
		{
			AKSC_Shape2D_Entity_Player.__SetIsEnable_Internal(base.NativePtr, InIsEnable);
		}

		// Token: 0x0601D796 RID: 120726 RVA: 0x002B8698 File Offset: 0x002B6898
		public unsafe void SetEntityTransformDebug(in FTransform Transform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			AKSC_Shape2D_Entity_Player.__SetEntityTransformDebug_Internal(base.NativePtr, ptr);
		}

		// Token: 0x0601D797 RID: 120727 RVA: 0x002B86CD File Offset: 0x002B68CD
		public void OnLifeChange(EKSC_AttrType AttrType, int Value)
		{
			AKSC_Shape2D_Entity_Player.__OnLifeChange_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601D798 RID: 120728 RVA: 0x002B86DC File Offset: 0x002B68DC
		public bool GetIsEnable()
		{
			return AKSC_Shape2D_Entity_Player.__GetIsEnable_Internal(base.NativePtr);
		}

		// Token: 0x0601D799 RID: 120729 RVA: 0x002B86E9 File Offset: 0x002B68E9
		[NullableContext(2)]
		public void AssignPlayerStateChange(in FOnPlayerStateChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnPlayerStateChange fonPlayerStateChange = InDelegate;
			AKSC_Shape2D_Entity_Player.__AssignPlayerStateChange_Internal(nativePtr, (fonPlayerStateChange != null) ? fonPlayerStateChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601D79A RID: 120730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UseSkill_Internal(IntPtr @this, int SkillIndex);

		// Token: 0x0601D79B RID: 120731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsEnable_Internal(IntPtr @this, bool InIsEnable);

		// Token: 0x0601D79C RID: 120732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEntityTransformDebug_Internal(IntPtr @this, in FTransform Transform);

		// Token: 0x0601D79D RID: 120733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLifeChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601D79E RID: 120734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsEnable_Internal(IntPtr @this);

		// Token: 0x0601D79F RID: 120735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignPlayerStateChange_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601D7A0 RID: 120736 RVA: 0x002B8705 File Offset: 0x002B6905
		static AKSC_Shape2D_Entity_Player()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Player");
		}

		// Token: 0x0601D7A1 RID: 120737 RVA: 0x002B8713 File Offset: 0x002B6913
		protected AKSC_Shape2D_Entity_Player(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFAA RID: 65450
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Player";

		// Token: 0x0400FFAB RID: 65451
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFAC RID: 65452
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FFAD RID: 65453
		internal static int __PropertyOffset_IsPlayerAlive;
	}
}
