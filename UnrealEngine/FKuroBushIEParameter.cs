using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200044D RID: 1101
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroBushIEParameter")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroBushIEParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006A38 RID: 27192 RVA: 0x0009AEB7 File Offset: 0x000990B7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBushIEParameter._ScriptStructPtr != 0) ? FKuroBushIEParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroBushIEParameter", ref FKuroBushIEParameter._ScriptStructPtr);
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06006A39 RID: 27193 RVA: 0x0009AEDB File Offset: 0x000990DB
		// (set) Token: 0x06006A3A RID: 27194 RVA: 0x0009AEEB File Offset: 0x000990EB
		public unsafe float SpawnCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnCountScale) = value;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06006A3B RID: 27195 RVA: 0x0009AEFC File Offset: 0x000990FC
		// (set) Token: 0x06006A3C RID: 27196 RVA: 0x0009AF0C File Offset: 0x0009910C
		public unsafe float SpawnSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnSizeScale) = value;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06006A3D RID: 27197 RVA: 0x0009AF1D File Offset: 0x0009911D
		// (set) Token: 0x06006A3E RID: 27198 RVA: 0x0009AF31 File Offset: 0x00099131
		public unsafe FVector SpawnBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnBoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnBoxExtent) = value;
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06006A3F RID: 27199 RVA: 0x0009AF46 File Offset: 0x00099146
		// (set) Token: 0x06006A40 RID: 27200 RVA: 0x0009AF5A File Offset: 0x0009915A
		public unsafe FVector SpawnBoxOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnBoxOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SpawnBoxOffset) = value;
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06006A41 RID: 27201 RVA: 0x0009AF6F File Offset: 0x0009916F
		// (set) Token: 0x06006A42 RID: 27202 RVA: 0x0009AF7F File Offset: 0x0009917F
		public unsafe int UVIndexBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_UVIndexBegin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_UVIndexBegin) = value;
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06006A43 RID: 27203 RVA: 0x0009AF90 File Offset: 0x00099190
		// (set) Token: 0x06006A44 RID: 27204 RVA: 0x0009AFA0 File Offset: 0x000991A0
		public unsafe int UVIndexEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_UVIndexEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_UVIndexEnd) = value;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06006A45 RID: 27205 RVA: 0x0009AFB1 File Offset: 0x000991B1
		// (set) Token: 0x06006A46 RID: 27206 RVA: 0x0009AFC1 File Offset: 0x000991C1
		public unsafe float SoaringSpawnSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpawnSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpawnSizeScale) = value;
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06006A47 RID: 27207 RVA: 0x0009AFD2 File Offset: 0x000991D2
		// (set) Token: 0x06006A48 RID: 27208 RVA: 0x0009AFE2 File Offset: 0x000991E2
		public unsafe float SoaringSpawnCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpawnCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpawnCountScale) = value;
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06006A49 RID: 27209 RVA: 0x0009AFF3 File Offset: 0x000991F3
		// (set) Token: 0x06006A4A RID: 27210 RVA: 0x0009B003 File Offset: 0x00099203
		public unsafe float SoaringSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringSpeedScale) = value;
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06006A4B RID: 27211 RVA: 0x0009B014 File Offset: 0x00099214
		// (set) Token: 0x06006A4C RID: 27212 RVA: 0x0009B024 File Offset: 0x00099224
		public unsafe float SoaringLifeTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringLifeTimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_SoaringLifeTimeScale) = value;
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06006A4D RID: 27213 RVA: 0x0009B035 File Offset: 0x00099235
		// (set) Token: 0x06006A4E RID: 27214 RVA: 0x0009B045 File Offset: 0x00099245
		public unsafe int TreeEffectTypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_TreeEffectTypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_TreeEffectTypeIndex) = value;
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06006A4F RID: 27215 RVA: 0x0009B056 File Offset: 0x00099256
		// (set) Token: 0x06006A50 RID: 27216 RVA: 0x0009B066 File Offset: 0x00099266
		public unsafe int BushEffectTypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_BushEffectTypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBushIEParameter.__PropertyOffset_BushEffectTypeIndex) = value;
			}
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x0009B077 File Offset: 0x00099277
		public FKuroBushIEParameter()
		{
		}

		// Token: 0x06006A52 RID: 27218 RVA: 0x0009B07F File Offset: 0x0009927F
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBushIEParameter.StaticStruct();
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x0009B08B File Offset: 0x0009928B
		[NullableContext(2)]
		public FKuroBushIEParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A54 RID: 27220 RVA: 0x0009B095 File Offset: 0x00099295
		public FKuroBushIEParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x0009B0A0 File Offset: 0x000992A0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBushIEParameter(Pointer, false, true);
		}

		// Token: 0x06006A56 RID: 27222 RVA: 0x0009B0AA File Offset: 0x000992AA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBushIEParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04002D0B RID: 11531
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroInteractionEffect.KuroBushIEParameter";

		// Token: 0x04002D0C RID: 11532
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D0D RID: 11533
		internal static int __PropertyOffset_SpawnCountScale;

		// Token: 0x04002D0E RID: 11534
		internal static int __PropertyOffset_SpawnSizeScale;

		// Token: 0x04002D0F RID: 11535
		internal static int __PropertyOffset_SpawnBoxExtent;

		// Token: 0x04002D10 RID: 11536
		internal static int __PropertyOffset_SpawnBoxOffset;

		// Token: 0x04002D11 RID: 11537
		internal static int __PropertyOffset_UVIndexBegin;

		// Token: 0x04002D12 RID: 11538
		internal static int __PropertyOffset_UVIndexEnd;

		// Token: 0x04002D13 RID: 11539
		internal static int __PropertyOffset_SoaringSpawnSizeScale;

		// Token: 0x04002D14 RID: 11540
		internal static int __PropertyOffset_SoaringSpawnCountScale;

		// Token: 0x04002D15 RID: 11541
		internal static int __PropertyOffset_SoaringSpeedScale;

		// Token: 0x04002D16 RID: 11542
		internal static int __PropertyOffset_SoaringLifeTimeScale;

		// Token: 0x04002D17 RID: 11543
		internal static int __PropertyOffset_TreeEffectTypeIndex;

		// Token: 0x04002D18 RID: 11544
		internal static int __PropertyOffset_BushEffectTypeIndex;
	}
}
