using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001602 RID: 5634
	[UnrealObjectPath("/Script/KuroAnim.AdditiveBlendAlpha")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FAdditiveBlendAlpha : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060144D6 RID: 83158 RVA: 0x001DD2AE File Offset: 0x001DB4AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAdditiveBlendAlpha._ScriptStructPtr != 0) ? FAdditiveBlendAlpha._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AdditiveBlendAlpha", ref FAdditiveBlendAlpha._ScriptStructPtr);
		}

		// Token: 0x17004FA5 RID: 20389
		// (get) Token: 0x060144D7 RID: 83159 RVA: 0x001DD2D2 File Offset: 0x001DB4D2
		// (set) Token: 0x060144D8 RID: 83160 RVA: 0x001DD2E2 File Offset: 0x001DB4E2
		public unsafe float MeshSpaceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAdditiveBlendAlpha.__PropertyOffset_MeshSpaceAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAdditiveBlendAlpha.__PropertyOffset_MeshSpaceAlpha) = value;
			}
		}

		// Token: 0x17004FA6 RID: 20390
		// (get) Token: 0x060144D9 RID: 83161 RVA: 0x001DD2F3 File Offset: 0x001DB4F3
		// (set) Token: 0x060144DA RID: 83162 RVA: 0x001DD303 File Offset: 0x001DB503
		public unsafe float AdditiveAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAdditiveBlendAlpha.__PropertyOffset_AdditiveAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAdditiveBlendAlpha.__PropertyOffset_AdditiveAlpha) = value;
			}
		}

		// Token: 0x17004FA7 RID: 20391
		// (get) Token: 0x060144DB RID: 83163 RVA: 0x001DD314 File Offset: 0x001DB514
		// (set) Token: 0x060144DC RID: 83164 RVA: 0x001DD324 File Offset: 0x001DB524
		public unsafe float OverlayAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAdditiveBlendAlpha.__PropertyOffset_OverlayAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAdditiveBlendAlpha.__PropertyOffset_OverlayAlpha) = value;
			}
		}

		// Token: 0x060144DD RID: 83165 RVA: 0x001DD335 File Offset: 0x001DB535
		public FAdditiveBlendAlpha()
		{
		}

		// Token: 0x060144DE RID: 83166 RVA: 0x001DD33D File Offset: 0x001DB53D
		public FAdditiveBlendAlpha(float MeshSpaceAlpha, float AdditiveAlpha, float OverlayAlpha)
		{
			this.MeshSpaceAlpha = MeshSpaceAlpha;
			this.AdditiveAlpha = AdditiveAlpha;
			this.OverlayAlpha = OverlayAlpha;
		}

		// Token: 0x060144DF RID: 83167 RVA: 0x001DD35A File Offset: 0x001DB55A
		protected override IntPtr GetUStructPtr()
		{
			return FAdditiveBlendAlpha.StaticStruct();
		}

		// Token: 0x060144E0 RID: 83168 RVA: 0x001DD366 File Offset: 0x001DB566
		[NullableContext(2)]
		public FAdditiveBlendAlpha(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060144E1 RID: 83169 RVA: 0x001DD370 File Offset: 0x001DB570
		public FAdditiveBlendAlpha(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060144E2 RID: 83170 RVA: 0x001DD37B File Offset: 0x001DB57B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAdditiveBlendAlpha(Pointer, false, true);
		}

		// Token: 0x060144E3 RID: 83171 RVA: 0x001DD385 File Offset: 0x001DB585
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAdditiveBlendAlpha(Pointer, MemoryOwner);
		}

		// Token: 0x0400B0C7 RID: 45255
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.AdditiveBlendAlpha";

		// Token: 0x0400B0C8 RID: 45256
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B0C9 RID: 45257
		internal static int __PropertyOffset_MeshSpaceAlpha;

		// Token: 0x0400B0CA RID: 45258
		internal static int __PropertyOffset_AdditiveAlpha;

		// Token: 0x0400B0CB RID: 45259
		internal static int __PropertyOffset_OverlayAlpha;
	}
}
