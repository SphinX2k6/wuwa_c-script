using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016D0 RID: 5840
	[UnrealObjectPath("/Script/KuroBulletCore.CircleRandomEmitterSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FCircleRandomEmitterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015281 RID: 86657 RVA: 0x001F195D File Offset: 0x001EFB5D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCircleRandomEmitterSettings._ScriptStructPtr != 0) ? FCircleRandomEmitterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.CircleRandomEmitterSettings", ref FCircleRandomEmitterSettings._ScriptStructPtr);
		}

		// Token: 0x1700539E RID: 21406
		// (get) Token: 0x06015282 RID: 86658 RVA: 0x001F1981 File Offset: 0x001EFB81
		// (set) Token: 0x06015283 RID: 86659 RVA: 0x001F1991 File Offset: 0x001EFB91
		public unsafe float OuterRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleRandomEmitterSettings.__PropertyOffset_OuterRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleRandomEmitterSettings.__PropertyOffset_OuterRadius) = value;
			}
		}

		// Token: 0x1700539F RID: 21407
		// (get) Token: 0x06015284 RID: 86660 RVA: 0x001F19A2 File Offset: 0x001EFBA2
		// (set) Token: 0x06015285 RID: 86661 RVA: 0x001F19B2 File Offset: 0x001EFBB2
		public unsafe float InnerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleRandomEmitterSettings.__PropertyOffset_InnerRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleRandomEmitterSettings.__PropertyOffset_InnerRadius) = value;
			}
		}

		// Token: 0x170053A0 RID: 21408
		// (get) Token: 0x06015286 RID: 86662 RVA: 0x001F19C3 File Offset: 0x001EFBC3
		// (set) Token: 0x06015287 RID: 86663 RVA: 0x001F19D3 File Offset: 0x001EFBD3
		public unsafe ECircleRandomEmitterDirection Direction
		{
			get
			{
				return (ECircleRandomEmitterDirection)(*(base.NativePtr + (IntPtr)FCircleRandomEmitterSettings.__PropertyOffset_Direction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleRandomEmitterSettings.__PropertyOffset_Direction) = (byte)value;
			}
		}

		// Token: 0x06015288 RID: 86664 RVA: 0x001F19E4 File Offset: 0x001EFBE4
		public FCircleRandomEmitterSettings()
		{
		}

		// Token: 0x06015289 RID: 86665 RVA: 0x001F19EC File Offset: 0x001EFBEC
		public FCircleRandomEmitterSettings(float OuterRadius, float InnerRadius, ECircleRandomEmitterDirection Direction)
		{
			this.OuterRadius = OuterRadius;
			this.InnerRadius = InnerRadius;
			this.Direction = Direction;
		}

		// Token: 0x0601528A RID: 86666 RVA: 0x001F1A09 File Offset: 0x001EFC09
		protected override IntPtr GetUStructPtr()
		{
			return FCircleRandomEmitterSettings.StaticStruct();
		}

		// Token: 0x0601528B RID: 86667 RVA: 0x001F1A15 File Offset: 0x001EFC15
		[NullableContext(2)]
		public FCircleRandomEmitterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601528C RID: 86668 RVA: 0x001F1A1F File Offset: 0x001EFC1F
		public FCircleRandomEmitterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601528D RID: 86669 RVA: 0x001F1A2A File Offset: 0x001EFC2A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCircleRandomEmitterSettings(Pointer, false, true);
		}

		// Token: 0x0601528E RID: 86670 RVA: 0x001F1A34 File Offset: 0x001EFC34
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCircleRandomEmitterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B826 RID: 47142
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.CircleRandomEmitterSettings";

		// Token: 0x0400B827 RID: 47143
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B828 RID: 47144
		internal static int __PropertyOffset_OuterRadius;

		// Token: 0x0400B829 RID: 47145
		internal static int __PropertyOffset_InnerRadius;

		// Token: 0x0400B82A RID: 47146
		internal static int __PropertyOffset_Direction;
	}
}
