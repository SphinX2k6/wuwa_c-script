using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200180C RID: 6156
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.BatchSystemFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBatchSystemFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016C81 RID: 93313 RVA: 0x00213EA5 File Offset: 0x002120A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBatchSystemFunctionLibrary._ClassPtr;
		}

		// Token: 0x06016C82 RID: 93314 RVA: 0x00213EB4 File Offset: 0x002120B4
		public UBatchSystemFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UBatchSystemFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016C83 RID: 93315 RVA: 0x00213EDC File Offset: 0x002120DC
		[NullableContext(1)]
		public UBatchSystemFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBatchSystemFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016C84 RID: 93316 RVA: 0x00213F0F File Offset: 0x0021210F
		[NullableContext(2)]
		public static void ProcessAllBatches(UObject WorldContextObject)
		{
			UBatchSystemFunctionLibrary.__ProcessAllBatches_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016C85 RID: 93317 RVA: 0x00213F26 File Offset: 0x00212126
		[NullableContext(2)]
		public static UBatchSystemSubsystem GetBatchSystemSubsystem(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBatchSystemSubsystem>(UBatchSystemFunctionLibrary.__GetBatchSystemSubsystem_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06016C86 RID: 93318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ProcessAllBatches_Internal(IntPtr WorldContextObject);

		// Token: 0x06016C87 RID: 93319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBatchSystemSubsystem_Internal(IntPtr WorldContextObject);

		// Token: 0x06016C88 RID: 93320 RVA: 0x00213F42 File Offset: 0x00212142
		static UBatchSystemFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDynamicMeshBatch.BatchSystemFunctionLibrary");
		}

		// Token: 0x06016C89 RID: 93321 RVA: 0x00213F50 File Offset: 0x00212150
		protected UBatchSystemFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C5C6 RID: 50630
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroDynamicMeshBatch.BatchSystemFunctionLibrary";

		// Token: 0x0400C5C7 RID: 50631
		private static IntPtr _ClassPtr;

		// Token: 0x0400C5C8 RID: 50632
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
