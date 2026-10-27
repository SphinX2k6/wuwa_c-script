using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000B36 RID: 2870
	[UnrealObjectPath("/Script/Engine.EquirectProps")]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FEquirectProps : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009282 RID: 37506 RVA: 0x000D22FD File Offset: 0x000D04FD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEquirectProps._ScriptStructPtr != 0) ? FEquirectProps._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EquirectProps", ref FEquirectProps._ScriptStructPtr);
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x06009283 RID: 37507 RVA: 0x000D2321 File Offset: 0x000D0521
		// (set) Token: 0x06009284 RID: 37508 RVA: 0x000D2335 File Offset: 0x000D0535
		public unsafe FBox2D LeftUVRect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_LeftUVRect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_LeftUVRect) = value;
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x06009285 RID: 37509 RVA: 0x000D234A File Offset: 0x000D054A
		// (set) Token: 0x06009286 RID: 37510 RVA: 0x000D235E File Offset: 0x000D055E
		public unsafe FBox2D RightUVRect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_RightUVRect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_RightUVRect) = value;
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x06009287 RID: 37511 RVA: 0x000D2373 File Offset: 0x000D0573
		// (set) Token: 0x06009288 RID: 37512 RVA: 0x000D2387 File Offset: 0x000D0587
		public unsafe FVector2D LeftScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_LeftScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_LeftScale) = value;
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x06009289 RID: 37513 RVA: 0x000D239C File Offset: 0x000D059C
		// (set) Token: 0x0600928A RID: 37514 RVA: 0x000D23B0 File Offset: 0x000D05B0
		public unsafe FVector2D RightScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_RightScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_RightScale) = value;
			}
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x0600928B RID: 37515 RVA: 0x000D23C5 File Offset: 0x000D05C5
		// (set) Token: 0x0600928C RID: 37516 RVA: 0x000D23D9 File Offset: 0x000D05D9
		public unsafe FVector2D LeftBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_LeftBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_LeftBias) = value;
			}
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x0600928D RID: 37517 RVA: 0x000D23EE File Offset: 0x000D05EE
		// (set) Token: 0x0600928E RID: 37518 RVA: 0x000D2402 File Offset: 0x000D0602
		public unsafe FVector2D RightBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_RightBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEquirectProps.__PropertyOffset_RightBias) = value;
			}
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x000D2417 File Offset: 0x000D0617
		public FEquirectProps()
		{
		}

		// Token: 0x06009290 RID: 37520 RVA: 0x000D241F File Offset: 0x000D061F
		public FEquirectProps(FBox2D LeftUVRect, FBox2D RightUVRect, FVector2D LeftScale, FVector2D RightScale, FVector2D LeftBias, FVector2D RightBias)
		{
			this.LeftUVRect = LeftUVRect;
			this.RightUVRect = RightUVRect;
			this.LeftScale = LeftScale;
			this.RightScale = RightScale;
			this.LeftBias = LeftBias;
			this.RightBias = RightBias;
		}

		// Token: 0x06009291 RID: 37521 RVA: 0x000D2454 File Offset: 0x000D0654
		protected override IntPtr GetUStructPtr()
		{
			return FEquirectProps.StaticStruct();
		}

		// Token: 0x06009292 RID: 37522 RVA: 0x000D2460 File Offset: 0x000D0660
		[NullableContext(2)]
		public FEquirectProps(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009293 RID: 37523 RVA: 0x000D246A File Offset: 0x000D066A
		public FEquirectProps(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009294 RID: 37524 RVA: 0x000D2475 File Offset: 0x000D0675
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEquirectProps(Pointer, false, true);
		}

		// Token: 0x06009295 RID: 37525 RVA: 0x000D247F File Offset: 0x000D067F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEquirectProps(Pointer, MemoryOwner);
		}

		// Token: 0x04004F18 RID: 20248
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.EquirectProps";

		// Token: 0x04004F19 RID: 20249
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004F1A RID: 20250
		internal static int __PropertyOffset_LeftUVRect;

		// Token: 0x04004F1B RID: 20251
		internal static int __PropertyOffset_RightUVRect;

		// Token: 0x04004F1C RID: 20252
		internal static int __PropertyOffset_LeftScale;

		// Token: 0x04004F1D RID: 20253
		internal static int __PropertyOffset_RightScale;

		// Token: 0x04004F1E RID: 20254
		internal static int __PropertyOffset_LeftBias;

		// Token: 0x04004F1F RID: 20255
		internal static int __PropertyOffset_RightBias;
	}
}
