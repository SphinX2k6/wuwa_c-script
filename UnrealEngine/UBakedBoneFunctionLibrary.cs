using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200087A RID: 2170
	[UnrealObjectPath("/Script/Engine.BakedBoneFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBakedBoneFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600762C RID: 30252 RVA: 0x000A98C0 File Offset: 0x000A7AC0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneFunctionLibrary._ClassPtr;
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x000A98CC File Offset: 0x000A7ACC
		public UBakedBoneFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x000A98F4 File Offset: 0x000A7AF4
		[NullableContext(1)]
		public UBakedBoneFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x000A9927 File Offset: 0x000A7B27
		[NullableContext(2)]
		public static void AppendMontageSectionInfoIntoAsset(UBakedBoneMontageInfoAsset Asset, UAnimMontage Montage, int AnimArrayIndex)
		{
			UBakedBoneFunctionLibrary.__AppendMontageSectionInfoIntoAsset_Internal((Asset != null) ? Asset.NativePtr : IntPtr.Zero, (Montage != null) ? Montage.NativePtr : IntPtr.Zero, AnimArrayIndex);
		}

		// Token: 0x06007630 RID: 30256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AppendMontageSectionInfoIntoAsset_Internal(IntPtr Asset, IntPtr Montage, int AnimArrayIndex);

		// Token: 0x06007631 RID: 30257 RVA: 0x000A994F File Offset: 0x000A7B4F
		static UBakedBoneFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneFunctionLibrary");
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x000A995D File Offset: 0x000A7B5D
		protected UBakedBoneFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038E8 RID: 14568
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BakedBoneFunctionLibrary";

		// Token: 0x040038E9 RID: 14569
		private static IntPtr _ClassPtr;

		// Token: 0x040038EA RID: 14570
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
