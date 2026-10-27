using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008A4 RID: 2212
	[UnrealObjectPath("/Script/Engine.BasedPosition")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FBasedPosition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600790B RID: 30987 RVA: 0x000AD490 File Offset: 0x000AB690
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBasedPosition._ScriptStructPtr != 0) ? FBasedPosition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BasedPosition", ref FBasedPosition._ScriptStructPtr);
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x0600790C RID: 30988 RVA: 0x000AD4B4 File Offset: 0x000AB6B4
		// (set) Token: 0x0600790D RID: 30989 RVA: 0x000AD4C8 File Offset: 0x000AB6C8
		[Nullable(2)]
		public unsafe AActor Base
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FBasedPosition.__PropertyOffset_Base);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBasedPosition.__PropertyOffset_Base, value);
			}
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x0600790E RID: 30990 RVA: 0x000AD4DD File Offset: 0x000AB6DD
		// (set) Token: 0x0600790F RID: 30991 RVA: 0x000AD4F1 File Offset: 0x000AB6F1
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedPosition.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedPosition.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06007910 RID: 30992 RVA: 0x000AD506 File Offset: 0x000AB706
		// (set) Token: 0x06007911 RID: 30993 RVA: 0x000AD51A File Offset: 0x000AB71A
		public unsafe FVector CachedBaseLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedPosition.__PropertyOffset_CachedBaseLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedPosition.__PropertyOffset_CachedBaseLocation) = value;
			}
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06007912 RID: 30994 RVA: 0x000AD52F File Offset: 0x000AB72F
		// (set) Token: 0x06007913 RID: 30995 RVA: 0x000AD543 File Offset: 0x000AB743
		public unsafe FRotator CachedBaseRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedPosition.__PropertyOffset_CachedBaseRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedPosition.__PropertyOffset_CachedBaseRotation) = value;
			}
		}

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06007914 RID: 30996 RVA: 0x000AD558 File Offset: 0x000AB758
		// (set) Token: 0x06007915 RID: 30997 RVA: 0x000AD56C File Offset: 0x000AB76C
		public unsafe FVector CachedTransPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasedPosition.__PropertyOffset_CachedTransPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasedPosition.__PropertyOffset_CachedTransPosition) = value;
			}
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x000AD581 File Offset: 0x000AB781
		public FBasedPosition()
		{
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x000AD589 File Offset: 0x000AB789
		[NullableContext(1)]
		public FBasedPosition(AActor Base, FVector Position, FVector CachedBaseLocation, FRotator CachedBaseRotation, FVector CachedTransPosition)
		{
			this.Base = Base;
			this.Position = Position;
			this.CachedBaseLocation = CachedBaseLocation;
			this.CachedBaseRotation = CachedBaseRotation;
			this.CachedTransPosition = CachedTransPosition;
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x000AD5B6 File Offset: 0x000AB7B6
		protected override IntPtr GetUStructPtr()
		{
			return FBasedPosition.StaticStruct();
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x000AD5C2 File Offset: 0x000AB7C2
		[NullableContext(2)]
		public FBasedPosition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x000AD5CC File Offset: 0x000AB7CC
		public FBasedPosition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x000AD5D7 File Offset: 0x000AB7D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBasedPosition(Pointer, false, true);
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x000AD5E1 File Offset: 0x000AB7E1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBasedPosition(Pointer, MemoryOwner);
		}

		// Token: 0x04003A21 RID: 14881
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BasedPosition";

		// Token: 0x04003A22 RID: 14882
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A23 RID: 14883
		internal static int __PropertyOffset_Base;

		// Token: 0x04003A24 RID: 14884
		internal static int __PropertyOffset_Position;

		// Token: 0x04003A25 RID: 14885
		internal static int __PropertyOffset_CachedBaseLocation;

		// Token: 0x04003A26 RID: 14886
		internal static int __PropertyOffset_CachedBaseRotation;

		// Token: 0x04003A27 RID: 14887
		internal static int __PropertyOffset_CachedTransPosition;
	}
}
