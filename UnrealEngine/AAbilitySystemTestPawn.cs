using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012F2 RID: 4850
	[UnrealObjectPath("/Script/GameplayAbilities.AbilitySystemTestPawn")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class AAbilitySystemTestPawn : ADefaultPawn, IUnrealUObject, IUnrealObject, IGameplayCueInterface, IUnrealNativeInterface, IUnrealInterface, IAbilitySystemInterface
	{
		// Token: 0x06011DE7 RID: 73191 RVA: 0x001A35F2 File Offset: 0x001A17F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAbilitySystemTestPawn._ClassPtr;
		}

		// Token: 0x06011DE8 RID: 73192 RVA: 0x001A35FE File Offset: 0x001A17FE
		int IGameplayCueInterface.InterfaceOffset()
		{
			return AAbilitySystemTestPawn.__InterfaceOffset_IGameplayCueInterface;
		}

		// Token: 0x06011DE9 RID: 73193 RVA: 0x001A3605 File Offset: 0x001A1805
		int IAbilitySystemInterface.InterfaceOffset()
		{
			return AAbilitySystemTestPawn.__InterfaceOffset_IAbilitySystemInterface;
		}

		// Token: 0x06011DEA RID: 73194 RVA: 0x001A360C File Offset: 0x001A180C
		public AAbilitySystemTestPawn() : this(BuiltinUtils.AllocNativeUObject(AAbilitySystemTestPawn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011DEB RID: 73195 RVA: 0x001A3634 File Offset: 0x001A1834
		[NullableContext(1)]
		public AAbilitySystemTestPawn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAbilitySystemTestPawn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045CB RID: 17867
		// (get) Token: 0x06011DEC RID: 73196 RVA: 0x001A3667 File Offset: 0x001A1867
		// (set) Token: 0x06011DED RID: 73197 RVA: 0x001A367B File Offset: 0x001A187B
		[Nullable(2)]
		public unsafe UAbilitySystemComponent AbilitySystemComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAbilitySystemTestPawn.__PropertyOffset_AbilitySystemComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAbilitySystemTestPawn.__PropertyOffset_AbilitySystemComponent, value);
			}
		}

		// Token: 0x06011DEE RID: 73198 RVA: 0x001A3690 File Offset: 0x001A1890
		static AAbilitySystemTestPawn()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilitySystemTestPawn");
		}

		// Token: 0x06011DEF RID: 73199 RVA: 0x001A369E File Offset: 0x001A189E
		protected AAbilitySystemTestPawn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040098E0 RID: 39136
		internal static int __InterfaceOffset_IGameplayCueInterface;

		// Token: 0x040098E1 RID: 39137
		internal static int __InterfaceOffset_IAbilitySystemInterface;

		// Token: 0x040098E2 RID: 39138
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilitySystemTestPawn";

		// Token: 0x040098E3 RID: 39139
		private static IntPtr _ClassPtr;

		// Token: 0x040098E4 RID: 39140
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040098E5 RID: 39141
		internal static int __PropertyOffset_AbilitySystemComponent;
	}
}
