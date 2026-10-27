using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BD2 RID: 7122
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroTrailDrawerComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroTrailDrawerComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B560 RID: 111968 RVA: 0x0028453F File Offset: 0x0028273F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTrailDrawerComponent._ClassPtr;
		}

		// Token: 0x0601B561 RID: 111969 RVA: 0x0028454C File Offset: 0x0028274C
		public UKuroTrailDrawerComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroTrailDrawerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B562 RID: 111970 RVA: 0x00284574 File Offset: 0x00282774
		[NullableContext(1)]
		public UKuroTrailDrawerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTrailDrawerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DD9 RID: 28121
		// (get) Token: 0x0601B563 RID: 111971 RVA: 0x002845A7 File Offset: 0x002827A7
		// (set) Token: 0x0601B564 RID: 111972 RVA: 0x002845BB File Offset: 0x002827BB
		public unsafe FVector BoundScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailDrawerComponent.__PropertyOffset_BoundScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailDrawerComponent.__PropertyOffset_BoundScale) = value;
			}
		}

		// Token: 0x17006DDA RID: 28122
		// (get) Token: 0x0601B565 RID: 111973 RVA: 0x002845D0 File Offset: 0x002827D0
		// (set) Token: 0x0601B566 RID: 111974 RVA: 0x002845E0 File Offset: 0x002827E0
		public unsafe bool bPermanentRemoval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailDrawerComponent.__PropertyOffset_bPermanentRemoval) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailDrawerComponent.__PropertyOffset_bPermanentRemoval) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601B567 RID: 111975 RVA: 0x002845F1 File Offset: 0x002827F1
		public bool IsPermanentRemoval()
		{
			return UKuroTrailDrawerComponent.__IsPermanentRemoval_Internal(base.NativePtr);
		}

		// Token: 0x0601B568 RID: 111976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPermanentRemoval_Internal(IntPtr @this);

		// Token: 0x0601B569 RID: 111977 RVA: 0x002845FE File Offset: 0x002827FE
		static UKuroTrailDrawerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroTrailDrawerComponent");
		}

		// Token: 0x0601B56A RID: 111978 RVA: 0x0028460C File Offset: 0x0028280C
		protected UKuroTrailDrawerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB7C RID: 60284
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroTrailDrawerComponent";

		// Token: 0x0400EB7D RID: 60285
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB7E RID: 60286
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EB7F RID: 60287
		internal static int __PropertyOffset_BoundScale;

		// Token: 0x0400EB80 RID: 60288
		internal static int __PropertyOffset_bPermanentRemoval;
	}
}
