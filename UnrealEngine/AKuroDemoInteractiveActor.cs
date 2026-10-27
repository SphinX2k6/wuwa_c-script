using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EB5 RID: 7861
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroDemoInteractiveActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroDemoInteractiveActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD56 RID: 122198 RVA: 0x002C22BA File Offset: 0x002C04BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroDemoInteractiveActor._ClassPtr;
		}

		// Token: 0x0601DD57 RID: 122199 RVA: 0x002C22C8 File Offset: 0x002C04C8
		public AKuroDemoInteractiveActor() : this(BuiltinUtils.AllocNativeUObject(AKuroDemoInteractiveActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD58 RID: 122200 RVA: 0x002C22F0 File Offset: 0x002C04F0
		public AKuroDemoInteractiveActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroDemoInteractiveActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DD59 RID: 122201 RVA: 0x002C2324 File Offset: 0x002C0524
		public unsafe bool SetStringPropertyValue(FName PropertyName, string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			bool result = AKuroDemoInteractiveActor.__SetStringPropertyValue_Internal(base.NativePtr, PropertyName, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DD5A RID: 122202 RVA: 0x002C234F File Offset: 0x002C054F
		public bool SetIntPropertyValue(FName PropertyName, int Value)
		{
			return AKuroDemoInteractiveActor.__SetIntPropertyValue_Internal(base.NativePtr, PropertyName, Value);
		}

		// Token: 0x0601DD5B RID: 122203 RVA: 0x002C235E File Offset: 0x002C055E
		public bool SetFloatPropertyValue(FName PropertyName, float Value)
		{
			return AKuroDemoInteractiveActor.__SetFloatPropertyValue_Internal(base.NativePtr, PropertyName, Value);
		}

		// Token: 0x0601DD5C RID: 122204 RVA: 0x002C236D File Offset: 0x002C056D
		public bool SetBoolPropertyValue(FName PropertyName, bool Value)
		{
			return AKuroDemoInteractiveActor.__SetBoolPropertyValue_Internal(base.NativePtr, PropertyName, Value);
		}

		// Token: 0x0601DD5D RID: 122205 RVA: 0x002C237C File Offset: 0x002C057C
		public unsafe bool GetStringPropertyValue(FName PropertyName, ref string OutValue)
		{
			FString fstring = FString.AllocTemp(OutValue);
			bool result = AKuroDemoInteractiveActor.__GetStringPropertyValue_Internal(base.NativePtr, PropertyName, ref fstring);
			OutValue = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601DD5E RID: 122206 RVA: 0x002C23B4 File Offset: 0x002C05B4
		public unsafe bool GetPropertyOffsetFromContainer(FName PropertyName, ref int OutOffset)
		{
			fixed (int* ptr = &OutOffset)
			{
				void* ptr2 = (void*)ptr;
				return AKuroDemoInteractiveActor.__GetPropertyOffsetFromContainer_Internal(base.NativePtr, PropertyName, ref OutOffset);
			}
		}

		// Token: 0x0601DD5F RID: 122207 RVA: 0x002C23D4 File Offset: 0x002C05D4
		public unsafe bool GetIntPropertyValue(FName PropertyName, ref int OutValue)
		{
			fixed (int* ptr = &OutValue)
			{
				void* ptr2 = (void*)ptr;
				return AKuroDemoInteractiveActor.__GetIntPropertyValue_Internal(base.NativePtr, PropertyName, ref OutValue);
			}
		}

		// Token: 0x0601DD60 RID: 122208 RVA: 0x002C23F4 File Offset: 0x002C05F4
		public unsafe bool GetFloatPropertyValue(FName PropertyName, ref float OutValue)
		{
			fixed (float* ptr = &OutValue)
			{
				void* ptr2 = (void*)ptr;
				return AKuroDemoInteractiveActor.__GetFloatPropertyValue_Internal(base.NativePtr, PropertyName, ref OutValue);
			}
		}

		// Token: 0x0601DD61 RID: 122209 RVA: 0x002C2414 File Offset: 0x002C0614
		public unsafe bool GetBoolPropertyValue(FName PropertyName, ref bool OutValue)
		{
			fixed (bool* ptr = &OutValue)
			{
				void* ptr2 = (void*)ptr;
				return AKuroDemoInteractiveActor.__GetBoolPropertyValue_Internal(base.NativePtr, PropertyName, ref OutValue);
			}
		}

		// Token: 0x0601DD62 RID: 122210 RVA: 0x002C2433 File Offset: 0x002C0633
		public bool ExecuteSingleDelegateProperty(FName PropertyName)
		{
			return AKuroDemoInteractiveActor.__ExecuteSingleDelegateProperty_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x0601DD63 RID: 122211 RVA: 0x002C2441 File Offset: 0x002C0641
		public bool CallFunction(FName FunctionName)
		{
			return AKuroDemoInteractiveActor.__CallFunction_Internal(base.NativePtr, FunctionName);
		}

		// Token: 0x0601DD64 RID: 122212 RVA: 0x002C244F File Offset: 0x002C064F
		public bool BroadcastMulticastDelegateProperty(FName PropertyName)
		{
			return AKuroDemoInteractiveActor.__BroadcastMulticastDelegateProperty_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x0601DD65 RID: 122213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetStringPropertyValue_Internal(IntPtr @this, FName PropertyName, in FString Value);

		// Token: 0x0601DD66 RID: 122214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetIntPropertyValue_Internal(IntPtr @this, FName PropertyName, int Value);

		// Token: 0x0601DD67 RID: 122215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetFloatPropertyValue_Internal(IntPtr @this, FName PropertyName, float Value);

		// Token: 0x0601DD68 RID: 122216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetBoolPropertyValue_Internal(IntPtr @this, FName PropertyName, bool Value);

		// Token: 0x0601DD69 RID: 122217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetStringPropertyValue_Internal(IntPtr @this, FName PropertyName, ref FString OutValue);

		// Token: 0x0601DD6A RID: 122218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPropertyOffsetFromContainer_Internal(IntPtr @this, FName PropertyName, ref int OutOffset);

		// Token: 0x0601DD6B RID: 122219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIntPropertyValue_Internal(IntPtr @this, FName PropertyName, ref int OutValue);

		// Token: 0x0601DD6C RID: 122220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFloatPropertyValue_Internal(IntPtr @this, FName PropertyName, ref float OutValue);

		// Token: 0x0601DD6D RID: 122221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBoolPropertyValue_Internal(IntPtr @this, FName PropertyName, ref bool OutValue);

		// Token: 0x0601DD6E RID: 122222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ExecuteSingleDelegateProperty_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x0601DD6F RID: 122223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CallFunction_Internal(IntPtr @this, FName FunctionName);

		// Token: 0x0601DD70 RID: 122224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BroadcastMulticastDelegateProperty_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x0601DD71 RID: 122225 RVA: 0x002C245D File Offset: 0x002C065D
		static AKuroDemoInteractiveActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroDemoInteractiveActor");
		}

		// Token: 0x0601DD72 RID: 122226 RVA: 0x002C246B File Offset: 0x002C066B
		protected AKuroDemoInteractiveActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102AF RID: 66223
		public new const string __ObjectPath = "/Script/KuroUtility.KuroDemoInteractiveActor";

		// Token: 0x040102B0 RID: 66224
		private static IntPtr _ClassPtr;

		// Token: 0x040102B1 RID: 66225
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
