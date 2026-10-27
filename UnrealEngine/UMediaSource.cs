using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200229B RID: 8859
	[UnrealObjectPath("/Script/MediaAssets.MediaSource")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UMediaSource : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B39 RID: 138041 RVA: 0x0031D47C File Offset: 0x0031B67C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaSource._ClassPtr;
		}

		// Token: 0x06021B3A RID: 138042 RVA: 0x0031D488 File Offset: 0x0031B688
		public bool Validate()
		{
			return UMediaSource.__Validate_Internal(base.NativePtr);
		}

		// Token: 0x06021B3B RID: 138043 RVA: 0x0031D498 File Offset: 0x0031B698
		[NullableContext(1)]
		public unsafe void SetMediaOptionString(in FName Key, string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			fixed (FName* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				UMediaSource.__SetMediaOptionString_Internal(base.NativePtr, Key, fstring);
				FString.NativeDestruct(&fstring, 1);
			}
		}

		// Token: 0x06021B3C RID: 138044 RVA: 0x0031D4CC File Offset: 0x0031B6CC
		public unsafe void SetMediaOptionInt64(in FName Key, long Value)
		{
			fixed (FName* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				UMediaSource.__SetMediaOptionInt64_Internal(base.NativePtr, Key, Value);
			}
		}

		// Token: 0x06021B3D RID: 138045 RVA: 0x0031D4F0 File Offset: 0x0031B6F0
		public unsafe void SetMediaOptionFloat(in FName Key, float Value)
		{
			fixed (FName* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				UMediaSource.__SetMediaOptionFloat_Internal(base.NativePtr, Key, Value);
			}
		}

		// Token: 0x06021B3E RID: 138046 RVA: 0x0031D514 File Offset: 0x0031B714
		public unsafe void SetMediaOptionBool(in FName Key, bool Value)
		{
			fixed (FName* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				UMediaSource.__SetMediaOptionBool_Internal(base.NativePtr, Key, Value);
			}
		}

		// Token: 0x06021B3F RID: 138047 RVA: 0x0031D536 File Offset: 0x0031B736
		[NullableContext(1)]
		public string GetUrl()
		{
			return FString.ToStringAndDeleteNativePtr(UMediaSource.__GetUrl_Internal(base.NativePtr));
		}

		// Token: 0x06021B40 RID: 138048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Validate_Internal(IntPtr @this);

		// Token: 0x06021B41 RID: 138049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaOptionString_Internal(IntPtr @this, in FName Key, in FString Value);

		// Token: 0x06021B42 RID: 138050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaOptionInt64_Internal(IntPtr @this, in FName Key, long Value);

		// Token: 0x06021B43 RID: 138051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaOptionFloat_Internal(IntPtr @this, in FName Key, float Value);

		// Token: 0x06021B44 RID: 138052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaOptionBool_Internal(IntPtr @this, in FName Key, bool Value);

		// Token: 0x06021B45 RID: 138053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetUrl_Internal(IntPtr @this);

		// Token: 0x06021B46 RID: 138054 RVA: 0x0031D548 File Offset: 0x0031B748
		static UMediaSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaSource");
		}

		// Token: 0x06021B47 RID: 138055 RVA: 0x0031D558 File Offset: 0x0031B758
		protected UMediaSource() : this(BuiltinUtils.AllocNativeUObject(UMediaSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B48 RID: 138056 RVA: 0x0031D580 File Offset: 0x0031B780
		protected UMediaSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FAD RID: 73645
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.MediaSource";

		// Token: 0x04011FAE RID: 73646
		private static IntPtr _ClassPtr;

		// Token: 0x04011FAF RID: 73647
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
