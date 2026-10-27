using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017A0 RID: 6048
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSAxisInstanceLayoutEntry")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroCSAxisInstanceLayoutEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015CE4 RID: 89316 RVA: 0x00200676 File Offset: 0x001FE876
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSAxisInstanceLayoutEntry._ScriptStructPtr != 0) ? FKuroCSAxisInstanceLayoutEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSAxisInstanceLayoutEntry", ref FKuroCSAxisInstanceLayoutEntry._ScriptStructPtr);
		}

		// Token: 0x17005664 RID: 22116
		// (get) Token: 0x06015CE5 RID: 89317 RVA: 0x0020069A File Offset: 0x001FE89A
		// (set) Token: 0x06015CE6 RID: 89318 RVA: 0x002006AE File Offset: 0x001FE8AE
		public unsafe FVector InitialOffsetLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSAxisInstanceLayoutEntry.__PropertyOffset_InitialOffsetLocal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSAxisInstanceLayoutEntry.__PropertyOffset_InitialOffsetLocal) = value;
			}
		}

		// Token: 0x17005665 RID: 22117
		// (get) Token: 0x06015CE7 RID: 89319 RVA: 0x002006C3 File Offset: 0x001FE8C3
		// (set) Token: 0x06015CE8 RID: 89320 RVA: 0x002006D3 File Offset: 0x001FE8D3
		public unsafe float CollisionRadiusAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSAxisInstanceLayoutEntry.__PropertyOffset_CollisionRadiusAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSAxisInstanceLayoutEntry.__PropertyOffset_CollisionRadiusAlpha) = value;
			}
		}

		// Token: 0x17005666 RID: 22118
		// (get) Token: 0x06015CE9 RID: 89321 RVA: 0x002006E4 File Offset: 0x001FE8E4
		// (set) Token: 0x06015CEA RID: 89322 RVA: 0x002006F4 File Offset: 0x001FE8F4
		public unsafe int TexelX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSAxisInstanceLayoutEntry.__PropertyOffset_TexelX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSAxisInstanceLayoutEntry.__PropertyOffset_TexelX) = value;
			}
		}

		// Token: 0x17005667 RID: 22119
		// (get) Token: 0x06015CEB RID: 89323 RVA: 0x00200705 File Offset: 0x001FE905
		// (set) Token: 0x06015CEC RID: 89324 RVA: 0x00200715 File Offset: 0x001FE915
		public unsafe int TexelY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSAxisInstanceLayoutEntry.__PropertyOffset_TexelY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSAxisInstanceLayoutEntry.__PropertyOffset_TexelY) = value;
			}
		}

		// Token: 0x06015CED RID: 89325 RVA: 0x00200726 File Offset: 0x001FE926
		public FKuroCSAxisInstanceLayoutEntry()
		{
		}

		// Token: 0x06015CEE RID: 89326 RVA: 0x0020072E File Offset: 0x001FE92E
		public FKuroCSAxisInstanceLayoutEntry(FVector InitialOffsetLocal, float CollisionRadiusAlpha, int TexelX, int TexelY)
		{
			this.InitialOffsetLocal = InitialOffsetLocal;
			this.CollisionRadiusAlpha = CollisionRadiusAlpha;
			this.TexelX = TexelX;
			this.TexelY = TexelY;
		}

		// Token: 0x06015CEF RID: 89327 RVA: 0x00200753 File Offset: 0x001FE953
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSAxisInstanceLayoutEntry.StaticStruct();
		}

		// Token: 0x06015CF0 RID: 89328 RVA: 0x0020075F File Offset: 0x001FE95F
		[NullableContext(2)]
		public FKuroCSAxisInstanceLayoutEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015CF1 RID: 89329 RVA: 0x00200769 File Offset: 0x001FE969
		public FKuroCSAxisInstanceLayoutEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015CF2 RID: 89330 RVA: 0x00200774 File Offset: 0x001FE974
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSAxisInstanceLayoutEntry(Pointer, false, true);
		}

		// Token: 0x06015CF3 RID: 89331 RVA: 0x0020077E File Offset: 0x001FE97E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSAxisInstanceLayoutEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400BE56 RID: 48726
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSAxisInstanceLayoutEntry";

		// Token: 0x0400BE57 RID: 48727
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BE58 RID: 48728
		internal static int __PropertyOffset_InitialOffsetLocal;

		// Token: 0x0400BE59 RID: 48729
		internal static int __PropertyOffset_CollisionRadiusAlpha;

		// Token: 0x0400BE5A RID: 48730
		internal static int __PropertyOffset_TexelX;

		// Token: 0x0400BE5B RID: 48731
		internal static int __PropertyOffset_TexelY;
	}
}
