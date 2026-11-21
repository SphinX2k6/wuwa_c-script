using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000432 RID: 1074
	[UnrealObjectPath("/Script/KuroGAS.BaseGameplayAbility")]
	[UnrealStructLayout(968, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 968)]
	public class UBaseGameplayAbility : UGameplayAbility, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600683A RID: 26682 RVA: 0x00098335 File Offset: 0x00096535
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseGameplayAbility._ClassPtr;
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x00098344 File Offset: 0x00096544
		public UBaseGameplayAbility() : this(BuiltinUtils.AllocNativeUObject(UBaseGameplayAbility.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x0009836C File Offset: 0x0009656C
		[NullableContext(1)]
		public UBaseGameplayAbility(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseGameplayAbility.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x0600683D RID: 26685 RVA: 0x0009839F File Offset: 0x0009659F
		// (set) Token: 0x0600683E RID: 26686 RVA: 0x000983AF File Offset: 0x000965AF
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

		// Token: 0x0600683F RID: 26687 RVA: 0x000983C0 File Offset: 0x000965C0
		public virtual void PreAvatarSet()
		{
			UBaseGameplayAbility.__PreAvatarSet_Internal(base.NativePtr);
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x000983CD File Offset: 0x000965CD
		public float GetCallerMagnitudeByTag(in FGameplayTag Tag)
		{
			return UBaseGameplayAbility.__GetCallerMagnitudeByTag_Internal(base.NativePtr, Tag);
		}

		// Token: 0x06006841 RID: 26689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreAvatarSet_Internal(IntPtr @this);

		// Token: 0x06006842 RID: 26690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCallerMagnitudeByTag_Internal(IntPtr @this, in FGameplayTag Tag);

		// Token: 0x06006843 RID: 26691 RVA: 0x000983DB File Offset: 0x000965DB
		static UBaseGameplayAbility()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.BaseGameplayAbility");
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x000983E9 File Offset: 0x000965E9
		protected UBaseGameplayAbility(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002C91 RID: 11409
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.BaseGameplayAbility";

		// Token: 0x04002C92 RID: 11410
		private static IntPtr _ClassPtr;

		// Token: 0x04002C93 RID: 11411
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002C94 RID: 11412
		internal static int __PropertyOffset_StartOnGiven;
	}
}
