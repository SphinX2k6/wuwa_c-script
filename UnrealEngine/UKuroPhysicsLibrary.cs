using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EC7 RID: 7879
	[UnrealObjectPath("/Script/KuroUtility.KuroPhysicsLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPhysicsLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE5F RID: 122463 RVA: 0x002C3917 File Offset: 0x002C1B17
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPhysicsLibrary._ClassPtr;
		}

		// Token: 0x0601DE60 RID: 122464 RVA: 0x002C3924 File Offset: 0x002C1B24
		public UKuroPhysicsLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPhysicsLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE61 RID: 122465 RVA: 0x002C394C File Offset: 0x002C1B4C
		[NullableContext(1)]
		public UKuroPhysicsLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPhysicsLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DE62 RID: 122466 RVA: 0x002C3980 File Offset: 0x002C1B80
		[NullableContext(2)]
		public static bool GetSphereHitPoint(FVectorDouble StartLocation, FVectorDouble EndLocation, AActor Actor, UPrimitiveComponent TraceComp, float Radius, UKuroHitResult HitResult, float DrawDuration = 0f, bool ForceTrace = false)
		{
			return UKuroPhysicsLibrary.__GetSphereHitPoint_Internal(StartLocation, EndLocation, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, (TraceComp != null) ? TraceComp.NativePtr : IntPtr.Zero, Radius, (HitResult != null) ? HitResult.NativePtr : IntPtr.Zero, DrawDuration, ForceTrace);
		}

		// Token: 0x0601DE63 RID: 122467 RVA: 0x002C39CC File Offset: 0x002C1BCC
		[NullableContext(2)]
		public static bool GetHitPoint(FVectorDouble StartLocation, FVectorDouble EndLocation, AActor Actor, UPrimitiveComponent TraceComp, UKuroHitResult HitResult, float DrawDuration = 0f, bool ForceTrace = false)
		{
			return UKuroPhysicsLibrary.__GetHitPoint_Internal(StartLocation, EndLocation, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, (TraceComp != null) ? TraceComp.NativePtr : IntPtr.Zero, (HitResult != null) ? HitResult.NativePtr : IntPtr.Zero, DrawDuration, ForceTrace);
		}

		// Token: 0x0601DE64 RID: 122468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSphereHitPoint_Internal(FVectorDouble StartLocation, FVectorDouble EndLocation, IntPtr Actor, IntPtr TraceComp, float Radius, IntPtr HitResult, float DrawDuration, bool ForceTrace);

		// Token: 0x0601DE65 RID: 122469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitPoint_Internal(FVectorDouble StartLocation, FVectorDouble EndLocation, IntPtr Actor, IntPtr TraceComp, IntPtr HitResult, float DrawDuration, bool ForceTrace);

		// Token: 0x0601DE66 RID: 122470 RVA: 0x002C3A0B File Offset: 0x002C1C0B
		static UKuroPhysicsLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroPhysicsLibrary");
		}

		// Token: 0x0601DE67 RID: 122471 RVA: 0x002C3A19 File Offset: 0x002C1C19
		protected UKuroPhysicsLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010308 RID: 66312
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroPhysicsLibrary";

		// Token: 0x04010309 RID: 66313
		private static IntPtr _ClassPtr;

		// Token: 0x0401030A RID: 66314
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
