using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017F9 RID: 6137
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroData.KuroTraceLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroTraceLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016B4B RID: 93003 RVA: 0x00212494 File Offset: 0x00210694
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTraceLibrary._ClassPtr;
		}

		// Token: 0x06016B4C RID: 93004 RVA: 0x002124A0 File Offset: 0x002106A0
		public UKuroTraceLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroTraceLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016B4D RID: 93005 RVA: 0x002124C8 File Offset: 0x002106C8
		public UKuroTraceLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTraceLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016B4E RID: 93006 RVA: 0x002124FC File Offset: 0x002106FC
		public unsafe static bool SphereTrace([Nullable(2)] UTraceSphereElement Element, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroTraceLibrary.__SphereTrace_Internal((Element != null) ? Element.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06016B4F RID: 93007 RVA: 0x00212530 File Offset: 0x00210730
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

		// Token: 0x06016B50 RID: 93008 RVA: 0x0021257C File Offset: 0x0021077C
		public unsafe static bool LineTrace([Nullable(2)] UTraceLineElement Element, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroTraceLibrary.__LineTrace_Internal((Element != null) ? Element.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06016B51 RID: 93009 RVA: 0x002125B0 File Offset: 0x002107B0
		public unsafe static bool CapsuleTrace([Nullable(2)] UTraceCapsuleElement Element, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroTraceLibrary.__CapsuleTrace_Internal((Element != null) ? Element.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06016B52 RID: 93010 RVA: 0x002125E4 File Offset: 0x002107E4
		public unsafe static bool BoxTrace([Nullable(2)] UTraceBoxElement Element, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroTraceLibrary.__BoxTrace_Internal((Element != null) ? Element.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06016B53 RID: 93011 RVA: 0x00212618 File Offset: 0x00210818
		[NullableContext(2)]
		public unsafe static void AsyncSphereTrace(UTraceSphereElement Element, [Nullable(1)] string ProfileKey, in FAsyncTraceDelegate Delegate, double Frame, double Index)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			IntPtr element = (Element != null) ? Element.NativePtr : IntPtr.Zero;
			FAsyncTraceDelegate fasyncTraceDelegate = Delegate;
			UKuroTraceLibrary.__AsyncSphereTrace_Internal(element, fstring, (fasyncTraceDelegate != null) ? fasyncTraceDelegate.NativePtr : ((IntPtr)0), Frame, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06016B54 RID: 93012 RVA: 0x00212660 File Offset: 0x00210860
		[NullableContext(2)]
		public unsafe static void AsyncLineTrace(UTraceLineElement Element, [Nullable(1)] string ProfileKey, in FAsyncTraceDelegate Delegate, double Frame, double Index)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			IntPtr element = (Element != null) ? Element.NativePtr : IntPtr.Zero;
			FAsyncTraceDelegate fasyncTraceDelegate = Delegate;
			UKuroTraceLibrary.__AsyncLineTrace_Internal(element, fstring, (fasyncTraceDelegate != null) ? fasyncTraceDelegate.NativePtr : ((IntPtr)0), Frame, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06016B55 RID: 93013 RVA: 0x002126A8 File Offset: 0x002108A8
		[NullableContext(2)]
		public unsafe static void AsyncCapsuleTrace(UTraceCapsuleElement Element, [Nullable(1)] string ProfileKey, in FAsyncTraceDelegate Delegate, double Frame, double Index)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			IntPtr element = (Element != null) ? Element.NativePtr : IntPtr.Zero;
			FAsyncTraceDelegate fasyncTraceDelegate = Delegate;
			UKuroTraceLibrary.__AsyncCapsuleTrace_Internal(element, fstring, (fasyncTraceDelegate != null) ? fasyncTraceDelegate.NativePtr : ((IntPtr)0), Frame, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06016B56 RID: 93014 RVA: 0x002126F0 File Offset: 0x002108F0
		[NullableContext(2)]
		public unsafe static void AsyncBoxTrace(UTraceBoxElement Element, [Nullable(1)] string ProfileKey, in FAsyncTraceDelegate Delegate, double Frame, double Index)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			IntPtr element = (Element != null) ? Element.NativePtr : IntPtr.Zero;
			FAsyncTraceDelegate fasyncTraceDelegate = Delegate;
			UKuroTraceLibrary.__AsyncBoxTrace_Internal(element, fstring, (fasyncTraceDelegate != null) ? fasyncTraceDelegate.NativePtr : ((IntPtr)0), Frame, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06016B57 RID: 93015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SphereTrace_Internal(IntPtr Element, in FString ProfileKey);

		// Token: 0x06016B58 RID: 93016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShapeTrace_Internal(IntPtr InShapeComp, IntPtr Element, in FName TraceTagName, in FString ProfileKey);

		// Token: 0x06016B59 RID: 93017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineTrace_Internal(IntPtr Element, in FString ProfileKey);

		// Token: 0x06016B5A RID: 93018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CapsuleTrace_Internal(IntPtr Element, in FString ProfileKey);

		// Token: 0x06016B5B RID: 93019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxTrace_Internal(IntPtr Element, in FString ProfileKey);

		// Token: 0x06016B5C RID: 93020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncSphereTrace_Internal(IntPtr Element, in FString ProfileKey, IntPtr Delegate, double Frame, double Index);

		// Token: 0x06016B5D RID: 93021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncLineTrace_Internal(IntPtr Element, in FString ProfileKey, IntPtr Delegate, double Frame, double Index);

		// Token: 0x06016B5E RID: 93022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncCapsuleTrace_Internal(IntPtr Element, in FString ProfileKey, IntPtr Delegate, double Frame, double Index);

		// Token: 0x06016B5F RID: 93023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncBoxTrace_Internal(IntPtr Element, in FString ProfileKey, IntPtr Delegate, double Frame, double Index);

		// Token: 0x06016B60 RID: 93024 RVA: 0x00212736 File Offset: 0x00210936
		static UKuroTraceLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.KuroTraceLibrary");
		}

		// Token: 0x06016B61 RID: 93025 RVA: 0x00212744 File Offset: 0x00210944
		protected UKuroTraceLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C548 RID: 50504
		public new const string __ObjectPath = "/Script/KuroData.KuroTraceLibrary";

		// Token: 0x0400C549 RID: 50505
		private static IntPtr _ClassPtr;

		// Token: 0x0400C54A RID: 50506
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
