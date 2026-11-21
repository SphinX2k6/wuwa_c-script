using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000751 RID: 1873
	[UnrealObjectPath("/Script/MediaAssets.MediaSource")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UMediaSource : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3B2 RID: 41906 RVA: 0x000F1AF8 File Offset: 0x000EFCF8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaSource._ClassPtr;
		}

		// Token: 0x0600A3B3 RID: 41907 RVA: 0x000F1B04 File Offset: 0x000EFD04
		public bool Validate()
		{
			return UMediaSource.__Validate_Internal(base.NativePtr);
		}

		// Token: 0x0600A3B4 RID: 41908 RVA: 0x000F1B14 File Offset: 0x000EFD14
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

		// Token: 0x0600A3B5 RID: 41909 RVA: 0x000F1B48 File Offset: 0x000EFD48
		public unsafe void SetMediaOptionInt64(in FName Key, long Value)
		{
			fixed (FName* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				UMediaSource.__SetMediaOptionInt64_Internal(base.NativePtr, Key, Value);
			}
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x000F1B6C File Offset: 0x000EFD6C
		public unsafe void SetMediaOptionFloat(in FName Key, float Value)
		{
			fixed (FName* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				UMediaSource.__SetMediaOptionFloat_Internal(base.NativePtr, Key, Value);
			}
		}

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x000F1B90 File Offset: 0x000EFD90
		public unsafe void SetMediaOptionBool(in FName Key, bool Value)
		{
			fixed (FName* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				UMediaSource.__SetMediaOptionBool_Internal(base.NativePtr, Key, Value);
			}
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x000F1BB2 File Offset: 0x000EFDB2
		[NullableContext(1)]
		public string GetUrl()
		{
			return FString.ToStringAndDeleteNativePtr(UMediaSource.__GetUrl_Internal(base.NativePtr));
		}

		// Token: 0x0600A3B9 RID: 41913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Validate_Internal(IntPtr @this);

		// Token: 0x0600A3BA RID: 41914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaOptionString_Internal(IntPtr @this, in FName Key, in FString Value);

		// Token: 0x0600A3BB RID: 41915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaOptionInt64_Internal(IntPtr @this, in FName Key, long Value);

		// Token: 0x0600A3BC RID: 41916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaOptionFloat_Internal(IntPtr @this, in FName Key, float Value);

		// Token: 0x0600A3BD RID: 41917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaOptionBool_Internal(IntPtr @this, in FName Key, bool Value);

		// Token: 0x0600A3BE RID: 41918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetUrl_Internal(IntPtr @this);

		// Token: 0x0600A3BF RID: 41919 RVA: 0x000F1BC4 File Offset: 0x000EFDC4
		static UMediaSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaSource");
		}

		// Token: 0x0600A3C0 RID: 41920 RVA: 0x000F1BD4 File Offset: 0x000EFDD4
		protected UMediaSource() : this(BuiltinUtils.AllocNativeUObject(UMediaSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3C1 RID: 41921 RVA: 0x000F1BFC File Offset: 0x000EFDFC
		protected UMediaSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040045DB RID: 17883
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.MediaSource";

		// Token: 0x040045DC RID: 17884
		private static IntPtr _ClassPtr;

		// Token: 0x040045DD RID: 17885
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
