using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D0 RID: 976
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARTraceResultLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UARTraceResultLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600368F RID: 13967 RVA: 0x00052BE2 File Offset: 0x00050DE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTraceResultLibrary._ClassPtr;
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x00052BF0 File Offset: 0x00050DF0
		public UARTraceResultLibrary() : this(BuiltinUtils.AllocNativeUObject(UARTraceResultLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x00052C18 File Offset: 0x00050E18
		[NullableContext(1)]
		public UARTraceResultLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARTraceResultLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x00052C4B File Offset: 0x00050E4B
		public static UARTrackedGeometry GetTrackedGeometry(in FARTraceResult TraceResult)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTrackedGeometry>(UARTraceResultLibrary.__GetTrackedGeometry_Internal((TraceResult ?? new FARTraceResult()).NativePtr));
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x00052C67 File Offset: 0x00050E67
		public static EARLineTraceChannels GetTraceChannel(in FARTraceResult TraceResult)
		{
			return UARTraceResultLibrary.__GetTraceChannel_Internal((TraceResult ?? new FARTraceResult()).NativePtr);
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x00052C7E File Offset: 0x00050E7E
		public static FTransform GetLocalTransform(in FARTraceResult TraceResult)
		{
			return UARTraceResultLibrary.__GetLocalTransform_Internal((TraceResult ?? new FARTraceResult()).NativePtr);
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x00052C95 File Offset: 0x00050E95
		public static FTransform GetLocalToWorldTransform(in FARTraceResult TraceResult)
		{
			return UARTraceResultLibrary.__GetLocalToWorldTransform_Internal((TraceResult ?? new FARTraceResult()).NativePtr);
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x00052CAC File Offset: 0x00050EAC
		public static FTransform GetLocalToTrackingTransform(in FARTraceResult TraceResult)
		{
			return UARTraceResultLibrary.__GetLocalToTrackingTransform_Internal((TraceResult ?? new FARTraceResult()).NativePtr);
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00052CC3 File Offset: 0x00050EC3
		public static float GetDistanceFromCamera(in FARTraceResult TraceResult)
		{
			return UARTraceResultLibrary.__GetDistanceFromCamera_Internal((TraceResult ?? new FARTraceResult()).NativePtr);
		}

		// Token: 0x06003698 RID: 13976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTrackedGeometry_Internal(IntPtr TraceResult);

		// Token: 0x06003699 RID: 13977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARLineTraceChannels __GetTraceChannel_Internal(IntPtr TraceResult);

		// Token: 0x0600369A RID: 13978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetLocalTransform_Internal(IntPtr TraceResult);

		// Token: 0x0600369B RID: 13979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetLocalToWorldTransform_Internal(IntPtr TraceResult);

		// Token: 0x0600369C RID: 13980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetLocalToTrackingTransform_Internal(IntPtr TraceResult);

		// Token: 0x0600369D RID: 13981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceFromCamera_Internal(IntPtr TraceResult);

		// Token: 0x0600369E RID: 13982 RVA: 0x00052CDA File Offset: 0x00050EDA
		static UARTraceResultLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTraceResultLibrary");
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00052CE8 File Offset: 0x00050EE8
		protected UARTraceResultLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400179A RID: 6042
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTraceResultLibrary";

		// Token: 0x0400179B RID: 6043
		private static IntPtr _ClassPtr;

		// Token: 0x0400179C RID: 6044
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
