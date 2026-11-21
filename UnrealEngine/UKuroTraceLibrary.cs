using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036B RID: 875
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroData.KuroTraceLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroTraceLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005921 RID: 22817 RVA: 0x0007DBB1 File Offset: 0x0007BDB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTraceLibrary._ClassPtr;
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x0007DBC0 File Offset: 0x0007BDC0
		public UKuroTraceLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroTraceLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x0007DBE8 File Offset: 0x0007BDE8
		public UKuroTraceLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTraceLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x0007DC1C File Offset: 0x0007BE1C
		public unsafe static bool SphereTrace([Nullable(2)] UTraceSphereElement Element, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroTraceLibrary.__SphereTrace_Internal((Element != null) ? Element.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x0007DC50 File Offset: 0x0007BE50
		[NullableContext(2)]
		public unsafe static bool ShapeTrace(UShapeComponent InShapeComp, UTraceBaseElement Element, in FName TraceTagName, [Nullable(1)] string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			fixed (FName* ptr = &TraceTagName)
			{
				void* ptr2 = (void*)ptr;
				bool result = UKuroTraceLibrary.__ShapeTrace_Internal((InShapeComp != null) ? InShapeComp.NativePtr : IntPtr.Zero, (Element != null) ? Element.NativePtr : IntPtr.Zero, TraceTagName, fstring);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x0007DC9C File Offset: 0x0007BE9C
		public unsafe static bool LineTrace([Nullable(2)] UTraceLineElement Element, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroTraceLibrary.__LineTrace_Internal((Element != null) ? Element.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x0007DCD0 File Offset: 0x0007BED0
		public unsafe static bool CapsuleTrace([Nullable(2)] UTraceCapsuleElement Element, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroTraceLibrary.__CapsuleTrace_Internal((Element != null) ? Element.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x0007DD04 File Offset: 0x0007BF04
		public unsafe static bool BoxTrace([Nullable(2)] UTraceBoxElement Element, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroTraceLibrary.__BoxTrace_Internal((Element != null) ? Element.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x0007DD38 File Offset: 0x0007BF38
		[NullableContext(2)]
		public unsafe static void AsyncSphereTrace(UTraceSphereElement Element, [Nullable(1)] string ProfileKey, in FAsyncTraceDelegate Delegate, double Frame, double Index)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			IntPtr element = (Element != null) ? Element.NativePtr : IntPtr.Zero;
			FAsyncTraceDelegate fasyncTraceDelegate = Delegate;
			UKuroTraceLibrary.__AsyncSphereTrace_Internal(element, fstring, (fasyncTraceDelegate != null) ? fasyncTraceDelegate.NativePtr : ((IntPtr)0), Frame, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x0007DD80 File Offset: 0x0007BF80
		[NullableContext(2)]
		public unsafe static void AsyncLineTrace(UTraceLineElement Element, [Nullable(1)] string ProfileKey, in FAsyncTraceDelegate Delegate, double Frame, double Index)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			IntPtr element = (Element != null) ? Element.NativePtr : IntPtr.Zero;
			FAsyncTraceDelegate fasyncTraceDelegate = Delegate;
			UKuroTraceLibrary.__AsyncLineTrace_Internal(element, fstring, (fasyncTraceDelegate != null) ? fasyncTraceDelegate.NativePtr : ((IntPtr)0), Frame, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x0007DDC8 File Offset: 0x0007BFC8
		[NullableContext(2)]
		public unsafe static void AsyncCapsuleTrace(UTraceCapsuleElement Element, [Nullable(1)] string ProfileKey, in FAsyncTraceDelegate Delegate, double Frame, double Index)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			IntPtr element = (Element != null) ? Element.NativePtr : IntPtr.Zero;
			FAsyncTraceDelegate fasyncTraceDelegate = Delegate;
			UKuroTraceLibrary.__AsyncCapsuleTrace_Internal(element, fstring, (fasyncTraceDelegate != null) ? fasyncTraceDelegate.NativePtr : ((IntPtr)0), Frame, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x0007DE10 File Offset: 0x0007C010
		[NullableContext(2)]
		public unsafe static void AsyncBoxTrace(UTraceBoxElement Element, [Nullable(1)] string ProfileKey, in FAsyncTraceDelegate Delegate, double Frame, double Index)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			IntPtr element = (Element != null) ? Element.NativePtr : IntPtr.Zero;
			FAsyncTraceDelegate fasyncTraceDelegate = Delegate;
			UKuroTraceLibrary.__AsyncBoxTrace_Internal(element, fstring, (fasyncTraceDelegate != null) ? fasyncTraceDelegate.NativePtr : ((IntPtr)0), Frame, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600592D RID: 22829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTrace_Internal(IntPtr Element, in FString ProfileKey);

		// Token: 0x0600592E RID: 22830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShapeTrace_Internal(IntPtr InShapeComp, IntPtr Element, in FName TraceTagName, in FString ProfileKey);

		// Token: 0x0600592F RID: 22831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTrace_Internal(IntPtr Element, in FString ProfileKey);

		// Token: 0x06005930 RID: 22832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTrace_Internal(IntPtr Element, in FString ProfileKey);

		// Token: 0x06005931 RID: 22833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTrace_Internal(IntPtr Element, in FString ProfileKey);

		// Token: 0x06005932 RID: 22834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncSphereTrace_Internal(IntPtr Element, in FString ProfileKey, IntPtr Delegate, double Frame, double Index);

		// Token: 0x06005933 RID: 22835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncLineTrace_Internal(IntPtr Element, in FString ProfileKey, IntPtr Delegate, double Frame, double Index);

		// Token: 0x06005934 RID: 22836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncCapsuleTrace_Internal(IntPtr Element, in FString ProfileKey, IntPtr Delegate, double Frame, double Index);

		// Token: 0x06005935 RID: 22837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncBoxTrace_Internal(IntPtr Element, in FString ProfileKey, IntPtr Delegate, double Frame, double Index);

		// Token: 0x06005936 RID: 22838 RVA: 0x0007DE56 File Offset: 0x0007C056
		static UKuroTraceLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.KuroTraceLibrary");
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x0007DE64 File Offset: 0x0007C064
		protected UKuroTraceLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040024E0 RID: 9440
		public new const string __ObjectPath = "/Script/KuroData.KuroTraceLibrary";

		// Token: 0x040024E1 RID: 9441
		private static IntPtr _ClassPtr;

		// Token: 0x040024E2 RID: 9442
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
