using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AF RID: 943
	[UnrealObjectPath("/Script/AugmentedReality.ARMeshGeometry")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UARMeshGeometry : UARTrackedGeometry, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003444 RID: 13380 RVA: 0x0004FEA8 File Offset: 0x0004E0A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARMeshGeometry._ClassPtr;
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x0004FEB4 File Offset: 0x0004E0B4
		public UARMeshGeometry() : this(BuiltinUtils.AllocNativeUObject(UARMeshGeometry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x0004FEDC File Offset: 0x0004E0DC
		[NullableContext(1)]
		public UARMeshGeometry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARMeshGeometry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x0004FF10 File Offset: 0x0004E110
		public unsafe bool GetObjectClassificationAtLocation(in FVector InWorldLocation, ref EARObjectClassification OutClassification, ref FVector OutClassificationLocation, float MaxLocationDiff = 10f)
		{
			fixed (EARObjectClassification* ptr = &OutClassification)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &OutClassificationLocation)
				{
					void* ptr4 = (void*)ptr3;
					return UARMeshGeometry.__GetObjectClassificationAtLocation_Internal(base.NativePtr, InWorldLocation, ref OutClassification, ref OutClassificationLocation, MaxLocationDiff);
				}
			}
		}

		// Token: 0x06003448 RID: 13384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetObjectClassificationAtLocation_Internal(IntPtr @this, in FVector InWorldLocation, ref EARObjectClassification OutClassification, ref FVector OutClassificationLocation, float MaxLocationDiff);

		// Token: 0x06003449 RID: 13385 RVA: 0x0004FF37 File Offset: 0x0004E137
		static UARMeshGeometry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARMeshGeometry");
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x0004FF45 File Offset: 0x0004E145
		protected UARMeshGeometry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040016B0 RID: 5808
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARMeshGeometry";

		// Token: 0x040016B1 RID: 5809
		private static IntPtr _ClassPtr;

		// Token: 0x040016B2 RID: 5810
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
