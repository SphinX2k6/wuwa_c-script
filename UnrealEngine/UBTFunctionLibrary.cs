using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014C RID: 332
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBTFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016E2 RID: 5858 RVA: 0x00021B93 File Offset: 0x0001FD93
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTFunctionLibrary._ClassPtr;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		public UBTFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UBTFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00021BC8 File Offset: 0x0001FDC8
		[NullableContext(1)]
		public UBTFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00021BFB File Offset: 0x0001FDFB
		public static void StopUsingExternalEvent(UBTNode NodeOwner)
		{
			UBTFunctionLibrary.__StopUsingExternalEvent_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00021C12 File Offset: 0x0001FE12
		public static void StartUsingExternalEvent(UBTNode NodeOwner, AActor OwningActor)
		{
			UBTFunctionLibrary.__StartUsingExternalEvent_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (OwningActor != null) ? OwningActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00021C39 File Offset: 0x0001FE39
		public static void SetBlackboardValueAsVector(UBTNode NodeOwner, in FBlackboardKeySelector Key, FVector Value)
		{
			UBTFunctionLibrary.__SetBlackboardValueAsVector_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr, Value);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00021C64 File Offset: 0x0001FE64
		public unsafe static void SetBlackboardValueAsString(UBTNode NodeOwner, in FBlackboardKeySelector Key, [Nullable(1)] string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			UBTFunctionLibrary.__SetBlackboardValueAsString_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00021CA8 File Offset: 0x0001FEA8
		public static void SetBlackboardValueAsRotator(UBTNode NodeOwner, in FBlackboardKeySelector Key, FRotator Value)
		{
			UBTFunctionLibrary.__SetBlackboardValueAsRotator_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr, Value);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00021CD0 File Offset: 0x0001FED0
		public static void SetBlackboardValueAsObject(UBTNode NodeOwner, in FBlackboardKeySelector Key, UObject Value)
		{
			UBTFunctionLibrary.__SetBlackboardValueAsObject_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00021D07 File Offset: 0x0001FF07
		public static void SetBlackboardValueAsName(UBTNode NodeOwner, in FBlackboardKeySelector Key, FName Value)
		{
			UBTFunctionLibrary.__SetBlackboardValueAsName_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr, Value);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00021D2F File Offset: 0x0001FF2F
		public static void SetBlackboardValueAsInt(UBTNode NodeOwner, in FBlackboardKeySelector Key, int Value)
		{
			UBTFunctionLibrary.__SetBlackboardValueAsInt_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr, Value);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00021D57 File Offset: 0x0001FF57
		public static void SetBlackboardValueAsFloat(UBTNode NodeOwner, in FBlackboardKeySelector Key, float Value)
		{
			UBTFunctionLibrary.__SetBlackboardValueAsFloat_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr, Value);
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00021D7F File Offset: 0x0001FF7F
		public static void SetBlackboardValueAsEnum(UBTNode NodeOwner, in FBlackboardKeySelector Key, byte Value)
		{
			UBTFunctionLibrary.__SetBlackboardValueAsEnum_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr, Value);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00021DA7 File Offset: 0x0001FFA7
		public static void SetBlackboardValueAsClass(UBTNode NodeOwner, in FBlackboardKeySelector Key, UClassStackOnlyPtr Value)
		{
			UBTFunctionLibrary.__SetBlackboardValueAsClass_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr, Value._NativePtr);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00021DD4 File Offset: 0x0001FFD4
		public static void SetBlackboardValueAsBool(UBTNode NodeOwner, in FBlackboardKeySelector Key, bool Value)
		{
			UBTFunctionLibrary.__SetBlackboardValueAsBool_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr, Value);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00021DFC File Offset: 0x0001FFFC
		public static UBlackboardComponent GetOwnersBlackboard(UBTNode NodeOwner)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBlackboardComponent>(UBTFunctionLibrary.__GetOwnersBlackboard_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00021E18 File Offset: 0x00020018
		public static UBehaviorTreeComponent GetOwnerComponent(UBTNode NodeOwner)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBehaviorTreeComponent>(UBTFunctionLibrary.__GetOwnerComponent_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00021E34 File Offset: 0x00020034
		public static FVector GetBlackboardValueAsVector(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return UBTFunctionLibrary.__GetBlackboardValueAsVector_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr);
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00021E5B File Offset: 0x0002005B
		[return: Nullable(1)]
		public static string GetBlackboardValueAsString(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return FString.ToStringAndDeleteNativePtr(UBTFunctionLibrary.__GetBlackboardValueAsString_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr));
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00021E87 File Offset: 0x00020087
		public static FRotator GetBlackboardValueAsRotator(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return UBTFunctionLibrary.__GetBlackboardValueAsRotator_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr);
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00021EAE File Offset: 0x000200AE
		public static UObject GetBlackboardValueAsObject(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UBTFunctionLibrary.__GetBlackboardValueAsObject_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr));
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00021EDA File Offset: 0x000200DA
		public static FName GetBlackboardValueAsName(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return UBTFunctionLibrary.__GetBlackboardValueAsName_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00021F01 File Offset: 0x00020101
		public static int GetBlackboardValueAsInt(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return UBTFunctionLibrary.__GetBlackboardValueAsInt_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00021F28 File Offset: 0x00020128
		public static float GetBlackboardValueAsFloat(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return UBTFunctionLibrary.__GetBlackboardValueAsFloat_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr);
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00021F4F File Offset: 0x0002014F
		public static byte GetBlackboardValueAsEnum(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return UBTFunctionLibrary.__GetBlackboardValueAsEnum_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr);
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00021F76 File Offset: 0x00020176
		public static UClassStackOnlyPtr GetBlackboardValueAsClass(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return UBTFunctionLibrary.__GetBlackboardValueAsClass_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr);
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00021FA2 File Offset: 0x000201A2
		public static bool GetBlackboardValueAsBool(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return UBTFunctionLibrary.__GetBlackboardValueAsBool_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00021FC9 File Offset: 0x000201C9
		public static AActor GetBlackboardValueAsActor(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UBTFunctionLibrary.__GetBlackboardValueAsActor_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr));
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00021FF5 File Offset: 0x000201F5
		public static void ClearBlackboardValueAsVector(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			UBTFunctionLibrary.__ClearBlackboardValueAsVector_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0002201C File Offset: 0x0002021C
		public static void ClearBlackboardValue(UBTNode NodeOwner, in FBlackboardKeySelector Key)
		{
			UBTFunctionLibrary.__ClearBlackboardValue_Internal((NodeOwner != null) ? NodeOwner.NativePtr : IntPtr.Zero, (Key ?? new FBlackboardKeySelector()).NativePtr);
		}

		// Token: 0x06001700 RID: 5888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopUsingExternalEvent_Internal(IntPtr NodeOwner);

		// Token: 0x06001701 RID: 5889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartUsingExternalEvent_Internal(IntPtr NodeOwner, IntPtr OwningActor);

		// Token: 0x06001702 RID: 5890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlackboardValueAsVector_Internal(IntPtr NodeOwner, IntPtr Key, FVector Value);

		// Token: 0x06001703 RID: 5891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlackboardValueAsString_Internal(IntPtr NodeOwner, IntPtr Key, in FString Value);

		// Token: 0x06001704 RID: 5892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlackboardValueAsRotator_Internal(IntPtr NodeOwner, IntPtr Key, FRotator Value);

		// Token: 0x06001705 RID: 5893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlackboardValueAsObject_Internal(IntPtr NodeOwner, IntPtr Key, IntPtr Value);

		// Token: 0x06001706 RID: 5894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlackboardValueAsName_Internal(IntPtr NodeOwner, IntPtr Key, FName Value);

		// Token: 0x06001707 RID: 5895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlackboardValueAsInt_Internal(IntPtr NodeOwner, IntPtr Key, int Value);

		// Token: 0x06001708 RID: 5896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlackboardValueAsFloat_Internal(IntPtr NodeOwner, IntPtr Key, float Value);

		// Token: 0x06001709 RID: 5897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlackboardValueAsEnum_Internal(IntPtr NodeOwner, IntPtr Key, byte Value);

		// Token: 0x0600170A RID: 5898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlackboardValueAsClass_Internal(IntPtr NodeOwner, IntPtr Key, IntPtr Value);

		// Token: 0x0600170B RID: 5899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlackboardValueAsBool_Internal(IntPtr NodeOwner, IntPtr Key, bool Value);

		// Token: 0x0600170C RID: 5900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwnersBlackboard_Internal(IntPtr NodeOwner);

		// Token: 0x0600170D RID: 5901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwnerComponent_Internal(IntPtr NodeOwner);

		// Token: 0x0600170E RID: 5902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetBlackboardValueAsVector_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x0600170F RID: 5903
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBlackboardValueAsString_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x06001710 RID: 5904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetBlackboardValueAsRotator_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x06001711 RID: 5905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBlackboardValueAsObject_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x06001712 RID: 5906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetBlackboardValueAsName_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x06001713 RID: 5907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetBlackboardValueAsInt_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x06001714 RID: 5908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBlackboardValueAsFloat_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x06001715 RID: 5909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetBlackboardValueAsEnum_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x06001716 RID: 5910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBlackboardValueAsClass_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x06001717 RID: 5911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBlackboardValueAsBool_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x06001718 RID: 5912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBlackboardValueAsActor_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x06001719 RID: 5913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearBlackboardValueAsVector_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x0600171A RID: 5914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearBlackboardValue_Internal(IntPtr NodeOwner, IntPtr Key);

		// Token: 0x0600171B RID: 5915 RVA: 0x00022043 File Offset: 0x00020243
		static UBTFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTFunctionLibrary");
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00022051 File Offset: 0x00020251
		protected UBTFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400055F RID: 1375
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTFunctionLibrary";

		// Token: 0x04000560 RID: 1376
		private static IntPtr _ClassPtr;

		// Token: 0x04000561 RID: 1377
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
