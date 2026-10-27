using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009B5 RID: 2485
	[UnrealObjectPath("/Script/Engine.DepthFieldGlowInfo")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FDepthFieldGlowInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008C7A RID: 35962 RVA: 0x000C910F File Offset: 0x000C730F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDepthFieldGlowInfo._ScriptStructPtr != 0) ? FDepthFieldGlowInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DepthFieldGlowInfo", ref FDepthFieldGlowInfo._ScriptStructPtr);
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06008C7B RID: 35963 RVA: 0x000C9133 File Offset: 0x000C7333
		// (set) Token: 0x06008C7C RID: 35964 RVA: 0x000C914C File Offset: 0x000C734C
		public unsafe bool bEnableGlow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FDepthFieldGlowInfo.__PropertyOffset_bEnableGlow) & FDepthFieldGlowInfo.__PropertyMask_bEnableGlow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FDepthFieldGlowInfo.__PropertyOffset_bEnableGlow) = ((*(base.NativePtr + (IntPtr)FDepthFieldGlowInfo.__PropertyOffset_bEnableGlow) & ~FDepthFieldGlowInfo.__PropertyMask_bEnableGlow) | (value ? FDepthFieldGlowInfo.__PropertyMask_bEnableGlow : 0));
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06008C7D RID: 35965 RVA: 0x000C917C File Offset: 0x000C737C
		// (set) Token: 0x06008C7E RID: 35966 RVA: 0x000C9190 File Offset: 0x000C7390
		public unsafe FLinearColor GlowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDepthFieldGlowInfo.__PropertyOffset_GlowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDepthFieldGlowInfo.__PropertyOffset_GlowColor) = value;
			}
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06008C7F RID: 35967 RVA: 0x000C91A5 File Offset: 0x000C73A5
		// (set) Token: 0x06008C80 RID: 35968 RVA: 0x000C91B9 File Offset: 0x000C73B9
		public unsafe FVector2D GlowOuterRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDepthFieldGlowInfo.__PropertyOffset_GlowOuterRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDepthFieldGlowInfo.__PropertyOffset_GlowOuterRadius) = value;
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06008C81 RID: 35969 RVA: 0x000C91CE File Offset: 0x000C73CE
		// (set) Token: 0x06008C82 RID: 35970 RVA: 0x000C91E2 File Offset: 0x000C73E2
		public unsafe FVector2D GlowInnerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDepthFieldGlowInfo.__PropertyOffset_GlowInnerRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDepthFieldGlowInfo.__PropertyOffset_GlowInnerRadius) = value;
			}
		}

		// Token: 0x06008C83 RID: 35971 RVA: 0x000C91F7 File Offset: 0x000C73F7
		public FDepthFieldGlowInfo()
		{
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x000C91FF File Offset: 0x000C73FF
		public FDepthFieldGlowInfo(bool bEnableGlow, FLinearColor GlowColor, FVector2D GlowOuterRadius, FVector2D GlowInnerRadius)
		{
			this.bEnableGlow = bEnableGlow;
			this.GlowColor = GlowColor;
			this.GlowOuterRadius = GlowOuterRadius;
			this.GlowInnerRadius = GlowInnerRadius;
		}

		// Token: 0x06008C85 RID: 35973 RVA: 0x000C9224 File Offset: 0x000C7424
		protected override IntPtr GetUStructPtr()
		{
			return FDepthFieldGlowInfo.StaticStruct();
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x000C9230 File Offset: 0x000C7430
		[NullableContext(2)]
		public FDepthFieldGlowInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x000C923A File Offset: 0x000C743A
		public FDepthFieldGlowInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x000C9245 File Offset: 0x000C7445
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDepthFieldGlowInfo(Pointer, false, true);
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x000C924F File Offset: 0x000C744F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDepthFieldGlowInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040042B2 RID: 17074
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DepthFieldGlowInfo";

		// Token: 0x040042B3 RID: 17075
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040042B4 RID: 17076
		internal static int __PropertyOffset_bEnableGlow;

		// Token: 0x040042B5 RID: 17077
		internal static byte __PropertyMask_bEnableGlow;

		// Token: 0x040042B6 RID: 17078
		internal static int __PropertyOffset_GlowColor;

		// Token: 0x040042B7 RID: 17079
		internal static int __PropertyOffset_GlowOuterRadius;

		// Token: 0x040042B8 RID: 17080
		internal static int __PropertyOffset_GlowInnerRadius;
	}
}
