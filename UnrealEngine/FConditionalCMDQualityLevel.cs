using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A5F RID: 6751
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ConditionalCMDQualityLevel")]
	[UnrealStructLayout(7, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 7)]
	public class FConditionalCMDQualityLevel : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018FE0 RID: 102368 RVA: 0x0024F10E File Offset: 0x0024D30E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConditionalCMDQualityLevel._ScriptStructPtr != 0) ? FConditionalCMDQualityLevel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.ConditionalCMDQualityLevel", ref FConditionalCMDQualityLevel._ScriptStructPtr);
		}

		// Token: 0x17006312 RID: 25362
		// (get) Token: 0x06018FE1 RID: 102369 RVA: 0x0024F132 File Offset: 0x0024D332
		// (set) Token: 0x06018FE2 RID: 102370 RVA: 0x0024F142 File Offset: 0x0024D342
		public unsafe bool bEnableQualityLevelConditional
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableQualityLevelConditional) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableQualityLevelConditional) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006313 RID: 25363
		// (get) Token: 0x06018FE3 RID: 102371 RVA: 0x0024F153 File Offset: 0x0024D353
		// (set) Token: 0x06018FE4 RID: 102372 RVA: 0x0024F163 File Offset: 0x0024D363
		public unsafe bool bEnableInLowest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInLowest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInLowest) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006314 RID: 25364
		// (get) Token: 0x06018FE5 RID: 102373 RVA: 0x0024F174 File Offset: 0x0024D374
		// (set) Token: 0x06018FE6 RID: 102374 RVA: 0x0024F184 File Offset: 0x0024D384
		public unsafe bool bEnableInLow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInLow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInLow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006315 RID: 25365
		// (get) Token: 0x06018FE7 RID: 102375 RVA: 0x0024F195 File Offset: 0x0024D395
		// (set) Token: 0x06018FE8 RID: 102376 RVA: 0x0024F1A5 File Offset: 0x0024D3A5
		public unsafe bool bEnableInNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInNormal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInNormal) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006316 RID: 25366
		// (get) Token: 0x06018FE9 RID: 102377 RVA: 0x0024F1B6 File Offset: 0x0024D3B6
		// (set) Token: 0x06018FEA RID: 102378 RVA: 0x0024F1C6 File Offset: 0x0024D3C6
		public unsafe bool bEnableInHigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInHigh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInHigh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006317 RID: 25367
		// (get) Token: 0x06018FEB RID: 102379 RVA: 0x0024F1D7 File Offset: 0x0024D3D7
		// (set) Token: 0x06018FEC RID: 102380 RVA: 0x0024F1E7 File Offset: 0x0024D3E7
		public unsafe bool bEnableInVeryHigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInVeryHigh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInVeryHigh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006318 RID: 25368
		// (get) Token: 0x06018FED RID: 102381 RVA: 0x0024F1F8 File Offset: 0x0024D3F8
		// (set) Token: 0x06018FEE RID: 102382 RVA: 0x0024F208 File Offset: 0x0024D408
		public unsafe bool bEnableInHighest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInHighest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalCMDQualityLevel.__PropertyOffset_bEnableInHighest) = (value ? 1 : 0);
			}
		}

		// Token: 0x06018FEF RID: 102383 RVA: 0x0024F219 File Offset: 0x0024D419
		public FConditionalCMDQualityLevel()
		{
		}

		// Token: 0x06018FF0 RID: 102384 RVA: 0x0024F221 File Offset: 0x0024D421
		public FConditionalCMDQualityLevel(bool bEnableQualityLevelConditional, bool bEnableInLowest, bool bEnableInLow, bool bEnableInNormal, bool bEnableInHigh, bool bEnableInVeryHigh, bool bEnableInHighest)
		{
			this.bEnableQualityLevelConditional = bEnableQualityLevelConditional;
			this.bEnableInLowest = bEnableInLowest;
			this.bEnableInLow = bEnableInLow;
			this.bEnableInNormal = bEnableInNormal;
			this.bEnableInHigh = bEnableInHigh;
			this.bEnableInVeryHigh = bEnableInVeryHigh;
			this.bEnableInHighest = bEnableInHighest;
		}

		// Token: 0x06018FF1 RID: 102385 RVA: 0x0024F25E File Offset: 0x0024D45E
		protected override IntPtr GetUStructPtr()
		{
			return FConditionalCMDQualityLevel.StaticStruct();
		}

		// Token: 0x06018FF2 RID: 102386 RVA: 0x0024F26A File Offset: 0x0024D46A
		[NullableContext(2)]
		public FConditionalCMDQualityLevel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018FF3 RID: 102387 RVA: 0x0024F274 File Offset: 0x0024D474
		public FConditionalCMDQualityLevel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018FF4 RID: 102388 RVA: 0x0024F27F File Offset: 0x0024D47F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConditionalCMDQualityLevel(Pointer, false, true);
		}

		// Token: 0x06018FF5 RID: 102389 RVA: 0x0024F289 File Offset: 0x0024D489
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConditionalCMDQualityLevel(Pointer, MemoryOwner);
		}

		// Token: 0x0400D859 RID: 55385
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.ConditionalCMDQualityLevel";

		// Token: 0x0400D85A RID: 55386
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D85B RID: 55387
		internal static int __PropertyOffset_bEnableQualityLevelConditional;

		// Token: 0x0400D85C RID: 55388
		internal static int __PropertyOffset_bEnableInLowest;

		// Token: 0x0400D85D RID: 55389
		internal static int __PropertyOffset_bEnableInLow;

		// Token: 0x0400D85E RID: 55390
		internal static int __PropertyOffset_bEnableInNormal;

		// Token: 0x0400D85F RID: 55391
		internal static int __PropertyOffset_bEnableInHigh;

		// Token: 0x0400D860 RID: 55392
		internal static int __PropertyOffset_bEnableInVeryHigh;

		// Token: 0x0400D861 RID: 55393
		internal static int __PropertyOffset_bEnableInHighest;
	}
}
