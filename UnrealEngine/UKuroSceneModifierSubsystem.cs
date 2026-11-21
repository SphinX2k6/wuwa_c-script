using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200051E RID: 1310
	[UnrealObjectPath("/Script/KuroSceneModifier.KuroSceneModifierSubsystem")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UKuroSceneModifierSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007AA1 RID: 31393 RVA: 0x000B3D9A File Offset: 0x000B1F9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneModifierSubsystem._ClassPtr;
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x000B3DA8 File Offset: 0x000B1FA8
		public UKuroSceneModifierSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneModifierSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x000B3DD0 File Offset: 0x000B1FD0
		[NullableContext(1)]
		public UKuroSceneModifierSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneModifierSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x000B3E03 File Offset: 0x000B2003
		[NullableContext(2)]
		public void ResetMaterialsByDataLayer(in TSet<FName> InDataLayerLabels)
		{
			UKuroSceneModifierSubsystem.__ResetMaterialsByDataLayer_Internal(base.NativePtr, (InDataLayerLabels ?? new TSet<FName>()).NativeSetPtr);
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x000B3E20 File Offset: 0x000B2020
		[NullableContext(2)]
		public void ModifyMaterialsByDataLayer(in TSet<FName> InDataLayerLabels, UKuroSceneMatModifyDataAsset InMatDataAsset, bool bVisibleBeforeModify = false)
		{
			UKuroSceneModifierSubsystem.__ModifyMaterialsByDataLayer_Internal(base.NativePtr, (InDataLayerLabels ?? new TSet<FName>()).NativeSetPtr, (InMatDataAsset != null) ? InMatDataAsset.NativePtr : IntPtr.Zero, bVisibleBeforeModify);
		}

		// Token: 0x06007AA6 RID: 31398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMaterialsByDataLayer_Internal(IntPtr @this, IntPtr InDataLayerLabels);

		// Token: 0x06007AA7 RID: 31399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ModifyMaterialsByDataLayer_Internal(IntPtr @this, IntPtr InDataLayerLabels, IntPtr InMatDataAsset, bool bVisibleBeforeModify);

		// Token: 0x06007AA8 RID: 31400 RVA: 0x000B3E4E File Offset: 0x000B204E
		static UKuroSceneModifierSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSceneModifier.KuroSceneModifierSubsystem");
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x000B3E5C File Offset: 0x000B205C
		protected UKuroSceneModifierSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003427 RID: 13351
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSceneModifier.KuroSceneModifierSubsystem";

		// Token: 0x04003428 RID: 13352
		private static IntPtr _ClassPtr;

		// Token: 0x04003429 RID: 13353
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
