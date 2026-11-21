using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004A3 RID: 1187
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CapsuleStampConsumer")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1592)]
	public class ACapsuleStampConsumer : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IKuroRenderingStampConsumer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06006E68 RID: 28264 RVA: 0x000A2F55 File Offset: 0x000A1155
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACapsuleStampConsumer._ClassPtr;
		}

		// Token: 0x06006E69 RID: 28265 RVA: 0x000A2F61 File Offset: 0x000A1161
		int IKuroRenderingStampConsumer.InterfaceOffset()
		{
			return ACapsuleStampConsumer.__InterfaceOffset_IKuroRenderingStampConsumer;
		}

		// Token: 0x06006E6A RID: 28266 RVA: 0x000A2F68 File Offset: 0x000A1168
		public ACapsuleStampConsumer() : this(BuiltinUtils.AllocNativeUObject(ACapsuleStampConsumer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006E6B RID: 28267 RVA: 0x000A2F90 File Offset: 0x000A1190
		[NullableContext(1)]
		public ACapsuleStampConsumer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACapsuleStampConsumer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06006E6C RID: 28268 RVA: 0x000A2FC3 File Offset: 0x000A11C3
		// (set) Token: 0x06006E6D RID: 28269 RVA: 0x000A2FD7 File Offset: 0x000A11D7
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

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x000A2FEC File Offset: 0x000A11EC
		// (set) Token: 0x06006E6F RID: 28271 RVA: 0x000A2FFC File Offset: 0x000A11FC
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

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06006E70 RID: 28272 RVA: 0x000A300D File Offset: 0x000A120D
		// (set) Token: 0x06006E71 RID: 28273 RVA: 0x000A3021 File Offset: 0x000A1221
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

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06006E72 RID: 28274 RVA: 0x000A3036 File Offset: 0x000A1236
		// (set) Token: 0x06006E73 RID: 28275 RVA: 0x000A3046 File Offset: 0x000A1246
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

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06006E74 RID: 28276 RVA: 0x000A3057 File Offset: 0x000A1257
		// (set) Token: 0x06006E75 RID: 28277 RVA: 0x000A3067 File Offset: 0x000A1267
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

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06006E76 RID: 28278 RVA: 0x000A3078 File Offset: 0x000A1278
		// (set) Token: 0x06006E77 RID: 28279 RVA: 0x000A3088 File Offset: 0x000A1288
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

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06006E78 RID: 28280 RVA: 0x000A3099 File Offset: 0x000A1299
		// (set) Token: 0x06006E79 RID: 28281 RVA: 0x000A30A9 File Offset: 0x000A12A9
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

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06006E7A RID: 28282 RVA: 0x000A30BA File Offset: 0x000A12BA
		// (set) Token: 0x06006E7B RID: 28283 RVA: 0x000A30CA File Offset: 0x000A12CA
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

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06006E7C RID: 28284 RVA: 0x000A30DB File Offset: 0x000A12DB
		// (set) Token: 0x06006E7D RID: 28285 RVA: 0x000A30EB File Offset: 0x000A12EB
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

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06006E7E RID: 28286 RVA: 0x000A30FC File Offset: 0x000A12FC
		// (set) Token: 0x06006E7F RID: 28287 RVA: 0x000A3110 File Offset: 0x000A1310
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

		// Token: 0x06006E80 RID: 28288 RVA: 0x000A3125 File Offset: 0x000A1325
		public void SnapToTargetAndDrawOnce(bool bFlush = false)
		{
			ACapsuleStampConsumer.__SnapToTargetAndDrawOnce_Internal(base.NativePtr, bFlush);
		}

		// Token: 0x06006E81 RID: 28289 RVA: 0x000A3133 File Offset: 0x000A1333
		public void SetTargetPoints(in TArray<FVectorDouble> Points, float RadiusWorld, float Value = 1f, float SoftEdgeWidthWorld = 0f)
		{
			ACapsuleStampConsumer.__SetTargetPoints_Internal(base.NativePtr, (Points ?? new TArray<FVectorDouble>()).NativePtr, RadiusWorld, Value, SoftEdgeWidthWorld);
		}

		// Token: 0x06006E82 RID: 28290 RVA: 0x000A3154 File Offset: 0x000A1354
		public void SetTargetPoint(FVectorDouble Point, float RadiusWorld, float Value = 1f, float SoftEdgeWidthWorld = 0f)
		{
			ACapsuleStampConsumer.__SetTargetPoint_Internal(base.NativePtr, Point, RadiusWorld, Value, SoftEdgeWidthWorld);
		}

		// Token: 0x06006E83 RID: 28291 RVA: 0x000A3166 File Offset: 0x000A1366
		public void PushCapsules()
		{
			ACapsuleStampConsumer.__PushCapsules_Internal(base.NativePtr);
		}

		// Token: 0x06006E84 RID: 28292 RVA: 0x000A3173 File Offset: 0x000A1373
		public void MarkCapsulesDirty()
		{
			ACapsuleStampConsumer.__MarkCapsulesDirty_Internal(base.NativePtr);
		}

		// Token: 0x06006E85 RID: 28293 RVA: 0x000A3180 File Offset: 0x000A1380
		public void DrawOnce()
		{
			ACapsuleStampConsumer.__DrawOnce_Internal(base.NativePtr);
		}

		// Token: 0x06006E86 RID: 28294 RVA: 0x000A318D File Offset: 0x000A138D
		public void ClearRT()
		{
			ACapsuleStampConsumer.__ClearRT_Internal(base.NativePtr);
		}

		// Token: 0x06006E87 RID: 28295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SnapToTargetAndDrawOnce_Internal(IntPtr @this, bool bFlush);

		// Token: 0x06006E88 RID: 28296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetPoints_Internal(IntPtr @this, IntPtr Points, float RadiusWorld, float Value, float SoftEdgeWidthWorld);

		// Token: 0x06006E89 RID: 28297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetPoint_Internal(IntPtr @this, FVectorDouble Point, float RadiusWorld, float Value, float SoftEdgeWidthWorld);

		// Token: 0x06006E8A RID: 28298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PushCapsules_Internal(IntPtr @this);

		// Token: 0x06006E8B RID: 28299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkCapsulesDirty_Internal(IntPtr @this);

		// Token: 0x06006E8C RID: 28300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawOnce_Internal(IntPtr @this);

		// Token: 0x06006E8D RID: 28301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearRT_Internal(IntPtr @this);

		// Token: 0x06006E8E RID: 28302 RVA: 0x000A319A File Offset: 0x000A139A
		static ACapsuleStampConsumer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.CapsuleStampConsumer");
		}

		// Token: 0x06006E8F RID: 28303 RVA: 0x000A31A8 File Offset: 0x000A13A8
		protected ACapsuleStampConsumer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F69 RID: 12137
		internal static int __InterfaceOffset_IKuroRenderingStampConsumer;

		// Token: 0x04002F6A RID: 12138
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CapsuleStampConsumer";

		// Token: 0x04002F6B RID: 12139
		private static IntPtr _ClassPtr;

		// Token: 0x04002F6C RID: 12140
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002F6D RID: 12141
		internal static int __PropertyOffset_RTWorldCenter;

		// Token: 0x04002F6E RID: 12142
		internal static int __PropertyOffset_RTWorldRadius;

		// Token: 0x04002F6F RID: 12143
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x04002F70 RID: 12144
		internal static int __PropertyOffset_bOnlyDrawWhenDirty;

		// Token: 0x04002F71 RID: 12145
		internal static int __PropertyOffset_bEnableSmoothing;

		// Token: 0x04002F72 RID: 12146
		internal static int __PropertyOffset_SmoothingSpeed;

		// Token: 0x04002F73 RID: 12147
		internal static int __PropertyOffset_bValueOnlySmoothing;

		// Token: 0x04002F74 RID: 12148
		internal static int __PropertyOffset_bSpreadWhenUseEndValues;

		// Token: 0x04002F75 RID: 12149
		internal static int __PropertyOffset_SpreadSpeed;

		// Token: 0x04002F76 RID: 12150
		internal static int __PropertyOffset_Root;
	}
}
