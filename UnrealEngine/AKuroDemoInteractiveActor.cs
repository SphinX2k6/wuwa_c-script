using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D3 RID: 1491
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroDemoInteractiveActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroDemoInteractiveActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008423 RID: 33827 RVA: 0x000C4356 File Offset: 0x000C2556
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroDemoInteractiveActor._ClassPtr;
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x000C4364 File Offset: 0x000C2564
		public AKuroDemoInteractiveActor() : this(BuiltinUtils.AllocNativeUObject(AKuroDemoInteractiveActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008425 RID: 33829 RVA: 0x000C438C File Offset: 0x000C258C
		public AKuroDemoInteractiveActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroDemoInteractiveActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x000C43C0 File Offset: 0x000C25C0
		public unsafe bool SetStringPropertyValue(FName PropertyName, string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			bool result = AKuroDemoInteractiveActor.__SetStringPropertyValue_Internal(base.NativePtr, PropertyName, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x000C43EB File Offset: 0x000C25EB
		public bool SetIntPropertyValue(FName PropertyName, int Value)
		{
			return AKuroDemoInteractiveActor.__SetIntPropertyValue_Internal(base.NativePtr, PropertyName, Value);
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x000C43FA File Offset: 0x000C25FA
		public bool SetFloatPropertyValue(FName PropertyName, float Value)
		{
			return AKuroDemoInteractiveActor.__SetFloatPropertyValue_Internal(base.NativePtr, PropertyName, Value);
		}

		// Token: 0x06008429 RID: 33833 RVA: 0x000C4409 File Offset: 0x000C2609
		public bool SetBoolPropertyValue(FName PropertyName, bool Value)
		{
			return AKuroDemoInteractiveActor.__SetBoolPropertyValue_Internal(base.NativePtr, PropertyName, Value);
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x000C4418 File Offset: 0x000C2618
		public unsafe bool GetStringPropertyValue(FName PropertyName, ref string OutValue)
		{
			FString fstring = FString.AllocTemp(OutValue);
			bool result = AKuroDemoInteractiveActor.__GetStringPropertyValue_Internal(base.NativePtr, PropertyName, ref fstring);
			OutValue = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x000C4450 File Offset: 0x000C2650
		public unsafe bool GetPropertyOffsetFromContainer(FName PropertyName, ref int OutOffset)
		{
			fixed (int* ptr = &OutOffset)
			{
				void* ptr2 = (void*)ptr;
				return AKuroDemoInteractiveActor.__GetPropertyOffsetFromContainer_Internal(base.NativePtr, PropertyName, ref OutOffset);
			}
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x000C4470 File Offset: 0x000C2670
		public unsafe bool GetIntPropertyValue(FName PropertyName, ref int OutValue)
		{
			fixed (int* ptr = &OutValue)
			{
				void* ptr2 = (void*)ptr;
				return AKuroDemoInteractiveActor.__GetIntPropertyValue_Internal(base.NativePtr, PropertyName, ref OutValue);
			}
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x000C4490 File Offset: 0x000C2690
		public unsafe bool GetFloatPropertyValue(FName PropertyName, ref float OutValue)
		{
			fixed (float* ptr = &OutValue)
			{
				void* ptr2 = (void*)ptr;
				return AKuroDemoInteractiveActor.__GetFloatPropertyValue_Internal(base.NativePtr, PropertyName, ref OutValue);
			}
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x000C44B0 File Offset: 0x000C26B0
		public unsafe bool GetBoolPropertyValue(FName PropertyName, ref bool OutValue)
		{
			fixed (bool* ptr = &OutValue)
			{
				void* ptr2 = (void*)ptr;
				return AKuroDemoInteractiveActor.__GetBoolPropertyValue_Internal(base.NativePtr, PropertyName, ref OutValue);
			}
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x000C44CF File Offset: 0x000C26CF
		public bool ExecuteSingleDelegateProperty(FName PropertyName)
		{
			return AKuroDemoInteractiveActor.__ExecuteSingleDelegateProperty_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x000C44DD File Offset: 0x000C26DD
		public bool CallFunction(FName FunctionName)
		{
			return AKuroDemoInteractiveActor.__CallFunction_Internal(base.NativePtr, FunctionName);
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x000C44EB File Offset: 0x000C26EB
		public bool BroadcastMulticastDelegateProperty(FName PropertyName)
		{
			return AKuroDemoInteractiveActor.__BroadcastMulticastDelegateProperty_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x06008432 RID: 33842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetStringPropertyValue_Internal(IntPtr @this, FName PropertyName, in FString Value);

		// Token: 0x06008433 RID: 33843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetIntPropertyValue_Internal(IntPtr @this, FName PropertyName, int Value);

		// Token: 0x06008434 RID: 33844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetFloatPropertyValue_Internal(IntPtr @this, FName PropertyName, float Value);

		// Token: 0x06008435 RID: 33845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetBoolPropertyValue_Internal(IntPtr @this, FName PropertyName, bool Value);

		// Token: 0x06008436 RID: 33846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetStringPropertyValue_Internal(IntPtr @this, FName PropertyName, ref FString OutValue);

		// Token: 0x06008437 RID: 33847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPropertyOffsetFromContainer_Internal(IntPtr @this, FName PropertyName, ref int OutOffset);

		// Token: 0x06008438 RID: 33848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIntPropertyValue_Internal(IntPtr @this, FName PropertyName, ref int OutValue);

		// Token: 0x06008439 RID: 33849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFloatPropertyValue_Internal(IntPtr @this, FName PropertyName, ref float OutValue);

		// Token: 0x0600843A RID: 33850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBoolPropertyValue_Internal(IntPtr @this, FName PropertyName, ref bool OutValue);

		// Token: 0x0600843B RID: 33851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ExecuteSingleDelegateProperty_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x0600843C RID: 33852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CallFunction_Internal(IntPtr @this, FName FunctionName);

		// Token: 0x0600843D RID: 33853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BroadcastMulticastDelegateProperty_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x0600843E RID: 33854 RVA: 0x000C44F9 File Offset: 0x000C26F9
		static AKuroDemoInteractiveActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroDemoInteractiveActor");
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x000C4507 File Offset: 0x000C2707
		protected AKuroDemoInteractiveActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039C5 RID: 14789
		public new const string __ObjectPath = "/Script/KuroUtility.KuroDemoInteractiveActor";

		// Token: 0x040039C6 RID: 14790
		private static IntPtr _ClassPtr;

		// Token: 0x040039C7 RID: 14791
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
