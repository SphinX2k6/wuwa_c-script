using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A54 RID: 6740
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CapsuleStampConsumer")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1592)]
	public class ACapsuleStampConsumer : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IKuroRenderingStampConsumer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06018E85 RID: 102021 RVA: 0x0024D25C File Offset: 0x0024B45C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACapsuleStampConsumer._ClassPtr;
		}

		// Token: 0x06018E86 RID: 102022 RVA: 0x0024D268 File Offset: 0x0024B468
		int IKuroRenderingStampConsumer.InterfaceOffset()
		{
			return ACapsuleStampConsumer.__InterfaceOffset_IKuroRenderingStampConsumer;
		}

		// Token: 0x06018E87 RID: 102023 RVA: 0x0024D270 File Offset: 0x0024B470
		public ACapsuleStampConsumer() : this(BuiltinUtils.AllocNativeUObject(ACapsuleStampConsumer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018E88 RID: 102024 RVA: 0x0024D298 File Offset: 0x0024B498
		[NullableContext(1)]
		public ACapsuleStampConsumer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACapsuleStampConsumer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700629B RID: 25243
		// (get) Token: 0x06018E89 RID: 102025 RVA: 0x0024D2CB File Offset: 0x0024B4CB
		// (set) Token: 0x06018E8A RID: 102026 RVA: 0x0024D2DF File Offset: 0x0024B4DF
		public unsafe FVectorDouble RTWorldCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_RTWorldCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_RTWorldCenter) = value;
			}
		}

		// Token: 0x1700629C RID: 25244
		// (get) Token: 0x06018E8B RID: 102027 RVA: 0x0024D2F4 File Offset: 0x0024B4F4
		// (set) Token: 0x06018E8C RID: 102028 RVA: 0x0024D304 File Offset: 0x0024B504
		public unsafe float RTWorldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_RTWorldRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_RTWorldRadius) = value;
			}
		}

		// Token: 0x1700629D RID: 25245
		// (get) Token: 0x06018E8D RID: 102029 RVA: 0x0024D315 File Offset: 0x0024B515
		// (set) Token: 0x06018E8E RID: 102030 RVA: 0x0024D329 File Offset: 0x0024B529
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + ACapsuleStampConsumer.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACapsuleStampConsumer.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x1700629E RID: 25246
		// (get) Token: 0x06018E8F RID: 102031 RVA: 0x0024D340 File Offset: 0x0024B540
		// (set) Token: 0x06018E90 RID: 102032 RVA: 0x0024D379 File Offset: 0x0024B579
		[Nullable(1)]
		public TArray<FCapsuleStampWorld2D> Capsules
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FCapsuleStampWorld2D> result;
				if ((result = this._Capsules) == null)
				{
					result = (this._Capsules = new TArray<FCapsuleStampWorld2D>(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_Capsules, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Capsules.CopyAssign(value);
			}
		}

		// Token: 0x1700629F RID: 25247
		// (get) Token: 0x06018E91 RID: 102033 RVA: 0x0024D387 File Offset: 0x0024B587
		// (set) Token: 0x06018E92 RID: 102034 RVA: 0x0024D397 File Offset: 0x0024B597
		public unsafe bool bOnlyDrawWhenDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_bOnlyDrawWhenDirty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_bOnlyDrawWhenDirty) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062A0 RID: 25248
		// (get) Token: 0x06018E93 RID: 102035 RVA: 0x0024D3A8 File Offset: 0x0024B5A8
		// (set) Token: 0x06018E94 RID: 102036 RVA: 0x0024D3B8 File Offset: 0x0024B5B8
		public unsafe bool bEnableSmoothing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_bEnableSmoothing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_bEnableSmoothing) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062A1 RID: 25249
		// (get) Token: 0x06018E95 RID: 102037 RVA: 0x0024D3C9 File Offset: 0x0024B5C9
		// (set) Token: 0x06018E96 RID: 102038 RVA: 0x0024D3D9 File Offset: 0x0024B5D9
		public unsafe float SmoothingSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_SmoothingSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_SmoothingSpeed) = value;
			}
		}

		// Token: 0x170062A2 RID: 25250
		// (get) Token: 0x06018E97 RID: 102039 RVA: 0x0024D3EA File Offset: 0x0024B5EA
		// (set) Token: 0x06018E98 RID: 102040 RVA: 0x0024D3FA File Offset: 0x0024B5FA
		public unsafe bool bValueOnlySmoothing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_bValueOnlySmoothing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_bValueOnlySmoothing) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062A3 RID: 25251
		// (get) Token: 0x06018E99 RID: 102041 RVA: 0x0024D40B File Offset: 0x0024B60B
		// (set) Token: 0x06018E9A RID: 102042 RVA: 0x0024D41B File Offset: 0x0024B61B
		public unsafe bool bSpreadWhenUseEndValues
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_bSpreadWhenUseEndValues) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_bSpreadWhenUseEndValues) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062A4 RID: 25252
		// (get) Token: 0x06018E9B RID: 102043 RVA: 0x0024D42C File Offset: 0x0024B62C
		// (set) Token: 0x06018E9C RID: 102044 RVA: 0x0024D43C File Offset: 0x0024B63C
		public unsafe float SpreadSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_SpreadSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACapsuleStampConsumer.__PropertyOffset_SpreadSpeed) = value;
			}
		}

		// Token: 0x170062A5 RID: 25253
		// (get) Token: 0x06018E9D RID: 102045 RVA: 0x0024D44D File Offset: 0x0024B64D
		// (set) Token: 0x06018E9E RID: 102046 RVA: 0x0024D461 File Offset: 0x0024B661
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACapsuleStampConsumer.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACapsuleStampConsumer.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x06018E9F RID: 102047 RVA: 0x0024D476 File Offset: 0x0024B676
		public void SnapToTargetAndDrawOnce(bool bFlush = false)
		{
			ACapsuleStampConsumer.__SnapToTargetAndDrawOnce_Internal(base.NativePtr, bFlush);
		}

		// Token: 0x06018EA0 RID: 102048 RVA: 0x0024D484 File Offset: 0x0024B684
		public void SetTargetPoints(in TArray<FVectorDouble> Points, float RadiusWorld, float Value = 1f, float SoftEdgeWidthWorld = 0f)
		{
			ACapsuleStampConsumer.__SetTargetPoints_Internal(base.NativePtr, (Points ?? new TArray<FVectorDouble>()).NativePtr, RadiusWorld, Value, SoftEdgeWidthWorld);
		}

		// Token: 0x06018EA1 RID: 102049 RVA: 0x0024D4A5 File Offset: 0x0024B6A5
		public void SetTargetPoint(FVectorDouble Point, float RadiusWorld, float Value = 1f, float SoftEdgeWidthWorld = 0f)
		{
			ACapsuleStampConsumer.__SetTargetPoint_Internal(base.NativePtr, Point, RadiusWorld, Value, SoftEdgeWidthWorld);
		}

		// Token: 0x06018EA2 RID: 102050 RVA: 0x0024D4B7 File Offset: 0x0024B6B7
		public void SetTargetCapsules([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FCapsuleStampWorld2D> InTargetCapsules, bool bSnapImmediately = false)
		{
			ACapsuleStampConsumer.__SetTargetCapsules_Internal(base.NativePtr, (InTargetCapsules ?? new TArray<FCapsuleStampWorld2D>()).NativePtr, bSnapImmediately);
		}

		// Token: 0x06018EA3 RID: 102051 RVA: 0x0024D4D5 File Offset: 0x0024B6D5
		public void PushCapsules()
		{
			ACapsuleStampConsumer.__PushCapsules_Internal(base.NativePtr);
		}

		// Token: 0x06018EA4 RID: 102052 RVA: 0x0024D4E2 File Offset: 0x0024B6E2
		public void MarkCapsulesDirty()
		{
			ACapsuleStampConsumer.__MarkCapsulesDirty_Internal(base.NativePtr);
		}

		// Token: 0x06018EA5 RID: 102053 RVA: 0x0024D4EF File Offset: 0x0024B6EF
		public void DrawOnce()
		{
			ACapsuleStampConsumer.__DrawOnce_Internal(base.NativePtr);
		}

		// Token: 0x06018EA6 RID: 102054 RVA: 0x0024D4FC File Offset: 0x0024B6FC
		public void ClearRT()
		{
			ACapsuleStampConsumer.__ClearRT_Internal(base.NativePtr);
		}

		// Token: 0x06018EA7 RID: 102055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SnapToTargetAndDrawOnce_Internal(IntPtr @this, bool bFlush);

		// Token: 0x06018EA8 RID: 102056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetPoints_Internal(IntPtr @this, IntPtr Points, float RadiusWorld, float Value, float SoftEdgeWidthWorld);

		// Token: 0x06018EA9 RID: 102057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetPoint_Internal(IntPtr @this, FVectorDouble Point, float RadiusWorld, float Value, float SoftEdgeWidthWorld);

		// Token: 0x06018EAA RID: 102058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetCapsules_Internal(IntPtr @this, IntPtr InTargetCapsules, bool bSnapImmediately);

		// Token: 0x06018EAB RID: 102059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PushCapsules_Internal(IntPtr @this);

		// Token: 0x06018EAC RID: 102060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkCapsulesDirty_Internal(IntPtr @this);

		// Token: 0x06018EAD RID: 102061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawOnce_Internal(IntPtr @this);

		// Token: 0x06018EAE RID: 102062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearRT_Internal(IntPtr @this);

		// Token: 0x06018EAF RID: 102063 RVA: 0x0024D509 File Offset: 0x0024B709
		static ACapsuleStampConsumer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.CapsuleStampConsumer");
		}

		// Token: 0x06018EB0 RID: 102064 RVA: 0x0024D517 File Offset: 0x0024B717
		protected ACapsuleStampConsumer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D7A3 RID: 55203
		internal static int __InterfaceOffset_IKuroRenderingStampConsumer;

		// Token: 0x0400D7A4 RID: 55204
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CapsuleStampConsumer";

		// Token: 0x0400D7A5 RID: 55205
		private static IntPtr _ClassPtr;

		// Token: 0x0400D7A6 RID: 55206
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D7A7 RID: 55207
		internal static int __PropertyOffset_RTWorldCenter;

		// Token: 0x0400D7A8 RID: 55208
		internal static int __PropertyOffset_RTWorldRadius;

		// Token: 0x0400D7A9 RID: 55209
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400D7AA RID: 55210
		internal static int __PropertyOffset_Capsules;

		// Token: 0x0400D7AB RID: 55211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCapsuleStampWorld2D> _Capsules;

		// Token: 0x0400D7AC RID: 55212
		internal static int __PropertyOffset_bOnlyDrawWhenDirty;

		// Token: 0x0400D7AD RID: 55213
		internal static int __PropertyOffset_bEnableSmoothing;

		// Token: 0x0400D7AE RID: 55214
		internal static int __PropertyOffset_SmoothingSpeed;

		// Token: 0x0400D7AF RID: 55215
		internal static int __PropertyOffset_bValueOnlySmoothing;

		// Token: 0x0400D7B0 RID: 55216
		internal static int __PropertyOffset_bSpreadWhenUseEndValues;

		// Token: 0x0400D7B1 RID: 55217
		internal static int __PropertyOffset_SpreadSpeed;

		// Token: 0x0400D7B2 RID: 55218
		internal static int __PropertyOffset_Root;
	}
}
