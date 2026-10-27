using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A60 RID: 6752
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CoralInteractor")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FCoralInteractor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018FF6 RID: 102390 RVA: 0x0024F292 File Offset: 0x0024D492
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCoralInteractor._ScriptStructPtr != 0) ? FCoralInteractor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CoralInteractor", ref FCoralInteractor._ScriptStructPtr);
		}

		// Token: 0x17006319 RID: 25369
		// (get) Token: 0x06018FF7 RID: 102391 RVA: 0x0024F2B6 File Offset: 0x0024D4B6
		// (set) Token: 0x06018FF8 RID: 102392 RVA: 0x0024F2CA File Offset: 0x0024D4CA
		public unsafe FVectorDouble P0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCoralInteractor.__PropertyOffset_P0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCoralInteractor.__PropertyOffset_P0) = value;
			}
		}

		// Token: 0x1700631A RID: 25370
		// (get) Token: 0x06018FF9 RID: 102393 RVA: 0x0024F2DF File Offset: 0x0024D4DF
		// (set) Token: 0x06018FFA RID: 102394 RVA: 0x0024F2F3 File Offset: 0x0024D4F3
		public unsafe FVectorDouble P1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCoralInteractor.__PropertyOffset_P1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCoralInteractor.__PropertyOffset_P1) = value;
			}
		}

		// Token: 0x1700631B RID: 25371
		// (get) Token: 0x06018FFB RID: 102395 RVA: 0x0024F308 File Offset: 0x0024D508
		// (set) Token: 0x06018FFC RID: 102396 RVA: 0x0024F318 File Offset: 0x0024D518
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCoralInteractor.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCoralInteractor.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x1700631C RID: 25372
		// (get) Token: 0x06018FFD RID: 102397 RVA: 0x0024F329 File Offset: 0x0024D529
		// (set) Token: 0x06018FFE RID: 102398 RVA: 0x0024F339 File Offset: 0x0024D539
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCoralInteractor.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCoralInteractor.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x06018FFF RID: 102399 RVA: 0x0024F34A File Offset: 0x0024D54A
		public FCoralInteractor()
		{
		}

		// Token: 0x06019000 RID: 102400 RVA: 0x0024F352 File Offset: 0x0024D552
		public FCoralInteractor(FVectorDouble P0, FVectorDouble P1, float Radius, float Strength)
		{
			this.P0 = P0;
			this.P1 = P1;
			this.Radius = Radius;
			this.Strength = Strength;
		}

		// Token: 0x06019001 RID: 102401 RVA: 0x0024F377 File Offset: 0x0024D577
		protected override IntPtr GetUStructPtr()
		{
			return FCoralInteractor.StaticStruct();
		}

		// Token: 0x06019002 RID: 102402 RVA: 0x0024F383 File Offset: 0x0024D583
		[NullableContext(2)]
		public FCoralInteractor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019003 RID: 102403 RVA: 0x0024F38D File Offset: 0x0024D58D
		public FCoralInteractor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019004 RID: 102404 RVA: 0x0024F398 File Offset: 0x0024D598
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCoralInteractor(Pointer, false, true);
		}

		// Token: 0x06019005 RID: 102405 RVA: 0x0024F3A2 File Offset: 0x0024D5A2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCoralInteractor(Pointer, MemoryOwner);
		}

		// Token: 0x0400D862 RID: 55394
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CoralInteractor";

		// Token: 0x0400D863 RID: 55395
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D864 RID: 55396
		internal static int __PropertyOffset_P0;

		// Token: 0x0400D865 RID: 55397
		internal static int __PropertyOffset_P1;

		// Token: 0x0400D866 RID: 55398
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400D867 RID: 55399
		internal static int __PropertyOffset_Strength;
	}
}
