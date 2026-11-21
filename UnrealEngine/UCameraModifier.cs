using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019A RID: 410
	[UnrealObjectPath("/Script/Engine.CameraModifier")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UCameraModifier : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001BAC RID: 7084 RVA: 0x00029209 File Offset: 0x00027409
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraModifier._ClassPtr;
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00029218 File Offset: 0x00027418
		public UCameraModifier() : this(BuiltinUtils.AllocNativeUObject(UCameraModifier.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00029240 File Offset: 0x00027440
		[NullableContext(1)]
		public UCameraModifier(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCameraModifier.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x00029273 File Offset: 0x00027473
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x0002928C File Offset: 0x0002748C
		public unsafe bool bDebug
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bDebug) & UCameraModifier.__PropertyMask_bDebug) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bDebug) = ((*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bDebug) & ~UCameraModifier.__PropertyMask_bDebug) | (value ? UCameraModifier.__PropertyMask_bDebug : 0));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x000292BC File Offset: 0x000274BC
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x000292D5 File Offset: 0x000274D5
		public unsafe bool bExclusive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bExclusive) & UCameraModifier.__PropertyMask_bExclusive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bExclusive) = ((*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_bExclusive) & ~UCameraModifier.__PropertyMask_bExclusive) | (value ? UCameraModifier.__PropertyMask_bExclusive : 0));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00029305 File Offset: 0x00027505
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x00029315 File Offset: 0x00027515
		public unsafe byte Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x00029326 File Offset: 0x00027526
		// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x0002933A File Offset: 0x0002753A
		[Nullable(2)]
		public unsafe APlayerCameraManager CameraOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerCameraManager>(base.NativePtr / (IntPtr)sizeof(void*) + UCameraModifier.__PropertyOffset_CameraOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCameraModifier.__PropertyOffset_CameraOwner, value);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0002934F File Offset: 0x0002754F
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x0002935F File Offset: 0x0002755F
		public unsafe float AlphaInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_AlphaInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_AlphaInTime) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00029370 File Offset: 0x00027570
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x00029380 File Offset: 0x00027580
		public unsafe float AlphaOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_AlphaOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_AlphaOutTime) = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00029391 File Offset: 0x00027591
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x000293A1 File Offset: 0x000275A1
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraModifier.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x000293B2 File Offset: 0x000275B2
		public bool IsDisabled()
		{
			return UCameraModifier.__IsDisabled_Internal(base.NativePtr);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000293BF File Offset: 0x000275BF
		[NullableContext(2)]
		public AActor GetViewTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UCameraModifier.__GetViewTarget_Internal(base.NativePtr));
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000293D1 File Offset: 0x000275D1
		public void EnableModifier()
		{
			UCameraModifier.__EnableModifier_Internal(base.NativePtr);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000293DE File Offset: 0x000275DE
		public void DisableModifier(bool bImmediate = false)
		{
			UCameraModifier.__DisableModifier_Internal(base.NativePtr, bImmediate);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000293EC File Offset: 0x000275EC
		[NullableContext(2)]
		public unsafe virtual void BlueprintModifyPostProcess(float DeltaTime, ref float PostProcessBlendWeight, ref FPostProcessSettings PostProcessSettings)
		{
			fixed (float* ptr = &PostProcessBlendWeight)
			{
				void* ptr2 = (void*)ptr;
				UCameraModifier.__BlueprintModifyPostProcess_Internal(base.NativePtr, DeltaTime, ref PostProcessBlendWeight, (PostProcessSettings ?? new FPostProcessSettings()).NativePtr);
			}
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00029420 File Offset: 0x00027620
		public unsafe virtual void BlueprintModifyCamera(float DeltaTime, FVector ViewLocation, FRotator ViewRotation, float FOV, ref FVector NewViewLocation, ref FRotator NewViewRotation, ref float NewFOV)
		{
			fixed (FVector* ptr = &NewViewLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &NewViewRotation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &NewFOV)
					{
						void* ptr6 = (void*)ptr5;
						UCameraModifier.__BlueprintModifyCamera_Internal(base.NativePtr, DeltaTime, ViewLocation, ViewRotation, FOV, ref NewViewLocation, ref NewViewRotation, ref NewFOV);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x06001BC3 RID: 7107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDisabled_Internal(IntPtr @this);

		// Token: 0x06001BC4 RID: 7108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetViewTarget_Internal(IntPtr @this);

		// Token: 0x06001BC5 RID: 7109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableModifier_Internal(IntPtr @this);

		// Token: 0x06001BC6 RID: 7110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableModifier_Internal(IntPtr @this, bool bImmediate);

		// Token: 0x06001BC7 RID: 7111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintModifyPostProcess_Internal(IntPtr @this, float DeltaTime, ref float PostProcessBlendWeight, IntPtr PostProcessSettings);

		// Token: 0x06001BC8 RID: 7112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlueprintModifyCamera_Internal(IntPtr @this, float DeltaTime, FVector ViewLocation, FRotator ViewRotation, float FOV, ref FVector NewViewLocation, ref FRotator NewViewRotation, ref float NewFOV);

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00029464 File Offset: 0x00027664
		static UCameraModifier()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraModifier");
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00029472 File Offset: 0x00027672
		protected UCameraModifier(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008FB RID: 2299
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraModifier";

		// Token: 0x040008FC RID: 2300
		private static IntPtr _ClassPtr;

		// Token: 0x040008FD RID: 2301
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008FE RID: 2302
		internal static int __PropertyOffset_bDebug;

		// Token: 0x040008FF RID: 2303
		internal static byte __PropertyMask_bDebug;

		// Token: 0x04000900 RID: 2304
		internal static int __PropertyOffset_bExclusive;

		// Token: 0x04000901 RID: 2305
		internal static byte __PropertyMask_bExclusive;

		// Token: 0x04000902 RID: 2306
		internal static int __PropertyOffset_Priority;

		// Token: 0x04000903 RID: 2307
		internal static int __PropertyOffset_CameraOwner;

		// Token: 0x04000904 RID: 2308
		internal static int __PropertyOffset_AlphaInTime;

		// Token: 0x04000905 RID: 2309
		internal static int __PropertyOffset_AlphaOutTime;

		// Token: 0x04000906 RID: 2310
		internal static int __PropertyOffset_Alpha;

		// Token: 0x0200096E RID: 2414
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2656)]
		protected ref struct __BlueprintModifyPostProcess_FunctionParams
		{
			// Token: 0x040058A4 RID: 22692
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x040058A5 RID: 22693
			[FieldOffset(4)]
			public float PostProcessBlendWeight;

			// Token: 0x040058A6 RID: 22694
			[FieldOffset(16)]
			public byte PostProcessSettings;
		}

		// Token: 0x0200096F RID: 2415
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __BlueprintModifyCamera_FunctionParams
		{
			// Token: 0x040058A7 RID: 22695
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x040058A8 RID: 22696
			[FieldOffset(4)]
			public FVector ViewLocation;

			// Token: 0x040058A9 RID: 22697
			[FieldOffset(16)]
			public FRotator ViewRotation;

			// Token: 0x040058AA RID: 22698
			[FieldOffset(28)]
			public float FOV;

			// Token: 0x040058AB RID: 22699
			[FieldOffset(32)]
			public FVector NewViewLocation;

			// Token: 0x040058AC RID: 22700
			[FieldOffset(44)]
			public FRotator NewViewRotation;

			// Token: 0x040058AD RID: 22701
			[FieldOffset(56)]
			public float NewFOV;
		}
	}
}
