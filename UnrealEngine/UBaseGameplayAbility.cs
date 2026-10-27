using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200195D RID: 6493
	[UnrealObjectPath("/Script/KuroGAS.BaseGameplayAbility")]
	[UnrealStructLayout(968, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 968)]
	public class UBaseGameplayAbility : UGameplayAbility, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601823A RID: 98874 RVA: 0x0023952D File Offset: 0x0023772D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseGameplayAbility._ClassPtr;
		}

		// Token: 0x0601823B RID: 98875 RVA: 0x0023953C File Offset: 0x0023773C
		public UBaseGameplayAbility() : this(BuiltinUtils.AllocNativeUObject(UBaseGameplayAbility.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601823C RID: 98876 RVA: 0x00239564 File Offset: 0x00237764
		[NullableContext(1)]
		public UBaseGameplayAbility(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseGameplayAbility.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170060DC RID: 24796
		// (get) Token: 0x0601823D RID: 98877 RVA: 0x00239597 File Offset: 0x00237797
		// (set) Token: 0x0601823E RID: 98878 RVA: 0x002395A7 File Offset: 0x002377A7
		public unsafe bool StartOnGiven
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBaseGameplayAbility.__PropertyOffset_StartOnGiven) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBaseGameplayAbility.__PropertyOffset_StartOnGiven) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601823F RID: 98879 RVA: 0x002395B8 File Offset: 0x002377B8
		public virtual void PreAvatarSet()
		{
			UBaseGameplayAbility.__PreAvatarSet_Internal(base.NativePtr);
		}

		// Token: 0x06018240 RID: 98880 RVA: 0x002395C5 File Offset: 0x002377C5
		public float GetCallerMagnitudeByTag(in FGameplayTag Tag)
		{
			return UBaseGameplayAbility.__GetCallerMagnitudeByTag_Internal(base.NativePtr, Tag);
		}

		// Token: 0x06018241 RID: 98881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreAvatarSet_Internal(IntPtr @this);

		// Token: 0x06018242 RID: 98882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCallerMagnitudeByTag_Internal(IntPtr @this, in FGameplayTag Tag);

		// Token: 0x06018243 RID: 98883 RVA: 0x002395D3 File Offset: 0x002377D3
		static UBaseGameplayAbility()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.BaseGameplayAbility");
		}

		// Token: 0x06018244 RID: 98884 RVA: 0x002395E1 File Offset: 0x002377E1
		protected UBaseGameplayAbility(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D180 RID: 53632
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.BaseGameplayAbility";

		// Token: 0x0400D181 RID: 53633
		private static IntPtr _ClassPtr;

		// Token: 0x0400D182 RID: 53634
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D183 RID: 53635
		internal static int __PropertyOffset_StartOnGiven;
	}
}
