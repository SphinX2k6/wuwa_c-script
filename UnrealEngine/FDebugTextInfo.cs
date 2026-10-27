using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009AA RID: 2474
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DebugTextInfo")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FDebugTextInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008BA2 RID: 35746 RVA: 0x000C804E File Offset: 0x000C624E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDebugTextInfo._ScriptStructPtr != 0) ? FDebugTextInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DebugTextInfo", ref FDebugTextInfo._ScriptStructPtr);
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06008BA3 RID: 35747 RVA: 0x000C8072 File Offset: 0x000C6272
		// (set) Token: 0x06008BA4 RID: 35748 RVA: 0x000C8086 File Offset: 0x000C6286
		[Nullable(2)]
		public unsafe AActor SrcActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FDebugTextInfo.__PropertyOffset_SrcActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDebugTextInfo.__PropertyOffset_SrcActor, value);
			}
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x06008BA5 RID: 35749 RVA: 0x000C809B File Offset: 0x000C629B
		// (set) Token: 0x06008BA6 RID: 35750 RVA: 0x000C80AF File Offset: 0x000C62AF
		public unsafe FVector SrcActorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_SrcActorOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_SrcActorOffset) = value;
			}
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x06008BA7 RID: 35751 RVA: 0x000C80C4 File Offset: 0x000C62C4
		// (set) Token: 0x06008BA8 RID: 35752 RVA: 0x000C80D8 File Offset: 0x000C62D8
		public unsafe FVector SrcActorDesiredOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_SrcActorDesiredOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_SrcActorDesiredOffset) = value;
			}
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x06008BA9 RID: 35753 RVA: 0x000C80ED File Offset: 0x000C62ED
		// (set) Token: 0x06008BAA RID: 35754 RVA: 0x000C8101 File Offset: 0x000C6301
		public unsafe string DebugText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDebugTextInfo.__PropertyOffset_DebugText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDebugTextInfo.__PropertyOffset_DebugText)), value);
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x06008BAB RID: 35755 RVA: 0x000C8116 File Offset: 0x000C6316
		// (set) Token: 0x06008BAC RID: 35756 RVA: 0x000C8126 File Offset: 0x000C6326
		public unsafe float TimeRemaining
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_TimeRemaining);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_TimeRemaining) = value;
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x06008BAD RID: 35757 RVA: 0x000C8137 File Offset: 0x000C6337
		// (set) Token: 0x06008BAE RID: 35758 RVA: 0x000C8147 File Offset: 0x000C6347
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x06008BAF RID: 35759 RVA: 0x000C8158 File Offset: 0x000C6358
		// (set) Token: 0x06008BB0 RID: 35760 RVA: 0x000C816C File Offset: 0x000C636C
		public unsafe FColor TextColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_TextColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_TextColor) = value;
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x06008BB1 RID: 35761 RVA: 0x000C8181 File Offset: 0x000C6381
		// (set) Token: 0x06008BB2 RID: 35762 RVA: 0x000C819A File Offset: 0x000C639A
		public unsafe bool bAbsoluteLocation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_bAbsoluteLocation) & FDebugTextInfo.__PropertyMask_bAbsoluteLocation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_bAbsoluteLocation) = ((*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_bAbsoluteLocation) & ~FDebugTextInfo.__PropertyMask_bAbsoluteLocation) | (value ? FDebugTextInfo.__PropertyMask_bAbsoluteLocation : 0));
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x06008BB3 RID: 35763 RVA: 0x000C81CA File Offset: 0x000C63CA
		// (set) Token: 0x06008BB4 RID: 35764 RVA: 0x000C81E3 File Offset: 0x000C63E3
		public unsafe bool bKeepAttachedToActor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_bKeepAttachedToActor) & FDebugTextInfo.__PropertyMask_bKeepAttachedToActor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_bKeepAttachedToActor) = ((*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_bKeepAttachedToActor) & ~FDebugTextInfo.__PropertyMask_bKeepAttachedToActor) | (value ? FDebugTextInfo.__PropertyMask_bKeepAttachedToActor : 0));
			}
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x06008BB5 RID: 35765 RVA: 0x000C8213 File Offset: 0x000C6413
		// (set) Token: 0x06008BB6 RID: 35766 RVA: 0x000C822C File Offset: 0x000C642C
		public unsafe bool bDrawShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_bDrawShadow) & FDebugTextInfo.__PropertyMask_bDrawShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_bDrawShadow) = ((*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_bDrawShadow) & ~FDebugTextInfo.__PropertyMask_bDrawShadow) | (value ? FDebugTextInfo.__PropertyMask_bDrawShadow : 0));
			}
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x06008BB7 RID: 35767 RVA: 0x000C825C File Offset: 0x000C645C
		// (set) Token: 0x06008BB8 RID: 35768 RVA: 0x000C8270 File Offset: 0x000C6470
		public unsafe FVector OrigActorLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_OrigActorLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_OrigActorLocation) = value;
			}
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x06008BB9 RID: 35769 RVA: 0x000C8285 File Offset: 0x000C6485
		// (set) Token: 0x06008BBA RID: 35770 RVA: 0x000C8299 File Offset: 0x000C6499
		[Nullable(2)]
		public unsafe UFont Font
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + FDebugTextInfo.__PropertyOffset_Font);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDebugTextInfo.__PropertyOffset_Font, value);
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x06008BBB RID: 35771 RVA: 0x000C82AE File Offset: 0x000C64AE
		// (set) Token: 0x06008BBC RID: 35772 RVA: 0x000C82BE File Offset: 0x000C64BE
		public unsafe float FontScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_FontScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugTextInfo.__PropertyOffset_FontScale) = value;
			}
		}

		// Token: 0x06008BBD RID: 35773 RVA: 0x000C82CF File Offset: 0x000C64CF
		public FDebugTextInfo()
		{
		}

		// Token: 0x06008BBE RID: 35774 RVA: 0x000C82D8 File Offset: 0x000C64D8
		public FDebugTextInfo(AActor SrcActor, FVector SrcActorOffset, FVector SrcActorDesiredOffset, string DebugText, float TimeRemaining, float Duration, FColor TextColor, bool bAbsoluteLocation, bool bKeepAttachedToActor, bool bDrawShadow, FVector OrigActorLocation, UFont Font, float FontScale)
		{
			this.SrcActor = SrcActor;
			this.SrcActorOffset = SrcActorOffset;
			this.SrcActorDesiredOffset = SrcActorDesiredOffset;
			this.DebugText = DebugText;
			this.TimeRemaining = TimeRemaining;
			this.Duration = Duration;
			this.TextColor = TextColor;
			this.bAbsoluteLocation = bAbsoluteLocation;
			this.bKeepAttachedToActor = bKeepAttachedToActor;
			this.bDrawShadow = bDrawShadow;
			this.OrigActorLocation = OrigActorLocation;
			this.Font = Font;
			this.FontScale = FontScale;
		}

		// Token: 0x06008BBF RID: 35775 RVA: 0x000C8350 File Offset: 0x000C6550
		protected override IntPtr GetUStructPtr()
		{
			return FDebugTextInfo.StaticStruct();
		}

		// Token: 0x06008BC0 RID: 35776 RVA: 0x000C835C File Offset: 0x000C655C
		[NullableContext(2)]
		public FDebugTextInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008BC1 RID: 35777 RVA: 0x000C8366 File Offset: 0x000C6566
		public FDebugTextInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008BC2 RID: 35778 RVA: 0x000C8371 File Offset: 0x000C6571
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDebugTextInfo(Pointer, false, true);
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x000C837B File Offset: 0x000C657B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDebugTextInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04004253 RID: 16979
		public const string __ObjectPath = "/Script/Engine.DebugTextInfo";

		// Token: 0x04004254 RID: 16980
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004255 RID: 16981
		internal static int __PropertyOffset_SrcActor;

		// Token: 0x04004256 RID: 16982
		internal static int __PropertyOffset_SrcActorOffset;

		// Token: 0x04004257 RID: 16983
		internal static int __PropertyOffset_SrcActorDesiredOffset;

		// Token: 0x04004258 RID: 16984
		internal static int __PropertyOffset_DebugText;

		// Token: 0x04004259 RID: 16985
		internal static int __PropertyOffset_TimeRemaining;

		// Token: 0x0400425A RID: 16986
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400425B RID: 16987
		internal static int __PropertyOffset_TextColor;

		// Token: 0x0400425C RID: 16988
		internal static int __PropertyOffset_bAbsoluteLocation;

		// Token: 0x0400425D RID: 16989
		internal static byte __PropertyMask_bAbsoluteLocation;

		// Token: 0x0400425E RID: 16990
		internal static int __PropertyOffset_bKeepAttachedToActor;

		// Token: 0x0400425F RID: 16991
		internal static byte __PropertyMask_bKeepAttachedToActor;

		// Token: 0x04004260 RID: 16992
		internal static int __PropertyOffset_bDrawShadow;

		// Token: 0x04004261 RID: 16993
		internal static byte __PropertyMask_bDrawShadow;

		// Token: 0x04004262 RID: 16994
		internal static int __PropertyOffset_OrigActorLocation;

		// Token: 0x04004263 RID: 16995
		internal static int __PropertyOffset_Font;

		// Token: 0x04004264 RID: 16996
		internal static int __PropertyOffset_FontScale;
	}
}
