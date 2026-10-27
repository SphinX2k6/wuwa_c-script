using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200187A RID: 6266
	[UnrealObjectPath("/Script/KuroGameplayInterface.KuroWaterDetectedInterfaceHelperLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroWaterDetectedInterfaceHelperLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601712D RID: 94509 RVA: 0x0021A064 File Offset: 0x00218264
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWaterDetectedInterfaceHelperLibrary._ClassPtr;
		}

		// Token: 0x0601712E RID: 94510 RVA: 0x0021A070 File Offset: 0x00218270
		public UKuroWaterDetectedInterfaceHelperLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroWaterDetectedInterfaceHelperLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601712F RID: 94511 RVA: 0x0021A098 File Offset: 0x00218298
		[NullableContext(1)]
		public UKuroWaterDetectedInterfaceHelperLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWaterDetectedInterfaceHelperLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017130 RID: 94512 RVA: 0x0021A0CB File Offset: 0x002182CB
		[NullableContext(2)]
		public static void Execute_BroadcastWaterDetectedTick(UObject Object, float DeltaTime, float WaterSurface, FVector Location)
		{
			UKuroWaterDetectedInterfaceHelperLibrary.__Execute_BroadcastWaterDetectedTick_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, DeltaTime, WaterSurface, Location);
		}

		// Token: 0x06017131 RID: 94513 RVA: 0x0021A0E5 File Offset: 0x002182E5
		[NullableContext(2)]
		public static void Execute_BroadcastWaterDetectedStart(UObject Object)
		{
			UKuroWaterDetectedInterfaceHelperLibrary.__Execute_BroadcastWaterDetectedStart_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017132 RID: 94514 RVA: 0x0021A0FC File Offset: 0x002182FC
		[NullableContext(2)]
		public static void Execute_BroadcastWaterDetectedEnd(UObject Object)
		{
			UKuroWaterDetectedInterfaceHelperLibrary.__Execute_BroadcastWaterDetectedEnd_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017133 RID: 94515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Execute_BroadcastWaterDetectedTick_Internal(IntPtr Object, float DeltaTime, float WaterSurface, FVector Location);

		// Token: 0x06017134 RID: 94516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Execute_BroadcastWaterDetectedStart_Internal(IntPtr Object);

		// Token: 0x06017135 RID: 94517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Execute_BroadcastWaterDetectedEnd_Internal(IntPtr Object);

		// Token: 0x06017136 RID: 94518 RVA: 0x0021A113 File Offset: 0x00218313
		static UKuroWaterDetectedInterfaceHelperLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayInterface.KuroWaterDetectedInterfaceHelperLibrary");
		}

		// Token: 0x06017137 RID: 94519 RVA: 0x0021A121 File Offset: 0x00218321
		protected UKuroWaterDetectedInterfaceHelperLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C854 RID: 51284
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayInterface.KuroWaterDetectedInterfaceHelperLibrary";

		// Token: 0x0400C855 RID: 51285
		private static IntPtr _ClassPtr;

		// Token: 0x0400C856 RID: 51286
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
