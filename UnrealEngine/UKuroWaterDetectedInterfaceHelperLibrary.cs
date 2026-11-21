using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A4 RID: 932
	[UnrealObjectPath("/Script/KuroGameplayInterface.KuroWaterDetectedInterfaceHelperLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroWaterDetectedInterfaceHelperLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005C37 RID: 23607 RVA: 0x00081F81 File Offset: 0x00080181
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWaterDetectedInterfaceHelperLibrary._ClassPtr;
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x00081F90 File Offset: 0x00080190
		public UKuroWaterDetectedInterfaceHelperLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroWaterDetectedInterfaceHelperLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005C39 RID: 23609 RVA: 0x00081FB8 File Offset: 0x000801B8
		[NullableContext(1)]
		public UKuroWaterDetectedInterfaceHelperLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWaterDetectedInterfaceHelperLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005C3A RID: 23610 RVA: 0x00081FEB File Offset: 0x000801EB
		[NullableContext(2)]
		public static void Execute_BroadcastWaterDetectedTick(UObject Object, float DeltaTime, float WaterSurface, FVector Location)
		{
			UKuroWaterDetectedInterfaceHelperLibrary.__Execute_BroadcastWaterDetectedTick_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, DeltaTime, WaterSurface, Location);
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x00082005 File Offset: 0x00080205
		[NullableContext(2)]
		public static void Execute_BroadcastWaterDetectedStart(UObject Object)
		{
			UKuroWaterDetectedInterfaceHelperLibrary.__Execute_BroadcastWaterDetectedStart_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x0008201C File Offset: 0x0008021C
		[NullableContext(2)]
		public static void Execute_BroadcastWaterDetectedEnd(UObject Object)
		{
			UKuroWaterDetectedInterfaceHelperLibrary.__Execute_BroadcastWaterDetectedEnd_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005C3D RID: 23613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Execute_BroadcastWaterDetectedTick_Internal(IntPtr Object, float DeltaTime, float WaterSurface, FVector Location);

		// Token: 0x06005C3E RID: 23614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Execute_BroadcastWaterDetectedStart_Internal(IntPtr Object);

		// Token: 0x06005C3F RID: 23615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Execute_BroadcastWaterDetectedEnd_Internal(IntPtr Object);

		// Token: 0x06005C40 RID: 23616 RVA: 0x00082033 File Offset: 0x00080233
		static UKuroWaterDetectedInterfaceHelperLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayInterface.KuroWaterDetectedInterfaceHelperLibrary");
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x00082041 File Offset: 0x00080241
		protected UKuroWaterDetectedInterfaceHelperLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400266B RID: 9835
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayInterface.KuroWaterDetectedInterfaceHelperLibrary";

		// Token: 0x0400266C RID: 9836
		private static IntPtr _ClassPtr;

		// Token: 0x0400266D RID: 9837
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
